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
    public partial class fQuanLy : Form
    {
        private Button activeButton;
        private User admin;
        private UserBLL _userBLL;

        public fQuanLy(User user)
        {
            InitializeComponent();
            admin = user;
            txtName.Text = admin.FullName;
            _userBLL = new UserBLL();
        }
        public void LoadControlToPanel(UserControl control, Panel panel)
        {
            panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel.Controls.Add(control);
            control.BringToFront();
        }
        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucTaoDon(admin), panelChiTiet);
            HighlightButton(btnTaoDon);
        }
        private void btnThucDon_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucThucDon(), panelChiTiet);
            HighlightButton(btnThucDon);
        }
        private void btnTTTK_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucTTTK(admin), panelChiTiet);
            HighlightButton(btnTTTK);
        }
        private void btnQLTK_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucQLTK(), panelChiTiet);
            HighlightButton(btnQLTK);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucThongKe(), panelChiTiet);
            HighlightButton(btnThongKe);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucKhoHang(), panelChiTiet);
            HighlightButton(btnKhoHang);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                admin.LastLoginAt = DateTime.Now;
                _userBLL.UpdateUser(admin);
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

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelChiTiet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoiNhuan_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucLoiNhuan(), panelChiTiet);
            HighlightButton(btnLoiNhuan);
        }
    }
}