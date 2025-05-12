using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Management.Instrumentation;

namespace PBL3_CoffeeHome.GUI
{
    public partial class fDangNhap: Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }
        //public void LoadFormToPanel(Form formToLoad, Panel targetPanel)
        //{
        //    // Xóa form cũ nếu có
        //    if (targetPanel.Controls.Count > 0)
        //    {
        //        Form oldForm = targetPanel.Controls[0] as Form;
        //        if (oldForm != null)
        //        {
        //            oldForm.Close();
        //        }
        //        targetPanel.Controls.Clear();
        //    }

        //    // Cấu hình form con
        //    formToLoad.TopLevel = false;
        //    formToLoad.FormBorderStyle = FormBorderStyle.None;
        //    formToLoad.Dock = DockStyle.Fill;

        //    // Add form vào panel
        //    targetPanel.Controls.Add(formToLoad);
        //    targetPanel.Tag = formToLoad;

        //    formToLoad.Show();
        //}
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTDN.Text.Trim();

            //this.Hide();
            switch (userName)
            {
                case "thungan":
                    fThuNgan f1 = new fThuNgan();
                    f1.ShowDialog();
                    break;
                case "phache":
                    fPhaChe f2 = new fPhaChe();
                    f2.ShowDialog();
                    break;
                case "quanly":
                    fQuanLy f3 = new fQuanLy();
                    f3.ShowDialog();
                    break;
                case "":
                    fQuanLy f = new fQuanLy();
                    f.ShowDialog();
                    break;
            }
            this.Close();
        }
    }
}
