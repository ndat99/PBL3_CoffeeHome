using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.DAL;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.GUI
{
    public partial class fThuNgan : Form
    {
        private Button activeButton;
        private User cashier;
        private readonly UserBLL _userBLL;
        public fThuNgan(User user)
        {
            InitializeComponent();
            cashier = user;
            _userBLL = new UserBLL();
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
            LoadControlToPanel(new ucTaoDon(cashier), panelChiTiet);
            HighlightButton(btnTaoDon);
        }
        private void btnTTTK_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucTTTK(cashier), panelChiTiet);
            HighlightButton(btnTTTK);
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                cashier.LastLoginAt = DateTime.Now;
                _userBLL.UpdateUser(cashier);
                Application.Restart();
            }
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