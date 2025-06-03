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
        int tempLoc = 0; // Biến tạm để lưu giá trị lọc

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
            command.CommandText = "select * from QLThuChi where Loai = 'Thu' AND username = @username";
            command.Parameters.AddWithValue("@username", currentUsername); // Thêm tham số username vào câu lệnh SQL
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            income_dgv.DataSource = table;
            income_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đổi tên các cột sau khi bind data
            income_dgv.Columns[0].HeaderText = "ID";
            income_dgv.Columns[1].HeaderText = "Số tiền (VNĐ)";
            income_dgv.Columns[2].HeaderText = "Danh mục";
            income_dgv.Columns[3].HeaderText = "Loại";
            income_dgv.Columns[4].HeaderText = "Ghi chú";
            income_dgv.Columns[5].HeaderText = "Ngày tháng";
            income_dgv.Columns[6].HeaderText = "Người dùng"; // Cột người dùng

            // Ẩn cột ID
            income_dgv.Columns[0].Visible = false;
            income_dgv.Columns[3].Visible = false; // Ẩn cột "Loại"
            income_dgv.Columns[6].Visible = false; // Ẩn cột "Người dùng"

            //Căn giữa tiêu đề cột
            income_dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Chỉnh màu nền cho tiêu đề cột
            //income_dgv.EnableHeadersVisualStyles = false;
            //income_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);


            // Định dạng thêm cho các cột
            income_dgv.Columns[0].Width = 50;          // Độ rộng cột
            income_dgv.Columns[1].DefaultCellStyle.Format = "N0";  // Format số tiền
            income_dgv.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format ngày

            // Căn chỉnh nội dung
            income_dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            income_dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; //căn cột số tiền bên phải
            income_dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; //căn cột Ngày tháng bên phải

        }
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            //connection.Open();
            //LoadDataForUser(currentUsername);
            //connection.Close();
        }

        private void income_addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string insertData = "INSERT INTO QLThuChi (SoTien, DanhMuc, Loai, GhiChu, NgayThang, username) VALUES (@SoTien, @DanhMuc, @Loai, @GhiChu, @NgayThang, @username)";
                using (SqlCommand insertCommand = new SqlCommand(insertData, connection))
                {
                    insertCommand.Parameters.AddWithValue("@SoTien", income_money.Text);
                    insertCommand.Parameters.AddWithValue("@DanhMuc", income_group.Text);
                    insertCommand.Parameters.AddWithValue("@Loai", "Thu"); // Đặt loại là "Thu"
                    insertCommand.Parameters.AddWithValue("@GhiChu", income_note.Text);
                    insertCommand.Parameters.AddWithValue("@NgayThang", income_date.Value);
                    insertCommand.Parameters.AddWithValue("@username", currentUsername); // Thêm tham số username vào câu lệnh SQL
                    insertCommand.ExecuteNonQuery();
                    connection.Close(); // Đóng kết nối sau khi thực hiện lệnh
                    MessageBox.Show("Thêm khoản thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    income_dgv.ClearSelection(); // Xóa chọn dòng trong DataGridView

                    income_money.Clear(); // Xóa nội dung ô nhập tiền
                    income_group.SelectedIndex = -1; // Đặt lại ô chọn nhóm
                    income_note.Clear(); // Xóa nội dung ô ghi chú
                    income_date.Value = DateTime.Now; // Đặt lại ngày tháng về ngày hiện tại

                    LoadDataForUser(currentUsername);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void income_editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string updateData = "UPDATE QLThuChi SET SoTien = @SoTien, DanhMuc = @DanhMuc, GhiChu = @GhiChu, NgayThang = @NgayThang WHERE id = @STT";
                using (SqlCommand updateCommand = new SqlCommand(updateData, connection))
                {
                    updateCommand.Parameters.AddWithValue("@SoTien", income_money.Text);
                    updateCommand.Parameters.AddWithValue("@DanhMuc", income_group.Text);
                    updateCommand.Parameters.AddWithValue("@GhiChu", income_note.Text);
                    updateCommand.Parameters.AddWithValue("@NgayThang", income_date.Value);
                    updateCommand.Parameters.AddWithValue("@STT", tempID);
                    updateCommand.ExecuteNonQuery();
                    connection.Close(); // Đóng kết nối sau khi thực hiện lệnh
                    MessageBox.Show("Cập nhật khoản thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    income_dgv.ClearSelection(); // Xóa chọn dòng trong DataGridView

                    income_money.Clear(); // Xóa nội dung ô nhập tiền
                    income_group.SelectedIndex = -1; // Đặt lại ô chọn nhóm
                    income_note.Clear(); // Xóa nội dung ô ghi chú
                    income_date.Value = DateTime.Now; // Đặt lại ngày tháng về ngày hiện tại

                    LoadDataForUser(currentUsername);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void income_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Bôi đen cả dòng được chọn
            if (income_dgv.CurrentRow != null)
            {
                income_dgv.CurrentRow.Selected = true; // Bôi đen dòng hiện tại
            }
            income_dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 121, 84);


            // Lấy id từ cột đầu tiên (index 0)
            tempID = income_dgv.CurrentRow.Cells[0].Value.ToString();

            // Hiển thị dữ liệu vào các ô nhập liệu
            income_money.Text = income_dgv.CurrentRow.Cells[1].Value.ToString();
            income_group.Text = income_dgv.CurrentRow.Cells[2].Value.ToString();
            income_note.Text = income_dgv.CurrentRow.Cells[4].Value.ToString();
            //Check xem giá trị có phải là DBNull hay không trước khi chuyển đổi
            if (income_dgv.CurrentRow.Cells[4].Value != DBNull.Value && !string.IsNullOrEmpty(income_dgv.CurrentRow.Cells[4].Value.ToString()))
            {
                income_date.Value = DateTime.Parse(income_dgv.CurrentRow.Cells[5].Value.ToString());
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
                if(string.IsNullOrEmpty(tempID))
                {
                    MessageBox.Show("Vui lòng chọn một khoản thu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Bạn có chắc muốn xóa khoản thu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return; // Nếu người dùng chọn No, thoát khỏi hàm
                }

                connection.Open();
                string deleteData = "DELETE FROM QLThuChi WHERE id = @STT";
                using (SqlCommand deleteCommand = new SqlCommand(deleteData, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@STT", tempID);
                    deleteCommand.ExecuteNonQuery();
                    connection.Close(); // Đóng kết nối sau khi thực hiện lệnh
                    MessageBox.Show("Xóa khoản thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    income_dgv.ClearSelection(); // Xóa chọn dòng trong DataGridView

                    income_money.Clear(); // Xóa nội dung ô nhập tiền
                    income_group.SelectedIndex = -1; // Đặt lại ô chọn nhóm
                    income_note.Clear(); // Xóa nội dung ô ghi chú
                    income_date.Value = DateTime.Now; // Đặt lại ngày tháng về ngày hiện tại

                    LoadDataForUser(currentUsername);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string clearData = "DELETE FROM QLThuChi";
                using (SqlCommand clearCommand = new SqlCommand(clearData, connection))
                {
                    clearCommand.ExecuteNonQuery();
                    connection.Close(); // Đóng kết nối sau khi thực hiện lệnh
                    MessageBox.Show("Xóa tất cả khoản thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    income_dgv.ClearSelection(); // Xóa chọn dòng trong DataGridView
                    income_money.Clear(); // Xóa nội dung ô nhập tiền
                    income_group.SelectedIndex = -1; // Đặt lại ô chọn nhóm
                    income_note.Clear(); // Xóa nội dung ô ghi chú
                    income_date.Value = DateTime.Now; // Đặt lại ngày tháng về ngày hiện tại

                    LoadDataForUser(currentUsername);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideLabel()
        {
            income_lbLocDanhMuc.Visible = false;
            income_cbLocDanhMuc.Visible = false;
            income_lbLocSoTienDau.Visible = false;
            income_tbLocSoTienDau.Visible = false;
            income_lbLocSoTienCuoi.Visible = false;
            income_tbLocSoTienCuoi.Visible = false;
            income_lbLocNgayDau.Visible = false;
            income_dtpLocNgayDau.Visible = false;
            income_lbLocNgayCuoi.Visible = false;
            income_dtpLocNgayCuoi.Visible = false;
        }

        private void income_cbChonTruongLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataForUser(currentUsername);
            switch(income_cbChonTruongLoc.SelectedIndex)
            {
                case 0: // Danh mục
                    HideLabel();
                    income_lbLocDanhMuc.Visible = true;
                    income_cbLocDanhMuc.Visible = true;
                    tempLoc = 0; // Cập nhật biến tạm để lưu giá trị lọc
                    break;
                case 1: // Số tiền
                    HideLabel();
                    income_lbLocSoTienDau.Visible = true;
                    income_tbLocSoTienDau.Visible = true;
                    income_lbLocSoTienCuoi.Visible = true;
                    income_tbLocSoTienCuoi.Visible = true;
                    tempLoc = 1; // Cập nhật biến tạm để lưu giá trị lọc
                    break;
                case 2: // Ngày tháng
                    HideLabel();
                    income_lbLocNgayDau.Visible = true;
                    income_dtpLocNgayDau.Visible = true;
                    income_lbLocNgayCuoi.Visible = true;
                    income_dtpLocNgayCuoi.Visible = true;
                    tempLoc = 2; // Cập nhật biến tạm để lưu giá trị lọc
                    break;
            }
        }

        private void income_cbLocDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void income_btnFilter_Click(object sender, EventArgs e)
        {
            switch (tempLoc)
            {
                case 0:
                    // Lọc theo danh mục
                    if (income_cbLocDanhMuc.SelectedIndex == -1)
                    {
                        MessageBox.Show("Vui lòng chọn danh mục để lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string selectedCategory = income_cbLocDanhMuc.SelectedItem.ToString();
                    command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM QLThuChi WHERE DanhMuc = @DanhMuc AND Loai = 'Thu' AND username = @username";
                    command.Parameters.AddWithValue("@DanhMuc", selectedCategory);
                    command.Parameters.AddWithValue("@username", currentUsername); // Thêm tham số username vào câu lệnh SQL
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    income_dgv.DataSource = table;
                    break;
                case 1:
                    // Lọc theo số tiền
                    if (string.IsNullOrEmpty(income_tbLocSoTienDau.Text) || string.IsNullOrEmpty(income_tbLocSoTienCuoi.Text))
                    {
                        MessageBox.Show("Vui lòng nhập khoảng số tiền để lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    decimal minAmount, maxAmount;
                    if (!decimal.TryParse(income_tbLocSoTienDau.Text, out minAmount) || !decimal.TryParse(income_tbLocSoTienCuoi.Text, out maxAmount))
                    {
                        MessageBox.Show("Vui lòng nhập số tiền hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM QLThuChi WHERE SoTien BETWEEN @MinAmount AND @MaxAmount AND Loai = 'Thu' AND username = @username";
                    command.Parameters.AddWithValue("@MinAmount", minAmount);
                    command.Parameters.AddWithValue("@MaxAmount", maxAmount);
                    command.Parameters.AddWithValue("@username", currentUsername); // Thêm tham số username vào câu lệnh SQL
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    income_dgv.DataSource = table;
                    break;
                case 2:
                    // Lọc theo ngày tháng
                    DateTime startDate = income_dtpLocNgayDau.Value.Date; // Lấy ngày bắt đầu và đặt thời gian về 00:00:00
                    DateTime endDate = income_dtpLocNgayCuoi.Value.Date.AddDays(1).AddSeconds(-1); // Lấy ngày kết thúc và đặt thời gian về 23:59:59

                    if (startDate > endDate)
                    {
                        MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM QLThuChi WHERE NgayThang >= @StartDate AND NgayThang <= @EndDate AND Loai = 'Thu' AND username = @username";
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    command.Parameters.AddWithValue("@username", currentUsername); // Thêm tham số username vào câu lệnh SQL
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    income_dgv.DataSource = table;
                    break;
            }
        }

        private void income_loadDGV_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDataForUser(currentUsername); // Tải lại dữ liệu từ cơ sở dữ liệu
                MessageBox.Show("Đã tải lại dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
