using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.GUI.Admin
{
    public partial class ucDetailLSGD : UserControl
    {
        public ucDetailLSGD()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var AdminForm = (fQuanLy)this.ParentForm;
            AdminForm.LoadControlToPanel(new ucKhoHang(), AdminForm.panelChiTiet);
        }
    }
}
