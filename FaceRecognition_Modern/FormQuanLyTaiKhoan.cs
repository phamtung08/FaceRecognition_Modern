namespace FaceRecognition_Modern
{
    public partial class FormQuanLyTaiKhoan : Form
    {
        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
            AddBackButton();
        }

        private void AddBackButton()
        {
            var btn = new System.Windows.Forms.Button
            {
                Text = "<- Quay lai",
                Dock = System.Windows.Forms.DockStyle.Bottom,
                Height = 36,
                Font = new System.Drawing.Font("Segoe UI", 9f),
                BackColor = System.Drawing.Color.FromArgb(40, 40, 60),
                ForeColor = System.Drawing.Color.FromArgb(150, 150, 180),
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Cursor = System.Windows.Forms.Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += (s, e) => this.Close();
            this.Controls.Add(btn);
        }

        private void FormQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = $"Dang nhap: {UserSession.Username} (Admin)";
            LoadAccounts();

            // Mac dinh: o trang them moi
            txtUsername.Focus();
        }

        // ── Load danh sach tai khoan ──────────────────────────────────────────
        private void LoadAccounts()
        {
            dataGrid.Rows.Clear();
            var accounts = DatabaseHelper.GetAllAccounts();
            int i = 1;
            foreach (var acc in accounts)
            {
                dataGrid.Rows.Add(i++, acc.Id, acc.Username, acc.Role);
            }
            lblTotal.Text = $"Tong: {accounts.Count} tai khoan";
        }

        // ── Them tai khoan ────────────────────────────────────────────────────
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cboRole.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui long nhap day du Username va Password!",
                    "Thieu thong tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(role))
                role = "Admin";

            bool ok = DatabaseHelper.AddAccount(username, password, role);
            if (ok)
            {
                MessageBox.Show($"Them tai khoan '{username}' thanh cong!",
                    "Thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Clear();
                txtPassword.Clear();
                LoadAccounts();
            }
            else
            {
                MessageBox.Show($"Them that bai!\nTen '{username}' co the da ton tai.",
                    "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Xoa tai khoan ─────────────────────────────────────────────────────
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hay chon tai khoan can xoa!",
                    "Chua chon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dataGrid.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells[1].Value);
            string uname = row.Cells[2].Value?.ToString() ?? "";

            // Khong cho xoa chinh minh
            if (uname == UserSession.Username)
            {
                MessageBox.Show("Khong the xoa tai khoan dang dang nhap!",
                    "Khong cho phep", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Xoa tai khoan '{uname}'?",
                "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool ok = DatabaseHelper.DeleteAccount(id);
                if (ok)
                {
                    MessageBox.Show("Xoa thanh cong!", "OK",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccounts();
                }
                else
                {
                    MessageBox.Show("Xoa that bai!", "Loi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ── Doi mat khau ──────────────────────────────────────────────────────
        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hay chon tai khoan can doi mat khau!",
                    "Chua chon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dataGrid.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells[1].Value);
            string uname = row.Cells[2].Value?.ToString() ?? "";
            string newPass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Nhap mat khau moi vao o Password!",
                    "Thieu mat khau", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = DatabaseHelper.UpdatePassword(id, newPass);
            if (ok)
            {
                MessageBox.Show($"Doi mat khau '{uname}' thanh cong!",
                    "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Doi mat khau that bai!", "Loi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Click vao row -> dien vao form ────────────────────────────────────
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0) return;
            var row = dataGrid.SelectedRows[0];
            txtUsername.Text = row.Cells[2].Value?.ToString() ?? "";
            string role = row.Cells[3].Value?.ToString() ?? "Admin";
            cboRole.Text = role;
        }
    }
}