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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.cBVaiTro = new System.Windows.Forms.ComboBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDoiVaiTro = new System.Windows.Forms.Button();
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
            this.cBVaiTro.Items.AddRange(new object[] {
            "All",
            "Admin",
            "Barista",
            "Cashier"});
            this.cBVaiTro.Location = new System.Drawing.Point(134, 152);
            this.cBVaiTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBVaiTro.Name = "cBVaiTro";
            this.cBVaiTro.Size = new System.Drawing.Size(188, 28);
            this.cBVaiTro.TabIndex = 44;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle2;
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
            // btnDoiVaiTro
            // 
            this.btnDoiVaiTro.BackColor = System.Drawing.Color.White;
            this.btnDoiVaiTro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiVaiTro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDoiVaiTro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDoiVaiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiVaiTro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDoiVaiTro.Image = global::PBL3_CoffeeHome.Properties.Resources.Panel;
            this.btnDoiVaiTro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiVaiTro.Location = new System.Drawing.Point(1090, 450);
            this.btnDoiVaiTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiVaiTro.Name = "btnDoiVaiTro";
            this.btnDoiVaiTro.Size = new System.Drawing.Size(192, 39);
            this.btnDoiVaiTro.TabIndex = 101;
            this.btnDoiVaiTro.Text = "Đổi chức vụ";
            this.btnDoiVaiTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiVaiTro.UseVisualStyleBackColor = false;
            this.btnDoiVaiTro.Click += new System.EventHandler(this.btnDoiVaiTro_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.btnResetMK.Click += new System.EventHandler(this.btnResetMK_Click);
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
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // ucQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDoiVaiTro);
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
            this.Load += new System.EventHandler(this.ucQLTK_Load);
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
        private System.Windows.Forms.Button btnDoiVaiTro;
    }
}
