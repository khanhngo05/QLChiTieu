using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLChiTieu
{
    public partial class IncomeForm : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-2CJCN1N;Initial Catalog=QLChiTieu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        string tempID = null;

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhoanThu";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            income_dgv.DataSource = table;
            income_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đổi tên các cột sau khi bind data
            income_dgv.Columns[0].HeaderText = "ID";
            income_dgv.Columns[1].HeaderText = "Số tiền (VNĐ)";
            income_dgv.Columns[2].HeaderText = "Nhóm";
            income_dgv.Columns[3].HeaderText = "Ghi chú";
            income_dgv.Columns[4].HeaderText = "Ngày tháng";

            // Ẩn cột ID
            income_dgv.Columns[0].Visible = false;

            //Căn giữa tiêu đề cột
            income_dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Chỉnh màu nền cho tiêu đề cột
            //income_dgv.EnableHeadersVisualStyles = false;
            //income_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);


            // Định dạng thêm cho các cột
            income_dgv.Columns[0].Width = 50;          // Độ rộng cột
            income_dgv.Columns[1].DefaultCellStyle.Format = "N0";  // Format số tiền
            income_dgv.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format ngày

            // Căn chỉnh nội dung
            income_dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            income_dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; //căn cột số tiền bên phải
            income_dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; //căn cột Ngày tháng bên phải

        }
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            connection.Close();
        }

        private void income_addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string insertData = "INSERT INTO KhoanThu (SoTien, Nhom, GhiChu, NgayThang) VALUES (@SoTien, @Nhom, @GhiChu, @NgayThang)";
                using (SqlCommand insertCommand = new SqlCommand(insertData, connection))
                {
                    insertCommand.Parameters.AddWithValue("@SoTien", income_money.Text);
                    insertCommand.Parameters.AddWithValue("@Nhom", income_group.Text);
                    insertCommand.Parameters.AddWithValue("@GhiChu", income_note.Text);
                    insertCommand.Parameters.AddWithValue("@NgayThang", income_date.Value);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Thêm khoản thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                income_dgv.ClearSelection(); // Xóa chọn dòng trong DataGridView

                income_money.Clear(); // Xóa nội dung ô nhập tiền
                income_group.SelectedIndex = -1; // Đặt lại ô chọn nhóm
                income_note.Clear(); // Xóa nội dung ô ghi chú
                income_date.Value = DateTime.Now; // Đặt lại ngày tháng về ngày hiện tại

                // Đóng kết nối trong khối finally để đảm bảo nó luôn được thực thi
                connection.Close();
            }
        }

        private void income_editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string updateData = "UPDATE KhoanThu SET SoTien = @SoTien, Nhom = @Nhom, GhiChu = @GhiChu, NgayThang = @NgayThang WHERE id = @STT";
                using (SqlCommand updateCommand = new SqlCommand(updateData, connection))
                {
                    updateCommand.Parameters.AddWithValue("@SoTien", income_money.Text);
                    updateCommand.Parameters.AddWithValue("@Nhom", income_group.Text);
                    updateCommand.Parameters.AddWithValue("@GhiChu", income_note.Text);
                    updateCommand.Parameters.AddWithValue("@NgayThang", income_date.Value);
                    updateCommand.Parameters.AddWithValue("@STT", tempID);
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật khoản thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                income_dgv.ClearSelection(); // Xóa chọn dòng trong DataGridView

                income_money.Clear(); // Xóa nội dung ô nhập tiền
                income_group.SelectedIndex = -1; // Đặt lại ô chọn nhóm
                income_note.Clear(); // Xóa nội dung ô ghi chú
                income_date.Value = DateTime.Now; // Đặt lại ngày tháng về ngày hiện tại
                connection.Close();
            }
        }

        private void income_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy id từ cột đầu tiên (index 0)
            tempID = income_dgv.CurrentRow.Cells[0].Value.ToString();

            income_money.Text = income_dgv.CurrentRow.Cells[1].Value.ToString();
            income_group.Text = income_dgv.CurrentRow.Cells[2].Value.ToString();
            income_note.Text = income_dgv.CurrentRow.Cells[3].Value.ToString();
            //Check xem giá trị có phải là DBNull hay không trước khi chuyển đổi
            if (income_dgv.CurrentRow.Cells[4].Value != DBNull.Value && !string.IsNullOrEmpty(income_dgv.CurrentRow.Cells[4].Value.ToString()))
            {
                income_date.Value = DateTime.Parse(income_dgv.CurrentRow.Cells[4].Value.ToString());
            }
            else
            {
                income_date.Value = DateTime.Now; // Hoặc là ngày hiện tại
            }

            tempID = income_dgv.CurrentRow.Cells[0].Value.ToString();
        }

        private void income_deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string deleteData = "DELETE FROM KhoanThu WHERE id = @STT";
                using (SqlCommand deleteCommand = new SqlCommand(deleteData, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@STT", tempID);
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa khoản thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                income_dgv.ClearSelection(); // Xóa chọn dòng trong DataGridView

                income_money.Clear(); // Xóa nội dung ô nhập tiền
                income_group.SelectedIndex = -1; // Đặt lại ô chọn nhóm
                income_note.Clear(); // Xóa nội dung ô ghi chú
                income_date.Value = DateTime.Now; // Đặt lại ngày tháng về ngày hiện tại
                connection.Close();
            }
        }

        private void income_clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                if(MessageBox.Show("Bạn có chắc muốn xóa tất cả khoản thu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                string clearData = "DELETE FROM KhoanThu";
                using (SqlCommand clearCommand = new SqlCommand(clearData, connection))
                {
                    clearCommand.ExecuteNonQuery();
                    MessageBox.Show("Xóa tất cả khoản thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                income_dgv.ClearSelection(); // Xóa chọn dòng trong DataGridView
                income_money.Clear(); // Xóa nội dung ô nhập tiền
                income_group.SelectedIndex = -1; // Đặt lại ô chọn nhóm
                income_note.Clear(); // Xóa nội dung ô ghi chú
                income_date.Value = DateTime.Now; // Đặt lại ngày tháng về ngày hiện tại

                connection.Close();
            }
        }
    }
}
