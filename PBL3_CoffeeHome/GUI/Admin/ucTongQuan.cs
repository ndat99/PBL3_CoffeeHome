using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.BLL;

namespace PBL3_CoffeeHome.GUI.Admin
{
    public partial class ucTongQuan : UserControl
    {
        private readonly RevenueBLL _revenueBLL;
        private readonly RevenueDetailsBLL _revenueDetailsBLL;


        public ucTongQuan()
        {
            InitializeComponent();
            _revenueBLL = new RevenueBLL();
            _revenueDetailsBLL = new RevenueDetailsBLL();
        }

        private void ucTongQuan_Load(object sender, EventArgs e)
        {

        }

    }
}
