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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartLoiNhuan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTongLuongKhach = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongChi = new System.Windows.Forms.TextBox();
            this.panelTongSanPham = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongLoiNhuan = new System.Windows.Forms.TextBox();
            this.panelTongDoanhThu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongDT = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoiNhuan)).BeginInit();
            this.panelTongLuongKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelTongSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTongDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartLoiNhuan
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLoiNhuan.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLoiNhuan.Legends.Add(legend2);
            this.chartLoiNhuan.Location = new System.Drawing.Point(32, 122);
            this.chartLoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartLoiNhuan.Name = "chartLoiNhuan";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartLoiNhuan.Series.Add(series2);
            this.chartLoiNhuan.Size = new System.Drawing.Size(1316, 483);
            this.chartLoiNhuan.TabIndex = 1;
            this.chartLoiNhuan.Text = "chart1";
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
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(5, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(495, 38);
            this.label14.TabIndex = 104;
            this.label14.Text = "Tính toán lợi nhuận theo thời gian";
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
            // panelTongLuongKhach
            // 
            this.panelTongLuongKhach.BackColor = System.Drawing.Color.Transparent;
            this.panelTongLuongKhach.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Panel;
            this.panelTongLuongKhach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTongLuongKhach.Controls.Add(this.pictureBox3);
            this.panelTongLuongKhach.Controls.Add(this.label5);
            this.panelTongLuongKhach.Controls.Add(this.txtTongChi);
            this.panelTongLuongKhach.Location = new System.Drawing.Point(378, 633);
            this.panelTongLuongKhach.Name = "panelTongLuongKhach";
            this.panelTongLuongKhach.Size = new System.Drawing.Size(270, 89);
            this.panelTongLuongKhach.TabIndex = 113;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.dollar;
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
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "Tổng chi";
            // 
            // txtTongChi
            // 
            this.txtTongChi.BackColor = System.Drawing.Color.White;
            this.txtTongChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(198)))), ((int)(((byte)(61)))));
            this.txtTongChi.Location = new System.Drawing.Point(72, 42);
            this.txtTongChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongChi.Name = "txtTongChi";
            this.txtTongChi.Size = new System.Drawing.Size(186, 31);
            this.txtTongChi.TabIndex = 106;
            this.txtTongChi.Text = "0";
            // 
            // panelTongSanPham
            // 
            this.panelTongSanPham.BackColor = System.Drawing.Color.Transparent;
            this.panelTongSanPham.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Panel;
            this.panelTongSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTongSanPham.Controls.Add(this.pictureBox2);
            this.panelTongSanPham.Controls.Add(this.label3);
            this.panelTongSanPham.Controls.Add(this.txtTongLoiNhuan);
            this.panelTongSanPham.Location = new System.Drawing.Point(734, 633);
            this.panelTongSanPham.Name = "panelTongSanPham";
            this.panelTongSanPham.Size = new System.Drawing.Size(329, 89);
            this.panelTongSanPham.TabIndex = 112;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.salary;
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
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Tổng lợi nhuận";
            // 
            // txtTongLoiNhuan
            // 
            this.txtTongLoiNhuan.BackColor = System.Drawing.Color.White;
            this.txtTongLoiNhuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongLoiNhuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(83)))));
            this.txtTongLoiNhuan.Location = new System.Drawing.Point(68, 36);
            this.txtTongLoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongLoiNhuan.Name = "txtTongLoiNhuan";
            this.txtTongLoiNhuan.Size = new System.Drawing.Size(186, 31);
            this.txtTongLoiNhuan.TabIndex = 106;
            this.txtTongLoiNhuan.Text = "0";
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // ucLoiNhuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelTongLuongKhach);
            this.Controls.Add(this.panelTongSanPham);
            this.Controls.Add(this.panelTongDoanhThu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.chartLoiNhuan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucLoiNhuan";
            this.Size = new System.Drawing.Size(1351, 799);
            this.Load += new System.EventHandler(this.ucLoiNhuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartLoiNhuan)).EndInit();
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

        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoiNhuan;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.Label label6;
    }
}
