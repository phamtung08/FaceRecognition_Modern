namespace FaceRecognition_Modern
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblModelStatus;
        private System.Windows.Forms.Label lblDbStatus;
        private System.Windows.Forms.Label lblCameraStatus;
        private System.Windows.Forms.Label lblFaceCount;
        private System.Windows.Forms.Label lblTableHeader;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGrid;

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
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblModelStatus = new System.Windows.Forms.Label();
            this.lblDbStatus = new System.Windows.Forms.Label();
            this.lblCameraStatus = new System.Windows.Forms.Label();
            this.lblFaceCount = new System.Windows.Forms.Label();
            this.lblTableHeader = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // ── panelTop ─────────────────────────────────────────────────────
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 52;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            this.panelTop.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);

            this.lblTitle.Text = "  Hệ thống Điểm Danh";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Width = 230;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 230, 118);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblDbStatus.Text = "DB: Đang kiểm tra...";
            this.lblDbStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDbStatus.Width = 180;
            this.lblDbStatus.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblDbStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblDbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblModelStatus.Text = "Model: chưa load";
            this.lblModelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelStatus.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblModelStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblModelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblDate.Text = "Ngay: ";
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Width = 150;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.panelTop.Controls.Add(this.lblModelStatus);
            this.panelTop.Controls.Add(this.lblDbStatus);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblDate);

            // ── panelLeft (camera) ────────────────────────────────────────────
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 560;
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(8, 8, 16);
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);

            this.picCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamera.BackColor = System.Drawing.Color.FromArgb(5, 5, 12);
            this.picCamera.TabStop = false;

            this.panelLeft.Controls.Add(this.picCamera);

            // ── panelRight ────────────────────────────────────────────────────
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(12, 12, 20);
            this.panelRight.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);

            this.lblTableHeader.Text = "DANH SÁCH ĐIỂM DANH";
            this.lblTableHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTableHeader.Height = 28;
            this.lblTableHeader.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblTableHeader.ForeColor = System.Drawing.Color.FromArgb(0, 230, 118);
            this.lblTableHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblTotal.Text = "Tổng: 0 người";
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotal.Height = 26;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(0, 230, 118);
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // DataGridView
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

            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "STT", Width = 40 });
            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Họ tên", Width = 120 });
            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Ngày", Width = 84 });
            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Giờ vào", Width = 70 });
            this.dataGrid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Trạng thái", Width = 80 });

            this.panelRight.Controls.Add(this.dataGrid);
            this.panelRight.Controls.Add(this.lblTotal);
            this.panelRight.Controls.Add(this.lblTableHeader);

            // ── panelBottom ───────────────────────────────────────────────────
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 54;
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(16, 16, 26);
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);

            this.btnStart.Text = "▶  Bắt đầu";
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStart.Width = 130;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(0, 160, 80);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);

            this.btnStop.Text = "■  Dừng";
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.Width = 90;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(180, 40, 40);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.Enabled = false;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);

            this.btnRefresh.Text = "↺  Làm mới";
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Width = 100;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(50, 100, 160);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);

            this.btnExport.Text = "Xuất CSV";
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.Width = 100;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);

            this.btnClear.Text = "Xóa hôm nay";
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Width = 110;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(70, 70, 90);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

            this.lblCameraStatus.Text = "Chưa bắt đầu";
            this.lblCameraStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCameraStatus.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCameraStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblCameraStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblFaceCount.Text = "";
            this.lblFaceCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFaceCount.Width = 200;
            this.lblFaceCount.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblFaceCount.ForeColor = System.Drawing.Color.FromArgb(120, 120, 150);
            this.lblFaceCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFaceCount.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);


            this.btnBack.Text = "← Quay lai";
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Width = 100;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            this.panelBottom.Controls.Add(this.lblCameraStatus);
            this.panelBottom.Controls.Add(this.lblFaceCount);
            this.panelBottom.Controls.Add(this.btnRefresh);
            this.panelBottom.Controls.Add(this.btnStop);
            this.panelBottom.Controls.Add(this.btnStart);
            this.panelBottom.Controls.Add(this.btnClear);
            this.panelBottom.Controls.Add(this.btnExport);
            this.panelBottom.Controls.Add(this.btnBack);

            // ── Form4 ─────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 620);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 18);
            this.Text = "Form4 — Hệ thống Điểm Danh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form4_Load);

            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);

            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}