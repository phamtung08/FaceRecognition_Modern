using System.Drawing.Drawing2D;
using System.IO.Pipelines;

namespace FaceRecognition_Modern
{
    public partial class FormChart : Form
    {
        public FormChart()
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

        private void FormChart_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Dang nhap: {UserSession.Username} ({UserSession.Role})";
            LoadCharts();
        }

        private void LoadCharts()
        {
            // Lấy dữ liệu
            var weekData = DatabaseHelper.GetAttendanceByWeek();
            int totalReg = DatabaseHelper.GetTotalRegistered();
            int todayPresent = DatabaseHelper.GetTodayAttendanceCount();
            int todayAbsent = totalReg - todayPresent;
            if (todayAbsent < 0) todayAbsent = 0;

            // Cập nhật stats
            lblTotalReg.Text = $"Tong da dang ky: {totalReg} nguoi";
            lblTodayPresent.Text = $"Co mat hom nay: {todayPresent} nguoi";
            lblTodayAbsent.Text = $"Vang hom nay:   {todayAbsent} nguoi";

            // Vẽ biểu đồ cột
            DrawBarChart(weekData);

            // Vẽ biểu đồ tròn
            DrawPieChart(todayPresent, todayAbsent);
        }

        // ── Biểu đồ cột — số người điểm danh theo ngày ───────────────────────
        private void DrawBarChart(List<(DateTime Date, int Count)> data)
        {
            int w = picBar.Width;
            int h = picBar.Height;
            var bmp = new Bitmap(w, h);

            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.Clear(System.Drawing.Color.FromArgb(16, 16, 26));

            if (data.Count == 0)
            {
                using var noDataFont = new Font("Segoe UI", 10f);
                using var noDataBrush = new SolidBrush(System.Drawing.Color.FromArgb(100, 100, 130));
                g.DrawString("Chua co du lieu", noDataFont, noDataBrush,
                    new PointF(w / 2f - 60, h / 2f - 10));
                picBar.Image = bmp;
                return;
            }

            int maxCount = data.Max(d => d.Count);
            if (maxCount == 0) maxCount = 1;
            int padding = 50;
            int chartW = w - padding * 2;
            int chartH = h - padding * 2 - 20;
            int barWidth = Math.Max(20, chartW / (data.Count * 2));
            int gap = barWidth;

            // Vẽ trục
            using var axisPen = new Pen(System.Drawing.Color.FromArgb(60, 60, 80), 1);
            using var axisFont = new Font("Segoe UI", 8f);
            using var axisBr = new SolidBrush(System.Drawing.Color.FromArgb(120, 120, 150));

            g.DrawLine(axisPen, padding, padding, padding, padding + chartH);
            g.DrawLine(axisPen, padding, padding + chartH, w - padding, padding + chartH);

            // Vẽ đường lưới ngang
            for (int i = 1; i <= 4; i++)
            {
                int y = padding + chartH - (chartH * i / 4);
                g.DrawLine(axisPen, padding, y, w - padding, y);
                int val = maxCount * i / 4;
                g.DrawString(val.ToString(), axisFont, axisBr,
                    new PointF(4, y - 8));
            }

            // Vẽ các cột
            for (int i = 0; i < data.Count; i++)
            {
                int barH = (int)((double)data[i].Count / maxCount * chartH);
                int x = padding + gap / 2 + i * (barWidth + gap);
                int y = padding + chartH - barH;

                // Cột gradient
                using var barBrush = new SolidBrush(System.Drawing.Color.FromArgb(0, 180, 100));
                g.FillRectangle(barBrush, x, y, barWidth, barH);

                // Viền trên cột
                using var topPen = new Pen(System.Drawing.Color.FromArgb(0, 230, 118), 2);
                g.DrawLine(topPen, x, y, x + barWidth, y);

                // Số trên cột
                using var countBrush = new SolidBrush(System.Drawing.Color.White);
                using var countFont = new Font("Segoe UI", 8f, FontStyle.Bold);
                string countStr = data[i].Count.ToString();
                g.DrawString(countStr, countFont, countBrush,
                    new PointF(x + barWidth / 2f - 6, y - 18));

                // Nhãn ngày dưới
                string dateStr = data[i].Date.ToString("dd/MM");
                g.DrawString(dateStr, axisFont, axisBr,
                    new PointF(x + barWidth / 2f - 14, padding + chartH + 6));
            }

            // Tiêu đề
            using var titleFont = new Font("Segoe UI", 10f, FontStyle.Bold);
            using var titleBrush = new SolidBrush(System.Drawing.Color.FromArgb(0, 230, 118));
            g.DrawString("So nguoi diem danh 7 ngay gan nhat",
                titleFont, titleBrush, new PointF(padding, 8));

            picBar.Image = bmp;
        }

