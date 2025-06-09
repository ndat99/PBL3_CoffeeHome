using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.GUI.Admin
{
    partial class ucNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.panelChiTiet = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnDoiVaiTro = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnResetMK = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cBVaiTro = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabLichLamViec = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteNL_tabDSNL = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLichLamViec_tabLich = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTypeSchedule_tabLich = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTimKiem_tabLich = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddLich_tabLich = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudHourlyRate_tabLich = new System.Windows.Forms.NumericUpDown();
            this.cbbCaLamViec_tabLich = new System.Windows.Forms.ComboBox();
            this.cbbUser_TabLich = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabLuong = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblTongGioLamViec_tabLuong = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTongQuyLuong_tabLuong = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThanhToan_tabLuong = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbNam_tabLuong = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvLuong_tabLuong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbThang_tabLuong = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSearch_TabLuong = new System.Windows.Forms.TextBox();
            this.dtpDate_tabLich = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            this.panelChiTiet.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabLichLamViec.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec_tabLich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyRate_tabLich)).BeginInit();
            this.tabLuong.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong_tabLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNhanVien);
            this.tabControl1.Controls.Add(this.tabLichLamViec);
            this.tabControl1.Controls.Add(this.tabLuong);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1852, 938);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.panelChiTiet);
            this.tabNhanVien.Controls.Add(this.dataGridView1);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 34);
            this.tabNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Size = new System.Drawing.Size(1844, 900);
            this.tabNhanVien.TabIndex = 2;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // panelChiTiet
            // 
            this.panelChiTiet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelChiTiet.Controls.Add(this.panel7);
            this.panelChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChiTiet.Location = new System.Drawing.Point(0, 0);
            this.panelChiTiet.Name = "panelChiTiet";
            this.panelChiTiet.Size = new System.Drawing.Size(1844, 900);
            this.panelChiTiet.TabIndex = 94;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelQLTK1;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.dgvTaiKhoan);
            this.panel7.Controls.Add(this.btnLoc);
            this.panel7.Controls.Add(this.btnDoiVaiTro);
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.btnResetMK);
            this.panel7.Controls.Add(this.pictureBox6);
            this.panel7.Controls.Add(this.btnXemChiTiet);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.btnTaoTK);
            this.panel7.Controls.Add(this.btnXoaTK);
            this.panel7.Controls.Add(this.txtTimKiem);
            this.panel7.Controls.Add(this.cBVaiTro);
            this.panel7.Location = new System.Drawing.Point(15, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1716, 822);
            this.panel7.TabIndex = 106;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(892, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 23);
            this.label13.TabIndex = 168;
            this.label13.Text = "Tìm kiếm bằng từ khóa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(586, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 23);
            this.label15.TabIndex = 169;
            this.label15.Text = "Vai trò";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.dgvTaiKhoan.ColumnHeadersHeight = 40;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle58;
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(1, 248);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 40;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(1453, 553);
            this.dgvTaiKhoan.TabIndex = 61;
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
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = global::PBL3_CoffeeHome.Properties.Resources.Filter;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.Location = new System.Drawing.Point(1282, 192);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(101, 41);
            this.btnLoc.TabIndex = 167;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnDoiVaiTro
            // 
            this.btnDoiVaiTro.BackColor = System.Drawing.Color.White;
            this.btnDoiVaiTro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiVaiTro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDoiVaiTro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDoiVaiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiVaiTro.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiVaiTro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDoiVaiTro.Image = global::PBL3_CoffeeHome.Properties.Resources.Change;
            this.btnDoiVaiTro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiVaiTro.Location = new System.Drawing.Point(1491, 574);
            this.btnDoiVaiTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiVaiTro.Name = "btnDoiVaiTro";
            this.btnDoiVaiTro.Size = new System.Drawing.Size(190, 44);
            this.btnDoiVaiTro.TabIndex = 101;
            this.btnDoiVaiTro.Text = "Đổi chức vụ";
            this.btnDoiVaiTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiVaiTro.UseVisualStyleBackColor = false;
            this.btnDoiVaiTro.Click += new System.EventHandler(this.btnDoiVaiTro_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.TimKiemEnd;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(1193, 195);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 36);
            this.pictureBox5.TabIndex = 81;
            this.pictureBox5.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(21, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(260, 31);
            this.label16.TabIndex = 166;
            this.label16.Text = "🔎 Thông tin tìm kiếm";
            // 
            // btnResetMK
            // 
            this.btnResetMK.BackColor = System.Drawing.Color.White;
            this.btnResetMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetMK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnResetMK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnResetMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetMK.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetMK.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnResetMK.Image = global::PBL3_CoffeeHome.Properties.Resources.Reset;
            this.btnResetMK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetMK.Location = new System.Drawing.Point(1491, 496);
            this.btnResetMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetMK.Name = "btnResetMK";
            this.btnResetMK.Size = new System.Drawing.Size(190, 44);
            this.btnResetMK.TabIndex = 42;
            this.btnResetMK.Text = "Reset mật khẩu";
            this.btnResetMK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetMK.UseVisualStyleBackColor = false;
            this.btnResetMK.Click += new System.EventHandler(this.btnResetMK_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.TimKiem;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(896, 195);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 36);
            this.pictureBox6.TabIndex = 80;
            this.pictureBox6.TabStop = false;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemChiTiet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnXemChiTiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnXemChiTiet.Image = global::PBL3_CoffeeHome.Properties.Resources.Xem;
            this.btnXemChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemChiTiet.Location = new System.Drawing.Point(1491, 340);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(190, 44);
            this.btnXemChiTiet.TabIndex = 41;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(678, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(372, 50);
            this.label17.TabIndex = 162;
            this.label17.Text = "Danh sách tài khoản";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.BackColor = System.Drawing.Color.White;
            this.btnTaoTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoTK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTaoTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnTaoTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoTK.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTaoTK.Image = global::PBL3_CoffeeHome.Properties.Resources.Add;
            this.btnTaoTK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoTK.Location = new System.Drawing.Point(1491, 262);
            this.btnTaoTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(190, 44);
            this.btnTaoTK.TabIndex = 14;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoTK.UseVisualStyleBackColor = false;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.BackColor = System.Drawing.Color.White;
            this.btnXoaTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnXoaTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnXoaTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTK.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.ForeColor = System.Drawing.Color.Red;
            this.btnXoaTK.Image = global::PBL3_CoffeeHome.Properties.Resources.Cancel;
            this.btnXoaTK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTK.Location = new System.Drawing.Point(1491, 418);
            this.btnXoaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(190, 44);
            this.btnXoaTK.TabIndex = 15;
            this.btnXoaTK.Text = "Xóa tài khoản";
            this.btnXoaTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTK.UseVisualStyleBackColor = false;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(925, 195);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(272, 34);
            this.txtTimKiem.TabIndex = 79;
            // 
            // cBVaiTro
            // 
            this.cBVaiTro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBVaiTro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBVaiTro.FormattingEnabled = true;
            this.cBVaiTro.Items.AddRange(new object[] {
            "All",
            "Admin",
            "Barista",
            "Cashier"});
            this.cBVaiTro.Location = new System.Drawing.Point(590, 197);
            this.cBVaiTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBVaiTro.Name = "cBVaiTro";
            this.cBVaiTro.Size = new System.Drawing.Size(188, 31);
            this.cBVaiTro.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle59.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle60;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 0, 15, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1844, 900);
            this.dataGridView1.TabIndex = 93;
            // 
            // tabLichLamViec
            // 
            this.tabLichLamViec.Controls.Add(this.tableLayoutPanel1);
            this.tabLichLamViec.Location = new System.Drawing.Point(4, 34);
            this.tabLichLamViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLichLamViec.Name = "tabLichLamViec";
            this.tabLichLamViec.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.tabLichLamViec.Size = new System.Drawing.Size(1844, 900);
            this.tabLichLamViec.TabIndex = 0;
            this.tabLichLamViec.Text = "Lịch làm việc";
            this.tabLichLamViec.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.63327F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.36673F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1822, 880);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnDeleteNL_tabDSNL);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbbTypeSchedule_tabLich);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtTimKiem_tabLich);
            this.panel2.Location = new System.Drawing.Point(527, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 790);
            this.panel2.TabIndex = 169;
            // 
            // btnDeleteNL_tabDSNL
            // 
            this.btnDeleteNL_tabDSNL.BackColor = System.Drawing.Color.White;
            this.btnDeleteNL_tabDSNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNL_tabDSNL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteNL_tabDSNL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDeleteNL_tabDSNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNL_tabDSNL.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNL_tabDSNL.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteNL_tabDSNL.Image = global::PBL3_CoffeeHome.Properties.Resources.Cancel;
            this.btnDeleteNL_tabDSNL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteNL_tabDSNL.Location = new System.Drawing.Point(927, 144);
            this.btnDeleteNL_tabDSNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteNL_tabDSNL.Name = "btnDeleteNL_tabDSNL";
            this.btnDeleteNL_tabDSNL.Size = new System.Drawing.Size(132, 41);
            this.btnDeleteNL_tabDSNL.TabIndex = 171;
            this.btnDeleteNL_tabDSNL.Text = "Xóa lịch";
            this.btnDeleteNL_tabDSNL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNL_tabDSNL.UseVisualStyleBackColor = false;
            this.btnDeleteNL_tabDSNL.Click += new System.EventHandler(this.btnDeleteNL_tabDSNL_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvLichLamViec_tabLich);
            this.panel3.Location = new System.Drawing.Point(86, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 496);
            this.panel3.TabIndex = 170;
            // 
            // dgvLichLamViec_tabLich
            // 
            this.dgvLichLamViec_tabLich.AllowUserToAddRows = false;
            this.dgvLichLamViec_tabLich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLamViec_tabLich.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichLamViec_tabLich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichLamViec_tabLich.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLichLamViec_tabLich.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle61.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle61.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichLamViec_tabLich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
            this.dgvLichLamViec_tabLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichLamViec_tabLich.DefaultCellStyle = dataGridViewCellStyle62;
            this.dgvLichLamViec_tabLich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichLamViec_tabLich.EnableHeadersVisualStyles = false;
            this.dgvLichLamViec_tabLich.Location = new System.Drawing.Point(0, 0);
            this.dgvLichLamViec_tabLich.Margin = new System.Windows.Forms.Padding(7, 0, 15, 0);
            this.dgvLichLamViec_tabLich.Name = "dgvLichLamViec_tabLich";
            this.dgvLichLamViec_tabLich.RowHeadersVisible = false;
            this.dgvLichLamViec_tabLich.RowHeadersWidth = 51;
            this.dgvLichLamViec_tabLich.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvLichLamViec_tabLich.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dgvLichLamViec_tabLich.RowTemplate.Height = 44;
            this.dgvLichLamViec_tabLich.RowTemplate.ReadOnly = true;
            this.dgvLichLamViec_tabLich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichLamViec_tabLich.Size = new System.Drawing.Size(973, 496);
            this.dgvLichLamViec_tabLich.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(441, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 31);
            this.label8.TabIndex = 169;
            this.label8.Text = "LỊCH PHÂN CA LÀM VIỆC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(420, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 168;
            // 
            // cbbTypeSchedule_tabLich
            // 
            this.cbbTypeSchedule_tabLich.FormattingEnabled = true;
            this.cbbTypeSchedule_tabLich.Items.AddRange(new object[] {
            "Tất cả",
            "Ca 1 (6h - 12h)",
            "Ca 2 (12h - 18h)",
            "Ca 3 (18h - 23h)"});
            this.cbbTypeSchedule_tabLich.Location = new System.Drawing.Point(120, 147);
            this.cbbTypeSchedule_tabLich.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTypeSchedule_tabLich.Name = "cbbTypeSchedule_tabLich";
            this.cbbTypeSchedule_tabLich.Size = new System.Drawing.Size(187, 33);
            this.cbbTypeSchedule_tabLich.TabIndex = 94;
            this.cbbTypeSchedule_tabLich.SelectedIndexChanged += new System.EventHandler(this.cbbTypeSchedule_tabLich_SelectedIndexChanged_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.TimKiemEnd;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(826, 145);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.TimKiem;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(583, 145);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // txtTimKiem_tabLich
            // 
            this.txtTimKiem_tabLich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem_tabLich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem_tabLich.Location = new System.Drawing.Point(615, 145);
            this.txtTimKiem_tabLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem_tabLich.Name = "txtTimKiem_tabLich";
            this.txtTimKiem_tabLich.Size = new System.Drawing.Size(215, 34);
            this.txtTimKiem_tabLich.TabIndex = 91;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 862);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelTaoDon_1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.dtpDate_tabLich);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnAddLich_tabLich);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.nudHourlyRate_tabLich);
            this.panel4.Controls.Add(this.cbbCaLamViec_tabLich);
            this.panel4.Controls.Add(this.cbbUser_TabLich);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(20, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 533);
            this.panel4.TabIndex = 126;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(59, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 31);
            this.label7.TabIndex = 167;
            this.label7.Text = "📋 PHÂN CÔNG LÀM VIỆC";
            // 
            // btnAddLich_tabLich
            // 
            this.btnAddLich_tabLich.BackColor = System.Drawing.Color.White;
            this.btnAddLich_tabLich.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddLich_tabLich.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddLich_tabLich.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddLich_tabLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLich_tabLich.Location = new System.Drawing.Point(92, 440);
            this.btnAddLich_tabLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddLich_tabLich.Name = "btnAddLich_tabLich";
            this.btnAddLich_tabLich.Size = new System.Drawing.Size(244, 43);
            this.btnAddLich_tabLich.TabIndex = 2;
            this.btnAddLich_tabLich.Text = "Đăng ký ca làm";
            this.btnAddLich_tabLich.UseVisualStyleBackColor = false;
            this.btnAddLich_tabLich.Click += new System.EventHandler(this.btnAddLich_tabLich_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày làm việc:";
            // 
            // nudHourlyRate_tabLich
            // 
            this.nudHourlyRate_tabLich.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHourlyRate_tabLich.Location = new System.Drawing.Point(192, 271);
            this.nudHourlyRate_tabLich.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudHourlyRate_tabLich.Name = "nudHourlyRate_tabLich";
            this.nudHourlyRate_tabLich.Size = new System.Drawing.Size(172, 31);
            this.nudHourlyRate_tabLich.TabIndex = 10;
            // 
            // cbbCaLamViec_tabLich
            // 
            this.cbbCaLamViec_tabLich.FormattingEnabled = true;
            this.cbbCaLamViec_tabLich.Items.AddRange(new object[] {
            "Ca 1 (6h - 12h)",
            "Ca 2 (12h - 18h)",
            "Ca 3 (18h - 23h)"});
            this.cbbCaLamViec_tabLich.Location = new System.Drawing.Point(52, 187);
            this.cbbCaLamViec_tabLich.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCaLamViec_tabLich.Name = "cbbCaLamViec_tabLich";
            this.cbbCaLamViec_tabLich.Size = new System.Drawing.Size(312, 33);
            this.cbbCaLamViec_tabLich.TabIndex = 4;
            // 
            // cbbUser_TabLich
            // 
            this.cbbUser_TabLich.FormattingEnabled = true;
            this.cbbUser_TabLich.Location = new System.Drawing.Point(52, 94);
            this.cbbUser_TabLich.Margin = new System.Windows.Forms.Padding(4);
            this.cbbUser_TabLich.Name = "cbbUser_TabLich";
            this.cbbUser_TabLich.Size = new System.Drawing.Size(312, 33);
            this.cbbUser_TabLich.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ca làm việc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lương /1h:";
            // 
            // tabLuong
            // 
            this.tabLuong.Controls.Add(this.panel11);
            this.tabLuong.Controls.Add(this.panel8);
            this.tabLuong.Controls.Add(this.panel5);
            this.tabLuong.Location = new System.Drawing.Point(4, 34);
            this.tabLuong.Name = "tabLuong";
            this.tabLuong.Size = new System.Drawing.Size(1844, 900);
            this.tabLuong.TabIndex = 3;
            this.tabLuong.Text = "Lương";
            this.tabLuong.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelDonHang_1;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Controls.Add(this.lblTongGioLamViec_tabLuong);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Location = new System.Drawing.Point(1340, 474);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(292, 249);
            this.panel11.TabIndex = 173;
            // 
            // lblTongGioLamViec_tabLuong
            // 
            this.lblTongGioLamViec_tabLuong.AutoSize = true;
            this.lblTongGioLamViec_tabLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblTongGioLamViec_tabLuong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongGioLamViec_tabLuong.ForeColor = System.Drawing.Color.Gray;
            this.lblTongGioLamViec_tabLuong.Location = new System.Drawing.Point(60, 126);
            this.lblTongGioLamViec_tabLuong.Name = "lblTongGioLamViec_tabLuong";
            this.lblTongGioLamViec_tabLuong.Size = new System.Drawing.Size(0, 41);
            this.lblTongGioLamViec_tabLuong.TabIndex = 171;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(33, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 31);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tổng giờ làm việc";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelDonHang_1;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.lblTongQuyLuong_tabLuong);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(1340, 118);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(292, 250);
            this.panel8.TabIndex = 172;
            // 
            // lblTongQuyLuong_tabLuong
            // 
            this.lblTongQuyLuong_tabLuong.AutoSize = true;
            this.lblTongQuyLuong_tabLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblTongQuyLuong_tabLuong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongQuyLuong_tabLuong.ForeColor = System.Drawing.Color.Gray;
            this.lblTongQuyLuong_tabLuong.Location = new System.Drawing.Point(47, 119);
            this.lblTongQuyLuong_tabLuong.Name = "lblTongQuyLuong_tabLuong";
            this.lblTongQuyLuong_tabLuong.Size = new System.Drawing.Size(0, 41);
            this.lblTongQuyLuong_tabLuong.TabIndex = 170;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(3, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(254, 31);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tổng quỹ lương tháng";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_2;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.btnThanhToan_tabLuong);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.cbbNam_tabLuong);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.cbbThang_tabLuong);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.txtSearch_TabLuong);
            this.panel5.Location = new System.Drawing.Point(17, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1320, 790);
            this.panel5.TabIndex = 171;
            // 
            // btnThanhToan_tabLuong
            // 
            this.btnThanhToan_tabLuong.BackColor = System.Drawing.Color.White;
            this.btnThanhToan_tabLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan_tabLuong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThanhToan_tabLuong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnThanhToan_tabLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan_tabLuong.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan_tabLuong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThanhToan_tabLuong.Image = global::PBL3_CoffeeHome.Properties.Resources.Add;
            this.btnThanhToan_tabLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan_tabLuong.Location = new System.Drawing.Point(967, 133);
            this.btnThanhToan_tabLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan_tabLuong.Name = "btnThanhToan_tabLuong";
            this.btnThanhToan_tabLuong.Padding = new System.Windows.Forms.Padding(5);
            this.btnThanhToan_tabLuong.Size = new System.Drawing.Size(150, 43);
            this.btnThanhToan_tabLuong.TabIndex = 174;
            this.btnThanhToan_tabLuong.Text = "Thanh toán";
            this.btnThanhToan_tabLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan_tabLuong.UseVisualStyleBackColor = false;
            this.btnThanhToan_tabLuong.Click += new System.EventHandler(this.btnThanhToan_tabLuong_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(289, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 25);
            this.label14.TabIndex = 173;
            this.label14.Text = "Năm:";
            // 
            // cbbNam_tabLuong
            // 
            this.cbbNam_tabLuong.FormattingEnabled = true;
            this.cbbNam_tabLuong.Items.AddRange(new object[] {
            "Tất cả",
            "Ca 1 (6h - 12h)",
            "Ca 2 (12h - 18h)",
            "Ca 3 (18h - 23h)"});
            this.cbbNam_tabLuong.Location = new System.Drawing.Point(348, 139);
            this.cbbNam_tabLuong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNam_tabLuong.Name = "cbbNam_tabLuong";
            this.cbbNam_tabLuong.Size = new System.Drawing.Size(133, 33);
            this.cbbNam_tabLuong.TabIndex = 172;
            this.cbbNam_tabLuong.SelectedIndexChanged += new System.EventHandler(this.cbbNam_tabLuong_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 171;
            this.label10.Text = "Tháng:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvLuong_tabLuong);
            this.panel6.Location = new System.Drawing.Point(80, 225);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1074, 496);
            this.panel6.TabIndex = 170;
            // 
            // dgvLuong_tabLuong
            // 
            this.dgvLuong_tabLuong.AllowUserToAddRows = false;
            this.dgvLuong_tabLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong_tabLuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvLuong_tabLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLuong_tabLuong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLuong_tabLuong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle63.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLuong_tabLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle63;
            this.dgvLuong_tabLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLuong_tabLuong.DefaultCellStyle = dataGridViewCellStyle64;
            this.dgvLuong_tabLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuong_tabLuong.EnableHeadersVisualStyles = false;
            this.dgvLuong_tabLuong.Location = new System.Drawing.Point(0, 0);
            this.dgvLuong_tabLuong.Margin = new System.Windows.Forms.Padding(7, 0, 15, 0);
            this.dgvLuong_tabLuong.Name = "dgvLuong_tabLuong";
            this.dgvLuong_tabLuong.RowHeadersVisible = false;
            this.dgvLuong_tabLuong.RowHeadersWidth = 51;
            this.dgvLuong_tabLuong.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvLuong_tabLuong.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dgvLuong_tabLuong.RowTemplate.Height = 44;
            this.dgvLuong_tabLuong.RowTemplate.ReadOnly = true;
            this.dgvLuong_tabLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuong_tabLuong.Size = new System.Drawing.Size(1074, 496);
            this.dgvLuong_tabLuong.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(417, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 169;
            this.label1.Text = "CHI TIẾT LƯƠNG LÀM VIỆC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(394, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 31);
            this.label9.TabIndex = 168;
            // 
            // cbbThang_tabLuong
            // 
            this.cbbThang_tabLuong.FormattingEnabled = true;
            this.cbbThang_tabLuong.Items.AddRange(new object[] {
            "Tất cả",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang_tabLuong.Location = new System.Drawing.Point(161, 139);
            this.cbbThang_tabLuong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbThang_tabLuong.Name = "cbbThang_tabLuong";
            this.cbbThang_tabLuong.Size = new System.Drawing.Size(85, 33);
            this.cbbThang_tabLuong.TabIndex = 94;
            this.cbbThang_tabLuong.SelectedIndexChanged += new System.EventHandler(this.cbbThang_tabLuong_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.TimKiemEnd;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(829, 134);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.TabIndex = 93;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.TimKiem;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(585, 134);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 36);
            this.pictureBox4.TabIndex = 92;
            this.pictureBox4.TabStop = false;
            // 
            // txtSearch_TabLuong
            // 
            this.txtSearch_TabLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch_TabLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_TabLuong.Location = new System.Drawing.Point(618, 134);
            this.txtSearch_TabLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch_TabLuong.Name = "txtSearch_TabLuong";
            this.txtSearch_TabLuong.Size = new System.Drawing.Size(215, 34);
            this.txtSearch_TabLuong.TabIndex = 91;
            this.txtSearch_TabLuong.TextChanged += new System.EventHandler(this.txtSearch_TabLuong_TextChanged);
            // 
            // dtpDate_tabLich
            // 
            this.dtpDate_tabLich.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate_tabLich.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate_tabLich.Location = new System.Drawing.Point(192, 351);
            this.dtpDate_tabLich.Name = "dtpDate_tabLich";
            this.dtpDate_tabLich.Size = new System.Drawing.Size(172, 31);
            this.dtpDate_tabLich.TabIndex = 168;
            this.dtpDate_tabLich.Value = new System.DateTime(2025, 5, 16, 0, 0, 0, 0);
            // 
            // ucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucNhanVien";
            this.Size = new System.Drawing.Size(1852, 938);
            this.Load += new System.EventHandler(this.ucNhanVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabNhanVien.ResumeLayout(false);
            this.panelChiTiet.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabLichLamViec.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec_tabLich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyRate_tabLich)).EndInit();
            this.tabLuong.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong_tabLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLichLamViec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddLich_tabLich;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.ComboBox cbbCaLamViec_tabLich;
        private System.Windows.Forms.ComboBox cbbUser_TabLich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHourlyRate_tabLich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvLichLamViec_tabLich;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTypeSchedule_tabLich;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiem_tabLich;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelChiTiet;
        private System.Windows.Forms.TabPage tabLuong;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbNam_tabLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvLuong_tabLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbThang_tabLuong;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtSearch_TabLuong;
        private System.Windows.Forms.Button btnDeleteNL_tabDSNL;
        private System.Windows.Forms.Button btnThanhToan_tabLuong;
        private System.Windows.Forms.Label lblTongGioLamViec_tabLuong;
        private System.Windows.Forms.Label lblTongQuyLuong_tabLuong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnDoiVaiTro;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnResetMK;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cBVaiTro;

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

        private DateTimePicker dtpDate_tabLich;
    }
}
