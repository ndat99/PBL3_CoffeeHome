using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.GUI
{
    partial class ucDiscounts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.btnDeleteDiscount = new System.Windows.Forms.Button();
            this.btnEditDiscount = new System.Windows.Forms.Button();
            this.dgvDiscounts = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.BackgroundImage = global::PBL3_CoffeeHome.Properties.Resources.panelDiscount_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHienThiTatCa);
            this.panel1.Controls.Add(this.btnLoc);
            this.panel1.Controls.Add(this.dtpKetThuc);
            this.panel1.Controls.Add(this.dtpBatDau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAddDiscount);
            this.panel1.Controls.Add(this.btnDeleteDiscount);
            this.panel1.Controls.Add(this.btnEditDiscount);
            this.panel1.Controls.Add(this.dgvDiscounts);
            this.panel1.Location = new System.Drawing.Point(15, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1716, 851);
            this.panel1.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(21, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 31);
            this.label2.TabIndex = 184;
            this.label2.Text = "🔎 Thông tin tìm kiếm";
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnHienThiTatCa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHienThiTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHienThiTatCa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnHienThiTatCa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnHienThiTatCa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.btnHienThiTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThiTatCa.Location = new System.Drawing.Point(1196, 195);
            this.btnHienThiTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(212, 41);
            this.btnHienThiTatCa.TabIndex = 183;
            this.btnHienThiTatCa.Text = "Hiển thị tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = false;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = global::PBL3_CoffeeHome.Properties.Resources.Filter;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.Location = new System.Drawing.Point(1049, 195);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(95, 41);
            this.btnLoc.TabIndex = 182;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(844, 205);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(132, 31);
            this.dtpKetThuc.TabIndex = 181;
            this.dtpKetThuc.Value = new System.DateTime(2025, 5, 16, 0, 0, 0, 0);
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatDau.Location = new System.Drawing.Point(651, 205);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(132, 31);
            this.dtpBatDau.TabIndex = 180;
            this.dtpBatDau.Value = new System.DateTime(2025, 5, 16, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(840, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 179;
            this.label1.Text = "Đến ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 178;
            this.label4.Text = "Từ ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(655, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(425, 50);
            this.label5.TabIndex = 162;
            this.label5.Text = "Danh sách mã giảm giá";
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.BackColor = System.Drawing.Color.White;
            this.btnAddDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiscount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddDiscount.Image = global::PBL3_CoffeeHome.Properties.Resources.Add;
            this.btnAddDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDiscount.Location = new System.Drawing.Point(1491, 262);
            this.btnAddDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(190, 44);
            this.btnAddDiscount.TabIndex = 11;
            this.btnAddDiscount.Text = "Thêm mã";
            this.btnAddDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDiscount.UseVisualStyleBackColor = false;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnDeleteDiscount
            // 
            this.btnDeleteDiscount.BackColor = System.Drawing.Color.White;
            this.btnDeleteDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDeleteDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDiscount.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteDiscount.Image = global::PBL3_CoffeeHome.Properties.Resources.Cancel;
            this.btnDeleteDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteDiscount.Location = new System.Drawing.Point(1491, 421);
            this.btnDeleteDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteDiscount.Name = "btnDeleteDiscount";
            this.btnDeleteDiscount.Size = new System.Drawing.Size(190, 44);
            this.btnDeleteDiscount.TabIndex = 12;
            this.btnDeleteDiscount.Text = "Xóa mã";
            this.btnDeleteDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDiscount.UseVisualStyleBackColor = false;
            this.btnDeleteDiscount.Click += new System.EventHandler(this.btnDeleteDiscount_Click);
            // 
            // btnEditDiscount
            // 
            this.btnEditDiscount.BackColor = System.Drawing.Color.White;
            this.btnEditDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEditDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEditDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDiscount.ForeColor = System.Drawing.Color.Orange;
            this.btnEditDiscount.Image = global::PBL3_CoffeeHome.Properties.Resources.Edit;
            this.btnEditDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditDiscount.Location = new System.Drawing.Point(1491, 341);
            this.btnEditDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditDiscount.Name = "btnEditDiscount";
            this.btnEditDiscount.Size = new System.Drawing.Size(190, 44);
            this.btnEditDiscount.TabIndex = 9;
            this.btnEditDiscount.Text = "Sửa mã";
            this.btnEditDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDiscount.UseVisualStyleBackColor = false;
            this.btnEditDiscount.Click += new System.EventHandler(this.btnEditDiscount_Click);
            // 
            // dgvDiscounts
            // 
            this.dgvDiscounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscounts.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiscounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiscounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiscounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiscounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiscounts.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiscounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiscounts.EnableHeadersVisualStyles = false;
            this.dgvDiscounts.Location = new System.Drawing.Point(1, 262);
            this.dgvDiscounts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDiscounts.Name = "dgvDiscounts";
            this.dgvDiscounts.RowHeadersVisible = false;
            this.dgvDiscounts.RowHeadersWidth = 51;
            this.dgvDiscounts.RowTemplate.Height = 40;
            this.dgvDiscounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscounts.Size = new System.Drawing.Size(1453, 549);
            this.dgvDiscounts.TabIndex = 62;
            // 
            // ucDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucDiscounts";
            this.Size = new System.Drawing.Size(1790, 920);
            this.Load += new System.EventHandler(this.ucDiscounts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDiscounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
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

        private Button btnAddDiscount;
        private Button btnDeleteDiscount;
        private Button btnEditDiscount;
        private DateTimePicker dtpKetThuc;
        private DateTimePicker dtpBatDau;
        private Label label1;
        private Label label4;
        private Button btnLoc;
        private Button btnHienThiTatCa;
        private Label label2;
    }
}