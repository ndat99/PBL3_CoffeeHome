namespace PBL3_CoffeeHome.GUI
{
    partial class ucThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartSanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.cbThongKeTheo = new System.Windows.Forms.ComboBox();
            this.panelTongLuongKhach = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongKH = new System.Windows.Forms.TextBox();
            this.panelTongSanPham = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongSP = new System.Windows.Forms.TextBox();
            this.panelTongDoanhThu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongDT = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPham)).BeginInit();
            this.panelTongLuongKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelTongSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTongDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(32, 126);
            this.chartDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(836, 483);
            this.chartDoanhThu.TabIndex = 1;
            this.chartDoanhThu.Text = "chart1";
            // 
            // cbThang
            // 
            this.cbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(577, 65);
            this.cbThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(112, 28);
            this.cbThang.TabIndex = 99;
            // 
            // cbNam
            // 
            this.cbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(365, 65);
            this.cbNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(112, 28);
            this.cbNam.TabIndex = 101;
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.cbNam_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 102;
            this.label9.Text = "Thống kê theo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 103;
            this.label4.Text = "Tháng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(5, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(370, 38);
            this.label14.TabIndex = 104;
            this.label14.Text = "Doanh thu theo thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(950, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 25);
            this.label2.TabIndex = 107;
            this.label2.Text = "Các sản phẩm bán chạy nhất:";
            // 
            // chartSanPham
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSanPham.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSanPham.Legends.Add(legend2);
            this.chartSanPham.Location = new System.Drawing.Point(874, 126);
            this.chartSanPham.Name = "chartSanPham";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSanPham.Series.Add(series2);
            this.chartSanPham.Size = new System.Drawing.Size(428, 483);
            this.chartSanPham.TabIndex = 108;
            this.chartSanPham.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 115;
            this.label6.Text = "Năm";
            // 
            // cbThongKeTheo
            // 
            this.cbThongKeTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThongKeTheo.FormattingEnabled = true;
            this.cbThongKeTheo.Location = new System.Drawing.Point(169, 65);
            this.cbThongKeTheo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbThongKeTheo.Name = "cbThongKeTheo";
            this.cbThongKeTheo.Size = new System.Drawing.Size(112, 28);
            this.cbThongKeTheo.TabIndex = 114;
            this.cbThongKeTheo.SelectedIndexChanged += new System.EventHandler(this.cbThongKeTheo_SelectedIndexChanged);
            // 
            // panelTongLuongKhach
            // 
            this.panelTongLuongKhach.BackColor = System.Drawing.Color.Transparent;
            this.panelTongLuongKhach.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Panel;
            this.panelTongLuongKhach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTongLuongKhach.Controls.Add(this.pictureBox3);
            this.panelTongLuongKhach.Controls.Add(this.label5);
            this.panelTongLuongKhach.Controls.Add(this.txtTongKH);
            this.panelTongLuongKhach.Location = new System.Drawing.Point(689, 633);
            this.panelTongLuongKhach.Name = "panelTongLuongKhach";
            this.panelTongLuongKhach.Size = new System.Drawing.Size(270, 89);
            this.panelTongLuongKhach.TabIndex = 113;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.KhachHang;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(12, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 107;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "Tổng lượng khách";
            // 
            // txtTongKH
            // 
            this.txtTongKH.BackColor = System.Drawing.Color.White;
            this.txtTongKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(198)))), ((int)(((byte)(61)))));
            this.txtTongKH.Location = new System.Drawing.Point(72, 42);
            this.txtTongKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongKH.Name = "txtTongKH";
            this.txtTongKH.Size = new System.Drawing.Size(186, 31);
            this.txtTongKH.TabIndex = 106;
            this.txtTongKH.Text = "0";
            // 
            // panelTongSanPham
            // 
            this.panelTongSanPham.BackColor = System.Drawing.Color.Transparent;
            this.panelTongSanPham.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Panel;
            this.panelTongSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTongSanPham.Controls.Add(this.pictureBox2);
            this.panelTongSanPham.Controls.Add(this.label3);
            this.panelTongSanPham.Controls.Add(this.txtTongSP);
            this.panelTongSanPham.Location = new System.Drawing.Point(361, 633);
            this.panelTongSanPham.Name = "panelTongSanPham";
            this.panelTongSanPham.Size = new System.Drawing.Size(270, 89);
            this.panelTongSanPham.TabIndex = 112;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.SanPham;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Sản phẩm đã bán";
            // 
            // txtTongSP
            // 
            this.txtTongSP.BackColor = System.Drawing.Color.White;
            this.txtTongSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(83)))));
            this.txtTongSP.Location = new System.Drawing.Point(72, 42);
            this.txtTongSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongSP.Name = "txtTongSP";
            this.txtTongSP.Size = new System.Drawing.Size(186, 31);
            this.txtTongSP.TabIndex = 106;
            this.txtTongSP.Text = "0";
            // 
            // panelTongDoanhThu
            // 
            this.panelTongDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.panelTongDoanhThu.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Panel;
            this.panelTongDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTongDoanhThu.Controls.Add(this.pictureBox1);
            this.panelTongDoanhThu.Controls.Add(this.label1);
            this.panelTongDoanhThu.Controls.Add(this.txtTongDT);
            this.panelTongDoanhThu.Location = new System.Drawing.Point(32, 633);
            this.panelTongDoanhThu.Name = "panelTongDoanhThu";
            this.panelTongDoanhThu.Size = new System.Drawing.Size(270, 89);
            this.panelTongDoanhThu.TabIndex = 111;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Money;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 105;
            this.label1.Text = "Tổng doanh thu";
            // 
            // txtTongDT
            // 
            this.txtTongDT.BackColor = System.Drawing.Color.White;
            this.txtTongDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDT.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtTongDT.Location = new System.Drawing.Point(67, 42);
            this.txtTongDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongDT.Name = "txtTongDT";
            this.txtTongDT.Size = new System.Drawing.Size(186, 31);
            this.txtTongDT.TabIndex = 106;
            this.txtTongDT.Text = "0";
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
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = global::PBL3_CoffeeHome.Properties.Resources.Filter;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.Location = new System.Drawing.Point(734, 63);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(95, 32);
            this.btnLoc.TabIndex = 52;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // ucThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbThongKeTheo);
            this.Controls.Add(this.panelTongLuongKhach);
            this.Controls.Add(this.panelTongSanPham);
            this.Controls.Add(this.panelTongDoanhThu);
            this.Controls.Add(this.chartSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.chartDoanhThu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(1351, 799);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPham)).EndInit();
            this.panelTongLuongKhach.ResumeLayout(false);
            this.panelTongLuongKhach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelTongSanPham.ResumeLayout(false);
            this.panelTongSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTongDoanhThu.ResumeLayout(false);
            this.panelTongDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTongDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSanPham;
        private System.Windows.Forms.Panel panelTongDoanhThu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTongSanPham;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongSP;
        private System.Windows.Forms.Panel panelTongLuongKhach;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbThongKeTheo;
    }
}
