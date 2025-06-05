using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudQuantityThucTe = new System.Windows.Forms.NumericUpDown();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.dtpDSNLbyDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListKiemKe = new System.Windows.Forms.DataGridView();
            this.cTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSLHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSLTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNguoiKiemKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChenhLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThucHienKiemKe = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStockOut = new System.Windows.Forms.DataGridView();
            this.cTenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSLHeThong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGhiChu = new RoundedTextBox();
            this.roundedTextBox1 = new RoundedTextBox();
            this.txtQuantityNL = new RoundedTextBox();
            this.txtNameNL = new RoundedTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityThucTe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKiemKe)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Controls.Add(this.nudQuantityThucTe);
            this.panel2.Controls.Add(this.roundedTextBox1);
            this.panel2.Controls.Add(this.txtQuantityNL);
            this.panel2.Controls.Add(this.txtNameNL);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnThemVaoDS);
            this.panel2.Controls.Add(this.btnHoanTac);
            this.panel2.Controls.Add(this.dtpDSNLbyDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvListKiemKe);
            this.panel2.Controls.Add(this.btnThucHienKiemKe);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(17, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1716, 851);
            this.panel2.TabIndex = 153;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Image = global::PBL3_CoffeeHome.Properties.Resources.back;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1457, 143);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 45);
            this.btnExit.TabIndex = 154;
            this.btnExit.Text = "      Quay về";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(700, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 50);
            this.label5.TabIndex = 161;
            this.label5.Text = "Kiểm kê hàng hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(55, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 35);
            this.label4.TabIndex = 160;
            this.label4.Text = "Danh sách nguyên liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(510, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 35);
            this.label2.TabIndex = 159;
            this.label2.Text = "ⓘ Thông tin phiếu kiểm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(21, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 45);
            this.label14.TabIndex = 158;
            this.label14.Text = "≡";
            // 
            // nudQuantityThucTe
            // 
            this.nudQuantityThucTe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudQuantityThucTe.DecimalPlaces = 2;
            this.nudQuantityThucTe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantityThucTe.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudQuantityThucTe.Location = new System.Drawing.Point(1103, 225);
            this.nudQuantityThucTe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQuantityThucTe.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudQuantityThucTe.Name = "nudQuantityThucTe";
            this.nudQuantityThucTe.Size = new System.Drawing.Size(97, 30);
            this.nudQuantityThucTe.TabIndex = 135;
            this.nudQuantityThucTe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::PBL3_CoffeeHome.Properties.Resources.Save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(1457, 290);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(141, 45);
            this.btnLuu.TabIndex = 151;
            this.btnLuu.Text = "     Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.BackColor = System.Drawing.Color.White;
            this.btnThemVaoDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVaoDS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThemVaoDS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnThemVaoDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoDS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoDS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemVaoDS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVaoDS.Location = new System.Drawing.Point(1263, 216);
            this.btnThemVaoDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(141, 44);
            this.btnThemVaoDS.TabIndex = 150;
            this.btnThemVaoDS.Text = "Thêm vào DS";
            this.btnThemVaoDS.UseVisualStyleBackColor = false;
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.BackColor = System.Drawing.Color.White;
            this.btnHoanTac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoanTac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnHoanTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTac.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnHoanTac.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoanTac.Location = new System.Drawing.Point(1457, 216);
            this.btnHoanTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(141, 44);
            this.btnHoanTac.TabIndex = 149;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = false;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // dtpDSNLbyDate
            // 
            this.dtpDSNLbyDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDSNLbyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDSNLbyDate.Location = new System.Drawing.Point(61, 204);
            this.dtpDSNLbyDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDSNLbyDate.Name = "dtpDSNLbyDate";
            this.dtpDSNLbyDate.Size = new System.Drawing.Size(136, 30);
            this.dtpDSNLbyDate.TabIndex = 140;
            this.dtpDSNLbyDate.ValueChanged += new System.EventHandler(this.dtpDSNLbyDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 139;
            this.label3.Text = "Tên nguyên liệu:";
            // 
            // dgvListKiemKe
            // 
            this.dgvListKiemKe.AllowUserToAddRows = false;
            this.dgvListKiemKe.BackgroundColor = System.Drawing.Color.White;
            this.dgvListKiemKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListKiemKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListKiemKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListKiemKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListKiemKe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListKiemKe.EnableHeadersVisualStyles = false;
            this.dgvListKiemKe.Location = new System.Drawing.Point(481, 362);
            this.dgvListKiemKe.Margin = new System.Windows.Forms.Padding(7, 0, 15, 0);
            this.dgvListKiemKe.Name = "dgvListKiemKe";
            this.dgvListKiemKe.RowHeadersVisible = false;
            this.dgvListKiemKe.RowHeadersWidth = 51;
            this.dgvListKiemKe.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvListKiemKe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dgvListKiemKe.RowTemplate.Height = 44;
            this.dgvListKiemKe.RowTemplate.ReadOnly = true;
            this.dgvListKiemKe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListKiemKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListKiemKe.Size = new System.Drawing.Size(1235, 457);
            this.dgvListKiemKe.TabIndex = 148;
            // 
            // cTen
            // 
            this.cTen.HeaderText = "Tên nguyên liệu";
            this.cTen.MinimumWidth = 6;
            this.cTen.Name = "cTen";
            this.cTen.Width = 200;
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
            // btnThucHienKiemKe
            // 
            this.btnThucHienKiemKe.BackColor = System.Drawing.Color.White;
            this.btnThucHienKiemKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThucHienKiemKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThucHienKiemKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnThucHienKiemKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucHienKiemKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHienKiemKe.ForeColor = System.Drawing.Color.Orange;
            this.btnThucHienKiemKe.Image = global::PBL3_CoffeeHome.Properties.Resources.Edit;
            this.btnThucHienKiemKe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThucHienKiemKe.Location = new System.Drawing.Point(244, 195);
            this.btnThucHienKiemKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThucHienKiemKe.Name = "btnThucHienKiemKe";
            this.btnThucHienKiemKe.Size = new System.Drawing.Size(212, 50);
            this.btnThucHienKiemKe.TabIndex = 152;
            this.btnThucHienKiemKe.Text = "Thực hiển kiểm kê";
            this.btnThucHienKiemKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucHienKiemKe.UseVisualStyleBackColor = false;
            this.btnThucHienKiemKe.Click += new System.EventHandler(this.btnThucHienKiemKe_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(920, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 20);
            this.label16.TabIndex = 132;
            this.label16.Text = "Số lượng hệ thống:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 136;
            this.label1.Text = "Ghi chú: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1088, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 20);
            this.label17.TabIndex = 133;
            this.label17.Text = "Số lượng thực tế:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dgvStockOut);
            this.panel1.Location = new System.Drawing.Point(3, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 566);
            this.panel1.TabIndex = 157;
            // 
            // dgvStockOut
            // 
            this.dgvStockOut.AllowUserToAddRows = false;
            this.dgvStockOut.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStockOut.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStockOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockOut.ColumnHeadersVisible = false;
            this.dgvStockOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTenNguyenLieu,
            this.cSLHeThong,
            this.cDonVi});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockOut.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStockOut.EnableHeadersVisualStyles = false;
            this.dgvStockOut.GridColor = System.Drawing.Color.Silver;
            this.dgvStockOut.Location = new System.Drawing.Point(20, 37);
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
            this.dgvStockOut.Size = new System.Drawing.Size(433, 492);
            this.dgvStockOut.TabIndex = 147;
            // 
            // cTenNguyenLieu
            // 
            this.cTenNguyenLieu.FillWeight = 280.7487F;
            this.cTenNguyenLieu.HeaderText = "Tên nguyên liệu";
            this.cTenNguyenLieu.MinimumWidth = 6;
            this.cTenNguyenLieu.Name = "cTenNguyenLieu";
            this.cTenNguyenLieu.Width = 250;
            // 
            // cSLHeThong
            // 
            this.cSLHeThong.FillWeight = 8.565047F;
            this.cSLHeThong.HeaderText = "";
            this.cSLHeThong.MinimumWidth = 6;
            this.cSLHeThong.Name = "cSLHeThong";
            this.cSLHeThong.Width = 40;
            // 
            // cDonVi
            // 
            this.cDonVi.FillWeight = 10.6863F;
            this.cDonVi.HeaderText = "";
            this.cDonVi.MinimumWidth = 6;
            this.cDonVi.Name = "cDonVi";
            this.cDonVi.Width = 50;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.BorderColor = System.Drawing.Color.Silver;
            this.txtGhiChu.BorderRadius = 10;
            this.txtGhiChu.BorderSize = 1;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(581, 291);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Padding = new System.Windows.Forms.Padding(6);
            this.txtGhiChu.Size = new System.Drawing.Size(823, 44);
            this.txtGhiChu.TabIndex = 156;
            this.txtGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BackColor = System.Drawing.Color.White;
            this.roundedTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.roundedTextBox1.BorderRadius = 10;
            this.roundedTextBox1.BorderSize = 1;
            this.roundedTextBox1.Location = new System.Drawing.Point(1092, 220);
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Padding = new System.Windows.Forms.Padding(6);
            this.roundedTextBox1.Size = new System.Drawing.Size(118, 40);
            this.roundedTextBox1.TabIndex = 155;
            this.roundedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtQuantityNL
            // 
            this.txtQuantityNL.BackColor = System.Drawing.Color.White;
            this.txtQuantityNL.BorderColor = System.Drawing.Color.Silver;
            this.txtQuantityNL.BorderRadius = 10;
            this.txtQuantityNL.BorderSize = 1;
            this.txtQuantityNL.Location = new System.Drawing.Point(929, 220);
            this.txtQuantityNL.Name = "txtQuantityNL";
            this.txtQuantityNL.Padding = new System.Windows.Forms.Padding(6);
            this.txtQuantityNL.Size = new System.Drawing.Size(118, 40);
            this.txtQuantityNL.TabIndex = 154;
            this.txtQuantityNL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameNL
            // 
            this.txtNameNL.BackColor = System.Drawing.Color.White;
            this.txtNameNL.BorderColor = System.Drawing.Color.Silver;
            this.txtNameNL.BorderRadius = 10;
            this.txtNameNL.BorderSize = 1;
            this.txtNameNL.Location = new System.Drawing.Point(581, 220);
            this.txtNameNL.Name = "txtNameNL";
            this.txtNameNL.Padding = new System.Windows.Forms.Padding(6);
            this.txtNameNL.Size = new System.Drawing.Size(295, 40);
            this.txtNameNL.TabIndex = 153;
            this.txtNameNL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ucNguyenVatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Name = "ucNguyenVatLieu";
            this.Size = new System.Drawing.Size(1824, 887);
            this.Load += new System.EventHandler(this.ucNguyenVatLieu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityThucTe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKiemKe)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDSNLbyDate;
        private System.Windows.Forms.DataGridView dgvStockOut;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQuantityThucTe;
        private System.Windows.Forms.DataGridView dgvListKiemKe;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnThemVaoDS;
        private System.Windows.Forms.Button btnThucHienKiemKe;
        private System.Windows.Forms.Panel panel2;
        private RoundedTextBox txtQuantityNL;
        private RoundedTextBox txtNameNL;
        private RoundedTextBox txtGhiChu;
        private RoundedTextBox roundedTextBox1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

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

        private Button btnExit;
    }
}
