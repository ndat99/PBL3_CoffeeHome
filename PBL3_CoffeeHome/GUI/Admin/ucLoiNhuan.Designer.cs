using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.GUI
{
    partial class ucLoiNhuan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLoiNhuan));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.panelTongSanPham = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongLoiNhuan = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.panelTongLuongKhach = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongChi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTongDoanhThu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongDT = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartLoiNhuan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panelTongSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTongLuongKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelTongDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoiNhuan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelThongKe_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cbNam);
            this.panel1.Controls.Add(this.panelTongSanPham);
            this.panel1.Controls.Add(this.btnLoc);
            this.panel1.Controls.Add(this.panelTongLuongKhach);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panelTongDoanhThu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(17, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1716, 851);
            this.panel1.TabIndex = 116;
            // 
            // cbNam
            // 
            this.cbNam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(1025, 57);
            this.cbNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(112, 31);
            this.cbNam.TabIndex = 101;
            // 
            // panelTongSanPham
            // 
            this.panelTongSanPham.BackColor = System.Drawing.Color.Transparent;
            this.panelTongSanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTongSanPham.BackgroundImage")));
            this.panelTongSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTongSanPham.Controls.Add(this.pictureBox2);
            this.panelTongSanPham.Controls.Add(this.label3);
            this.panelTongSanPham.Controls.Add(this.txtTongLoiNhuan);
            this.panelTongSanPham.Location = new System.Drawing.Point(1355, 407);
            this.panelTongSanPham.Name = "panelTongSanPham";
            this.panelTongSanPham.Size = new System.Drawing.Size(290, 89);
            this.panelTongSanPham.TabIndex = 112;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Money_Green;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(18, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 105;
            this.label3.Text = "Tổng lợi nhuận";
            // 
            // txtTongLoiNhuan
            // 
            this.txtTongLoiNhuan.BackColor = System.Drawing.Color.White;
            this.txtTongLoiNhuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongLoiNhuan.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongLoiNhuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(83)))));
            this.txtTongLoiNhuan.Location = new System.Drawing.Point(74, 36);
            this.txtTongLoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongLoiNhuan.Name = "txtTongLoiNhuan";
            this.txtTongLoiNhuan.Size = new System.Drawing.Size(186, 36);
            this.txtTongLoiNhuan.TabIndex = 106;
            this.txtTongLoiNhuan.Text = "0";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = global::PBL3_CoffeeHome.Properties.Resources.Filter;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.Location = new System.Drawing.Point(1194, 57);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(95, 32);
            this.btnLoc.TabIndex = 52;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // panelTongLuongKhach
            // 
            this.panelTongLuongKhach.BackColor = System.Drawing.Color.Transparent;
            this.panelTongLuongKhach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTongLuongKhach.BackgroundImage")));
            this.panelTongLuongKhach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTongLuongKhach.Controls.Add(this.pictureBox3);
            this.panelTongLuongKhach.Controls.Add(this.label5);
            this.panelTongLuongKhach.Controls.Add(this.txtTongChi);
            this.panelTongLuongKhach.Location = new System.Drawing.Point(1355, 275);
            this.panelTongLuongKhach.Name = "panelTongLuongKhach";
            this.panelTongLuongKhach.Size = new System.Drawing.Size(290, 89);
            this.panelTongLuongKhach.TabIndex = 113;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Money_Red;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(18, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 107;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 105;
            this.label5.Text = "Tổng chi";
            // 
            // txtTongChi
            // 
            this.txtTongChi.BackColor = System.Drawing.Color.White;
            this.txtTongChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongChi.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongChi.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtTongChi.Location = new System.Drawing.Point(78, 42);
            this.txtTongChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongChi.Name = "txtTongChi";
            this.txtTongChi.Size = new System.Drawing.Size(186, 36);
            this.txtTongChi.TabIndex = 106;
            this.txtTongChi.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(22, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(399, 38);
            this.label10.TabIndex = 167;
            this.label10.Text = "💰 Doanh thu theo thời gian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1021, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 116;
            this.label6.Text = "Năm";
            // 
            // panelTongDoanhThu
            // 
            this.panelTongDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.panelTongDoanhThu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTongDoanhThu.BackgroundImage")));
            this.panelTongDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTongDoanhThu.Controls.Add(this.pictureBox1);
            this.panelTongDoanhThu.Controls.Add(this.label1);
            this.panelTongDoanhThu.Controls.Add(this.txtTongDT);
            this.panelTongDoanhThu.Location = new System.Drawing.Point(1355, 144);
            this.panelTongDoanhThu.Name = "panelTongDoanhThu";
            this.panelTongDoanhThu.Size = new System.Drawing.Size(290, 89);
            this.panelTongDoanhThu.TabIndex = 111;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Money;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 105;
            this.label1.Text = "Tổng doanh thu";
            // 
            // txtTongDT
            // 
            this.txtTongDT.BackColor = System.Drawing.Color.White;
            this.txtTongDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongDT.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDT.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtTongDT.Location = new System.Drawing.Point(73, 42);
            this.txtTongDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongDT.Name = "txtTongDT";
            this.txtTongDT.Size = new System.Drawing.Size(186, 36);
            this.txtTongDT.TabIndex = 106;
            this.txtTongDT.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.chartLoiNhuan);
            this.panel2.Location = new System.Drawing.Point(3, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1337, 693);
            this.panel2.TabIndex = 168;
            // 
            // chartLoiNhuan
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLoiNhuan.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLoiNhuan.Legends.Add(legend1);
            this.chartLoiNhuan.Location = new System.Drawing.Point(52, 36);
            this.chartLoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartLoiNhuan.Name = "chartLoiNhuan";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLoiNhuan.Series.Add(series1);
            this.chartLoiNhuan.Size = new System.Drawing.Size(1217, 610);
            this.chartLoiNhuan.TabIndex = 1;
            this.chartLoiNhuan.Text = "chart1";
            // 
            // ucLoiNhuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucLoiNhuan";
            this.Size = new System.Drawing.Size(1753, 949);
            this.Load += new System.EventHandler(this.ucLoiNhuan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTongSanPham.ResumeLayout(false);
            this.panelTongSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTongLuongKhach.ResumeLayout(false);
            this.panelTongLuongKhach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelTongDoanhThu.ResumeLayout(false);
            this.panelTongDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLoiNhuan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoiNhuan;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.TextBox txtTongDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTongDoanhThu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTongSanPham;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongLoiNhuan;
        private System.Windows.Forms.Panel panelTongLuongKhach;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongChi;
        private System.Windows.Forms.Panel panel1;
        private void MakeButtonRounded(Button btn, int radius, Color borderColor)
        {
            Rectangle rect = btn.ClientRectangle;
            GraphicsPath path = CreateRoundedPath(rect, radius);
            btn.Region = new Region(path);

            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(borderColor, 3f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }
        private GraphicsPath CreateRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private Label label6;
        private Label label10;
        private Panel panel2;
    }
}
