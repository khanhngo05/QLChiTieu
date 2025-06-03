using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLChiTieu
{
    public partial class Expenditure : UserControl
    {
        string str = "Data Source=desktop-2cjcn1n;Initial Catalog=QLChiTieu;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        string tempID = null;
        private void Expenditure_Load(object sender, EventArgs e)
        {

            connection = new SqlConnection(str);
            //LoadDataForUser(currentUsername); // Gọi hàm LoadDataForUser với currentUsername đã được thiết lập

        }

        private string currentUsername;

        public void LoadDataForUser(string username)
        {
            currentUsername = username;
            if (connection == null)
            {
                connection = new SqlConnection(str);
            }
            connection.Open();
            loadData();
            connection.Close();
        }
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from QLThuChi where Loai = 'Chi' and username = @username";
            command.Parameters.AddWithValue("@username", currentUsername); // Thêm tham số username vào câu lệnh SQL
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            expenditure_dgv.DataSource = table;
            expenditure_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đổi tên các cột sau khi bind data
            expenditure_dgv.Columns[0].HeaderText = "ID";
            expenditure_dgv.Columns[1].HeaderText = "Số tiền (VNĐ)";
            expenditure_dgv.Columns[2].HeaderText = "Danh mục";
            expenditure_dgv.Columns[3].HeaderText = "Loại";
            expenditure_dgv.Columns[4].HeaderText = "Ghi chú";
            expenditure_dgv.Columns[5].HeaderText = "Ngày tháng";
            expenditure_dgv.Columns[6].HeaderText = "Username";
            

            // Ẩn cột ID
            expenditure_dgv.Columns[0].Visible = false;
            expenditure_dgv.Columns[6].Visible = false;


            //Căn giữa tiêu đề cột
            expenditure_dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Chỉnh màu nền cho tiêu đề cột
            //income_dgv.EnableHeadersVisualStyles = false;
            //income_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);


            // Định dạng thêm cho các cột
            expenditure_dgv.Columns[0].Width = 50;          // Độ rộng cột
            expenditure_dgv.Columns[1].DefaultCellStyle.Format = "N0";  // Format số tiền
            expenditure_dgv.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format ngày

            // Căn chỉnh nội dung
            expenditure_dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            expenditure_dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; //căn cột số tiền bên phải
            expenditure_dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; //căn cột Ngày tháng bên phải

        }
        public Expenditure()
        {
            InitializeComponent();
        }


        private void expenditure_addBtn_Click(object sender, EventArgs e)
        {
            if (expenditure_dgv == null)
            {
                MessageBox.Show("expenditure_dgv is null", "Debug");
                return;
            }
            try
            {
                connection.Open();
                string insertData = "INSERT INTO QLThuChi (SoTien, DanhMuc, Loai, GhiChu, Ngaythang, username) VALUES (@SoTien, @DanhMuc, @Loai, @GhiChu, @Ngaythang, @username)";
                using (SqlCommand insertCommand = new SqlCommand(insertData, connection))
                {
                    insertCommand.Parameters.AddWithValue("@SoTien", expenditure_money.Text);
                    insertCommand.Parameters.AddWithValue("@DanhMuc", expenditure_category.Text);
                    insertCommand.Parameters.AddWithValue("@Loai", "Chi"); // Đặt loại là "Chi"
                    insertCommand.Parameters.AddWithValue("@GhiChu", expenditure_note.Text);
                    insertCommand.Parameters.Add("@Ngaythang", SqlDbType.Date).Value = expenditure_date.Value.Date;
                    insertCommand.Parameters.AddWithValue("@username", currentUsername); // Thêm tham số username vào câu lệnh SQL
                    insertCommand.ExecuteNonQuery();
                    connection.Close(); // Đóng kết nối trước khi gọi LoadDataForUser

                    MessageBox.Show("Thêm khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa các trường nhập liệu
                    expenditure_dgv.ClearSelection();
                    expenditure_money.Clear();
                    expenditure_category.SelectedIndex = -1;
                    expenditure_note.Clear();
                    expenditure_date.Value = DateTime.Now;

                    // Tải lại dữ liệu
                    LoadDataForUser(currentUsername);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void expenditure_editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string updateData = "UPDATE QLThuChi SET SoTien = @SoTien, DanhMuc = @DanhMuc, GhiChu = @GhiChu, NgayThang = @NgayThang WHERE id = @STT";
                using (SqlCommand updateCommand = new SqlCommand(updateData, connection))
                {
                    updateCommand.Parameters.AddWithValue("@SoTien", expenditure_money.Text);
                    updateCommand.Parameters.AddWithValue("@DanhMuc", expenditure_category.Text);
                    updateCommand.Parameters.AddWithValue("@GhiChu", expenditure_note.Text);
                    updateCommand.Parameters.AddWithValue("@Ngaythang", expenditure_date.Value);
                    updateCommand.Parameters.AddWithValue("@STT", tempID);
                    updateCommand.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Cập nhật khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    expenditure_dgv.ClearSelection(); // Xóa chọn dòng trong DataGridView

                    expenditure_money.Clear(); // Xóa nội dung ô nhập tiền
                    expenditure_category.SelectedIndex = -1; // Đặt lại ô chọn nhóm
                    expenditure_note.Clear(); // Xóa nội dung ô ghi chú
                    expenditure_date.Value = DateTime.Now; // Đặt lại ngày tháng về ngày hiện tại


                    LoadDataForUser(currentUsername);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void expenditure_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy id từ cột đầu tiên (index 0)
            tempID = expenditure_dgv.CurrentRow.Cells[0].Value.ToString();

            // Hiển thị dữ liệu vào các ô nhập liệu
            expenditure_money.Text = expenditure_dgv.CurrentRow.Cells[1].Value.ToString();
            expenditure_category.Text = expenditure_dgv.CurrentRow.Cells[2].Value.ToString();
            expenditure_note.Text = expenditure_dgv.CurrentRow.Cells[4].Value.ToString();
            //Check xem giá trị có phải là DBNull hay không trước khi chuyển đổi
            if (expenditure_dgv.CurrentRow == null || expenditure_dgv.CurrentRow.Index < 0)
            {
                return;
            }

            if (expenditure_dgv.CurrentRow.Cells[5].Value != DBNull.Value && !string.IsNullOrEmpty(expenditure_dgv.CurrentRow.Cells[5].Value.ToString()))
            {
                expenditure_date.Value = DateTime.Parse(expenditure_dgv.CurrentRow.Cells[5].Value.ToString());
            }
            else
            {
                expenditure_date.Value = DateTime.Now; // Hoặc là ngày hiện tại
            }

            tempID = expenditure_dgv.CurrentRow.Cells[0].Value.ToString();
        }

        private void expenditure_deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string deleteData = "DELETE FROM QLThuChi WHERE ID = @STT and Loai = @Loai";
                using (SqlCommand deleteCommand = new SqlCommand(deleteData, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@STT", tempID);
                    deleteCommand.Parameters.AddWithValue("@Loai", "Chi");
                    deleteCommand.ExecuteNonQuery();
                    connection.Close(); // Đóng kết nối sau khi thực hiện xóa
                    MessageBox.Show("Xóa khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    expenditure_dgv.ClearSelection(); // Xóa chọn dòng trong DataGridView

                    expenditure_money.Clear(); // Xóa nội dung ô nhập tiền
                    expenditure_category.SelectedIndex = -1; // Đặt lại ô chọn nhóm
                    expenditure_note.Clear(); // Xóa nội dung ô ghi chú
                    expenditure_date.Value = DateTime.Now; // Đặt lại ngày tháng về ngày hiện tại

                    LoadDataForUser(currentUsername);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void expenditure_clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                if (MessageBox.Show("Bạn có chắc muốn xóa tất cả khoản chi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                string clearData = "DELETE FROM QLThuChi where Loai = 'Chi'";
                using (SqlCommand clearCommand = new SqlCommand(clearData, connection))
                {
                    clearCommand.ExecuteNonQuery();
                    connection.Close(); // Đóng kết nối sau khi thực hiện xóa
                    
                    MessageBox.Show("Xóa tất cả khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    expenditure_dgv.ClearSelection(); // Xóa chọn dòng trong DataGridView
                    expenditure_money.Clear(); // Xóa nội dung ô nhập tiền
                    expenditure_category.SelectedIndex = -1; // Đặt lại ô chọn nhóm
                    expenditure_note.Clear(); // Xóa nội dung ô ghi chú
                    expenditure_date.Value = DateTime.Now; // Đặt lại ngày tháng về ngày hiện tại

                    LoadDataForUser(currentUsername); // Gọi lại hàm LoadDataForUser để cập nhật dữ liệu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }

}
