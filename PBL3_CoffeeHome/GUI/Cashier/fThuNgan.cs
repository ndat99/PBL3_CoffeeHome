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
        private readonly BaristaQueueBLL _baristaQueueBLL;
        public fThuNgan(User user)
        {
            InitializeComponent();
            cashier = user;
            txtName.Text = cashier.FullName;
            _userBLL = new UserBLL();
            _baristaQueueBLL = new BaristaQueueBLL();
            timerBell.Start();
            oldQueue = _baristaQueueBLL.DoneQueueCheck();
            hasDoneQueue = false;
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
        private void btnAvatar_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucTTTK(cashier), panelChiTiet);
            HighlightButton(btnTTTK);
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                cashier.IsActive = false;
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
            LoadControlToPanel(new ucTaoDon(cashier), panelChiTiet);
            HighlightButton(btnTaoDon);
            btnBell.BackgroundImage = Properties.Resources.Bell_1;
            hasDoneQueue = false;
            oldQueue = _baristaQueueBLL.DoneQueueCheck();
        }
    }
}