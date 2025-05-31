using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace PBL3_CoffeeHome.GUI
{
    partial class ucTTTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTTTK));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMKmoi1 = new RoundedTextBox();
            this.txtMKmoi2 = new RoundedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTDN = new RoundedTextBox();
            this.txtMKCu = new RoundedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.txtDNCuoi = new RoundedTextBox();
            this.txtVaiTro = new RoundedTextBox();
            this.txtGmail = new RoundedTextBox();
            this.txtSDT = new RoundedTextBox();
            this.txtHoTen = new RoundedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(600, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gmail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(600, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vai trò";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 28);
            this.label2.TabIndex = 108;
            this.label2.Text = "Lần đăng nhập cuối";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(51, 420);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(374, 36);
            this.txtName.TabIndex = 123;
            this.txtName.Text = "Tên người dùng";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(139, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 45);
            this.label12.TabIndex = 124;
            this.label12.Text = "•";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(161, 458);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 28);
            this.label13.TabIndex = 125;
            this.label13.Text = "Đang hoạt động";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::PBL3_CoffeeHome.Properties.Resources.Pen1;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(605, 720);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 38);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(102, 41);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(200, 180);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 14;
            this.picAvatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelTTTK_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Location = new System.Drawing.Point(481, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 727);
            this.panel1.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 38);
            this.label3.TabIndex = 122;
            this.label3.Text = "👤 Thông tin cá nhân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::PBL3_CoffeeHome.Properties.Resources.Save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(333, 629);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 38);
            this.btnLuu.TabIndex = 107;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelTTTK_2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtMKmoi1);
            this.panel2.Controls.Add(this.txtMKmoi2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtTDN);
            this.panel2.Controls.Add(this.txtMKCu);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnDoiMK);
            this.panel2.Location = new System.Drawing.Point(1086, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 472);
            this.panel2.TabIndex = 122;
            // 
            // txtMKmoi1
            // 
            this.txtMKmoi1.BackColor = System.Drawing.Color.White;
            this.txtMKmoi1.BorderColor = System.Drawing.Color.Silver;
            this.txtMKmoi1.BorderRadius = 10;
            this.txtMKmoi1.BorderSize = 2;
            this.txtMKmoi1.Location = new System.Drawing.Point(318, 268);
            this.txtMKmoi1.Name = "txtMKmoi1";
            this.txtMKmoi1.Padding = new System.Windows.Forms.Padding(6);
            this.txtMKmoi1.Size = new System.Drawing.Size(196, 40);
            this.txtMKmoi1.TabIndex = 119;
            this.txtMKmoi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMKmoi2
            // 
            this.txtMKmoi2.BackColor = System.Drawing.Color.White;
            this.txtMKmoi2.BorderColor = System.Drawing.Color.Silver;
            this.txtMKmoi2.BorderRadius = 10;
            this.txtMKmoi2.BorderSize = 2;
            this.txtMKmoi2.Location = new System.Drawing.Point(67, 359);
            this.txtMKmoi2.Name = "txtMKmoi2";
            this.txtMKmoi2.Padding = new System.Windows.Forms.Padding(6);
            this.txtMKmoi2.Size = new System.Drawing.Size(196, 40);
            this.txtMKmoi2.TabIndex = 120;
            this.txtMKmoi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(207, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 38);
            this.label11.TabIndex = 122;
            this.label11.Text = "🔒 Bảo mật";
            // 
            // txtTDN
            // 
            this.txtTDN.BackColor = System.Drawing.Color.White;
            this.txtTDN.BorderColor = System.Drawing.Color.Silver;
            this.txtTDN.BorderRadius = 10;
            this.txtTDN.BorderSize = 2;
            this.txtTDN.Location = new System.Drawing.Point(67, 172);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Padding = new System.Windows.Forms.Padding(6);
            this.txtTDN.Size = new System.Drawing.Size(196, 40);
            this.txtTDN.TabIndex = 117;
            this.txtTDN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMKCu
            // 
            this.txtMKCu.BackColor = System.Drawing.Color.White;
            this.txtMKCu.BorderColor = System.Drawing.Color.Silver;
            this.txtMKCu.BorderRadius = 10;
            this.txtMKCu.BorderSize = 2;
            this.txtMKCu.Location = new System.Drawing.Point(67, 268);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Padding = new System.Windows.Forms.Padding(6);
            this.txtMKCu.Size = new System.Drawing.Size(196, 40);
            this.txtMKCu.TabIndex = 118;
            this.txtMKCu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên đăng nhập";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 28);
            this.label10.TabIndex = 111;
            this.label10.Text = "Nhập MK cũ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 28);
            this.label9.TabIndex = 106;
            this.label9.Text = "Nhập lại MK mới";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nhập MK mới";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnDoiMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoiMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMK.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDoiMK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnDoiMK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.btnDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Image = global::PBL3_CoffeeHome.Properties.Resources.Key;
            this.btnDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMK.Location = new System.Drawing.Point(318, 359);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(196, 40);
            this.btnDoiMK.TabIndex = 17;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // txtDNCuoi
            // 
            this.txtDNCuoi.BackColor = System.Drawing.Color.White;
            this.txtDNCuoi.BorderColor = System.Drawing.Color.Silver;
            this.txtDNCuoi.BorderRadius = 10;
            this.txtDNCuoi.BorderSize = 2;
            this.txtDNCuoi.Location = new System.Drawing.Point(605, 647);
            this.txtDNCuoi.Name = "txtDNCuoi";
            this.txtDNCuoi.Padding = new System.Windows.Forms.Padding(6);
            this.txtDNCuoi.Size = new System.Drawing.Size(305, 40);
            this.txtDNCuoi.TabIndex = 116;
            this.txtDNCuoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.BackColor = System.Drawing.Color.White;
            this.txtVaiTro.BorderColor = System.Drawing.Color.Silver;
            this.txtVaiTro.BorderRadius = 10;
            this.txtVaiTro.BorderSize = 2;
            this.txtVaiTro.Location = new System.Drawing.Point(605, 548);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Padding = new System.Windows.Forms.Padding(6);
            this.txtVaiTro.Size = new System.Drawing.Size(305, 40);
            this.txtVaiTro.TabIndex = 115;
            this.txtVaiTro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGmail
            // 
            this.txtGmail.BackColor = System.Drawing.Color.White;
            this.txtGmail.BorderColor = System.Drawing.Color.Silver;
            this.txtGmail.BorderRadius = 10;
            this.txtGmail.BorderSize = 2;
            this.txtGmail.Location = new System.Drawing.Point(605, 450);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Padding = new System.Windows.Forms.Padding(6);
            this.txtGmail.Size = new System.Drawing.Size(305, 40);
            this.txtGmail.TabIndex = 114;
            this.txtGmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderColor = System.Drawing.Color.Silver;
            this.txtSDT.BorderRadius = 10;
            this.txtSDT.BorderSize = 2;
            this.txtSDT.Location = new System.Drawing.Point(605, 359);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(6);
            this.txtSDT.Size = new System.Drawing.Size(305, 40);
            this.txtSDT.TabIndex = 113;
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.BorderColor = System.Drawing.Color.Silver;
            this.txtHoTen.BorderRadius = 10;
            this.txtHoTen.BorderSize = 2;
            this.txtHoTen.Location = new System.Drawing.Point(605, 263);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(6);
            this.txtHoTen.Size = new System.Drawing.Size(305, 40);
            this.txtHoTen.TabIndex = 112;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelTaoDon_1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.picAvatar);
            this.panel3.Location = new System.Drawing.Point(50, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 342);
            this.panel3.TabIndex = 126;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(5, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(304, 45);
            this.label14.TabIndex = 103;
            this.label14.Text = "Thông tin tài khoản";
            // 
            // ucTTTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDNCuoi);
            this.Controls.Add(this.txtVaiTro);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucTTTK";
            this.Size = new System.Drawing.Size(1657, 885);
            this.Load += new System.EventHandler(this.ucTTTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private RoundedTextBox txtHoTen;
        private RoundedTextBox txtSDT;
        private RoundedTextBox txtGmail;
        private RoundedTextBox txtVaiTro;
        private RoundedTextBox txtDNCuoi;
        private RoundedTextBox txtTDN;
        private RoundedTextBox txtMKCu;
        private RoundedTextBox txtMKmoi1;
        private RoundedTextBox txtMKmoi2;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Label label11;

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

        private TextBox txtName;
        private Label label12;
        private Label label13;
        private Panel panel3;
        private Label label14;
    }
}