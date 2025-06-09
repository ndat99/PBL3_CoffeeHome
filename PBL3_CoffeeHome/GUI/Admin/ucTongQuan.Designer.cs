using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.GUI.Admin
{
    partial class ucTongQuan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn30Days = new System.Windows.Forms.Button();
            this.btn7Days = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.panelTongSanPham = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongSP = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listPhaChe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listThuNgan = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartSanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTongDoanhThu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongDT = new System.Windows.Forms.TextBox();
            this.panelTongLuongKhach = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLichSuDon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelTongSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPham)).BeginInit();
            this.panelTongDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTongLuongKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelThongKe_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnLichSuDon);
            this.panel1.Controls.Add(this.btn30Days);
            this.panel1.Controls.Add(this.btn7Days);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.panelTongSanPham);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelTongDoanhThu);
            this.panel1.Controls.Add(this.panelTongLuongKhach);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.chartDoanhThu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(15, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1716, 851);
            this.panel1.TabIndex = 120;
            // 
            // btn30Days
            // 
            this.btn30Days.BackColor = System.Drawing.Color.White;
            this.btn30Days.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn30Days.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn30Days.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn30Days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn30Days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30Days.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30Days.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn30Days.Location = new System.Drawing.Point(370, 89);
            this.btn30Days.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn30Days.Name = "btn30Days";
            this.btn30Days.Size = new System.Drawing.Size(122, 41);
            this.btn30Days.TabIndex = 167;
            this.btn30Days.Text = "30 ngày";
            this.btn30Days.UseVisualStyleBackColor = false;
            this.btn30Days.Click += new System.EventHandler(this.btn30Days_Click);
            // 
            // btn7Days
            // 
            this.btn7Days.BackColor = System.Drawing.Color.White;
            this.btn7Days.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7Days.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7Days.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn7Days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn7Days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7Days.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7Days.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn7Days.Location = new System.Drawing.Point(205, 89);
            this.btn7Days.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7Days.Name = "btn7Days";
            this.btn7Days.Size = new System.Drawing.Size(122, 41);
            this.btn7Days.TabIndex = 167;
            this.btn7Days.Text = "7 ngày";
            this.btn7Days.UseVisualStyleBackColor = false;
            this.btn7Days.Click += new System.EventHandler(this.btn7Days_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.White;
            this.btnToday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnToday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToday.Location = new System.Drawing.Point(38, 89);
            this.btnToday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(122, 41);
            this.btnToday.TabIndex = 167;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // panelTongSanPham
            // 
            this.panelTongSanPham.BackColor = System.Drawing.Color.Transparent;
            this.panelTongSanPham.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_2;
            this.panelTongSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTongSanPham.Controls.Add(this.pictureBox2);
            this.panelTongSanPham.Controls.Add(this.label3);
            this.panelTongSanPham.Controls.Add(this.txtTongSP);
            this.panelTongSanPham.Location = new System.Drawing.Point(342, 164);
            this.panelTongSanPham.Name = "panelTongSanPham";
            this.panelTongSanPham.Size = new System.Drawing.Size(279, 89);
            this.panelTongSanPham.TabIndex = 118;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.SanPham;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(19, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 105;
            this.label3.Text = "Sản phẩm đã bán";
            // 
            // txtTongSP
            // 
            this.txtTongSP.BackColor = System.Drawing.Color.White;
            this.txtTongSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongSP.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(187)))), ((int)(((byte)(83)))));
            this.txtTongSP.Location = new System.Drawing.Point(79, 43);
            this.txtTongSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongSP.Name = "txtTongSP";
            this.txtTongSP.Size = new System.Drawing.Size(186, 36);
            this.txtTongSP.TabIndex = 106;
            this.txtTongSP.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_2;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.listPhaChe);
            this.panel4.Controls.Add(this.listThuNgan);
            this.panel4.Location = new System.Drawing.Point(1272, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(427, 781);
            this.panel4.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(15, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 38);
            this.label4.TabIndex = 168;
            this.label4.Text = "🧋 Pha chế năng suất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 38);
            this.label2.TabIndex = 167;
            this.label2.Text = "📝 Thu ngân chăm chỉ";
            // 
            // listPhaChe
            // 
            this.listPhaChe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPhaChe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.listPhaChe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPhaChe.FullRowSelect = true;
            this.listPhaChe.HideSelection = false;
            this.listPhaChe.Location = new System.Drawing.Point(17, 453);
            this.listPhaChe.Name = "listPhaChe";
            this.listPhaChe.Size = new System.Drawing.Size(391, 285);
            this.listPhaChe.TabIndex = 126;
            this.listPhaChe.UseCompatibleStateImageBehavior = false;
            this.listPhaChe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên pha chế";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 230;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số đơn";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listThuNgan
            // 
            this.listThuNgan.BackColor = System.Drawing.SystemColors.Window;
            this.listThuNgan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listThuNgan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listThuNgan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listThuNgan.FullRowSelect = true;
            this.listThuNgan.HideSelection = false;
            this.listThuNgan.Location = new System.Drawing.Point(17, 88);
            this.listThuNgan.Name = "listThuNgan";
            this.listThuNgan.Size = new System.Drawing.Size(391, 285);
            this.listThuNgan.TabIndex = 126;
            this.listThuNgan.UseCompatibleStateImageBehavior = false;
            this.listThuNgan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên thu ngân";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số đơn";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.chartSanPham);
            this.panel3.Location = new System.Drawing.Point(854, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 555);
            this.panel3.TabIndex = 109;
            // 
            // chartSanPham
            // 
            chartArea18.Name = "ChartArea1";
            this.chartSanPham.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chartSanPham.Legends.Add(legend18);
            this.chartSanPham.Location = new System.Drawing.Point(39, 32);
            this.chartSanPham.Name = "chartSanPham";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            this.chartSanPham.Series.Add(series18);
            this.chartSanPham.Size = new System.Drawing.Size(348, 487);
            this.chartSanPham.TabIndex = 108;
            this.chartSanPham.Text = "chart1";
            // 
            // panelTongDoanhThu
            // 
            this.panelTongDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.panelTongDoanhThu.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_2;
            this.panelTongDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTongDoanhThu.Controls.Add(this.pictureBox1);
            this.panelTongDoanhThu.Controls.Add(this.label1);
            this.panelTongDoanhThu.Controls.Add(this.txtTongDT);
            this.panelTongDoanhThu.Location = new System.Drawing.Point(29, 164);
            this.panelTongDoanhThu.Name = "panelTongDoanhThu";
            this.panelTongDoanhThu.Size = new System.Drawing.Size(279, 89);
            this.panelTongDoanhThu.TabIndex = 117;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Money;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(19, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 15);
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
            this.txtTongDT.Location = new System.Drawing.Point(74, 43);
            this.txtTongDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongDT.Name = "txtTongDT";
            this.txtTongDT.Size = new System.Drawing.Size(186, 36);
            this.txtTongDT.TabIndex = 106;
            this.txtTongDT.Text = "0";
            // 
            // panelTongLuongKhach
            // 
            this.panelTongLuongKhach.BackColor = System.Drawing.Color.Transparent;
            this.panelTongLuongKhach.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_2;
            this.panelTongLuongKhach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTongLuongKhach.Controls.Add(this.pictureBox3);
            this.panelTongLuongKhach.Controls.Add(this.label5);
            this.panelTongLuongKhach.Controls.Add(this.txtTongKH);
            this.panelTongLuongKhach.Location = new System.Drawing.Point(656, 164);
            this.panelTongLuongKhach.Name = "panelTongLuongKhach";
            this.panelTongLuongKhach.Size = new System.Drawing.Size(279, 89);
            this.panelTongLuongKhach.TabIndex = 119;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.KhachHang;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(19, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 107;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 105;
            this.label5.Text = "Tổng lượng khách";
            // 
            // txtTongKH
            // 
            this.txtTongKH.BackColor = System.Drawing.Color.White;
            this.txtTongKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongKH.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(198)))), ((int)(((byte)(61)))));
            this.txtTongKH.Location = new System.Drawing.Point(79, 43);
            this.txtTongKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongKH.Name = "txtTongKH";
            this.txtTongKH.Size = new System.Drawing.Size(186, 36);
            this.txtTongKH.TabIndex = 106;
            this.txtTongKH.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(22, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 38);
            this.label10.TabIndex = 166;
            this.label10.Text = "🔘Tổng quan";
            // 
            // chartDoanhThu
            // 
            chartArea17.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea17);
            legend17.Alignment = System.Drawing.StringAlignment.Center;
            legend17.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend17.IsTextAutoFit = false;
            legend17.Name = "Legend1";
            legend17.TitleFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartDoanhThu.Legends.Add(legend17);
            this.chartDoanhThu.Location = new System.Drawing.Point(37, 311);
            this.chartDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series17.ChartArea = "ChartArea1";
            series17.Color = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            series17.Legend = "Legend1";
            series17.Name = "Doanh thu";
            this.chartDoanhThu.Series.Add(series17);
            this.chartDoanhThu.Size = new System.Drawing.Size(810, 479);
            this.chartDoanhThu.TabIndex = 1;
            this.chartDoanhThu.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 555);
            this.panel2.TabIndex = 2;
            // 
            // btnLichSuDon
            // 
            this.btnLichSuDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(193)))), ((int)(((byte)(248)))));
            this.btnLichSuDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLichSuDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichSuDon.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLichSuDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLichSuDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.btnLichSuDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuDon.Image = global::PBL3_CoffeeHome.Properties.Resources.LichSu;
            this.btnLichSuDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLichSuDon.Location = new System.Drawing.Point(1050, 211);
            this.btnLichSuDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichSuDon.Name = "btnLichSuDon";
            this.btnLichSuDon.Size = new System.Drawing.Size(216, 39);
            this.btnLichSuDon.TabIndex = 168;
            this.btnLichSuDon.Text = "Lịch sử đơn hàng";
            this.btnLichSuDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuDon.UseVisualStyleBackColor = false;
            this.btnLichSuDon.Click += new System.EventHandler(this.btnLichSuDon_Click);
            // 
            // ucTongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.Name = "ucTongQuan";
            this.Size = new System.Drawing.Size(1783, 962);
            this.Load += new System.EventHandler(this.ucTongQuan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTongSanPham.ResumeLayout(false);
            this.panelTongSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPham)).EndInit();
            this.panelTongDoanhThu.ResumeLayout(false);
            this.panelTongDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTongLuongKhach.ResumeLayout(false);
            this.panelTongLuongKhach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSanPham;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongDT;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongSP;
        private System.Windows.Forms.Panel panelTongSanPham;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongKH;
        private System.Windows.Forms.Panel panelTongLuongKhach;
        private System.Windows.Forms.Panel panelTongDoanhThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btn30Days;
        private System.Windows.Forms.Button btn7Days;
        private System.Windows.Forms.ListView listThuNgan;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listPhaChe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;

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

        private Button btnLichSuDon;
    }
}
