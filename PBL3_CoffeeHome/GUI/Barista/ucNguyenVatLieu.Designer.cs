namespace PBL3_CoffeeHome.GUI.Barista
{
    partial class ucNguyenVatLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNameNL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDSNLbyDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvStockOut = new System.Windows.Forms.DataGridView();
            this.cTenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSLHeThong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQuantityThucTe = new System.Windows.Forms.NumericUpDown();
            this.dgvListKiemKe = new System.Windows.Forms.DataGridView();
            this.cTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSLHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSLTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNguoiKiemKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChenhLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.txtQuantityNL = new System.Windows.Forms.TextBox();
            this.btnThucHienKiemKe = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityThucTe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKiemKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNameNL
            // 
            this.txtNameNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameNL.Location = new System.Drawing.Point(165, 56);
            this.txtNameNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameNL.Multiline = true;
            this.txtNameNL.Name = "txtNameNL";
            this.txtNameNL.Size = new System.Drawing.Size(195, 32);
            this.txtNameNL.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 139;
            this.label3.Text = "Tên nguyên liệu:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.dtpDSNLbyDate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 128);
            this.panel1.TabIndex = 145;
            // 
            // dtpDSNLbyDate
            // 
            this.dtpDSNLbyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDSNLbyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDSNLbyDate.Location = new System.Drawing.Point(178, 66);
            this.dtpDSNLbyDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDSNLbyDate.Name = "dtpDSNLbyDate";
            this.dtpDSNLbyDate.Size = new System.Drawing.Size(136, 27);
            this.dtpDSNLbyDate.TabIndex = 140;
            this.dtpDSNLbyDate.ValueChanged += new System.EventHandler(this.dtpDSNLbyDate_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(430, 20);
            this.label10.TabIndex = 122;
            this.label10.Text = "DANH SÁCH NGUYÊN LIỆU SỬ DỤNG HÔM NAY";
            // 
            // dgvStockOut
            // 
            this.dgvStockOut.AllowUserToAddRows = false;
            this.dgvStockOut.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStockOut.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStockOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTenNguyenLieu,
            this.cSLHeThong,
            this.cDonVi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockOut.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockOut.EnableHeadersVisualStyles = false;
            this.dgvStockOut.Location = new System.Drawing.Point(0, 201);
            this.dgvStockOut.Margin = new System.Windows.Forms.Padding(7, 0, 10, 0);
            this.dgvStockOut.Name = "dgvStockOut";
            this.dgvStockOut.RowHeadersVisible = false;
            this.dgvStockOut.RowHeadersWidth = 51;
            this.dgvStockOut.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvStockOut.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dgvStockOut.RowTemplate.Height = 44;
            this.dgvStockOut.RowTemplate.ReadOnly = true;
            this.dgvStockOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStockOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockOut.Size = new System.Drawing.Size(507, 645);
            this.dgvStockOut.TabIndex = 147;
            // 
            // cTenNguyenLieu
            // 
            this.cTenNguyenLieu.FillWeight = 280.7487F;
            this.cTenNguyenLieu.HeaderText = "Tên nguyên liệu";
            this.cTenNguyenLieu.MinimumWidth = 6;
            this.cTenNguyenLieu.Name = "cTenNguyenLieu";
            this.cTenNguyenLieu.Width = 200;
            // 
            // cSLHeThong
            // 
            this.cSLHeThong.FillWeight = 8.565047F;
            this.cSLHeThong.HeaderText = "SL hệ thống";
            this.cSLHeThong.MinimumWidth = 6;
            this.cSLHeThong.Name = "cSLHeThong";
            this.cSLHeThong.Width = 125;
            // 
            // cDonVi
            // 
            this.cDonVi.FillWeight = 10.6863F;
            this.cDonVi.HeaderText = "Đơn vị";
            this.cDonVi.MinimumWidth = 6;
            this.cDonVi.Name = "cDonVi";
            this.cDonVi.Width = 80;
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.BackColor = System.Drawing.Color.White;
            this.btnHoanTac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoanTac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnHoanTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnHoanTac.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoanTac.Location = new System.Drawing.Point(1389, 142);
            this.btnHoanTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(141, 44);
            this.btnHoanTac.TabIndex = 149;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = false;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Location = new System.Drawing.Point(904, 33);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(298, 71);
            this.txtGhiChu.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(831, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 136;
            this.label1.Text = "Ghi chú: ";
            // 
            // nudQuantityThucTe
            // 
            this.nudQuantityThucTe.DecimalPlaces = 2;
            this.nudQuantityThucTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantityThucTe.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudQuantityThucTe.Location = new System.Drawing.Point(584, 84);
            this.nudQuantityThucTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQuantityThucTe.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudQuantityThucTe.Name = "nudQuantityThucTe";
            this.nudQuantityThucTe.Size = new System.Drawing.Size(161, 24);
            this.nudQuantityThucTe.TabIndex = 135;
            this.nudQuantityThucTe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvListKiemKe
            // 
            this.dgvListKiemKe.AllowUserToAddRows = false;
            this.dgvListKiemKe.BackgroundColor = System.Drawing.Color.White;
            this.dgvListKiemKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListKiemKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListKiemKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListKiemKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListKiemKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListKiemKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTen,
            this.cDanhMuc,
            this.cSLHT,
            this.cSLTT,
            this.cDV,
            this.cNguoiKiemKe,
            this.cGhiChu,
            this.cChenhLech});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListKiemKe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListKiemKe.EnableHeadersVisualStyles = false;
            this.dgvListKiemKe.Location = new System.Drawing.Point(513, 201);
            this.dgvListKiemKe.Margin = new System.Windows.Forms.Padding(7, 0, 15, 0);
            this.dgvListKiemKe.Name = "dgvListKiemKe";
            this.dgvListKiemKe.RowHeadersVisible = false;
            this.dgvListKiemKe.RowHeadersWidth = 51;
            this.dgvListKiemKe.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvListKiemKe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dgvListKiemKe.RowTemplate.Height = 44;
            this.dgvListKiemKe.RowTemplate.ReadOnly = true;
            this.dgvListKiemKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListKiemKe.Size = new System.Drawing.Size(1311, 645);
            this.dgvListKiemKe.TabIndex = 148;
            // 
            // cTen
            // 
            this.cTen.HeaderText = "Tên nguyên liệu";
            this.cTen.MinimumWidth = 6;
            this.cTen.Name = "cTen";
            this.cTen.Width = 180;
            // 
            // cDanhMuc
            // 
            this.cDanhMuc.HeaderText = "Danh mục";
            this.cDanhMuc.MinimumWidth = 6;
            this.cDanhMuc.Name = "cDanhMuc";
            this.cDanhMuc.Width = 120;
            // 
            // cSLHT
            // 
            this.cSLHT.HeaderText = "SL hệ thống";
            this.cSLHT.MinimumWidth = 6;
            this.cSLHT.Name = "cSLHT";
            this.cSLHT.Width = 80;
            // 
            // cSLTT
            // 
            this.cSLTT.HeaderText = "SL thực tế";
            this.cSLTT.MinimumWidth = 6;
            this.cSLTT.Name = "cSLTT";
            this.cSLTT.Width = 80;
            // 
            // cDV
            // 
            this.cDV.HeaderText = "Đơn vị";
            this.cDV.MinimumWidth = 6;
            this.cDV.Name = "cDV";
            this.cDV.Width = 80;
            // 
            // cNguoiKiemKe
            // 
            this.cNguoiKiemKe.HeaderText = "Người kiểm kê";
            this.cNguoiKiemKe.MinimumWidth = 6;
            this.cNguoiKiemKe.Name = "cNguoiKiemKe";
            this.cNguoiKiemKe.Width = 150;
            // 
            // cGhiChu
            // 
            this.cGhiChu.HeaderText = "Ghi chú";
            this.cGhiChu.MinimumWidth = 6;
            this.cGhiChu.Name = "cGhiChu";
            this.cGhiChu.Width = 150;
            // 
            // cChenhLech
            // 
            this.cChenhLech.HeaderText = "Chênh lệch";
            this.cChenhLech.MinimumWidth = 6;
            this.cChenhLech.Name = "cChenhLech";
            this.cChenhLech.Width = 80;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(434, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 18);
            this.label17.TabIndex = 133;
            this.label17.Text = "Số lượng thực tế:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(432, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 18);
            this.label16.TabIndex = 132;
            this.label16.Text = "Số lượng hệ thống:";
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.BackColor = System.Drawing.Color.White;
            this.btnThemVaoDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVaoDS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThemVaoDS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnThemVaoDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoDS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemVaoDS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVaoDS.Location = new System.Drawing.Point(1186, 142);
            this.btnThemVaoDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(141, 44);
            this.btnThemVaoDS.TabIndex = 150;
            this.btnThemVaoDS.Text = "Thêm vào DS";
            this.btnThemVaoDS.UseVisualStyleBackColor = false;
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // txtQuantityNL
            // 
            this.txtQuantityNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantityNL.Location = new System.Drawing.Point(584, 37);
            this.txtQuantityNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantityNL.Multiline = true;
            this.txtQuantityNL.Name = "txtQuantityNL";
            this.txtQuantityNL.Size = new System.Drawing.Size(161, 27);
            this.txtQuantityNL.TabIndex = 141;
            this.txtQuantityNL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThucHienKiemKe
            // 
            this.btnThucHienKiemKe.BackColor = System.Drawing.Color.White;
            this.btnThucHienKiemKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThucHienKiemKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThucHienKiemKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnThucHienKiemKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucHienKiemKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHienKiemKe.ForeColor = System.Drawing.Color.Orange;
            this.btnThucHienKiemKe.Image = global::PBL3_CoffeeHome.Properties.Resources.Edit;
            this.btnThucHienKiemKe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThucHienKiemKe.Location = new System.Drawing.Point(295, 142);
            this.btnThucHienKiemKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThucHienKiemKe.Name = "btnThucHienKiemKe";
            this.btnThucHienKiemKe.Size = new System.Drawing.Size(212, 50);
            this.btnThucHienKiemKe.TabIndex = 152;
            this.btnThucHienKiemKe.Text = "Thực hiển kiểm kê";
            this.btnThucHienKiemKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucHienKiemKe.UseVisualStyleBackColor = false;
            this.btnThucHienKiemKe.Click += new System.EventHandler(this.btnThucHienKiemKe_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::PBL3_CoffeeHome.Properties.Resources.Save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(1588, 142);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(127, 45);
            this.btnLuu.TabIndex = 151;
            this.btnLuu.Text = "     Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.groupBox1.Controls.Add(this.txtQuantityNL);
            this.groupBox1.Controls.Add(this.txtNameNL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudQuantityThucTe);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(513, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1311, 127);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu kiểm";
            // 
            // ucNguyenVatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThucHienKiemKe);
            this.Controls.Add(this.btnThemVaoDS);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHoanTac);
            this.Controls.Add(this.dgvStockOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListKiemKe);
            this.Name = "ucNguyenVatLieu";
            this.Size = new System.Drawing.Size(1824, 887);
            this.Load += new System.EventHandler(this.ucNguyenVatLieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityThucTe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKiemKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtNameNL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDSNLbyDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvStockOut;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQuantityThucTe;
        private System.Windows.Forms.DataGridView dgvListKiemKe;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnThemVaoDS;
        private System.Windows.Forms.Button btnThucHienKiemKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSLHeThong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSLHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSLTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNguoiKiemKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChenhLech;
        private System.Windows.Forms.TextBox txtQuantityNL;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
