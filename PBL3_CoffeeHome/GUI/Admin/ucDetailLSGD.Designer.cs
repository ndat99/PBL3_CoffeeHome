namespace PBL3_CoffeeHome.GUI.Admin
{
    partial class ucDetailLSGD
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
            this.listView_InformationLSGD = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView_InformationLSGD
            // 
            this.listView_InformationLSGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_InformationLSGD.HideSelection = false;
            this.listView_InformationLSGD.Location = new System.Drawing.Point(0, 0);
            this.listView_InformationLSGD.Name = "listView_InformationLSGD";
            this.listView_InformationLSGD.Size = new System.Drawing.Size(621, 660);
            this.listView_InformationLSGD.TabIndex = 0;
            this.listView_InformationLSGD.UseCompatibleStateImageBehavior = false;
            // 
            // ucDetailLSGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView_InformationLSGD);
            this.Name = "ucDetailLSGD";
            this.Size = new System.Drawing.Size(621, 660);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_InformationLSGD;
    }
}
