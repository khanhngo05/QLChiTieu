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
    public partial class DebtBook : UserControl
    {
        public DebtBook()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
        private string connectionString = @"Data Source=DESKTOP-2CJCN1N;Initial Catalog=QLChiTieu;Integrated Security=True;TrustServerCertificate=True";

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void CapNhatDataGridView()
        {
            // Xóa dữ liệu cũ trong DataGridView
            dgvDanhSachNo.Rows.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM KhoanNo";
                    string dn, dm;
                    string dd, de;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dn = reader["TenNo"].ToString();
                                dm = reader["TienNo"].ToString();
                                dd = reader["NgayNo"] != DBNull.Value ? Convert.ToString(reader["NgayNo"]) : "";
                                de = reader["NgayTra"] != DBNull.Value ? Convert.ToString(reader["NgayTra"]) : "";
                                // Thêm dữ liệu vào DataGridView
                                int rowIndex = dgvDanhSachNo.Rows.Add(
                                    reader["Id"].ToString(),
                                    dn,
                                    dm,
                                    dd,
                                    de,
                                    reader["Trangthai"].ToString()
                                );
                                if (reader["Trangthai"].ToString() == "Đã trả")
                                {
                                    dgvDanhSachNo.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                                    dgvDanhSachNo.Rows[rowIndex].DefaultCellStyle.Font = new Font(dgvDanhSachNo.DefaultCellStyle.Font, FontStyle.Strikeout);
                                }
                            }
                        }
                    }

                    // Tính tổng nợ và tổng cho vay
                    decimal tongNo = 0, tongChoVay = 0;
                    query = "SELECT Trangthai, TienNo FROM KhoanNo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal soTien = Convert.ToDecimal(reader["TienNo"]);
                                string loai = reader["Trangthai"].ToString();
                                if (loai == "Nợ")
                                    tongNo += soTien;
                                else if (loai == "Cho vay")
                                    tongChoVay += soTien;
                            }
                        }
                    }
                    totaltien.Text = "Tổng nợ: " + tongNo.ToString("N0") + " VNĐ           Tổng cho vay:  " + tongChoVay.ToString("N0") + " VNĐ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void ngayno_ValueChanged(object sender, EventArgs e)
        {
            ngayno.Tag = "1";
        }

        private void ngaytra_ValueChanged(object sender, EventArgs e)
        {
            ngaytra.Tag = "1";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachNo.Rows[e.RowIndex];
                if (row.Cells["status"].Value.ToString() != "Đã trả")
                {
                    // Lấy giá trị từ các cột và điền vào các control
                    tenkhoanno.Text = row.Cells["TenNo"].Value?.ToString() ?? ""; // Tránh null
                    if (decimal.TryParse(row.Cells["TienNo"].Value?.ToString(), out decimal tienNo))
                    {
                        sotienno.Text = tienNo.ToString();
                    }
                    else
                    {
                        sotienno.Text = ""; // Nếu không parse được, để trống
                    }

                    // Xử lý NgayNo (có thể NULL)
                    if (row.Cells["NgayGhiNo"].Value != DBNull.Value && DateTime.TryParse(row.Cells["NgayGhiNo"].Value?.ToString(), out DateTime ngayNo))
                    {
                        ngayno.Value = ngayNo;
                        ngayno.Tag = "1";
                    }
                    else
                    {
                        ngayno.Value = DateTime.Now;
                        ngayno.Tag = "0";// Giá trị mặc định nếu NULL
                    }

                    // Xử lý NgayTra
                    if (row.Cells["HanTra"].Value != DBNull.Value && DateTime.TryParse(row.Cells["HanTra"].Value?.ToString(), out DateTime ngayTra))
                    {
                        ngaytra.Value = ngayTra;
                        ngaytra.Tag = "1";
                    }
                    else
                    {
                        ngaytra.Value = DateTime.Now; // Giá trị mặc định nếu NULL
                        ngaytra.Tag = "0";
                    }

                    // Xử lý Loai
                    string loai = row.Cells["status"].Value?.ToString() ?? "";
                    trangthai.SelectedItem = loai; // Đảm bảo ComboBox có các giá trị như "Nợ", "Cho vay"

                    btn_change.Enabled = true;
                }
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            CapNhatDataGridView();
            if (btn_change.Enabled)
            {
                btn_change.Enabled = false; // Đặt nút thay đổi không khả dụng khi khởi động
                btn_change.BackColor = Color.DarkGray; // Đặt màu nền nút thay đổi
                btn_change.ForeColor = Color.White; // Đặt màu chữ nút thay đổi
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {

        }

        private void btn_change_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachNo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khoản nợ để trả!");
                return;
            }

            int id = Convert.ToInt32(dgvDanhSachNo.SelectedRows[0].Cells["STT"].Value);
            string ttHienTai = dgvDanhSachNo.SelectedRows[0].Cells["status"].Value?.ToString();

            // Kiểm tra nếu trạng thái đã là "Đã trả"
            if (ttHienTai == "Đã trả")
            {
                MessageBox.Show("Khoản nợ này đã được thanh toán!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đánh dấu khoản nợ này đã trả?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE KhoanNo SET Trangthai = @Trangthai WHERE Id = @Id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Trangthai", "Đã trả");
                            cmd.Parameters.AddWithValue("@Id", id);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("Không tìm thấy bản ghi để cập nhật!");
                            }
                            else
                            {
                                MessageBox.Show("Đã đánh dấu khoản nợ là Đã trả!");
                            }
                        }
                    }

                    // Cập nhật DataGridView
                    CapNhatDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message);
                }
            }
        }
    }

}
