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
        private Expenditure expenditure;
        private StaticsticalForm statics;

        private string currentUsername;

        public void SetCurrentUser(string username)
        {
            currentUsername = username;
            //Cập nhật dữ liệu cho user hiện tại
            LoadUserData();
        }
        private void LoadUserData()
        {
            // Gọi phương thức load dữ liệu của từng form con
            if (incomeForm != null)
                incomeForm.LoadDataForUser(currentUsername);
            if (expenditure != null)
                expenditure.LoadDataForUser(currentUsername);
            if (debtBook != null)
                debtBook.LoadDataForUser(currentUsername);
            if (statics != null)
                statics.LoadDataForUser(currentUsername);
        }
        public MainForm(string username)
        {
            InitializeComponent();

            currentUsername = username;

            // Khởi tạo các UserControl
            debtBook = new DebtBook();
            incomeForm = new IncomeForm();
            expenditure = new Expenditure();
            statics = new StaticsticalForm();

            // Thiết lập các thuộc tính cho UserControl
            debtBook.Dock = DockStyle.Fill;
            incomeForm.Dock = DockStyle.Fill;
            expenditure.Dock = DockStyle.Fill;
            statics.Dock = DockStyle.Fill;

            //Load dữ liệu ngay sau khi khởi tạo
            LoadUserData();

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
            // Chỉ hiện hộp thoại xác nhận khi người dùng chủ động đóng form
            if (e.CloseReason == CloseReason.UserClosing &&
                ModifierKeys != Keys.Alt && // Không phải Alt+F4
                !this.IsDisposed) // Form chưa bị dispose
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                Form1 loginForm = new Form1();
                this.Hide();
                loginForm.ShowDialog();
                //this.Close();
            }
        }

        private void btnKhoanThu_Click(object sender, EventArgs e)
        {
            if (incomeForm != null)
            {
                incomeForm.LoadDataForUser(currentUsername);
                panel3.Controls.Clear();
                panel3.Controls.Add(incomeForm);
                incomeForm.BringToFront();
            }
        }

        private void btnSoNo_Click(object sender, EventArgs e)
        {
            // Đảm bảo dữ liệu được load trước khi hiển thị
            if (debtBook != null)
            {
                debtBook.LoadDataForUser(currentUsername);
                panel3.Controls.Clear();
                panel3.Controls.Add(debtBook);
                debtBook.BringToFront();
            }
        }

        private void btnKhoanChi_Click(object sender, EventArgs e)
        {
            if (expenditure != null)
            {
                expenditure.LoadDataForUser(currentUsername);
                panel3.Controls.Clear();
                panel3.Controls.Add(expenditure);
                expenditure.BringToFront();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (statics != null)
            {
                statics.LoadDataForUser(currentUsername);
                panel3.Controls.Clear();
                panel3.Controls.Add(statics);
                statics.BringToFront();
            }
        }
    }
}
