namespace PBL3_CoffeeHome.GUI
{
    partial class fDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangNhap));
            this.textMK = new System.Windows.Forms.TextBox();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textMK
            // 
            this.textMK.BackColor = System.Drawing.Color.White;
            this.textMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMK.Location = new System.Drawing.Point(168, 101);
            this.textMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMK.Name = "textMK";
            this.textMK.PasswordChar = '•';
            this.textMK.Size = new System.Drawing.Size(205, 27);
            this.textMK.TabIndex = 11;
            // 
            // txtTDN
            // 
            this.txtTDN.BackColor = System.Drawing.Color.White;
            this.txtTDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDN.Location = new System.Drawing.Point(168, 49);
            this.txtTDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(205, 27);
            this.txtTDN.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên đăng nhập";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(267, 139);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 16);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu?";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(125)))), ((int)(((byte)(169)))));
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Image = global::PBL3_CoffeeHome.Properties.Resources.WhiteKey;
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.Location = new System.Drawing.Point(227, 177);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(147, 32);
            this.btnDangNhap.TabIndex = 22;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = global::PBL3_CoffeeHome.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(340, -53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(619, 247);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textMK);
            this.Controls.Add(this.txtTDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textMK;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnDangNhap;
    }
}