namespace PBL3_CoffeeHome.GUI
{
    partial class ucQLTK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.cBVaiTro = new System.Windows.Forms.ComboBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVaiTro = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cTDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResetMK = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Vai trò";
            // 
            // cBVaiTro
            // 
            this.cBVaiTro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBVaiTro.FormattingEnabled = true;
            this.cBVaiTro.Location = new System.Drawing.Point(134, 152);
            this.cBVaiTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBVaiTro.Name = "cBVaiTro";
            this.cBVaiTro.Size = new System.Drawing.Size(188, 28);
            this.cBVaiTro.TabIndex = 44;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTaiKhoan.ColumnHeadersHeight = 30;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cHoTen,
            this.cVaiTro,
            this.cTDN,
            this.cSDT,
            this.cGmail});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(42, 205);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 30;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(1010, 478);
            this.dgvTaiKhoan.TabIndex = 61;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(811, 148);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(215, 30);
            this.txtTimKiem.TabIndex = 79;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(5, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(271, 38);
            this.label14.TabIndex = 100;
            this.label14.Text = "Quản lý tài khoản";
            // 
            // cHoTen
            // 
            this.cHoTen.HeaderText = "Họ tên";
            this.cHoTen.MinimumWidth = 6;
            this.cHoTen.Name = "cHoTen";
            this.cHoTen.Width = 215;
            // 
            // cVaiTro
            // 
            this.cVaiTro.HeaderText = "Vai trò";
            this.cVaiTro.Items.AddRange(new object[] {
            "Thu ngân",
            "Pha chế",
            "Quản lý"});
            this.cVaiTro.MinimumWidth = 6;
            this.cVaiTro.Name = "cVaiTro";
            this.cVaiTro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cVaiTro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cVaiTro.Width = 125;
            // 
            // cTDN
            // 
            this.cTDN.HeaderText = "Tên đăng nhập";
            this.cTDN.MinimumWidth = 6;
            this.cTDN.Name = "cTDN";
            this.cTDN.Width = 120;
            // 
            // cSDT
            // 
            this.cSDT.HeaderText = "SĐT";
            this.cSDT.MinimumWidth = 6;
            this.cSDT.Name = "cSDT";
            this.cSDT.Width = 120;
            // 
            // cGmail
            // 
            this.cGmail.HeaderText = "Gmail";
            this.cGmail.MinimumWidth = 6;
            this.cGmail.Name = "cGmail";
            this.cGmail.Width = 200;
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
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::PBL3_CoffeeHome.Properties.Resources.Save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(1090, 448);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 38);
            this.btnLuu.TabIndex = 108;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.TimKiemEnd;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1022, 148);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.TimKiem;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(780, 148);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // btnResetMK
            // 
            this.btnResetMK.BackColor = System.Drawing.Color.White;
            this.btnResetMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetMK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnResetMK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnResetMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetMK.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnResetMK.Image = global::PBL3_CoffeeHome.Properties.Resources.Reset;
            this.btnResetMK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetMK.Location = new System.Drawing.Point(1090, 386);
            this.btnResetMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetMK.Name = "btnResetMK";
            this.btnResetMK.Size = new System.Drawing.Size(192, 39);
            this.btnResetMK.TabIndex = 42;
            this.btnResetMK.Text = "Reset mật khẩu";
            this.btnResetMK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetMK.UseVisualStyleBackColor = false;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemChiTiet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnXemChiTiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnXemChiTiet.Image = global::PBL3_CoffeeHome.Properties.Resources.Xem;
            this.btnXemChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemChiTiet.Location = new System.Drawing.Point(1090, 266);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(192, 39);
            this.btnXemChiTiet.TabIndex = 41;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.BackColor = System.Drawing.Color.White;
            this.btnTaoTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoTK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTaoTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnTaoTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTaoTK.Image = global::PBL3_CoffeeHome.Properties.Resources.Add;
            this.btnTaoTK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoTK.Location = new System.Drawing.Point(1090, 205);
            this.btnTaoTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(192, 39);
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
            this.btnXoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.ForeColor = System.Drawing.Color.Red;
            this.btnXoaTK.Image = global::PBL3_CoffeeHome.Properties.Resources.Cancel;
            this.btnXoaTK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTK.Location = new System.Drawing.Point(1090, 325);
            this.btnXoaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(192, 39);
            this.btnXoaTK.TabIndex = 15;
            this.btnXoaTK.Text = "Xóa tài khoản";
            this.btnXoaTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTK.UseVisualStyleBackColor = false;
            // 
            // ucQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBVaiTro);
            this.Controls.Add(this.btnResetMK);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(this.btnXoaTK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucQLTK";
            this.Size = new System.Drawing.Size(1351, 799);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnResetMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBVaiTro;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHoTen;
        private System.Windows.Forms.DataGridViewComboBoxColumn cVaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGmail;
        private System.Windows.Forms.Button btnLuu;
    }
}
