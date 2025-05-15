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
    public partial class fDetailTTTK : Form
    {
        private readonly UserBLL _userBLL;
        private User _userSelected;
        public delegate void MyDel();
        public MyDel d { get; set; }
        public fDetailTTTK(MyDel d)
        {
            InitializeComponent();
            _userBLL = new UserBLL();
            txtDangNhapCuoi.Enabled = false;
            this.d = d;
        }
        public fDetailTTTK(User userSelected)
        {
            InitializeComponent();
            //Điền thông tin người dùng vào các textbox
            _userBLL = new UserBLL();
            _userSelected = userSelected;
            txtTDN.Text = _userSelected.UserName;
            txtTDN.Enabled = false;
            txtHoTen.Text = _userSelected.FullName;
            txtHoTen.Enabled = false;
            txtSDT.Text = _userSelected.PhoneNumber;
            txtSDT.Enabled = false;
            txtGmail.Text = _userSelected.Email;
            txtGmail.Enabled = false;
            txtVaiTro.Text = _userSelected.Role;
            txtVaiTro.Enabled = false;
            txtDangNhapCuoi.Text = _userSelected.LastLoginAt?.ToString("dd/MM/yyyy HH:mm:ss");
            txtDangNhapCuoi.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Kiểm tra đang tạo User mới hay xem thông tin
            if (_userSelected != null)
            {
                this.Close();
                return;
            }
            try
            {
                _userBLL.ValidateUserData(txtTDN.Text, txtVaiTro.Text, txtSDT.Text, txtGmail.Text);

                User newUser = new User
                {
                    UserID = _userBLL.GenerateNewUserId(),
                    UserName = txtTDN.Text,
                    FullName = txtHoTen.Text,
                    PhoneNumber = txtSDT.Text,
                    Email = txtGmail.Text,
                    Role = txtVaiTro.Text,
                    IsActive = false
                };

                if (_userSelected == null)
                {
                    bool success = _userBLL.AddUser(newUser, "123456");
                    if (success)
                    {
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        d();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Không thể thêm tài khoản. Vui lòng kiểm tra lại thông tin!");
                    }
                }
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
    }
}