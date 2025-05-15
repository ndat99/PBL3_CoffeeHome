using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Management.Instrumentation;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DAL;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.GUI
{
    public partial class fDangNhap : Form
    {
        private readonly UserBLL _userBLL;
        public fDangNhap()
        {
            InitializeComponent();
            _userBLL = new UserBLL();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra input
                if (string.IsNullOrEmpty(txtTDN.Text) || string.IsNullOrEmpty(textMK.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thực hiện đăng nhập
                User user = _userBLL.Login(txtTDN.Text.Trim(), textMK.Text.Trim());

                if (user == null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra và chuyển form theo role
                switch (user.Role)
                {
                    case "Cashier":
                        fThuNgan f1 = new fThuNgan(user);
                        this.Hide();
                        f1.ShowDialog();
                        break;
                    case "Barista":
                        fPhaChe f2 = new fPhaChe(user);
                        this.Hide();
                        f2.ShowDialog();
                        break;
                    case "Admin":
                        fQuanLy f3 = new fQuanLy(user);
                        this.Hide();
                        f3.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Không tìm thấy quyền truy cập!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
