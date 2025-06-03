using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;



namespace QLChiTieu
{
   
    public partial class StaticsticalForm : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=desktop-2cjcn1n;Initial Catalog=QLChiTieu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

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
        public StaticsticalForm()
        {
            InitializeComponent();
        }
       
        private void StaticsticalForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            //connection.Open();
            //LoadDataForUser(currentUsername);
            //connection.Close();
        }
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from QLThuChi where username = @username";
            command.Parameters.AddWithValue("@username", currentUsername);
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            staticstical_dgv.DataSource = table;
            staticstical_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đổi tên các cột sau khi bind data
            staticstical_dgv.Columns[0].HeaderText = "ID";
            staticstical_dgv.Columns[1].HeaderText = "Số tiền (VNĐ)";
            staticstical_dgv.Columns[2].HeaderText = "Danh mục";
            staticstical_dgv.Columns[3].HeaderText = "Loại";
            staticstical_dgv.Columns[4].HeaderText = "Ghi chú";
            staticstical_dgv.Columns[5].HeaderText = "Ngày tháng";

            // Ẩn cột ID
            staticstical_dgv.Columns[0].Visible = false;

            //Căn giữa tiêu đề cột
            staticstical_dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Chỉnh màu nền cho tiêu đề cột
            //income_dgv.EnableHeadersVisualStyles = false;
            //income_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);


            // Định dạng thêm cho các cột
            staticstical_dgv.Columns[0].Width = 50;          // Độ rộng cột
            staticstical_dgv.Columns[1].DefaultCellStyle.Format = "N0";  // Format số tiền
            staticstical_dgv.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy"; // Format ngày

            // Căn chỉnh nội dung
            staticstical_dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            staticstical_dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; //căn cột số tiền bên phải
            staticstical_dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; //căn cột Ngày tháng bên phải
            VeBieuDoTheoData(table);
        }

        private void VeBieuDoTheoData(DataTable dt)
        {
            chart.Series.Clear();
            chart.Series.Add("ThuChi");
            chart.Series["ThuChi"].ChartType = SeriesChartType.Doughnut;

            decimal tongThu = 0;
            decimal tongChi = 0;

            // Duyệt từng dòng của DataTable
            foreach (DataRow row in dt.Rows)
            {
                string loai = row["Loai"].ToString();
                decimal soTien;

                // Chuyển đổi và kiểm tra dữ liệu
                if (decimal.TryParse(row["SoTien"].ToString(), out soTien))
                {
                    if (loai == "Thu")
                        tongThu += soTien;
                    else if (loai == "Chi")
                        tongChi += soTien;
                }
            }

            // Thêm dữ liệu vào biểu đồ nếu có
            if (tongThu > 0)
                chart.Series["ThuChi"].Points.AddXY("Thu", tongThu);
            if (tongChi > 0)
                chart.Series["ThuChi"].Points.AddXY("Chi", tongChi);

            // Nếu không có dữ liệu
            if (tongThu == 0 && tongChi == 0)
            {
                chart.Titles.Clear();
                chart.Titles.Add("Không có dữ liệu phù hợp");
                return;
            }

            // Cài đặt hiển thị
            chart.Series["ThuChi"]["PieLabelStyle"] = "Outside";
            chart.Series["ThuChi"].IsValueShownAsLabel = true;
            chart.Legends[0].Enabled = true;
            chart.Titles.Clear();
            chart.Titles.Add("Tỷ lệ Thu vs Chi trong tổng thu chi (đã lọc)");
        }


        private void staticstical_btnFilter_Click(object sender, EventArgs e)
        {
            string danhMuc = staticstical_ComboBox_Category.Text.Trim();
            string loai = staticstical_ComboBox_Type.Text.Trim();
            string ghiChu = staticstical_TextBox_Note.Text.Trim();
            if ((danhMuc == "" || danhMuc == "(None)") && (loai == "" || loai == "(None)") && ghiChu == "" && radioBtn_Disable.Checked && staticstical_labelMoney_From.Text == "" && staticstical_labelMoney_To.Text == "")
            {
                LoadDataForUser(currentUsername); // Nạp lại dữ liệu gốc nếu không có bộ lọc nào được áp dụng
            }
            else { 
                string query = "SELECT * FROM QLThuChi WHERE 1=1";

                // Danh mục
                if (!string.IsNullOrEmpty(danhMuc))
                {
                    if (danhMuc == "(None)") {
                        staticstical_ComboBox_Category.SelectedIndex = -1;
                    }
                    else
                    {
                        query += " AND DanhMuc = @DanhMuc";
                    }

                }

                // Thời gian (lọc theo ngày)
                if (radioBtn_Enable.Checked)
                {
                    query += " AND CONVERT(date, NgayThang) = @Ngay";
                }
               

                // Loại: Thu/Chi
                if (!string.IsNullOrEmpty(loai)) {
                    if (loai == "(None)") {
                        staticstical_ComboBox_Type.SelectedIndex = -1;
                    } else
                    {
                        query += " AND Loai = @Loai";
                    }
                }

                // Ghi chú
                if (!string.IsNullOrEmpty(ghiChu))
                    query += " AND GhiChu LIKE @GhiChu";

                // Mức tiền
                string fromText = staticstical_TextBox_From.Text.Replace(",", "").Replace(".", "");
                string toText = staticstical_TextBox_To.Text.Replace(",", "").Replace(".", "");

                bool coMucTu = int.TryParse(fromText, out int mucTu);
                bool coMucDen = int.TryParse(toText, out int mucDen);
                if (coMucTu)
                    query += " AND SoTien >= @MucTu";
                if (coMucDen)
                    query += " AND SoTien <= @MucDen";

                // Thực thi truy vấn
                using (SqlConnection conn = new SqlConnection(str))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(danhMuc))
                        cmd.Parameters.AddWithValue("@DanhMuc", danhMuc);
                    if (radioBtn_Enable.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Ngay", staticstical_DateTimePicker.Value.Date);
                    }
                    if (!string.IsNullOrEmpty(loai))
                        cmd.Parameters.AddWithValue("@Loai", loai);

                    if (!string.IsNullOrEmpty(ghiChu))
                        cmd.Parameters.AddWithValue("@GhiChu", "%" + ghiChu + "%");

                    if (coMucTu)
                        cmd.Parameters.AddWithValue("@MucTu", mucTu);

                    if (coMucDen)
                        cmd.Parameters.AddWithValue("@MucDen", mucDen);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    staticstical_dgv.DataSource = dt;
                    VeBieuDoTheoData(dt);
                }
            }
        }

        private void radioBtn_Enable_CheckedChanged(object sender, EventArgs e)
        { 
            staticstical_DateTimePicker.Enabled = true;
            
        }

        private void radioBtn_Disable_CheckedChanged(object sender, EventArgs e)
        {
            staticstical_DateTimePicker.Enabled = false;
        }

        //private void staticstical_btnExport_Click(object sender, EventArgs e)
        //{
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    if (staticstical_dgv.Rows.Count == 0)
        //    {
        //        MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        //    {
        //        saveFileDialog.Filter = "Excel File|*.xlsx";
        //        saveFileDialog.Title = "Chọn nơi lưu file Excel";
        //        saveFileDialog.FileName = "BaoCaoThuChi.xlsx"; // Tên mặc định

        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            try
        //            {
        //                using (ExcelPackage excelPackage = new ExcelPackage())
        //                {
        //                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("ThuChi");

        //                    // Tạo tiêu đề cột
        //                    for (int i = 0; i < staticstical_dgv.Columns.Count; i++)
        //                    {
        //                        worksheet.Cells[1, i + 1].Value = staticstical_dgv.Columns[i].HeaderText;
        //                        worksheet.Cells[1, i + 1].Style.Font.Bold = true;
        //                        worksheet.Cells[1, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
        //                        worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
        //                    }

        //                    // Thêm dữ liệu
        //                    for (int i = 0; i < staticstical_dgv.Rows.Count; i++)
        //                    {
        //                        for (int j = 0; j < staticstical_dgv.Columns.Count; j++)
        //                        {
        //                            worksheet.Cells[i + 2, j + 1].Value = staticstical_dgv.Rows[i].Cells[j].Value?.ToString();
        //                        }
        //                    }

        //                    // Tự động căn chỉnh cột
        //                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

        //                    // Lưu file
        //                    FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
        //                    excelPackage.SaveAs(fileInfo);

        //                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}
    }
}
