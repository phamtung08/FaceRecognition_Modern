using Microsoft.Data.SqlClient;

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

                var form1 = new Form1();
                this.Hide();
                form1.Show();

                // Khi Form1 đóng → kiểm tra có phải đăng xuất không
                form1.FormClosed += (s, ev) =>
                {
                    if (!UserSession.IsLoggedIn)
                    {
                        // Đăng xuất → hiện lại FormLogin
                        txtPassword.Clear();
                        btnLogin.Enabled = true;
                        lblError.Text = "Da dang xuat. Vui long dang nhap lai.";
                        lblError.ForeColor = Color.FromArgb(255, 180, 0);
                        this.Show();
                    }
                    else
                    {
                        // Đóng app bình thường
                        this.Close();
                    }
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                BtnLogin_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}