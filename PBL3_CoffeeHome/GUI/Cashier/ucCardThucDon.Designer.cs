namespace PBL3_CoffeeHome.GUI.Cashier
{
    partial class ucCardThucDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lbID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.MenuItemCard;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.btnXoaMon);
            this.panel1.Controls.Add(this.btnSuaMon);
            this.panel1.Controls.Add(this.btnThemMon);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.picIcon);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 0;
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaMon.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Cancel;
            this.btnXoaMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaMon.FlatAppearance.BorderSize = 0;
            this.btnXoaMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMon.Location = new System.Drawing.Point(150, 10);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(51, 40);
            this.btnXoaMon.TabIndex = 6;
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaMon.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.Edit;
            this.btnSuaMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaMon.FlatAppearance.BorderSize = 0;
            this.btnSuaMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaMon.Location = new System.Drawing.Point(149, 53);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(51, 40);
            this.btnSuaMon.TabIndex = 5;
            this.btnSuaMon.UseVisualStyleBackColor = false;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.Transparent;
            this.btnThemMon.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.ThemMon;
            this.btnThemMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemMon.FlatAppearance.BorderSize = 0;
            this.btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMon.Location = new System.Drawing.Point(149, 11);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(40, 40);
            this.btnThemMon.TabIndex = 4;
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtPrice.Location = new System.Drawing.Point(17, 164);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(168, 23);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "35.000";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(7, 139);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(188, 23);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Trà sữa socola";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcon.Location = new System.Drawing.Point(40, 15);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(120, 120);
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Gray;
            this.lbID.Location = new System.Drawing.Point(9, 18);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(81, 20);
            this.lbID.TabIndex = 8;
            this.lbID.Text = "MENU001";
            // 
            // ucCardThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ucCardThucDon";
            this.Size = new System.Drawing.Size(200, 200);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.Button btnThemMon;
        public System.Windows.Forms.Button btnSuaMon;
        public System.Windows.Forms.Button btnXoaMon;
        public System.Windows.Forms.Label lbID;
    }
}
