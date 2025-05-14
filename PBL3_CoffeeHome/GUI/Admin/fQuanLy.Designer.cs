namespace PBL3_CoffeeHome.GUI
{
    partial class fQuanLy
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLy));
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelChiTiet = new System.Windows.Forms.Panel();
            this.btnLoiNhuan = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnKhoHang = new System.Windows.Forms.Button();
            this.btnQLTK = new System.Windows.Forms.Button();
            this.btnTTTK = new System.Windows.Forms.Button();
            this.btnThucDon = new System.Windows.Forms.Button();
            this.btnTaoDon = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelChucNang.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChucNang
            // 
            this.panelChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panelChucNang.Controls.Add(this.btnLoiNhuan);
            this.panelChucNang.Controls.Add(this.btnDangXuat);
            this.panelChucNang.Controls.Add(this.btnThongKe);
            this.panelChucNang.Controls.Add(this.btnKhoHang);
            this.panelChucNang.Controls.Add(this.btnQLTK);
            this.panelChucNang.Controls.Add(this.btnTTTK);
            this.panelChucNang.Controls.Add(this.btnThucDon);
            this.panelChucNang.Controls.Add(this.btnTaoDon);
            this.panelChucNang.Controls.Add(this.picLogo);
            this.panelChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChucNang.Location = new System.Drawing.Point(0, 0);
            this.panelChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(300, 963);
            this.panelChucNang.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panelHeader.Controls.Add(this.txtName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(3, 2);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1618, 79);
            this.panelHeader.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(1064, 18);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 32);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Tên người dùng";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelChiTiet, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(300, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.658009F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.34199F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1624, 963);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panelChiTiet
            // 
            this.panelChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChiTiet.Location = new System.Drawing.Point(3, 86);
            this.panelChiTiet.Name = "panelChiTiet";
            this.panelChiTiet.Size = new System.Drawing.Size(1618, 874);
            this.panelChiTiet.TabIndex = 2;
            this.panelChiTiet.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChiTiet_Paint);
            // 
            // btnLoiNhuan
            // 
            this.btnLoiNhuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnLoiNhuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoiNhuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoiNhuan.FlatAppearance.BorderSize = 0;
            this.btnLoiNhuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoiNhuan.ForeColor = System.Drawing.Color.White;
            this.btnLoiNhuan.Image = global::PBL3_CoffeeHome.Properties.Resources.salary;
            this.btnLoiNhuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoiNhuan.Location = new System.Drawing.Point(0, 677);
            this.btnLoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoiNhuan.Name = "btnLoiNhuan";
            this.btnLoiNhuan.Size = new System.Drawing.Size(300, 94);
            this.btnLoiNhuan.TabIndex = 8;
            this.btnLoiNhuan.Text = "Lợi nhuận";
            this.btnLoiNhuan.UseVisualStyleBackColor = false;
            this.btnLoiNhuan.Click += new System.EventHandler(this.btnLoiNhuan_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = global::PBL3_CoffeeHome.Properties.Resources.DangXuat;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 869);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(300, 94);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = global::PBL3_CoffeeHome.Properties.Resources.ThongKe;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 583);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(300, 94);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnKhoHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhoHang.FlatAppearance.BorderSize = 0;
            this.btnKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoHang.ForeColor = System.Drawing.Color.White;
            this.btnKhoHang.Image = global::PBL3_CoffeeHome.Properties.Resources.KhoHang;
            this.btnKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.Location = new System.Drawing.Point(0, 489);
            this.btnKhoHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(300, 94);
            this.btnKhoHang.TabIndex = 0;
            this.btnKhoHang.Text = "   Quản lý kho";
            this.btnKhoHang.UseVisualStyleBackColor = false;
            this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
            // 
            // btnQLTK
            // 
            this.btnQLTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnQLTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTK.FlatAppearance.BorderSize = 0;
            this.btnQLTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTK.ForeColor = System.Drawing.Color.White;
            this.btnQLTK.Image = global::PBL3_CoffeeHome.Properties.Resources.QLTK;
            this.btnQLTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTK.Location = new System.Drawing.Point(0, 395);
            this.btnQLTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.Size = new System.Drawing.Size(300, 94);
            this.btnQLTK.TabIndex = 0;
            this.btnQLTK.Text = "       Quản lý tài khoản  ";
            this.btnQLTK.UseVisualStyleBackColor = false;
            this.btnQLTK.Click += new System.EventHandler(this.btnQLTK_Click);
            // 
            // btnTTTK
            // 
            this.btnTTTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnTTTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTTTK.FlatAppearance.BorderSize = 0;
            this.btnTTTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTTK.ForeColor = System.Drawing.Color.White;
            this.btnTTTK.Image = global::PBL3_CoffeeHome.Properties.Resources.TTTK;
            this.btnTTTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTTTK.Location = new System.Drawing.Point(0, 301);
            this.btnTTTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTTK.Name = "btnTTTK";
            this.btnTTTK.Size = new System.Drawing.Size(300, 94);
            this.btnTTTK.TabIndex = 3;
            this.btnTTTK.Text = "     Thông tin tài khoản";
            this.btnTTTK.UseVisualStyleBackColor = false;
            this.btnTTTK.Click += new System.EventHandler(this.btnTTTK_Click);
            // 
            // btnThucDon
            // 
            this.btnThucDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnThucDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThucDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThucDon.FlatAppearance.BorderSize = 0;
            this.btnThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucDon.ForeColor = System.Drawing.Color.White;
            this.btnThucDon.Image = global::PBL3_CoffeeHome.Properties.Resources.ThucDon;
            this.btnThucDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucDon.Location = new System.Drawing.Point(0, 207);
            this.btnThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThucDon.Name = "btnThucDon";
            this.btnThucDon.Size = new System.Drawing.Size(300, 94);
            this.btnThucDon.TabIndex = 0;
            this.btnThucDon.Text = "Thực đơn";
            this.btnThucDon.UseVisualStyleBackColor = false;
            this.btnThucDon.Click += new System.EventHandler(this.btnThucDon_Click);
            // 
            // btnTaoDon
            // 
            this.btnTaoDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnTaoDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaoDon.FlatAppearance.BorderSize = 0;
            this.btnTaoDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDon.ForeColor = System.Drawing.Color.White;
            this.btnTaoDon.Image = global::PBL3_CoffeeHome.Properties.Resources.TaoDon;
            this.btnTaoDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoDon.Location = new System.Drawing.Point(0, 113);
            this.btnTaoDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoDon.Name = "btnTaoDon";
            this.btnTaoDon.Size = new System.Drawing.Size(300, 94);
            this.btnTaoDon.TabIndex = 0;
            this.btnTaoDon.Text = "Tạo đơn";
            this.btnTaoDon.UseVisualStyleBackColor = false;
            this.btnTaoDon.Click += new System.EventHandler(this.btnTaoDon_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.logo2;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(300, 113);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // fQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 963);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelChucNang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelChucNang.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnQLTK;
        private System.Windows.Forms.Button btnThucDon;
        private System.Windows.Forms.Button btnKhoHang;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnTaoDon;
        private System.Windows.Forms.Button btnTTTK;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel panelChiTiet;
        private System.Windows.Forms.Button btnLoiNhuan;
    }
}