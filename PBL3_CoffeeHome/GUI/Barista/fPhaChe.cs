using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.GUI.Barista;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DAL;

namespace PBL3_CoffeeHome.GUI
{
    public partial class fPhaChe : Form
    {
        private User barista;
        private Button activeButton;
        private readonly UserBLL _userBLL;
        private readonly BaristaQueueBLL _baristaQueueBLL;
        public fPhaChe(User user)
        {
            InitializeComponent();
            barista = user;
            txtName.Text = barista.FullName;
            _userBLL = new UserBLL();
            _baristaQueueBLL = new BaristaQueueBLL();
            timerBell.Start();
            oldQueue = _baristaQueueBLL.DoneQueueCheck();
            hasNewQueue = false;
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
            LoadControlToPanel(new ucDonHang(barista), panelChiTiet);
            HighlightButton(btnDonHang);
        }

        private void btnNguyenVatLieu_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucNguyenVatLieu(barista), panelChiTiet);
            HighlightButton(btnNguyenVatLieu);
        }
        private void btnLichSuGiaoDich_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucLichSuHangHoa(barista), panelChiTiet);
            HighlightButton(btnLichSuGiaoDich);
        }
        private void btnTTTK_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucTTTK(barista), panelChiTiet);
            HighlightButton(btnTTTK);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                barista.IsActive = false;
                barista.LastLoginAt = DateTime.Now;
                _userBLL.UpdateUser(barista);
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

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucTTTK(barista), panelChiTiet);
            HighlightButton(btnTTTK);
        }

        int oldQueue = 0;
        private bool hasNewQueue = false;
        private void timerBell_Tick(object sender, EventArgs e)
        {
            int newQueue = _baristaQueueBLL.NewQueueCheck();
            if (newQueue > oldQueue)
            {
                hasNewQueue = true;
                btnBell.BackgroundImage = Properties.Resources.Bell_2;
            }
            else if (!hasNewQueue)
            {
                btnBell.BackgroundImage = Properties.Resources.Bell_1;
            }
            oldQueue = newQueue;
        }
        private void btnBell_Click(object sender, EventArgs e)
        {
            LoadControlToPanel(new ucDonHang(barista), panelChiTiet);
            HighlightButton(btnDonHang);
            btnBell.BackgroundImage = Properties.Resources.Bell_1;
            hasNewQueue = false;
            oldQueue = _baristaQueueBLL.NewQueueCheck();
        }
    }
}
