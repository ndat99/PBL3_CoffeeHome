using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.GUI.Barista;

namespace PBL3_CoffeeHome.GUI
{
    public partial class fPhaChe: Form
    {
        private Button activeButton;
        public fPhaChe()
        {
            InitializeComponent();
            txtName.Text = "Tiến";
        }
        public void LoadControlToPanel(UserControl control, Panel panel)
        {
            panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel.Controls.Add(control);
            control.BringToFront();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucDonHang(), panelChiTiet);
            HighlightButton(btnDonHang);
        }

        private void btnNguyenVatLieu_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucNguyenVatLieu(), panelChiTiet);
            HighlightButton(btnNguyenVatLieu);
        }

        private void btnTTTK_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucTTTK(), panelChiTiet);
            HighlightButton(btnTTTK);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắn chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }
        private void HighlightButton(Button button)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(43, 45, 66);
                activeButton.ForeColor = Color.Silver;
            }
            button.BackColor = Color.FromArgb(60, 62, 85);
            button.ForeColor = Color.White;
            activeButton = button;
        }
    }
}