        // ── Biểu đồ tròn — tỷ lệ có mặt / vắng ─────────────────────────────
        private void DrawPieChart(int present, int absent)
        {
            int w = picPie.Width;
            int h = picPie.Height;
            var bmp = new Bitmap(w, h);

            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(System.Drawing.Color.FromArgb(16, 16, 26));

            int total = present + absent;
            if (total == 0)
            {
                using var noDataFont = new Font("Segoe UI", 10f);
                using var noDataBrush = new SolidBrush(System.Drawing.Color.FromArgb(100, 100, 130));
                g.DrawString("Chua co du lieu", noDataFont, noDataBrush,
                    new PointF(w / 2f - 60, h / 2f - 10));
                picPie.Image = bmp;
                return;
            }

            int cx = w / 2 - 20;
            int cy = h / 2 + 10;
            int radius = Math.Min(w, h) / 2 - 40;
            var pieRect = new Rectangle(cx - radius, cy - radius, radius * 2, radius * 2);

            float presentPct = (float)present / total * 100f;
            float absentPct = 100f - presentPct;
            float startAngle = -90f;
            float sweepPresent = 360f * present / total;
            float sweepAbsent = 360f - sweepPresent;

            // Vẽ phần có mặt
            using var presentBrush = new SolidBrush(System.Drawing.Color.FromArgb(0, 200, 100));
            g.FillPie(presentBrush, pieRect, startAngle, sweepPresent);

            // Vẽ phần vắng
            using var absentBrush = new SolidBrush(System.Drawing.Color.FromArgb(220, 60, 60));
            g.FillPie(absentBrush, pieRect, startAngle + sweepPresent, sweepAbsent);

            // Viền
            using var borderPen = new Pen(System.Drawing.Color.FromArgb(16, 16, 26), 2);
            g.DrawEllipse(borderPen, pieRect);

            // Legend
            using var legendFont = new Font("Segoe UI", 9f);
            using var whiteBrush = new SolidBrush(System.Drawing.Color.White);
            using var greenBrush = new SolidBrush(System.Drawing.Color.FromArgb(0, 200, 100));
            using var redBrush = new SolidBrush(System.Drawing.Color.FromArgb(220, 60, 60));
            using var legendFont2 = new Font("Segoe UI", 9f, FontStyle.Bold);

            int lx = w - 130;
            g.FillRectangle(greenBrush, lx, 60, 14, 14);
            g.DrawString($"Co mat: {presentPct:F1}%", legendFont, whiteBrush,
                new PointF(lx + 20, 58));

            g.FillRectangle(redBrush, lx, 84, 14, 14);
            g.DrawString($"Vang: {absentPct:F1}%", legendFont, whiteBrush,
                new PointF(lx + 20, 82));

            // Số giữa
            g.DrawString($"{present}/{total}", legendFont2, whiteBrush,
                new PointF(cx - 18, cy - 10));

            // Tiêu đề
            using var titleFont = new Font("Segoe UI", 10f, FontStyle.Bold);
            using var titleBrush = new SolidBrush(System.Drawing.Color.FromArgb(0, 230, 118));
            g.DrawString("Ti le co mat hom nay", titleFont, titleBrush,
                new PointF(10, 8));

            picPie.Image = bmp;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadCharts();
        }
    }
}