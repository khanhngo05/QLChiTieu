using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLChiTieu
{
    public partial class MainForm : Form
    {
        private DebtBook debtBook;
        private IncomeForm incomeForm;

        public MainForm(string username)
        {
            InitializeComponent();
            // Khởi tạo các UserControl
            debtBook = new DebtBook();
            incomeForm = new IncomeForm();

            // Thiết lập các thuộc tính cho UserControl
            debtBook.Dock = DockStyle.Fill;
            incomeForm.Dock = DockStyle.Fill;

            label2.Text = username;

            // Căn giữa label2 dưới pictureBox2
            label2.AutoSize = true; // Cho phép label tự điều chỉnh kích thước theo nội dung

            // Tính toán vị trí để căn giữa label2 dưới pictureBox2
            int x = pictureBox2.Left + (pictureBox2.Width - label2.Width) / 2;
            int y = pictureBox2.Bottom + 5; // Cách pictureBox2 5 pixels

            label2.Location = new Point(x, y);
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        //public MainForm()
        //{
        //    InitializeComponent();
        //}
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing) // Kiểm tra nếu người dùng đóng form
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit(); // Đóng toàn bộ ứng dụng
                }
                else
                {
                    e.Cancel = true; // Hủy việc đóng form nếu người dùng chọn No
                }
            }
        }


        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Hide();
                Form1 loginForm = new Form1();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void btnKhoanThu_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); // Xóa control hiện tại trong panel
            panel3.Controls.Add(incomeForm); // Thêm IncomeForm
            incomeForm.BringToFront(); // Đưa lên trên cùng
        }

        private void btnSoNo_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); // Xóa control hiện tại trong panel
            panel3.Controls.Add(debtBook); // Thêm DebtBook
            debtBook.BringToFront(); // Đưa lên trên cùng
        }
    }
}
