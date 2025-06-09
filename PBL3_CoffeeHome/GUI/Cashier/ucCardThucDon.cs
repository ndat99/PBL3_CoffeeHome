using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.GUI.Cashier
{
    public partial class ucCardThucDon : UserControl
    {
        public string ItemId { get => lbID.Text; set => lbID.Text = value; }
        public string ItemName { get => txtName.Text; set => txtName.Text = value; }
        public decimal Price { get => decimal.Parse(txtPrice.Text.Replace(" đ", "").Replace(".", "")); set => txtPrice.Text = value.ToString("N0") + " đ"; }
        public Image ItemImage
        {
            get => picIcon.Image;
            set
            {
                picIcon.Image = value;
                picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        public event EventHandler btnThemMonClick;
        public event EventHandler btnXoaMonClick;
        public event EventHandler btnSuaMonClick;

        public ucCardThucDon()
        {
            InitializeComponent();
            //btnThemMon.Click += btnThemMon_Click;
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            btnThemMonClick?.Invoke(this, e);
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            btnXoaMonClick?.Invoke(this, e);
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            btnSuaMonClick?.Invoke(this, e);
        }
    }
}
