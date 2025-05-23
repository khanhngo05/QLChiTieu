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
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-2CJCN1N;Initial Catalog=QLChiTieu;Integrated Security=True");
        public RegisterForm()
        {
            InitializeComponent();
        }

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

        private void register_signinBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if(register_username.Text == "" || register_password.Text == "" || register_rePass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (register_password.Text != register_rePass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connect.Open();
                //Kiểm tra xem tên tài khoản nhập vào đã tồn tại hay chưa
                string selectUsername = "SELECT * FROM TaiKhoan WHERE username = @username";

                using(SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                {
                    checkUser.Parameters.AddWithValue("@username", register_username.Text.Trim());
                    SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if(table.Rows.Count != 0)
                    {
                        //Doạn này là để chuyển đổi chữ đầu tên tài khoản thành chữ hoa còn lại chữ thường
                        string tempUsername = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1).ToLower();
                        MessageBox.Show(tempUsername + " đã tồn tại, vui lòng chọn tên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(register_password.Text.Length < 0)
                    {
                        MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (register_password.Text != register_rePass.Text)
                    {
                        MessageBox.Show("Mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertData = "INSERT INTO TaiKhoan (username, password, date_create) VALUES (@username, @password, @date)";
                        using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                        {
                            insertUser.Parameters.AddWithValue("@username", register_username.Text.Trim());
                            insertUser.Parameters.AddWithValue("@password", register_password.Text.Trim());
                            insertUser.Parameters.AddWithValue("@date", DateTime.Today);
                            insertUser.ExecuteNonQuery();
                            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            Form1 loginForm = new Form1();
                            loginForm.Show();
                            
                            this.Close();
                        }
                    }
                }
                connect.Close();
                
            }
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_rePass.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void register_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                register_btn_Click(sender, e);
            }
        }
    }
}
