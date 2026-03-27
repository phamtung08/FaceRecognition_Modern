namespace FaceRecognition_Modern
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsernameHint;
        private System.Windows.Forms.Label lblPasswordHint;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMain = new Panel();
            lblAppName = new Label();
            lblSubtitle = new Label();
            lblUsernameHint = new Label();
            txtUsername = new TextBox();
            lblPasswordHint = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblError = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(22, 22, 34);
            panelMain.Controls.Add(lblAppName);
            panelMain.Controls.Add(lblSubtitle);
            panelMain.Controls.Add(lblUsernameHint);
            panelMain.Controls.Add(txtUsername);
            panelMain.Controls.Add(lblPasswordHint);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(btnLogin);
            panelMain.Controls.Add(lblError);
            panelMain.Location = new Point(140, 80);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(360, 440);
            panelMain.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAppName.ForeColor = Color.FromArgb(0, 230, 118);
            lblAppName.Location = new Point(0, 30);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(360, 40);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "FaceRecognition";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(120, 120, 150);
            lblSubtitle.Location = new Point(0, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(360, 24);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "He thong diem danh khuon mat";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsernameHint
            // 
            lblUsernameHint.Font = new Font("Segoe UI", 8.5F);
            lblUsernameHint.ForeColor = Color.FromArgb(150, 150, 180);
            lblUsernameHint.Location = new Point(30, 120);
            lblUsernameHint.Name = "lblUsernameHint";
            lblUsernameHint.Size = new Size(300, 20);
            lblUsernameHint.TabIndex = 2;
            lblUsernameHint.Text = "Ten dang nhap";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(32, 32, 48);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(30, 144);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 32);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "admin";
            // 
            // lblPasswordHint
            // 
            lblPasswordHint.Font = new Font("Segoe UI", 8.5F);
            lblPasswordHint.ForeColor = Color.FromArgb(150, 150, 180);
            lblPasswordHint.Location = new Point(30, 196);
            lblPasswordHint.Name = "lblPasswordHint";
            lblPasswordHint.Size = new Size(300, 20);
            lblPasswordHint.TabIndex = 4;
            lblPasswordHint.Text = "Mat khau";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(32, 32, 48);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(30, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(300, 32);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 180, 90);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 44);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Dang nhap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.FromArgb(255, 80, 80);
            lblError.Location = new Point(30, 336);
            lblError.Name = "lblError";
            lblError.Size = new Size(300, 24);
            lblError.TabIndex = 7;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 20);
            ClientSize = new Size(640, 600);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dang nhap — FaceRecognition";
            Load += FormLogin_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }
    }
}