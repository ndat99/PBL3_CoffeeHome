namespace PBL3_CoffeeHome.GUI
{
    partial class ucTaoDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTaoDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBDanhMuc = new System.Windows.Forms.ComboBox();
            this.cBMon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.imageTrangThai = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoBan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLichSuDon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.listDaHoanThanh = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.listDonHienCo = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.dgvChiTietDon = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Món";
            // 
            // cBDanhMuc
            // 
            this.cBDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDanhMuc.FormattingEnabled = true;
            this.cBDanhMuc.Location = new System.Drawing.Point(143, 102);
            this.cBDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBDanhMuc.Name = "cBDanhMuc";
            this.cBDanhMuc.Size = new System.Drawing.Size(195, 28);
            this.cBDanhMuc.TabIndex = 3;
            this.cBDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cBDanhMuc_SelectedIndexChanged);
            // 
            // cBMon
            // 
            this.cBMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMon.FormattingEnabled = true;
            this.cBMon.Location = new System.Drawing.Point(143, 151);
            this.cBMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBMon.Name = "cBMon";
            this.cBMon.Size = new System.Drawing.Size(195, 28);
            this.cBMon.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(444, 151);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 28);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 701);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Giảm giá";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.White;
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(422, 689);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(171, 38);
            this.txtThanhTien.TabIndex = 19;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(509, 102);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(53, 27);
            this.numSoLuong.TabIndex = 20;
            this.numSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 701);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "%";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(113)))), ((int)(((byte)(74)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(562, 151);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 28);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // imageTrangThai
            // 
            this.imageTrangThai.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageTrangThai.ImageStream")));
            this.imageTrangThai.TransparentColor = System.Drawing.Color.Transparent;
            this.imageTrangThai.Images.SetKeyName(0, "ChuaHoanThanh.png");
            this.imageTrangThai.Images.SetKeyName(1, "DaHoanThanh.png");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(617, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Số bàn";
            // 
            // txtSoBan
            // 
            this.txtSoBan.BackColor = System.Drawing.Color.White;
            this.txtSoBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoBan.Location = new System.Drawing.Point(689, 96);
            this.txtSoBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoBan.Name = "txtSoBan";
            this.txtSoBan.Size = new System.Drawing.Size(75, 34);
            this.txtSoBan.TabIndex = 26;
            this.txtSoBan.Text = "0";
            this.txtSoBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(5, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(278, 38);
            this.label14.TabIndex = 102;
            this.label14.Text = "Tạo đơn hàng mới";
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
            this.btnLichSuDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuDon.Image = global::PBL3_CoffeeHome.Properties.Resources.LichSu;
            this.btnLichSuDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLichSuDon.Location = new System.Drawing.Point(1126, 402);
            this.btnLichSuDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichSuDon.Name = "btnLichSuDon";
            this.btnLichSuDon.Size = new System.Drawing.Size(202, 39);
            this.btnLichSuDon.TabIndex = 47;
            this.btnLichSuDon.Text = "Lịch sử đơn hàng";
            this.btnLichSuDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuDon.UseVisualStyleBackColor = false;
            this.btnLichSuDon.Click += new System.EventHandler(this.btnLichSuDon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.btnThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(143)))), ((int)(((byte)(95)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Image = global::PBL3_CoffeeHome.Properties.Resources.In;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.Location = new System.Drawing.Point(615, 677);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(149, 60);
            this.btnThanhToan.TabIndex = 23;
            this.btnThanhToan.Text = "Tạo đơn \n    và \nThanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click_1);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(195, 701);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(58, 22);
            this.txtGiamGia.TabIndex = 103;
            // 
            // listDaHoanThanh
            // 
            this.listDaHoanThanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDaHoanThanh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader8});
            this.listDaHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDaHoanThanh.FullRowSelect = true;
            this.listDaHoanThanh.HideSelection = false;
            this.listDaHoanThanh.Location = new System.Drawing.Point(838, 465);
            this.listDaHoanThanh.Name = "listDaHoanThanh";
            this.listDaHoanThanh.Size = new System.Drawing.Size(456, 276);
            this.listDaHoanThanh.SmallImageList = this.imageTrangThai;
            this.listDaHoanThanh.TabIndex = 128;
            this.listDaHoanThanh.UseCompatibleStateImageBehavior = false;
            this.listDaHoanThanh.View = System.Windows.Forms.View.Details;
            this.listDaHoanThanh.SelectedIndexChanged += new System.EventHandler(this.listDaHoanThanh_SelectedIndexChanged);
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
            this.columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hoàn thành lúc";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(221)))), ((int)(((byte)(148)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(836, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 127;
            this.label4.Text = "Đã hoàn thành";
            // 
            // listDonHienCo
            // 
            this.listDonHienCo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDonHienCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDonHienCo.FullRowSelect = true;
            this.listDonHienCo.HideSelection = false;
            this.listDonHienCo.Location = new System.Drawing.Point(841, 99);
            this.listDonHienCo.Name = "listDonHienCo";
            this.listDonHienCo.Size = new System.Drawing.Size(456, 276);
            this.listDonHienCo.SmallImageList = this.imageTrangThai;
            this.listDonHienCo.TabIndex = 125;
            this.listDonHienCo.UseCompatibleStateImageBehavior = false;
            this.listDonHienCo.View = System.Windows.Forms.View.Details;
            this.listDonHienCo.SelectedIndexChanged += new System.EventHandler(this.listDonHienCo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Frame1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(811, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 295);
            this.panel1.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(221)))), ((int)(((byte)(148)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(839, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 124;
            this.label5.Text = "Đơn hiện có";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PBL3_CoffeeHome.Properties.Resources.tag;
            this.pictureBox4.Location = new System.Drawing.Point(805, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(199, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 130;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Frame1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(808, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 295);
            this.panel3.TabIndex = 129;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PBL3_CoffeeHome.Properties.Resources.tag;
            this.pictureBox5.Location = new System.Drawing.Point(802, 384);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(222, 78);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 131;
            this.pictureBox5.TabStop = false;
            // 
            // dgvChiTietDon
            // 
            this.dgvChiTietDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChiTietDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTietDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(221)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(221)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietDon.EnableHeadersVisualStyles = false;
            this.dgvChiTietDon.Location = new System.Drawing.Point(79, 217);
            this.dgvChiTietDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTietDon.Name = "dgvChiTietDon";
            this.dgvChiTietDon.RowHeadersVisible = false;
            this.dgvChiTietDon.RowHeadersWidth = 51;
            this.dgvChiTietDon.RowTemplate.Height = 24;
            this.dgvChiTietDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDon.Size = new System.Drawing.Size(685, 429);
            this.dgvChiTietDon.TabIndex = 132;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 701);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 133;
            this.label6.Text = "Tổng tiền";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Linen;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(679, 149);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 30);
            this.btnClear.TabIndex = 134;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ucTaoDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvChiTietDon);
            this.Controls.Add(this.listDaHoanThanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listDonHienCo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnLichSuDon);
            this.Controls.Add(this.txtSoBan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBDanhMuc);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.cBMon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucTaoDon";
            this.Size = new System.Drawing.Size(1351, 799);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBDanhMuc;
        private System.Windows.Forms.ComboBox cBMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ImageList imageTrangThai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoBan;
        private System.Windows.Forms.Button btnLichSuDon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.ListView listDaHoanThanh;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listDonHienCo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.DataGridView dgvChiTietDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
    }
}
