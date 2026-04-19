namespace FaceRecognition_Modern
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsernameHint;
        private System.Windows.Forms.Label lblPasswordHint;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblDefaultHint;
        private System.Windows.Forms.Label lblVersion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsernameHint = new System.Windows.Forms.Label();
            this.lblPasswordHint = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblDefaultHint = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();

            // ── panelHeader (xanh dương) ──────────────────────────────────────
            this.panelHeader.Location = new System.Drawing.Point(120, 60);
            this.panelHeader.Size = new System.Drawing.Size(400, 90);
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);

            this.lblAppName.Text = "FaceRecognition Pro";
            this.lblAppName.Location = new System.Drawing.Point(0, 12);
            this.lblAppName.Size = new System.Drawing.Size(400, 36);
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSubtitle.Text = "Hệ thống nhận diện & Điểm danh khuôn mặt";
            this.lblSubtitle.Location = new System.Drawing.Point(0, 52);
            this.lblSubtitle.Size = new System.Drawing.Size(400, 26);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(187, 222, 251);
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelHeader.Controls.Add(this.lblAppName);
            this.panelHeader.Controls.Add(this.lblSubtitle);

            // ── panelForm (trắng) ─────────────────────────────────────────────
            this.panelForm.Location = new System.Drawing.Point(120, 150);
            this.panelForm.Size = new System.Drawing.Size(400, 300);
            this.panelForm.BackColor = System.Drawing.Color.White;

            // lblUsernameHint
            this.lblUsernameHint.Text = "Tên đăng nhập";
            this.lblUsernameHint.Location = new System.Drawing.Point(40, 30);
            this.lblUsernameHint.Size = new System.Drawing.Size(320, 18);
            this.lblUsernameHint.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblUsernameHint.ForeColor = System.Drawing.Color.FromArgb(96, 125, 139);

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(40, 52);
            this.txtUsername.Size = new System.Drawing.Size(320, 32);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Text = "admin";

            // lblPasswordHint
            this.lblPasswordHint.Text = "Mật khẩu";
            this.lblPasswordHint.Location = new System.Drawing.Point(40, 96);
            this.lblPasswordHint.Size = new System.Drawing.Size(320, 18);
            this.lblPasswordHint.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblPasswordHint.ForeColor = System.Drawing.Color.FromArgb(96, 125, 139);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(40, 118);
            this.txtPassword.Size = new System.Drawing.Size(320, 32);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.PasswordChar = '●';

            // btnLogin
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.Location = new System.Drawing.Point(40, 168);
            this.btnLogin.Size = new System.Drawing.Size(320, 40);
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);

            // lblError
            this.lblError.Text = "";
            this.lblError.Location = new System.Drawing.Point(40, 218);
            this.lblError.Size = new System.Drawing.Size(320, 22);
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblDefaultHint
            this.lblDefaultHint.Text = "Mặc định: admin";
            this.lblDefaultHint.Location = new System.Drawing.Point(40, 252);
            this.lblDefaultHint.Size = new System.Drawing.Size(320, 18);
            this.lblDefaultHint.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblDefaultHint.ForeColor = System.Drawing.Color.FromArgb(189, 189, 189);
            this.lblDefaultHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelForm.Controls.Add(this.lblUsernameHint);
            this.panelForm.Controls.Add(this.txtUsername);
            this.panelForm.Controls.Add(this.lblPasswordHint);
            this.panelForm.Controls.Add(this.txtPassword);
            this.panelForm.Controls.Add(this.btnLogin);
            this.panelForm.Controls.Add(this.lblError);
            this.panelForm.Controls.Add(this.lblDefaultHint);

            // lblVersion (footer)
            this.lblVersion.Text = "v1.0 — FaceRecognition Modern";
            this.lblVersion.Location = new System.Drawing.Point(0, 468);
            this.lblVersion.Size = new System.Drawing.Size(640, 20);
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(189, 189, 189);
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FormLogin
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 500);
            this.BackColor = System.Drawing.Color.FromArgb(237, 241, 245);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceRecognition Pro — đăng nhập";
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.lblVersion);
            this.Load += new System.EventHandler(this.FormLogin_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}