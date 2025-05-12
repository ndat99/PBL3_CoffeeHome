namespace PBL3_CoffeeHome.GUI
{
    partial class fThuNgan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThuNgan));
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTTTK = new System.Windows.Forms.Button();
            this.btnTaoDon = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelChiTiet = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panelChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChucNang
            // 
            this.panelChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panelChucNang.Controls.Add(this.btnDangXuat);
            this.panelChucNang.Controls.Add(this.btnTTTK);
            this.panelChucNang.Controls.Add(this.btnTaoDon);
            this.panelChucNang.Controls.Add(this.picLogo);
            this.panelChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChucNang.Location = new System.Drawing.Point(0, 0);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(230, 853);
            this.panelChucNang.TabIndex = 0;
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
            this.btnDangXuat.Location = new System.Drawing.Point(0, 793);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(230, 60);
            this.btnDangXuat.TabIndex = 7;
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
            this.btnTTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTTK.ForeColor = System.Drawing.Color.White;
            this.btnTTTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTTTK.Image")));
            this.btnTTTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTTTK.Location = new System.Drawing.Point(0, 173);
            this.btnTTTK.Name = "btnTTTK";
            this.btnTTTK.Size = new System.Drawing.Size(230, 60);
            this.btnTTTK.TabIndex = 1;
            this.btnTTTK.Text = "Thông tin tài khoản";
            this.btnTTTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTTTK.UseVisualStyleBackColor = false;
            this.btnTTTK.Click += new System.EventHandler(this.btnTTTK_Click);
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
            this.btnTaoDon.Name = "btnTaoDon";
            this.btnTaoDon.Size = new System.Drawing.Size(230, 60);
            this.btnTaoDon.TabIndex = 0;
            this.btnTaoDon.Text = "Tạo đơn";
            this.btnTaoDon.UseVisualStyleBackColor = false;
            this.btnTaoDon.Click += new System.EventHandler(this.btnTaoDon_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.logo2;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(230, 113);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelChiTiet
            // 
            this.panelChiTiet.Location = new System.Drawing.Point(231, 55);
            this.panelChiTiet.Name = "panelChiTiet";
            this.panelChiTiet.Size = new System.Drawing.Size(1351, 799);
            this.panelChiTiet.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panelHeader.Controls.Add(this.txtName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(230, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1352, 54);
            this.panelHeader.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(1090, 16);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 32);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Tên người dùng";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelChiTiet);
            this.Controls.Add(this.panelChucNang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThuNgan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Management";
            this.panelChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaoDon;
        private System.Windows.Forms.Button btnTTTK;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Panel panelChiTiet;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDangXuat;
    }
}