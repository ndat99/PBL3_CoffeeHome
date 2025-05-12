using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucQLTK: UserControl
    {
        public ucQLTK()
        {
            InitializeComponent();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            fDetailTTTK f = new fDetailTTTK();
            f.Show();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            fDetailTTTK f = new fDetailTTTK();
            f.Show();
        }
    }
}
