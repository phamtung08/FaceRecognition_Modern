using Microsoft.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace FaceRecognition_Modern
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Tạo table nếu chưa có
            DatabaseHelper.EnsureAuthTableExists();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Vui long nhap day du thong tin!";
                lblError.ForeColor = Color.FromArgb(255, 80, 80);
                return;
            }

            btnLogin.Enabled = false;
            lblError.Text = "Dang xac thuc...";
            lblError.ForeColor = Color.Gray;

            var (success, role) = DatabaseHelper.Login(username, password);

            if (success)
            {
                UserSession.Username = username;
                UserSession.Role = role;

                lblError.Text = $"Dang nhap thanh cong! Role: {role}";
                lblError.ForeColor = Color.FromArgb(0, 200, 100);

                // Mở Form1 và đóng login
                var form1 = new Form1();
                form1.Show();
                this.Hide();
                form1.FormClosed += (s, ev) =>
                {
                    UserSession.Clear();
                    this.Close();
                };
            }
            else
            {
                lblError.Text = "Sai ten dang nhap hoac mat khau!";
                lblError.ForeColor = Color.FromArgb(255, 80, 80);
                txtPassword.Clear();
                txtPassword.Focus();
                btnLogin.Enabled = true;
            }
        }

        // Nhấn Enter để login
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                BtnLogin_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void lblDefaultHint_Click(object sender, EventArgs e)
        {

        }
    }
}