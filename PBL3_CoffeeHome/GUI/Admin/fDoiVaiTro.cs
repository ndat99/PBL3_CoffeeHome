using PBL3_CoffeeHome.BLL;
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

namespace PBL3_CoffeeHome.GUI
{
    public partial class fDoiVaiTro : Form
    {
        private readonly UserBLL _userBLL;
        private User _userSelected;
        public delegate void MyDel();
        public MyDel d { get; set; }
        public fDoiVaiTro(User user,MyDel d)
        {
            InitializeComponent();
            _userSelected = user;
            _userBLL = new UserBLL();
            txtTDN.Text = _userSelected.UserName;
            txtTDN.Enabled = false;
            txtVaiTro.Text = _userSelected.Role;
            txtVaiTro.Enabled = false;
            this.d = d;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thay đổi vai trò của tài khoản này không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (cbVaiTroMoi.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn vai trò mới!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_userBLL.ChangeUserRole(_userSelected.UserID, cbVaiTroMoi.SelectedItem.ToString()))
                {
                    MessageBox.Show("Thay đổi vai trò thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; 
                    d();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thay đổi vai trò thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fDoiVaiTro_Load(object sender, EventArgs e)
        {

        }
    }
}
