﻿namespace PBL3_CoffeeHome.GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThuNgan));
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTTTK = new System.Windows.Forms.Button();
            this.btnTaoDon = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelChiTiet = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBell = new System.Windows.Forms.Button();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.timerBell = new System.Windows.Forms.Timer(this.components);
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
            this.panelChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(300, 963);
            this.panelChucNang.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnTTTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTTK.ForeColor = System.Drawing.Color.White;
            this.btnTTTK.Image = global::PBL3_CoffeeHome.Properties.Resources.TTTK;
            this.btnTTTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTTTK.Location = new System.Drawing.Point(0, 207);
            this.btnTTTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTTK.Name = "btnTTTK";
            this.btnTTTK.Size = new System.Drawing.Size(300, 94);
            this.btnTTTK.TabIndex = 0;
            this.btnTTTK.Text = "   Thông tin tài khoản";
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
            this.btnTaoDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.logo2;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(300, 113);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelChiTiet
            // 
            this.panelChiTiet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelChiTiet.Location = new System.Drawing.Point(300, 76);
            this.panelChiTiet.Name = "panelChiTiet";
            this.panelChiTiet.Size = new System.Drawing.Size(1824, 933);
            this.panelChiTiet.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panelHeader.Controls.Add(this.btnBell);
            this.panelHeader.Controls.Add(this.btnAvatar);
            this.panelHeader.Controls.Add(this.txtName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(300, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1624, 79);
            this.panelHeader.TabIndex = 1;
            // 
            // btnBell
            // 
            this.btnBell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnBell.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Bell_1;
            this.btnBell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBell.FlatAppearance.BorderSize = 0;
            this.btnBell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBell.ForeColor = System.Drawing.Color.White;
            this.btnBell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBell.Location = new System.Drawing.Point(1363, 17);
            this.btnBell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBell.Name = "btnBell";
            this.btnBell.Size = new System.Drawing.Size(46, 43);
            this.btnBell.TabIndex = 2;
            this.btnBell.UseVisualStyleBackColor = false;
            this.btnBell.Click += new System.EventHandler(this.btnBell_Click);
            // 
            // btnAvatar
            // 
            this.btnAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnAvatar.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Avatar_small;
            this.btnAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvatar.FlatAppearance.BorderSize = 0;
            this.btnAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvatar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvatar.ForeColor = System.Drawing.Color.White;
            this.btnAvatar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvatar.Location = new System.Drawing.Point(1410, 17);
            this.btnAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(46, 43);
            this.btnAvatar.TabIndex = 1;
            this.btnAvatar.UseVisualStyleBackColor = false;
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(1462, 24);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(252, 32);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Tên người dùng";
            // 
            // timerBell
            // 
            this.timerBell.Interval = 2000;
            this.timerBell.Tick += new System.EventHandler(this.timerBell_Tick);
            // 
            // fThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 963);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelChiTiet);
            this.Controls.Add(this.panelChucNang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fThuNgan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button btnAvatar;
        private System.Windows.Forms.Timer timerBell;
        private System.Windows.Forms.Button btnBell;
    }
}