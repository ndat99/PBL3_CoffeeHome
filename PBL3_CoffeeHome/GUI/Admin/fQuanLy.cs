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
using PBL3_CoffeeHome.GUI.Admin;

namespace PBL3_CoffeeHome.GUI
{
    public partial class fQuanLy : Form
    {
        private Button activeButton;
        private User admin;
        private UserBLL _userBLL;
        private readonly BaristaQueueBLL _baristaQueueBLL;
        public fQuanLy(User user)
        {
            InitializeComponent();
            admin = user;
            txtName.Text = admin.FullName;
            _userBLL = new UserBLL();
            _baristaQueueBLL = new BaristaQueueBLL();
            timerBell.Start();
            oldQueue = _baristaQueueBLL.DoneQueueCheck();
            hasDoneQueue = false;
        }
        public void LoadControlToPanel(UserControl control, Panel panel)
        {
            panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel.Controls.Add(control);
            control.BringToFront();
        }
        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucDiscounts(), panelChiTiet);
            HighlightButton(btnGiamGia);
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
            LoadControlToPanel(new ucNhanVien(), panelChiTiet);
            HighlightButton(btnQLTK);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucThongKe(), panelChiTiet);
            HighlightButton(btnThongKe);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucKhoHang(admin, 0), panelChiTiet);
            HighlightButton(btnKhoHang);
        }
        private void btnLoiNhuan_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucLoiNhuan(), panelChiTiet);
            HighlightButton(btnLoiNhuan);
        }
        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucTongQuan(), panelChiTiet);
            HighlightButton(btnTongQuan);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                admin.IsActive = false;
                admin.LastLoginAt = DateTime.Now;
                admin.PasswordHash = _userBLL.GetUserById(admin.UserID).PasswordHash;
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

        int oldQueue = 0;
        private bool hasDoneQueue = false;
        private void timerBell_Tick(object sender, EventArgs e)
        {
            int doneQueue = _baristaQueueBLL.DoneQueueCheck();
            if (doneQueue > oldQueue)
            {
                hasDoneQueue = true;
                btnBell.BackgroundImage = Properties.Resources.Bell_2;
            }
            else if (!hasDoneQueue)
            {
                btnBell.BackgroundImage = Properties.Resources.Bell_1;
            }
            oldQueue = doneQueue;
        }

        private void btnBell_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucTaoDon(admin), panelChiTiet);
            HighlightButton(btnGiamGia);
            btnBell.BackgroundImage = Properties.Resources.Bell_1;
            hasDoneQueue = false;
            oldQueue = _baristaQueueBLL.DoneQueueCheck();
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucTTTK(admin), panelChiTiet);
            HighlightButton(btnTTTK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucDiscounts(), panelChiTiet);
            HighlightButton(btnQLTK);
        }
    }
}