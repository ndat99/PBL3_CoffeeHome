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
    public partial class ucQLTK : UserControl
    {
        private readonly UserBLL _userBLL;
        private BindingSource bindingSource;

        public ucQLTK()
        {
            InitializeComponent();
            _userBLL = new UserBLL();

            bindingSource = new BindingSource();

            SetupDataGridView();
            dgvTaiKhoan.DataSource = bindingSource;

            cBVaiTro.SelectedIndex = 0;

            LoadData();
        }

        public void LoadData()
        {
            try
            {
                List<User> users = _userBLL.GetALlUsers();
                if (users != null && users.Any())
                {
                    bindingSource.DataSource = users;
                    bindingSource.ResetBindings(true);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu người dùng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSource.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            // Tắt tự động tạo cột
            dgvTaiKhoan.AutoGenerateColumns = false;

            // Không cho phép thêm hàng mới
            dgvTaiKhoan.AllowUserToAddRows = false;

            dgvTaiKhoan.ReadOnly = true;                        
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.MultiSelect = false;                    
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.DataSourceChanged += (s, e) => dgvTaiKhoan.Refresh();


            // Thiết lập các cột cho DataGridView
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[]
            {
            new DataGridViewTextBoxColumn
            {
                Name = "UserID",
                HeaderText = "Mã NV",
                DataPropertyName = "UserID",
                Width = 80
            },
            new DataGridViewTextBoxColumn
            {
                Name = "UserName",
                HeaderText = "Tên đăng nhập",
                DataPropertyName = "UserName",
                Width = 120
            },
            new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "Họ và tên",
                DataPropertyName = "FullName",
                Width = 150
            },
            new DataGridViewTextBoxColumn
            {
                Name = "Role",
                HeaderText = "Chức vụ",
                DataPropertyName = "Role",
                Width = 100
            },
            new DataGridViewTextBoxColumn
            {
                Name = "PhoneNumber",
                HeaderText = "Số điện thoại",
                DataPropertyName = "PhoneNumber",
                Width = 100
            },
            new DataGridViewCheckBoxColumn
            {
                Name = "IsActive",
                HeaderText = "Hoạt động",
                DataPropertyName = "IsActive",
                Width = 70
            }
            });
        }

        private void LoadData(string searchText)
        {
            string selectedRole = cBVaiTro.SelectedItem.ToString();

            List<User> searchResult;

            searchResult = _userBLL.SearchUsers(searchText);
            bindingSource.DataSource = searchResult;
            bindingSource.ResetBindings(false);
        }

        private void LoadData(string searchText, string selectedRole)
        {
            List<User> searchResult;

            searchResult = _userBLL.SearchUsers(searchText,selectedRole);
            bindingSource.DataSource = searchResult;
            bindingSource.ResetBindings(false);
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            fDetailTTTK f = new fDetailTTTK(LoadData) ;
            f.Show();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            User userSelected = dgvTaiKhoan.CurrentRow.DataBoundItem as User;
            fDetailTTTK f = new fDetailTTTK(userSelected);
            f.Show();
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(cBVaiTro.SelectedItem.ToString() == "All")
            {
                LoadData(txtTimKiem.Text.Trim());
            }
            else LoadData(txtTimKiem.Text.Trim(), cBVaiTro.SelectedItem.ToString());
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            User userSelected = dgvTaiKhoan.CurrentRow.DataBoundItem as User;

            if (userSelected == null)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DialogResult.No == MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {userSelected.UserName} không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)) return;
            else
            {
                _userBLL.DeleteUser(userSelected.UserID);
                LoadData();
            }
                
        }

        private void btnResetMK_Click(object sender, EventArgs e)
        {
            User userSelected = dgvTaiKhoan.CurrentRow.DataBoundItem as User;

            if (userSelected == null)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để reset mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DialogResult.No == MessageBox.Show($"Bạn có chắc chắn muốn reset mật khẩu của {userSelected.UserName} không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)) return;
            else
            {
                _userBLL.ChangePassword(userSelected.UserID,userSelected.PasswordHash, "123456");
                LoadData();
            }
        }

        private void btnDoiVaiTro_Click(object sender, EventArgs e)
        {
            User userSelected = dgvTaiKhoan.CurrentRow.DataBoundItem as User;
            if(userSelected == null)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để thay đổi vai trò!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            fDoiVaiTro f = new fDoiVaiTro(userSelected,LoadData);
            f.Show();
        }

        private void ucQLTK_Load(object sender, EventArgs e)
        {

        }
    }
}
