using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.GUI
{
    partial class ucKhoHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageDanhSach = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKiemKeNL_tabDSNL = new System.Windows.Forms.Button();
            this.btnDeleteNL_tabDSNL = new System.Windows.Forms.Button();
            this.dgvDSNL = new System.Windows.Forms.DataGridView();
            this.btnUpdateNL_tabDSNL = new System.Windows.Forms.Button();
            this.txtSearchNL_tabDSNL = new System.Windows.Forms.TextBox();
            this.btnAddNL_TabDSNL = new System.Windows.Forms.Button();
            this.btnExpiring_tabDSNL = new System.Windows.Forms.Button();
            this.cboDanhMucNL_tabDSNL = new System.Windows.Forms.ComboBox();
            this.btnLowStock_tabDSNL = new System.Windows.Forms.Button();
            this.btnReset_tabDSNL = new System.Windows.Forms.Button();
            this.btnSubmit_tabDSNL = new System.Windows.Forms.Button();
            this.tabPageNhapKho = new System.Windows.Forms.TabPage();
            this.dgvNhapKho = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboDonVi_TabNhapKho = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpHSDNL_tabNhapKho = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXacNhan_tabNhapKho = new System.Windows.Forms.Button();
            this.btnHoanTac_tabNhapKho = new System.Windows.Forms.Button();
            this.nudCostPriceNL_tabNhapKho = new System.Windows.Forms.NumericUpDown();
            this.btnLuuPhieuNhap_tabNhapKho = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.nudQuantityNL_tabNhapKho = new System.Windows.Forms.NumericUpDown();
            this.cboNameNL_tabNhapKho = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboCategoryNL_tabNhapKho = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPageLSGH = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnReset_tabLSGD = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSubmit_tabLSGD = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dateEnd_TabLSGD = new System.Windows.Forms.DateTimePicker();
            this.txtSearch_tabLSGD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dateStart_TabLSGD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvNgayGD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetailTransaction_tabLSGD = new System.Windows.Forms.Button();
            this.dgvLSGD = new System.Windows.Forms.DataGridView();
            this.cboType_tabLSGD = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.roundedTextBox5 = new RoundedTextBox();
            this.roundedTextBox4 = new RoundedTextBox();
            this.roundedTextBox3 = new RoundedTextBox();
            this.txtGhiChu_tabNhapKho = new RoundedTextBox();
            this.roundedTextBox1 = new RoundedTextBox();
            this.roundedTextBox2 = new RoundedTextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageDanhSach.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNL)).BeginInit();
            this.tabPageNhapKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostPriceNL_tabNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityNL_tabNhapKho)).BeginInit();
            this.tabPageLSGH.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgayGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSGD)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageDanhSach);
            this.tabControlMain.Controls.Add(this.tabPageNhapKho);
            this.tabControlMain.Controls.Add(this.tabPageLSGH);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Padding = new System.Drawing.Point(6, 6);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1823, 956);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageDanhSach
            // 
            this.tabPageDanhSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPageDanhSach.Controls.Add(this.panel3);
            this.tabPageDanhSach.Location = new System.Drawing.Point(4, 40);
            this.tabPageDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDanhSach.Name = "tabPageDanhSach";
            this.tabPageDanhSach.Padding = new System.Windows.Forms.Padding(7);
            this.tabPageDanhSach.Size = new System.Drawing.Size(1815, 912);
            this.tabPageDanhSach.TabIndex = 0;
            this.tabPageDanhSach.Text = "Danh sách nguyên liệu";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelLSGD_1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnKiemKeNL_tabDSNL);
            this.panel3.Controls.Add(this.btnDeleteNL_tabDSNL);
            this.panel3.Controls.Add(this.dgvDSNL);
            this.panel3.Controls.Add(this.btnUpdateNL_tabDSNL);
            this.panel3.Controls.Add(this.txtSearchNL_tabDSNL);
            this.panel3.Controls.Add(this.btnAddNL_TabDSNL);
            this.panel3.Controls.Add(this.btnExpiring_tabDSNL);
            this.panel3.Controls.Add(this.cboDanhMucNL_tabDSNL);
            this.panel3.Controls.Add(this.btnLowStock_tabDSNL);
            this.panel3.Controls.Add(this.btnReset_tabDSNL);
            this.panel3.Controls.Add(this.btnSubmit_tabDSNL);
            this.panel3.Location = new System.Drawing.Point(17, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1700, 815);
            this.panel3.TabIndex = 97;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumPurple;
            this.label14.Location = new System.Drawing.Point(248, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 23);
            this.label14.TabIndex = 170;
            this.label14.Text = "Sắp hết hạn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(69, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 23);
            this.label12.TabIndex = 169;
            this.label12.Text = "Tồn kho thấp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(723, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 23);
            this.label10.TabIndex = 167;
            this.label10.Text = "Tìm kiếm bằng từ khóa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.TimKiem;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(727, 186);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.TabIndex = 165;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.TimKiemEnd;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1017, 186);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.TabIndex = 166;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 163;
            this.label9.Text = "Danh mục";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(648, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(412, 50);
            this.label8.TabIndex = 162;
            this.label8.Text = "Danh sách nguyên liệu";
            // 
            // btnKiemKeNL_tabDSNL
            // 
            this.btnKiemKeNL_tabDSNL.BackColor = System.Drawing.Color.White;
            this.btnKiemKeNL_tabDSNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiemKeNL_tabDSNL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnKiemKeNL_tabDSNL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnKiemKeNL_tabDSNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemKeNL_tabDSNL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemKeNL_tabDSNL.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnKiemKeNL_tabDSNL.Image = global::PBL3_CoffeeHome.Properties.Resources.BaoCao;
            this.btnKiemKeNL_tabDSNL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKiemKeNL_tabDSNL.Location = new System.Drawing.Point(1462, 719);
            this.btnKiemKeNL_tabDSNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKiemKeNL_tabDSNL.Name = "btnKiemKeNL_tabDSNL";
            this.btnKiemKeNL_tabDSNL.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnKiemKeNL_tabDSNL.Size = new System.Drawing.Size(221, 69);
            this.btnKiemKeNL_tabDSNL.TabIndex = 95;
            this.btnKiemKeNL_tabDSNL.Text = "Kiểm kê hàng hóa";
            this.btnKiemKeNL_tabDSNL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiemKeNL_tabDSNL.UseVisualStyleBackColor = false;
            this.btnKiemKeNL_tabDSNL.Click += new System.EventHandler(this.btnKiemKeNL_tabDSNL_Click);
            // 
            // btnDeleteNL_tabDSNL
            // 
            this.btnDeleteNL_tabDSNL.BackColor = System.Drawing.Color.White;
            this.btnDeleteNL_tabDSNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNL_tabDSNL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteNL_tabDSNL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDeleteNL_tabDSNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNL_tabDSNL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNL_tabDSNL.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteNL_tabDSNL.Image = global::PBL3_CoffeeHome.Properties.Resources.Cancel;
            this.btnDeleteNL_tabDSNL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteNL_tabDSNL.Location = new System.Drawing.Point(1462, 355);
            this.btnDeleteNL_tabDSNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteNL_tabDSNL.Name = "btnDeleteNL_tabDSNL";
            this.btnDeleteNL_tabDSNL.Size = new System.Drawing.Size(221, 67);
            this.btnDeleteNL_tabDSNL.TabIndex = 94;
            this.btnDeleteNL_tabDSNL.Text = "Xóa nguyên liệu";
            this.btnDeleteNL_tabDSNL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNL_tabDSNL.UseVisualStyleBackColor = false;
            this.btnDeleteNL_tabDSNL.Click += new System.EventHandler(this.btnDeleteNL_tabDSNL_Click);
            // 
            // dgvDSNL
            // 
            this.dgvDSNL.AllowUserToAddRows = false;
            this.dgvDSNL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNL.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSNL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSNL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSNL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSNL.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSNL.EnableHeadersVisualStyles = false;
            this.dgvDSNL.Location = new System.Drawing.Point(0, 253);
            this.dgvDSNL.Margin = new System.Windows.Forms.Padding(7, 0, 15, 0);
            this.dgvDSNL.Name = "dgvDSNL";
            this.dgvDSNL.RowHeadersVisible = false;
            this.dgvDSNL.RowHeadersWidth = 51;
            this.dgvDSNL.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvDSNL.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dgvDSNL.RowTemplate.Height = 44;
            this.dgvDSNL.RowTemplate.ReadOnly = true;
            this.dgvDSNL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNL.Size = new System.Drawing.Size(1444, 535);
            this.dgvDSNL.TabIndex = 96;
            // 
            // btnUpdateNL_tabDSNL
            // 
            this.btnUpdateNL_tabDSNL.BackColor = System.Drawing.Color.White;
            this.btnUpdateNL_tabDSNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateNL_tabDSNL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpdateNL_tabDSNL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnUpdateNL_tabDSNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateNL_tabDSNL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNL_tabDSNL.ForeColor = System.Drawing.Color.Orange;
            this.btnUpdateNL_tabDSNL.Image = global::PBL3_CoffeeHome.Properties.Resources.Edit;
            this.btnUpdateNL_tabDSNL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateNL_tabDSNL.Location = new System.Drawing.Point(1462, 457);
            this.btnUpdateNL_tabDSNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateNL_tabDSNL.Name = "btnUpdateNL_tabDSNL";
            this.btnUpdateNL_tabDSNL.Padding = new System.Windows.Forms.Padding(5);
            this.btnUpdateNL_tabDSNL.Size = new System.Drawing.Size(221, 69);
            this.btnUpdateNL_tabDSNL.TabIndex = 93;
            this.btnUpdateNL_tabDSNL.Text = "Sửa thông tin NL";
            this.btnUpdateNL_tabDSNL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateNL_tabDSNL.UseVisualStyleBackColor = false;
            this.btnUpdateNL_tabDSNL.Click += new System.EventHandler(this.btnUpdateNL_tabDSNL_Click);
            // 
            // txtSearchNL_tabDSNL
            // 
            this.txtSearchNL_tabDSNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchNL_tabDSNL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchNL_tabDSNL.Location = new System.Drawing.Point(761, 186);
            this.txtSearchNL_tabDSNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchNL_tabDSNL.Name = "txtSearchNL_tabDSNL";
            this.txtSearchNL_tabDSNL.Size = new System.Drawing.Size(257, 34);
            this.txtSearchNL_tabDSNL.TabIndex = 1;
            // 
            // btnAddNL_TabDSNL
            // 
            this.btnAddNL_TabDSNL.BackColor = System.Drawing.Color.White;
            this.btnAddNL_TabDSNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNL_TabDSNL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddNL_TabDSNL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAddNL_TabDSNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNL_TabDSNL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNL_TabDSNL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddNL_TabDSNL.Image = global::PBL3_CoffeeHome.Properties.Resources.Add;
            this.btnAddNL_TabDSNL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNL_TabDSNL.Location = new System.Drawing.Point(1462, 253);
            this.btnAddNL_TabDSNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNL_TabDSNL.Name = "btnAddNL_TabDSNL";
            this.btnAddNL_TabDSNL.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddNL_TabDSNL.Size = new System.Drawing.Size(221, 69);
            this.btnAddNL_TabDSNL.TabIndex = 92;
            this.btnAddNL_TabDSNL.Text = "Thêm nguyên liệu";
            this.btnAddNL_TabDSNL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNL_TabDSNL.UseVisualStyleBackColor = false;
            this.btnAddNL_TabDSNL.Click += new System.EventHandler(this.btnAddNL_TabDSNL_Click);
            // 
            // btnExpiring_tabDSNL
            // 
            this.btnExpiring_tabDSNL.BackColor = System.Drawing.Color.White;
            this.btnExpiring_tabDSNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpiring_tabDSNL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExpiring_tabDSNL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnExpiring_tabDSNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpiring_tabDSNL.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpiring_tabDSNL.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnExpiring_tabDSNL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpiring_tabDSNL.Location = new System.Drawing.Point(247, 177);
            this.btnExpiring_tabDSNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExpiring_tabDSNL.Name = "btnExpiring_tabDSNL";
            this.btnExpiring_tabDSNL.Size = new System.Drawing.Size(121, 55);
            this.btnExpiring_tabDSNL.TabIndex = 87;
            this.btnExpiring_tabDSNL.Text = "10";
            this.btnExpiring_tabDSNL.UseVisualStyleBackColor = false;
            this.btnExpiring_tabDSNL.Click += new System.EventHandler(this.btnExpiring_tabDSNL_Click);
            // 
            // cboDanhMucNL_tabDSNL
            // 
            this.cboDanhMucNL_tabDSNL.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDanhMucNL_tabDSNL.FormattingEnabled = true;
            this.cboDanhMucNL_tabDSNL.Location = new System.Drawing.Point(459, 190);
            this.cboDanhMucNL_tabDSNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDanhMucNL_tabDSNL.Name = "cboDanhMucNL_tabDSNL";
            this.cboDanhMucNL_tabDSNL.Size = new System.Drawing.Size(210, 31);
            this.cboDanhMucNL_tabDSNL.TabIndex = 2;
            // 
            // btnLowStock_tabDSNL
            // 
            this.btnLowStock_tabDSNL.BackColor = System.Drawing.Color.White;
            this.btnLowStock_tabDSNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLowStock_tabDSNL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLowStock_tabDSNL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLowStock_tabDSNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowStock_tabDSNL.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowStock_tabDSNL.ForeColor = System.Drawing.Color.Red;
            this.btnLowStock_tabDSNL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLowStock_tabDSNL.Location = new System.Drawing.Point(69, 177);
            this.btnLowStock_tabDSNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLowStock_tabDSNL.Name = "btnLowStock_tabDSNL";
            this.btnLowStock_tabDSNL.Size = new System.Drawing.Size(130, 55);
            this.btnLowStock_tabDSNL.TabIndex = 86;
            this.btnLowStock_tabDSNL.Text = "10";
            this.btnLowStock_tabDSNL.UseVisualStyleBackColor = false;
            this.btnLowStock_tabDSNL.Click += new System.EventHandler(this.btnLowStock_tabDSNL_Click);
            // 
            // btnReset_tabDSNL
            // 
            this.btnReset_tabDSNL.BackColor = System.Drawing.Color.White;
            this.btnReset_tabDSNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset_tabDSNL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReset_tabDSNL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnReset_tabDSNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset_tabDSNL.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset_tabDSNL.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnReset_tabDSNL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset_tabDSNL.Location = new System.Drawing.Point(1269, 185);
            this.btnReset_tabDSNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset_tabDSNL.Name = "btnReset_tabDSNL";
            this.btnReset_tabDSNL.Size = new System.Drawing.Size(123, 41);
            this.btnReset_tabDSNL.TabIndex = 80;
            this.btnReset_tabDSNL.Text = "Reset";
            this.btnReset_tabDSNL.UseVisualStyleBackColor = false;
            this.btnReset_tabDSNL.Click += new System.EventHandler(this.btnReset_tabDSNL_Click);
            // 
            // btnSubmit_tabDSNL
            // 
            this.btnSubmit_tabDSNL.BackColor = System.Drawing.Color.White;
            this.btnSubmit_tabDSNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit_tabDSNL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSubmit_tabDSNL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSubmit_tabDSNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit_tabDSNL.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit_tabDSNL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit_tabDSNL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit_tabDSNL.Location = new System.Drawing.Point(1098, 185);
            this.btnSubmit_tabDSNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit_tabDSNL.Name = "btnSubmit_tabDSNL";
            this.btnSubmit_tabDSNL.Size = new System.Drawing.Size(128, 41);
            this.btnSubmit_tabDSNL.TabIndex = 79;
            this.btnSubmit_tabDSNL.Text = "Áp dụng";
            this.btnSubmit_tabDSNL.UseVisualStyleBackColor = false;
            this.btnSubmit_tabDSNL.Click += new System.EventHandler(this.btnSubmit_tabDSNL_Click);
            // 
            // tabPageNhapKho
            // 
            this.tabPageNhapKho.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPageNhapKho.Controls.Add(this.dgvNhapKho);
            this.tabPageNhapKho.Controls.Add(this.panel1);
            this.tabPageNhapKho.Location = new System.Drawing.Point(4, 40);
            this.tabPageNhapKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageNhapKho.Name = "tabPageNhapKho";
            this.tabPageNhapKho.Size = new System.Drawing.Size(1815, 912);
            this.tabPageNhapKho.TabIndex = 3;
            this.tabPageNhapKho.Text = "Nhập kho";
            // 
            // dgvNhapKho
            // 
            this.dgvNhapKho.AllowUserToAddRows = false;
            this.dgvNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhapKho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhapKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhapKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhapKho.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhapKho.EnableHeadersVisualStyles = false;
            this.dgvNhapKho.Location = new System.Drawing.Point(17, 315);
            this.dgvNhapKho.Margin = new System.Windows.Forms.Padding(7, 0, 15, 0);
            this.dgvNhapKho.Name = "dgvNhapKho";
            this.dgvNhapKho.RowHeadersVisible = false;
            this.dgvNhapKho.RowHeadersWidth = 51;
            this.dgvNhapKho.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvNhapKho.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dgvNhapKho.RowTemplate.Height = 44;
            this.dgvNhapKho.RowTemplate.ReadOnly = true;
            this.dgvNhapKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapKho.Size = new System.Drawing.Size(1440, 489);
            this.dgvNhapKho.TabIndex = 149;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelLSGD_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtGhiChu_tabNhapKho);
            this.panel1.Controls.Add(this.cboDonVi_TabNhapKho);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtpHSDNL_tabNhapKho);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnXacNhan_tabNhapKho);
            this.panel1.Controls.Add(this.btnHoanTac_tabNhapKho);
            this.panel1.Controls.Add(this.nudCostPriceNL_tabNhapKho);
            this.panel1.Controls.Add(this.btnLuuPhieuNhap_tabNhapKho);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.nudQuantityNL_tabNhapKho);
            this.panel1.Controls.Add(this.cboNameNL_tabNhapKho);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cboCategoryNL_tabNhapKho);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.roundedTextBox1);
            this.panel1.Controls.Add(this.roundedTextBox2);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 815);
            this.panel1.TabIndex = 154;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_2;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.roundedTextBox5);
            this.panel5.Controls.Add(this.roundedTextBox4);
            this.panel5.Controls.Add(this.roundedTextBox3);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Location = new System.Drawing.Point(1458, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 337);
            this.panel5.TabIndex = 167;
            // 
            // cboDonVi_TabNhapKho
            // 
            this.cboDonVi_TabNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDonVi_TabNhapKho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDonVi_TabNhapKho.FormattingEnabled = true;
            this.cboDonVi_TabNhapKho.Location = new System.Drawing.Point(616, 165);
            this.cboDonVi_TabNhapKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDonVi_TabNhapKho.Name = "cboDonVi_TabNhapKho";
            this.cboDonVi_TabNhapKho.Size = new System.Drawing.Size(140, 31);
            this.cboDonVi_TabNhapKho.TabIndex = 148;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(754, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 50);
            this.label11.TabIndex = 163;
            this.label11.Text = "Nhập kho";
            // 
            // dtpHSDNL_tabNhapKho
            // 
            this.dtpHSDNL_tabNhapKho.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHSDNL_tabNhapKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHSDNL_tabNhapKho.Location = new System.Drawing.Point(616, 234);
            this.dtpHSDNL_tabNhapKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHSDNL_tabNhapKho.Name = "dtpHSDNL_tabNhapKho";
            this.dtpHSDNL_tabNhapKho.Size = new System.Drawing.Size(140, 31);
            this.dtpHSDNL_tabNhapKho.TabIndex = 136;
            this.dtpHSDNL_tabNhapKho.ValueChanged += new System.EventHandler(this.dtpHSDNL_tabNhapKho_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(612, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 23);
            this.label13.TabIndex = 138;
            this.label13.Text = "HSD";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(853, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 23);
            this.label18.TabIndex = 147;
            this.label18.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(612, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 147;
            this.label7.Text = "Đơn vị";
            // 
            // btnXacNhan_tabNhapKho
            // 
            this.btnXacNhan_tabNhapKho.BackColor = System.Drawing.Color.White;
            this.btnXacNhan_tabNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan_tabNhapKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnXacNhan_tabNhapKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnXacNhan_tabNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan_tabNhapKho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan_tabNhapKho.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXacNhan_tabNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan_tabNhapKho.Location = new System.Drawing.Point(857, 231);
            this.btnXacNhan_tabNhapKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan_tabNhapKho.Name = "btnXacNhan_tabNhapKho";
            this.btnXacNhan_tabNhapKho.Size = new System.Drawing.Size(141, 44);
            this.btnXacNhan_tabNhapKho.TabIndex = 144;
            this.btnXacNhan_tabNhapKho.Text = "Xác nhận";
            this.btnXacNhan_tabNhapKho.UseVisualStyleBackColor = false;
            this.btnXacNhan_tabNhapKho.Click += new System.EventHandler(this.btnXacNhan_tabNhapKho_Click);
            // 
            // btnHoanTac_tabNhapKho
            // 
            this.btnHoanTac_tabNhapKho.BackColor = System.Drawing.Color.White;
            this.btnHoanTac_tabNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoanTac_tabNhapKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHoanTac_tabNhapKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnHoanTac_tabNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTac_tabNhapKho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac_tabNhapKho.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnHoanTac_tabNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoanTac_tabNhapKho.Location = new System.Drawing.Point(1048, 230);
            this.btnHoanTac_tabNhapKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoanTac_tabNhapKho.Name = "btnHoanTac_tabNhapKho";
            this.btnHoanTac_tabNhapKho.Size = new System.Drawing.Size(141, 44);
            this.btnHoanTac_tabNhapKho.TabIndex = 151;
            this.btnHoanTac_tabNhapKho.Text = "Hoàn tác";
            this.btnHoanTac_tabNhapKho.UseVisualStyleBackColor = false;
            this.btnHoanTac_tabNhapKho.Click += new System.EventHandler(this.btnHoanTac_tabNhapKho_Click);
            // 
            // nudCostPriceNL_tabNhapKho
            // 
            this.nudCostPriceNL_tabNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCostPriceNL_tabNhapKho.DecimalPlaces = 2;
            this.nudCostPriceNL_tabNhapKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCostPriceNL_tabNhapKho.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudCostPriceNL_tabNhapKho.Location = new System.Drawing.Point(406, 238);
            this.nudCostPriceNL_tabNhapKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCostPriceNL_tabNhapKho.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudCostPriceNL_tabNhapKho.Name = "nudCostPriceNL_tabNhapKho";
            this.nudCostPriceNL_tabNhapKho.Size = new System.Drawing.Size(109, 30);
            this.nudCostPriceNL_tabNhapKho.TabIndex = 145;
            this.nudCostPriceNL_tabNhapKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLuuPhieuNhap_tabNhapKho
            // 
            this.btnLuuPhieuNhap_tabNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLuuPhieuNhap_tabNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuPhieuNhap_tabNhapKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLuuPhieuNhap_tabNhapKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLuuPhieuNhap_tabNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPhieuNhap_tabNhapKho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuNhap_tabNhapKho.ForeColor = System.Drawing.Color.Black;
            this.btnLuuPhieuNhap_tabNhapKho.Image = global::PBL3_CoffeeHome.Properties.Resources.Save;
            this.btnLuuPhieuNhap_tabNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuPhieuNhap_tabNhapKho.Location = new System.Drawing.Point(1239, 230);
            this.btnLuuPhieuNhap_tabNhapKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuPhieuNhap_tabNhapKho.Name = "btnLuuPhieuNhap_tabNhapKho";
            this.btnLuuPhieuNhap_tabNhapKho.Size = new System.Drawing.Size(141, 44);
            this.btnLuuPhieuNhap_tabNhapKho.TabIndex = 152;
            this.btnLuuPhieuNhap_tabNhapKho.Text = "Lưu";
            this.btnLuuPhieuNhap_tabNhapKho.UseVisualStyleBackColor = false;
            this.btnLuuPhieuNhap_tabNhapKho.Click += new System.EventHandler(this.btnLuuPhieuNhap_tabNhapKho_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(391, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 23);
            this.label17.TabIndex = 140;
            this.label17.Text = "Giá nhập";
            // 
            // nudQuantityNL_tabNhapKho
            // 
            this.nudQuantityNL_tabNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudQuantityNL_tabNhapKho.DecimalPlaces = 2;
            this.nudQuantityNL_tabNhapKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantityNL_tabNhapKho.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudQuantityNL_tabNhapKho.Location = new System.Drawing.Point(406, 164);
            this.nudQuantityNL_tabNhapKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQuantityNL_tabNhapKho.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudQuantityNL_tabNhapKho.Name = "nudQuantityNL_tabNhapKho";
            this.nudQuantityNL_tabNhapKho.Size = new System.Drawing.Size(109, 30);
            this.nudQuantityNL_tabNhapKho.TabIndex = 141;
            this.nudQuantityNL_tabNhapKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboNameNL_tabNhapKho
            // 
            this.cboNameNL_tabNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboNameNL_tabNhapKho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNameNL_tabNhapKho.FormattingEnabled = true;
            this.cboNameNL_tabNhapKho.Location = new System.Drawing.Point(88, 237);
            this.cboNameNL_tabNhapKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNameNL_tabNhapKho.Name = "cboNameNL_tabNhapKho";
            this.cboNameNL_tabNhapKho.Size = new System.Drawing.Size(215, 31);
            this.cboNameNL_tabNhapKho.TabIndex = 144;
            this.cboNameNL_tabNhapKho.SelectedIndexChanged += new System.EventHandler(this.cboNameNL_tabNhapKho_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(84, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 23);
            this.label19.TabIndex = 132;
            this.label19.Text = "Danh mục";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(391, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 23);
            this.label16.TabIndex = 139;
            this.label16.Text = "Số lượng";
            // 
            // cboCategoryNL_tabNhapKho
            // 
            this.cboCategoryNL_tabNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCategoryNL_tabNhapKho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoryNL_tabNhapKho.FormattingEnabled = true;
            this.cboCategoryNL_tabNhapKho.Location = new System.Drawing.Point(88, 165);
            this.cboCategoryNL_tabNhapKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCategoryNL_tabNhapKho.Name = "cboCategoryNL_tabNhapKho";
            this.cboCategoryNL_tabNhapKho.Size = new System.Drawing.Size(215, 31);
            this.cboCategoryNL_tabNhapKho.TabIndex = 133;
            this.cboCategoryNL_tabNhapKho.SelectedIndexChanged += new System.EventHandler(this.cboCategoryNL_tabNhapKho_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(84, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 23);
            this.label15.TabIndex = 134;
            this.label15.Text = "Nguyên liệu";
            // 
            // tabPageLSGH
            // 
            this.tabPageLSGH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPageLSGH.Controls.Add(this.panel2);
            this.tabPageLSGH.Location = new System.Drawing.Point(4, 40);
            this.tabPageLSGH.Name = "tabPageLSGH";
            this.tabPageLSGH.Size = new System.Drawing.Size(1815, 912);
            this.tabPageLSGH.TabIndex = 4;
            this.tabPageLSGH.Text = "Lịch sử giao dịch";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelLSGD_1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.btnReset_tabLSGD);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btnSubmit_tabLSGD);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.dateEnd_TabLSGD);
            this.panel2.Controls.Add(this.txtSearch_tabLSGD);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.dateStart_TabLSGD);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnDetailTransaction_tabLSGD);
            this.panel2.Controls.Add(this.dgvLSGD);
            this.panel2.Controls.Add(this.cboType_tabLSGD);
            this.panel2.Location = new System.Drawing.Point(17, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1700, 815);
            this.panel2.TabIndex = 164;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(612, 33);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(486, 50);
            this.label23.TabIndex = 174;
            this.label23.Text = "Lịch sử giao dịch hàng hóa";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gray;
            this.label22.Location = new System.Drawing.Point(1441, 136);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(245, 31);
            this.label22.TabIndex = 173;
            this.label22.Text = "📆 Giao dịch gần đây";
            // 
            // btnReset_tabLSGD
            // 
            this.btnReset_tabLSGD.BackColor = System.Drawing.Color.White;
            this.btnReset_tabLSGD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset_tabLSGD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReset_tabLSGD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnReset_tabLSGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset_tabLSGD.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset_tabLSGD.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnReset_tabLSGD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset_tabLSGD.Location = new System.Drawing.Point(1272, 207);
            this.btnReset_tabLSGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset_tabLSGD.Name = "btnReset_tabLSGD";
            this.btnReset_tabLSGD.Size = new System.Drawing.Size(123, 41);
            this.btnReset_tabLSGD.TabIndex = 156;
            this.btnReset_tabLSGD.Text = "Reset";
            this.btnReset_tabLSGD.UseVisualStyleBackColor = false;
            this.btnReset_tabLSGD.Click += new System.EventHandler(this.btnReset_tabLSGD_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.TimKiem;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(740, 209);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.TabIndex = 171;
            this.pictureBox3.TabStop = false;
            // 
            // btnSubmit_tabLSGD
            // 
            this.btnSubmit_tabLSGD.BackColor = System.Drawing.Color.White;
            this.btnSubmit_tabLSGD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit_tabLSGD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSubmit_tabLSGD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSubmit_tabLSGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit_tabLSGD.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit_tabLSGD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit_tabLSGD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit_tabLSGD.Location = new System.Drawing.Point(1107, 207);
            this.btnSubmit_tabLSGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit_tabLSGD.Name = "btnSubmit_tabLSGD";
            this.btnSubmit_tabLSGD.Size = new System.Drawing.Size(128, 41);
            this.btnSubmit_tabLSGD.TabIndex = 155;
            this.btnSubmit_tabLSGD.Text = "Áp dụng";
            this.btnSubmit_tabLSGD.UseVisualStyleBackColor = false;
            this.btnSubmit_tabLSGD.Click += new System.EventHandler(this.btnSubmit_tabLSGD_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.TimKiemEnd;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(1026, 209);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 36);
            this.pictureBox4.TabIndex = 172;
            this.pictureBox4.TabStop = false;
            // 
            // dateEnd_TabLSGD
            // 
            this.dateEnd_TabLSGD.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd_TabLSGD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd_TabLSGD.Location = new System.Drawing.Point(529, 209);
            this.dateEnd_TabLSGD.Name = "dateEnd_TabLSGD";
            this.dateEnd_TabLSGD.Size = new System.Drawing.Size(132, 31);
            this.dateEnd_TabLSGD.TabIndex = 159;
            this.dateEnd_TabLSGD.Value = new System.DateTime(2025, 5, 16, 0, 0, 0, 0);
            this.dateEnd_TabLSGD.ValueChanged += new System.EventHandler(this.dateEnd_TabLSGD_ValueChanged);
            // 
            // txtSearch_tabLSGD
            // 
            this.txtSearch_tabLSGD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch_tabLSGD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_tabLSGD.Location = new System.Drawing.Point(773, 209);
            this.txtSearch_tabLSGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch_tabLSGD.Name = "txtSearch_tabLSGD";
            this.txtSearch_tabLSGD.Size = new System.Drawing.Size(257, 34);
            this.txtSearch_tabLSGD.TabIndex = 152;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 170;
            this.label3.Text = "Tìm kiếm bằng từ khóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 169;
            this.label6.Text = "Đến ngày:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(78, 179);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 23);
            this.label20.TabIndex = 167;
            this.label20.Text = "Loại giao dịch:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(328, 179);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 23);
            this.label21.TabIndex = 168;
            this.label21.Text = "Từ ngày:";
            // 
            // dateStart_TabLSGD
            // 
            this.dateStart_TabLSGD.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart_TabLSGD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart_TabLSGD.Location = new System.Drawing.Point(332, 209);
            this.dateStart_TabLSGD.Name = "dateStart_TabLSGD";
            this.dateStart_TabLSGD.Size = new System.Drawing.Size(132, 31);
            this.dateStart_TabLSGD.TabIndex = 157;
            this.dateStart_TabLSGD.Value = new System.DateTime(2025, 5, 16, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 31);
            this.label2.TabIndex = 166;
            this.label2.Text = "🔎 Thông tin tìm kiếm";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelKiemKe_2;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.dgvNgayGD);
            this.panel4.Location = new System.Drawing.Point(1461, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 530);
            this.panel4.TabIndex = 163;
            // 
            // dgvNgayGD
            // 
            this.dgvNgayGD.AllowUserToAddRows = false;
            this.dgvNgayGD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNgayGD.BackgroundColor = System.Drawing.Color.White;
            this.dgvNgayGD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNgayGD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNgayGD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(22, 15, 0, 15);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNgayGD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNgayGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNgayGD.ColumnHeadersVisible = false;
            this.dgvNgayGD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNgayGD.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNgayGD.EnableHeadersVisualStyles = false;
            this.dgvNgayGD.Location = new System.Drawing.Point(43, 30);
            this.dgvNgayGD.Margin = new System.Windows.Forms.Padding(7, 0, 15, 0);
            this.dgvNgayGD.Name = "dgvNgayGD";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNgayGD.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNgayGD.RowHeadersVisible = false;
            this.dgvNgayGD.RowHeadersWidth = 51;
            this.dgvNgayGD.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvNgayGD.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dgvNgayGD.RowTemplate.Height = 44;
            this.dgvNgayGD.RowTemplate.ReadOnly = true;
            this.dgvNgayGD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNgayGD.Size = new System.Drawing.Size(166, 472);
            this.dgvNgayGD.TabIndex = 162;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ngày giao dịch";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // btnDetailTransaction_tabLSGD
            // 
            this.btnDetailTransaction_tabLSGD.BackColor = System.Drawing.Color.White;
            this.btnDetailTransaction_tabLSGD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailTransaction_tabLSGD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDetailTransaction_tabLSGD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDetailTransaction_tabLSGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailTransaction_tabLSGD.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailTransaction_tabLSGD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDetailTransaction_tabLSGD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetailTransaction_tabLSGD.Location = new System.Drawing.Point(1468, 207);
            this.btnDetailTransaction_tabLSGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetailTransaction_tabLSGD.Name = "btnDetailTransaction_tabLSGD";
            this.btnDetailTransaction_tabLSGD.Size = new System.Drawing.Size(205, 41);
            this.btnDetailTransaction_tabLSGD.TabIndex = 163;
            this.btnDetailTransaction_tabLSGD.Text = "Xem chi tiết";
            this.btnDetailTransaction_tabLSGD.UseVisualStyleBackColor = false;
            this.btnDetailTransaction_tabLSGD.Click += new System.EventHandler(this.btnDetailTransaction_tabLSGD_Click);
            // 
            // dgvLSGD
            // 
            this.dgvLSGD.AllowUserToAddRows = false;
            this.dgvLSGD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLSGD.BackgroundColor = System.Drawing.Color.White;
            this.dgvLSGD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLSGD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLSGD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLSGD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLSGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLSGD.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLSGD.EnableHeadersVisualStyles = false;
            this.dgvLSGD.Location = new System.Drawing.Point(1, 277);
            this.dgvLSGD.Margin = new System.Windows.Forms.Padding(7, 0, 15, 0);
            this.dgvLSGD.Name = "dgvLSGD";
            this.dgvLSGD.RowHeadersVisible = false;
            this.dgvLSGD.RowHeadersWidth = 51;
            this.dgvLSGD.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvLSGD.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dgvLSGD.RowTemplate.Height = 44;
            this.dgvLSGD.RowTemplate.ReadOnly = true;
            this.dgvLSGD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLSGD.Size = new System.Drawing.Size(1440, 512);
            this.dgvLSGD.TabIndex = 161;
            // 
            // cboType_tabLSGD
            // 
            this.cboType_tabLSGD.FormattingEnabled = true;
            this.cboType_tabLSGD.Location = new System.Drawing.Point(82, 207);
            this.cboType_tabLSGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboType_tabLSGD.Name = "cboType_tabLSGD";
            this.cboType_tabLSGD.Size = new System.Drawing.Size(177, 33);
            this.cboType_tabLSGD.TabIndex = 153;
            this.cboType_tabLSGD.SelectedIndexChanged += new System.EventHandler(this.cboType_tabLSGD_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Gray;
            this.label24.Location = new System.Drawing.Point(1446, 262);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(233, 35);
            this.label24.TabIndex = 168;
            this.label24.Text = "ⓘ Thông tin phiếu";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(20, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(134, 23);
            this.label25.TabIndex = 154;
            this.label25.Text = "Người thực hiện";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(20, 128);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(158, 23);
            this.label26.TabIndex = 155;
            this.label26.Text = "Thời gian thực hiện";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(20, 215);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(105, 23);
            this.label27.TabIndex = 156;
            this.label27.Text = "Tổng chi phí";
            // 
            // roundedTextBox5
            // 
            this.roundedTextBox5.BackColor = System.Drawing.Color.White;
            this.roundedTextBox5.BorderColor = System.Drawing.Color.Silver;
            this.roundedTextBox5.BorderRadius = 10;
            this.roundedTextBox5.BorderSize = 1;
            this.roundedTextBox5.Location = new System.Drawing.Point(24, 241);
            this.roundedTextBox5.Name = "roundedTextBox5";
            this.roundedTextBox5.Padding = new System.Windows.Forms.Padding(6);
            this.roundedTextBox5.Size = new System.Drawing.Size(178, 40);
            this.roundedTextBox5.TabIndex = 166;
            this.roundedTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roundedTextBox4
            // 
            this.roundedTextBox4.BackColor = System.Drawing.Color.White;
            this.roundedTextBox4.BorderColor = System.Drawing.Color.Silver;
            this.roundedTextBox4.BorderRadius = 10;
            this.roundedTextBox4.BorderSize = 1;
            this.roundedTextBox4.Location = new System.Drawing.Point(24, 154);
            this.roundedTextBox4.Name = "roundedTextBox4";
            this.roundedTextBox4.Padding = new System.Windows.Forms.Padding(6);
            this.roundedTextBox4.Size = new System.Drawing.Size(178, 40);
            this.roundedTextBox4.TabIndex = 166;
            this.roundedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roundedTextBox3
            // 
            this.roundedTextBox3.BackColor = System.Drawing.Color.White;
            this.roundedTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.roundedTextBox3.BorderRadius = 10;
            this.roundedTextBox3.BorderSize = 1;
            this.roundedTextBox3.Location = new System.Drawing.Point(24, 74);
            this.roundedTextBox3.Name = "roundedTextBox3";
            this.roundedTextBox3.Padding = new System.Windows.Forms.Padding(6);
            this.roundedTextBox3.Size = new System.Drawing.Size(178, 40);
            this.roundedTextBox3.TabIndex = 166;
            this.roundedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGhiChu_tabNhapKho
            // 
            this.txtGhiChu_tabNhapKho.BackColor = System.Drawing.Color.White;
            this.txtGhiChu_tabNhapKho.BorderColor = System.Drawing.Color.Silver;
            this.txtGhiChu_tabNhapKho.BorderRadius = 10;
            this.txtGhiChu_tabNhapKho.BorderSize = 1;
            this.txtGhiChu_tabNhapKho.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu_tabNhapKho.Location = new System.Drawing.Point(857, 157);
            this.txtGhiChu_tabNhapKho.Name = "txtGhiChu_tabNhapKho";
            this.txtGhiChu_tabNhapKho.Padding = new System.Windows.Forms.Padding(6);
            this.txtGhiChu_tabNhapKho.Size = new System.Drawing.Size(523, 44);
            this.txtGhiChu_tabNhapKho.TabIndex = 166;
            this.txtGhiChu_tabNhapKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BackColor = System.Drawing.Color.White;
            this.roundedTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.roundedTextBox1.BorderRadius = 10;
            this.roundedTextBox1.BorderSize = 1;
            this.roundedTextBox1.Location = new System.Drawing.Point(395, 233);
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Padding = new System.Windows.Forms.Padding(6);
            this.roundedTextBox1.Size = new System.Drawing.Size(130, 40);
            this.roundedTextBox1.TabIndex = 164;
            this.roundedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roundedTextBox2
            // 
            this.roundedTextBox2.BackColor = System.Drawing.Color.White;
            this.roundedTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.roundedTextBox2.BorderRadius = 10;
            this.roundedTextBox2.BorderSize = 1;
            this.roundedTextBox2.Location = new System.Drawing.Point(395, 159);
            this.roundedTextBox2.Name = "roundedTextBox2";
            this.roundedTextBox2.Padding = new System.Windows.Forms.Padding(6);
            this.roundedTextBox2.Size = new System.Drawing.Size(130, 40);
            this.roundedTextBox2.TabIndex = 165;
            this.roundedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ucKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucKhoHang";
            this.Size = new System.Drawing.Size(1823, 956);
            this.Load += new System.EventHandler(this.ucKhoHang_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageDanhSach.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNL)).EndInit();
            this.tabPageNhapKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostPriceNL_tabNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityNL_tabNhapKho)).EndInit();
            this.tabPageLSGH.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgayGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSGD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageDanhSach;
        private System.Windows.Forms.TabPage tabPageNhapKho;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPageLSGH;
        private System.Windows.Forms.Button btnExpiring_tabDSNL;
        private System.Windows.Forms.Button btnLowStock_tabDSNL;
        private System.Windows.Forms.TextBox txtSearchNL_tabDSNL;
        private System.Windows.Forms.ComboBox cboDanhMucNL_tabDSNL;
        private System.Windows.Forms.Button btnReset_tabDSNL;
        private System.Windows.Forms.Button btnSubmit_tabDSNL;
        private System.Windows.Forms.DataGridView dgvDSNL;
        private System.Windows.Forms.Button btnDeleteNL_tabDSNL;
        private System.Windows.Forms.Button btnUpdateNL_tabDSNL;
        private System.Windows.Forms.Button btnAddNL_TabDSNL;
        private System.Windows.Forms.Button btnKiemKeNL_tabDSNL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
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
        private ComboBox cboDonVi_TabNhapKho;
        private Label label7;
        private NumericUpDown nudCostPriceNL_tabNhapKho;
        private Button btnXacNhan_tabNhapKho;
        private ComboBox cboNameNL_tabNhapKho;
        private NumericUpDown nudQuantityNL_tabNhapKho;
        private Label label17;
        private Label label16;
        private Label label13;
        private DateTimePicker dtpHSDNL_tabNhapKho;
        private Label label15;
        private Label label19;
        private ComboBox cboCategoryNL_tabNhapKho;
        private DataGridView dgvNhapKho;
        private Button btnLuuPhieuNhap_tabNhapKho;
        private Button btnHoanTac_tabNhapKho;
        private Panel panel1;
        private Label label11;
        private RoundedTextBox roundedTextBox1;
        private RoundedTextBox roundedTextBox2;
        private RoundedTextBox txtGhiChu_tabNhapKho;
        private Label label18;
        private Panel panel5;
        private DateTimePicker dateEnd_TabLSGD;
        private Button btnReset_tabLSGD;
        private TextBox txtSearch_tabLSGD;
        private Button btnSubmit_tabLSGD;
        private DateTimePicker dateStart_TabLSGD;
        private ComboBox cboType_tabLSGD;
        private Button btnDetailTransaction_tabLSGD;
        private DataGridView dgvNgayGD;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dgvLSGD;
        private Panel panel2;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label20;
        private Label label21;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label22;
        private Label label23;
        private Label label24;
        private RoundedTextBox roundedTextBox3;
        private Label label27;
        private Label label26;
        private Label label25;
        private RoundedTextBox roundedTextBox5;
        private RoundedTextBox roundedTextBox4;
    }
}
