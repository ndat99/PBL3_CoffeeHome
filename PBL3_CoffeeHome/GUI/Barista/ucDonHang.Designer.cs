using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.GUI
{
    partial class ucDonHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDonHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageTrangThai = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.btnChuyenTrangThai = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listLichSuDon = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listDonHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCongThuc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvChiTietDon = new System.Windows.Forms.DataGridView();
            this.cTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThuc)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageTrangThai
            // 
            this.imageTrangThai.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageTrangThai.ImageStream")));
            this.imageTrangThai.TransparentColor = System.Drawing.Color.Transparent;
            this.imageTrangThai.Images.SetKeyName(0, "ChuaHoanThanh.png");
            this.imageTrangThai.Images.SetKeyName(1, "DaHoanThanh.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Đã hoàn thành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Chưa hoàn thành";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(5, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 45);
            this.label14.TabIndex = 103;
            this.label14.Text = "Đơn hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(794, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 38);
            this.label6.TabIndex = 113;
            this.label6.Text = "---------------------";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 30000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // btnChuyenTrangThai
            // 
            this.btnChuyenTrangThai.BackColor = System.Drawing.Color.White;
            this.btnChuyenTrangThai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChuyenTrangThai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnChuyenTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenTrangThai.Location = new System.Drawing.Point(617, 440);
            this.btnChuyenTrangThai.Name = "btnChuyenTrangThai";
            this.btnChuyenTrangThai.Size = new System.Drawing.Size(202, 36);
            this.btnChuyenTrangThai.TabIndex = 123;
            this.btnChuyenTrangThai.Text = "Chuyển trạng thái";
            this.btnChuyenTrangThai.UseVisualStyleBackColor = false;
            this.btnChuyenTrangThai.Click += new System.EventHandler(this.btnChuyenTrangThai_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.ChuaHoanThanh;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(242, 461);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.DaHoanThanh;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(242, 428);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelDonHang_1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.listLichSuDon);
            this.panel3.Controls.Add(this.datePicker);
            this.panel3.Location = new System.Drawing.Point(226, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 391);
            this.panel3.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(210, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 38);
            this.label3.TabIndex = 113;
            this.label3.Text = "Lịch sử đơn";
            // 
            // listLichSuDon
            // 
            this.listLichSuDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLichSuDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader8});
            this.listLichSuDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLichSuDon.FullRowSelect = true;
            this.listLichSuDon.HideSelection = false;
            this.listLichSuDon.Location = new System.Drawing.Point(31, 93);
            this.listLichSuDon.Name = "listLichSuDon";
            this.listLichSuDon.Size = new System.Drawing.Size(540, 276);
            this.listLichSuDon.SmallImageList = this.imageTrangThai;
            this.listLichSuDon.TabIndex = 110;
            this.listLichSuDon.UseCompatibleStateImageBehavior = false;
            this.listLichSuDon.View = System.Windows.Forms.View.Details;
            this.listLichSuDon.SelectedIndexChanged += new System.EventHandler(this.listLichSuDon_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng thái";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 85;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã đơn";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 175;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hoàn thành lúc";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 125;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(425, 25);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(146, 30);
            this.datePicker.TabIndex = 112;
            this.datePicker.Value = new System.DateTime(2025, 5, 14, 0, 0, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelDonHang_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listDonHang);
            this.panel1.Location = new System.Drawing.Point(226, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 391);
            this.panel1.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 38);
            this.label1.TabIndex = 110;
            this.label1.Text = "Đơn hiện có";
            // 
            // listDonHang
            // 
            this.listDonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDonHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listDonHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDonHang.FullRowSelect = true;
            this.listDonHang.HideSelection = false;
            this.listDonHang.Location = new System.Drawing.Point(31, 96);
            this.listDonHang.Name = "listDonHang";
            this.listDonHang.Size = new System.Drawing.Size(540, 276);
            this.listDonHang.SmallImageList = this.imageTrangThai;
            this.listDonHang.TabIndex = 27;
            this.listDonHang.UseCompatibleStateImageBehavior = false;
            this.listDonHang.View = System.Windows.Forms.View.Details;
            this.listDonHang.SelectedIndexChanged += new System.EventHandler(this.listDonHang_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Trạng thái";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã đơn";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giờ nhận";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 125;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelTaoDon_1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dgvCongThuc);
            this.panel4.Location = new System.Drawing.Point(983, 494);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(529, 383);
            this.panel4.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 167;
            this.label2.Text = "📋 Công thức";
            // 
            // dgvCongThuc
            // 
            this.dgvCongThuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvCongThuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCongThuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCongThuc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCongThuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCongThuc.ColumnHeadersHeight = 30;
            this.dgvCongThuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.cDonVi});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCongThuc.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCongThuc.EnableHeadersVisualStyles = false;
            this.dgvCongThuc.Location = new System.Drawing.Point(0, 74);
            this.dgvCongThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCongThuc.Name = "dgvCongThuc";
            this.dgvCongThuc.ReadOnly = true;
            this.dgvCongThuc.RowHeadersVisible = false;
            this.dgvCongThuc.RowHeadersWidth = 51;
            this.dgvCongThuc.RowTemplate.Height = 30;
            this.dgvCongThuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCongThuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongThuc.Size = new System.Drawing.Size(529, 295);
            this.dgvCongThuc.TabIndex = 122;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 111.9593F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên nguyên liệu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 220;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 88.04071F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // cDonVi
            // 
            this.cDonVi.HeaderText = "Đơn vị";
            this.cDonVi.MinimumWidth = 6;
            this.cDonVi.Name = "cDonVi";
            this.cDonVi.ReadOnly = true;
            this.cDonVi.Width = 90;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelTaoDon_1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dgvChiTietDon);
            this.panel2.Location = new System.Drawing.Point(983, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 391);
            this.panel2.TabIndex = 124;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(57, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 31);
            this.label10.TabIndex = 166;
            this.label10.Text = "Chi tiết đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(23, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 45);
            this.label7.TabIndex = 167;
            this.label7.Text = "≡";
            // 
            // dgvChiTietDon
            // 
            this.dgvChiTietDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTietDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvChiTietDon.ColumnHeadersHeight = 30;
            this.dgvChiTietDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTenMon,
            this.cSoLuong});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietDon.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvChiTietDon.EnableHeadersVisualStyles = false;
            this.dgvChiTietDon.Location = new System.Drawing.Point(0, 77);
            this.dgvChiTietDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTietDon.Name = "dgvChiTietDon";
            this.dgvChiTietDon.ReadOnly = true;
            this.dgvChiTietDon.RowHeadersVisible = false;
            this.dgvChiTietDon.RowHeadersWidth = 51;
            this.dgvChiTietDon.RowTemplate.Height = 30;
            this.dgvChiTietDon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChiTietDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDon.Size = new System.Drawing.Size(529, 295);
            this.dgvChiTietDon.TabIndex = 64;
            this.dgvChiTietDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietDon_CellClick);
            // 
            // cTenMon
            // 
            this.cTenMon.FillWeight = 111.9593F;
            this.cTenMon.HeaderText = "Tên món";
            this.cTenMon.MinimumWidth = 6;
            this.cTenMon.Name = "cTenMon";
            this.cTenMon.ReadOnly = true;
            this.cTenMon.Width = 300;
            // 
            // cSoLuong
            // 
            this.cSoLuong.FillWeight = 88.04071F;
            this.cSoLuong.HeaderText = "Số lượng";
            this.cSoLuong.MinimumWidth = 6;
            this.cSoLuong.Name = "cSoLuong";
            this.cSoLuong.ReadOnly = true;
            this.cSoLuong.Width = 125;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL3_CoffeeHome.Properties.Resources.line;
            this.pictureBox2.Location = new System.Drawing.Point(1233, 346);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 213);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 116;
            this.pictureBox2.TabStop = false;
            // 
            // ucDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnChuyenTrangThai);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ucDonHang";
            this.Size = new System.Drawing.Size(1671, 1000);
            this.Load += new System.EventHandler(this.ucDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThuc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageTrangThai;
        private System.Windows.Forms.ListView listDonHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataGridView dgvChiTietDon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listLichSuDon;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvCongThuc;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Button btnChuyenTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;

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

        private DataGridViewTextBoxColumn cTenMon;
        private DataGridViewTextBoxColumn cSoLuong;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn cDonVi;
        private Label label10;
        private Label label2;
        private Label label7;
    }
}
