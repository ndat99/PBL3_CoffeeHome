namespace PBL3_CoffeeHome.GUI
{
    partial class fLichSuBaoCao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLichSuBaoCao));
            this.label10 = new System.Windows.Forms.Label();
            this.dateNgayBaoCao = new System.Windows.Forms.DateTimePicker();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.cMaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 112;
            this.label10.Text = "Ngày";
            // 
            // dateNgayBaoCao
            // 
            this.dateNgayBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayBaoCao.Location = new System.Drawing.Point(91, 25);
            this.dateNgayBaoCao.Name = "dateNgayBaoCao";
            this.dateNgayBaoCao.Size = new System.Drawing.Size(132, 27);
            this.dateNgayBaoCao.TabIndex = 111;
            this.dateNgayBaoCao.Value = new System.DateTime(2025, 4, 18, 7, 34, 0, 0);
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaoCao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBaoCao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCao.ColumnHeadersHeight = 30;
            this.dgvBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaNL,
            this.cTenNguyenLieu,
            this.cSoLuong,
            this.cDonVi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoCao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaoCao.EnableHeadersVisualStyles = false;
            this.dgvBaoCao.Location = new System.Drawing.Point(0, 76);
            this.dgvBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.RowTemplate.Height = 30;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.Size = new System.Drawing.Size(734, 510);
            this.dgvBaoCao.TabIndex = 135;
            // 
            // cMaNL
            // 
            this.cMaNL.HeaderText = "Mã NL";
            this.cMaNL.MinimumWidth = 6;
            this.cMaNL.Name = "cMaNL";
            this.cMaNL.Width = 125;
            // 
            // cTenNguyenLieu
            // 
            this.cTenNguyenLieu.HeaderText = "Tên nguyên liệu";
            this.cTenNguyenLieu.MinimumWidth = 6;
            this.cTenNguyenLieu.Name = "cTenNguyenLieu";
            this.cTenNguyenLieu.Width = 240;
            // 
            // cSoLuong
            // 
            this.cSoLuong.HeaderText = "Số lượng";
            this.cSoLuong.MinimumWidth = 6;
            this.cSoLuong.Name = "cSoLuong";
            this.cSoLuong.Width = 92;
            // 
            // cDonVi
            // 
            this.cDonVi.HeaderText = "Đơn vị";
            this.cDonVi.MinimumWidth = 6;
            this.cDonVi.Name = "cDonVi";
            this.cDonVi.Width = 92;
            // 
            // fLichSuBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 587);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateNgayBaoCao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLichSuBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử báo cáo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateNgayBaoCao;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonVi;
    }
}