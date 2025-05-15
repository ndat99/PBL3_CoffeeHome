namespace PBL3_CoffeeHome.GUI
{
    partial class fPhaChe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPhaChe));
            this.panelChiTiet = new System.Windows.Forms.Panel();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTTTK = new System.Windows.Forms.Button();
            this.btnLichSuGiaoDich = new System.Windows.Forms.Button();
            this.btnNguyenVatLieu = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelChucNang.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChiTiet
            // 
            this.panelChiTiet.Location = new System.Drawing.Point(300, 76);
            this.panelChiTiet.Name = "panelChiTiet";
            this.panelChiTiet.Size = new System.Drawing.Size(1824, 887);
            this.panelChiTiet.TabIndex = 5;
            // 
            // panelChucNang
            // 
            this.panelChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panelChucNang.Controls.Add(this.btnDangXuat);
            this.panelChucNang.Controls.Add(this.btnTTTK);
            this.panelChucNang.Controls.Add(this.btnLichSuGiaoDich);
            this.panelChucNang.Controls.Add(this.btnNguyenVatLieu);
            this.panelChucNang.Controls.Add(this.btnDonHang);
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
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(300, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1624, 79);
            this.panelHeader.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(1385, 23);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 32);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Tên người dùng";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTTTK
            // 
            this.btnTTTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnTTTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTTTK.FlatAppearance.BorderSize = 0;
            this.btnTTTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTTK.ForeColor = System.Drawing.Color.White;
            this.btnTTTK.Image = global::PBL3_CoffeeHome.Properties.Resources.TTTK;
            this.btnTTTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTTTK.Location = new System.Drawing.Point(0, 395);
            this.btnTTTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTTK.Name = "btnTTTK";
            this.btnTTTK.Size = new System.Drawing.Size(300, 94);
            this.btnTTTK.TabIndex = 0;
            this.btnTTTK.Text = "   Thông tin tài khoản";
            this.btnTTTK.UseVisualStyleBackColor = false;
            this.btnTTTK.Click += new System.EventHandler(this.btnTTTK_Click);
            // 
            // btnLichSuGiaoDich
            // 
            this.btnLichSuGiaoDich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnLichSuGiaoDich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLichSuGiaoDich.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichSuGiaoDich.FlatAppearance.BorderSize = 0;
            this.btnLichSuGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuGiaoDich.ForeColor = System.Drawing.Color.White;
            this.btnLichSuGiaoDich.Image = global::PBL3_CoffeeHome.Properties.Resources.transaction;
            this.btnLichSuGiaoDich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuGiaoDich.Location = new System.Drawing.Point(0, 301);
            this.btnLichSuGiaoDich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichSuGiaoDich.Name = "btnLichSuGiaoDich";
            this.btnLichSuGiaoDich.Size = new System.Drawing.Size(300, 94);
            this.btnLichSuGiaoDich.TabIndex = 7;
            this.btnLichSuGiaoDich.Text = "  Lịch sử giao dịch";
            this.btnLichSuGiaoDich.UseVisualStyleBackColor = false;
            this.btnLichSuGiaoDich.Click += new System.EventHandler(this.btnLichSuGiaoDich_Click);
            // 
            // btnNguyenVatLieu
            // 
            this.btnNguyenVatLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnNguyenVatLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNguyenVatLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNguyenVatLieu.FlatAppearance.BorderSize = 0;
            this.btnNguyenVatLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguyenVatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNguyenVatLieu.ForeColor = System.Drawing.Color.White;
            this.btnNguyenVatLieu.Image = global::PBL3_CoffeeHome.Properties.Resources.NguyenVatLieu;
            this.btnNguyenVatLieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNguyenVatLieu.Location = new System.Drawing.Point(0, 207);
            this.btnNguyenVatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNguyenVatLieu.Name = "btnNguyenVatLieu";
            this.btnNguyenVatLieu.Size = new System.Drawing.Size(300, 94);
            this.btnNguyenVatLieu.TabIndex = 0;
            this.btnNguyenVatLieu.Text = "  Nguyên vật liệu";
            this.btnNguyenVatLieu.UseVisualStyleBackColor = false;
            this.btnNguyenVatLieu.Click += new System.EventHandler(this.btnNguyenVatLieu_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnDonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonHang.FlatAppearance.BorderSize = 0;
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.ForeColor = System.Drawing.Color.White;
            this.btnDonHang.Image = global::PBL3_CoffeeHome.Properties.Resources.DonHang;
            this.btnDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonHang.Location = new System.Drawing.Point(0, 113);
            this.btnDonHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(300, 94);
            this.btnDonHang.TabIndex = 0;
            this.btnDonHang.Text = "Đơn hàng";
            this.btnDonHang.UseVisualStyleBackColor = false;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.logo2;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(300, 113);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // fPhaChe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 963);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.panelChiTiet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPhaChe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelChucNang.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTTTK;
        private System.Windows.Forms.Button btnNguyenVatLieu;
        private System.Windows.Forms.Button btnDonHang;
        public System.Windows.Forms.Panel panelChiTiet;
        public System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnLichSuGiaoDich;
    }
}