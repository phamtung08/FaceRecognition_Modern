namespace FaceRecognition_Modern
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnTrain = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblTitle.Text = "Train EigenFace Model";
            this.lblTitle.Location = new System.Drawing.Point(12, 16);
            this.lblTitle.Size = new System.Drawing.Size(560, 30);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);

            this.lblInfo.Text = "Dataset phai co it nhat 2 nguoi, moi nguoi it nhat 10 anh.";
            this.lblInfo.Location = new System.Drawing.Point(12, 52);
            this.lblInfo.Size = new System.Drawing.Size(560, 22);
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;

            this.listLog.Location = new System.Drawing.Point(12, 84);
            this.listLog.Size = new System.Drawing.Size(560, 260);
            this.listLog.Font = new System.Drawing.Font("Consolas", 9f);
            this.listLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.progressBar.Location = new System.Drawing.Point(12, 358);
            this.progressBar.Size = new System.Drawing.Size(560, 22);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

            this.btnTrain.Text = "Bat dau Train Model";
            this.btnTrain.Location = new System.Drawing.Point(12, 394);
            this.btnTrain.Size = new System.Drawing.Size(560, 40);
            this.btnTrain.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            this.btnTrain.BackColor = System.Drawing.Color.FromArgb(156, 39, 176);
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain.FlatAppearance.BorderSize = 0;
            this.btnTrain.Click += new System.EventHandler(this.BtnTrain_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 492);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnTrain);
            this.Text = "Form2 - Train Model";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
        }
    }
}