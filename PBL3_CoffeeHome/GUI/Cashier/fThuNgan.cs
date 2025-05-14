using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using PBL3_CoffeeHome.DTO;
using User = PBL3_CoffeeHome.DTO.User;

namespace PBL3_CoffeeHome.GUI
{
    public partial class fThuNgan : Form
    {
        public User cashier;
        //public PBL3_CoffeeHome.DTO.User cashier { get; set; }
        private Button activeButton;
        public fThuNgan(User user)
        {
            InitializeComponent();
            cashier = user;
            txtName.Text = cashier.FullName;
        }
        private void LoadControlToPanel(UserControl control, Panel panel)
        {
            if (panel == null)
            {
                MessageBox.Show("Panel không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel.Controls.Add(control);
            control.BringToFront();
        }
        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            var ucTaoDon = new ucTaoDon(this);
            LoadControlToPanel(ucTaoDon, panelChiTiet);
            HighlightButton(btnTaoDon);
        }
        private void btnTTTK_Click(object sender, EventArgs e)
        {
            if (panelChiTiet == null)
            {
                MessageBox.Show("Panel chi tiết chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
