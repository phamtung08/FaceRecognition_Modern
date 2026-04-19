namespace FaceRecognition_Modern
{
    partial class FormQuanLyTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTableHeader;
        private System.Windows.Forms.Label lblUsernameHint;
        private System.Windows.Forms.Label lblPasswordHint;
        private System.Windows.Forms.Label lblRoleHint;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnBack;

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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTableHeader = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.lblUsernameHint = new System.Windows.Forms.Label();
            this.lblPasswordHint = new System.Windows.Forms.Label();
            this.lblRoleHint = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();

            // ── panelTop (header xanh dương) ──────────────────────────────────
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 56;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.panelTop.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);

            this.lblTitle.Text = "Quản lý tài khoản";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Width = 260;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblCurrentUser.Text = "";
            this.lblCurrentUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblCurrentUser.ForeColor = System.Drawing.Color.FromArgb(187, 222, 251);
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.panelTop.Controls.Add(this.lblCurrentUser);
            this.panelTop.Controls.Add(this.lblTitle);

            // ── panelRight (form nhập) ────────────────────────────────────────
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Width = 290;
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            // Header form nhập
            this.lblFormHeader.Text = "THÔNG TIN TÀI KHOẢN";
            this.lblFormHeader.Location = new System.Drawing.Point(0, 0);
            this.lblFormHeader.Size = new System.Drawing.Size(290, 36);
            this.lblFormHeader.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblFormHeader.ForeColor = System.Drawing.Color.White;
            this.lblFormHeader.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblFormHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Username
            this.lblUsernameHint.Text = "Username";
            this.lblUsernameHint.Location = new System.Drawing.Point(16, 52);
            this.lblUsernameHint.Size = new System.Drawing.Size(258, 18);
            this.lblUsernameHint.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblUsernameHint.ForeColor = System.Drawing.Color.FromArgb(96, 125, 139);

            this.txtUsername.Location = new System.Drawing.Point(16, 74);
            this.txtUsername.Size = new System.Drawing.Size(258, 32);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Password
            this.lblPasswordHint.Text = "Password";
            this.lblPasswordHint.Location = new System.Drawing.Point(16, 118);
            this.lblPasswordHint.Size = new System.Drawing.Size(258, 18);
            this.lblPasswordHint.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblPasswordHint.ForeColor = System.Drawing.Color.FromArgb(96, 125, 139);

            this.txtPassword.Location = new System.Drawing.Point(16, 140);
            this.txtPassword.Size = new System.Drawing.Size(258, 32);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Role
            this.lblRoleHint.Text = "Role";
            this.lblRoleHint.Location = new System.Drawing.Point(16, 184);
            this.lblRoleHint.Size = new System.Drawing.Size(258, 18);
            this.lblRoleHint.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblRoleHint.ForeColor = System.Drawing.Color.FromArgb(96, 125, 139);

            this.cboRole.Location = new System.Drawing.Point(16, 206);
            this.cboRole.Size = new System.Drawing.Size(258, 32);
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.cboRole.BackColor = System.Drawing.Color.White;
            this.cboRole.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Items.AddRange(new object[] { "Admin", "GiaoVien", "SinhVien" });
            this.cboRole.SelectedIndex = 0;

            // btnAdd
            this.btnAdd.Text = "Thêm tài khoản";
            this.btnAdd.Location = new System.Drawing.Point(16, 256);
            this.btnAdd.Size = new System.Drawing.Size(258, 36);
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

            // btnChangePass
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.Location = new System.Drawing.Point(16, 302);
            this.btnChangePass.Size = new System.Drawing.Size(258, 36);
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);

            // btnDelete
            this.btnDelete.Text = "Xóa tài khoản đã chọn";
            this.btnDelete.Location = new System.Drawing.Point(16, 348);
            this.btnDelete.Size = new System.Drawing.Size(258, 36);
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            this.panelRight.Controls.Add(this.lblFormHeader);
            this.panelRight.Controls.Add(this.lblUsernameHint);
            this.panelRight.Controls.Add(this.txtUsername);
            this.panelRight.Controls.Add(this.lblPasswordHint);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.lblRoleHint);
            this.panelRight.Controls.Add(this.cboRole);
            this.panelRight.Controls.Add(this.btnAdd);
            this.panelRight.Controls.Add(this.btnChangePass);
            this.panelRight.Controls.Add(this.btnDelete);

            // ── panelLeft (danh sách) ─────────────────────────────────────────
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Padding = new System.Windows.Forms.Padding(12, 10, 12, 0);

            this.lblTableHeader.Text = "DANH SÁCH TÀI KHOẢN";
            this.lblTableHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTableHeader.Height = 28;
            this.lblTableHeader.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblTableHeader.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblTableHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblTotal.Text = "Tổng: 0 tài khoản";
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotal.Height = 24;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(96, 125, 139);
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // DataGridView — light theme
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.dataGrid.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.dataGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.dataGrid.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.dataGrid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.dataGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.dataGrid.ColumnHeadersHeight = 34;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);

            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "STT", Width = 50 });
            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "ID", Width = 50 });
            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Username", Width = 180 });
            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Role", Width = 120 });

            this.panelLeft.Controls.Add(this.dataGrid);
            this.panelLeft.Controls.Add(this.lblTotal);
            this.panelLeft.Controls.Add(this.lblTableHeader);

            // ── panelBottom (nút quay lại) ────────────────────────────────────
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 46;
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelBottom.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);

            this.btnBack.Text = "Quay lại";
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Width = 130;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(96, 125, 139);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            this.panelBottom.Controls.Add(this.btnBack);

            // ── FormQuanLyTaiKhoan ────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 580);
            this.MinimumSize = new System.Drawing.Size(700, 460);
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceRecognition Pro — Quản lý tài khoản";
            this.Load += new System.EventHandler(this.FormQuanLyTaiKhoan_Load);

            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);

            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}