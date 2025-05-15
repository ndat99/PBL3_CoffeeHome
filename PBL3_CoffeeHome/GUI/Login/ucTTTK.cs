using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.DAL;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucTTTK: UserControl
    {
        private readonly UserBLL _userBLL;
        private User _user;
        public ucTTTK()
        {
            InitializeComponent();
        }

        public ucTTTK(User updatedUser)
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            _user = updatedUser;

            txtHoTen.Text = _user.FullName;
            txtHoTen.Enabled = false;

            txtSDT.Text = _user.PhoneNumber;
            txtSDT.Enabled = false;

            txtGmail.Text = _user.Email;
            txtGmail.Enabled = false;

            txtVaiTro.Text = _user.Role.ToString();
            txtVaiTro.Enabled = false;

            txtDNCuoi.Text = _user.LastLoginAt.ToString();
            txtDNCuoi.Enabled = false;
        }

        private void ucTTTK_Load(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtHoTen.Enabled = true;
            txtSDT.Enabled = true;
            txtGmail.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_userBLL.IsValidPhoneNumber(txtSDT.Text))
                {
                    throw new ArgumentException("Số điện thoại không hợp lệ");
                }
                if (!_userBLL.IsValidEmail(txtGmail.Text))
                {
                    throw new ArgumentException("Email không hợp lệ");
                }
                if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtGmail.Text))
                {
                    throw new ArgumentException("Không được để trống các thông tin cần thiết");
                }

                _user.FullName = txtHoTen.Text;
                _user.PhoneNumber = txtSDT.Text;
                _user.Email = txtGmail.Text;
                _userBLL.UpdateUser(_user);

                txtHoTen.Enabled = false;
                txtSDT.Enabled = false;
                txtGmail.Enabled = false;
                this.ParentForm.Refresh();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,
                              "Lỗi dữ liệu",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}",
                              "Lỗi hệ thống",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                if (_userBLL.Login(txtTDN.Text, txtMKCu.Text) == null)
                {
                    throw new ArgumentException("Mật khẩu cũ không đúng");
                }
                if (txtMKCu.Text == txtMKmoi1.Text)
                {
                    throw new ArgumentException("Mật khẩu mới không được giống mật khẩu cũ");
                }
                if (txtMKmoi1.Text != txtMKmoi2.Text)
                {
                    throw new ArgumentException("Mật khẩu mới không khớp");
                }
                if (_userBLL.ChangePassword(_user.UserID, txtMKCu.Text, txtMKmoi1.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công",
                                  "Thông báo",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Đổi mật khẩu không thành công");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,
                              "Lỗi :",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}",
                              "Lỗi hệ thống",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
    }
}
