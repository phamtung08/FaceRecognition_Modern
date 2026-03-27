namespace FaceRecognition_Modern
{
    partial class FormQuanLyTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblUsernameHint;
        private System.Windows.Forms.Label lblPasswordHint;
        private System.Windows.Forms.Label lblRoleHint;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangePass;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblUsernameHint = new System.Windows.Forms.Label();
            this.lblPasswordHint = new System.Windows.Forms.Label();
            this.lblRoleHint = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();

            // ── panelTop ──────────────────────────────────────────────────────
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 52;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            this.panelTop.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);

            this.lblTitle.Text = "  Quan ly tai khoan";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Width = 250;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 230, 118);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblCurrentUser.Text = "";
            this.lblCurrentUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(120, 120, 150);
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.panelTop.Controls.Add(this.lblCurrentUser);
            this.panelTop.Controls.Add(this.lblTitle);

            // ── panelLeft (danh sach) ─────────────────────────────────────────
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(12, 12, 20);
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);

            this.lblTotal.Text = "Tong: 0 tai khoan";
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotal.Height = 24;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(0, 230, 118);

            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(16, 16, 26);
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(32, 32, 48);
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.dataGrid.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(16, 16, 26);
            this.dataGrid.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(210, 210, 230);
            this.dataGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 90, 55);
            this.dataGrid.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 20, 32);
            this.dataGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 36);
            this.dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 230, 118);
            this.dataGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.dataGrid.ColumnHeadersHeight = 32;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.RowTemplate.Height = 30;
            this.dataGrid.MultiSelect = false;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);

            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "STT", Width = 50 });
            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "ID", Width = 50 });
            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Username", Width = 160 });
            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Role", Width = 120 });

            this.panelLeft.Controls.Add(this.dataGrid);
            this.panelLeft.Controls.Add(this.lblTotal);

            // ── panelRight (form nhap) ────────────────────────────────────────
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Width = 280;
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(16, 16, 26);
            this.panelRight.Padding = new System.Windows.Forms.Padding(16);

            this.lblUsernameHint.Text = "Username:";
            this.lblUsernameHint.Location = new System.Drawing.Point(16, 20);
            this.lblUsernameHint.Size = new System.Drawing.Size(248, 20);
            this.lblUsernameHint.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblUsernameHint.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);

            this.txtUsername.Location = new System.Drawing.Point(16, 44);
            this.txtUsername.Size = new System.Drawing.Size(248, 30);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(26, 26, 40);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblPasswordHint.Text = "Password:";
            this.lblPasswordHint.Location = new System.Drawing.Point(16, 86);
            this.lblPasswordHint.Size = new System.Drawing.Size(248, 20);
            this.lblPasswordHint.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblPasswordHint.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);

            this.txtPassword.Location = new System.Drawing.Point(16, 110);
            this.txtPassword.Size = new System.Drawing.Size(248, 30);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(26, 26, 40);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblRoleHint.Text = "Role:";
            this.lblRoleHint.Location = new System.Drawing.Point(16, 152);
            this.lblRoleHint.Size = new System.Drawing.Size(248, 20);
            this.lblRoleHint.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblRoleHint.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);

            this.cboRole.Location = new System.Drawing.Point(16, 176);
            this.cboRole.Size = new System.Drawing.Size(248, 30);
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.cboRole.BackColor = System.Drawing.Color.FromArgb(26, 26, 40);
            this.cboRole.ForeColor = System.Drawing.Color.White;
            this.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Items.AddRange(new object[] { "Admin", "GiaoVien", "SinhVien" });
            this.cboRole.SelectedIndex = 0;

            this.btnAdd.Text = "Them tai khoan";
            this.btnAdd.Location = new System.Drawing.Point(16, 224);
            this.btnAdd.Size = new System.Drawing.Size(248, 36);
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 160, 80);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

            this.btnChangePass.Text = "Doi mat khau";
            this.btnChangePass.Location = new System.Drawing.Point(16, 270);
            this.btnChangePass.Size = new System.Drawing.Size(248, 36);
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);

            this.btnDelete.Text = "Xoa tai khoan da chon";
            this.btnDelete.Location = new System.Drawing.Point(16, 316);
            this.btnDelete.Size = new System.Drawing.Size(248, 36);
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(180, 40, 40);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            this.panelRight.Controls.Add(this.lblUsernameHint);
            this.panelRight.Controls.Add(this.txtUsername);
            this.panelRight.Controls.Add(this.lblPasswordHint);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.lblRoleHint);
            this.panelRight.Controls.Add(this.cboRole);
            this.panelRight.Controls.Add(this.btnAdd);
            this.panelRight.Controls.Add(this.btnChangePass);
            this.panelRight.Controls.Add(this.btnDelete);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 18);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly tai khoan — Admin";
            this.Load += new System.EventHandler(this.FormQuanLyTaiKhoan_Load);

            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);

            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}