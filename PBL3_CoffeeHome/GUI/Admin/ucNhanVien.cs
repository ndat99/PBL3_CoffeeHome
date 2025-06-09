using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DTO.ViewModel;

namespace PBL3_CoffeeHome.GUI.Admin
{
    public partial class ucNhanVien : UserControl
    {
        private readonly ScheduleBLL _scheduleBLL;
        private readonly SalaryBLL _salaryBLL;
        private readonly UserBLL _userBLL;

        private BindingList<ScheduleDTO> _listLich;
        private BindingList<SalaryDTO> _listLuong;

        private readonly string _userId;
        private BindingSource bindingSource;
        public ucNhanVien()
        {
            InitializeComponent();
            _scheduleBLL = new ScheduleBLL();
            _salaryBLL = new SalaryBLL();
            _userBLL = new UserBLL();
        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            TabNhanVien();
            TabLich();
            TabLuong();
        }

        // tabNhanVien
        private void TabNhanVien()
        {
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
            dgvTaiKhoan.AutoGenerateColumns = false;

            dgvTaiKhoan.AllowUserToAddRows = false;

            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.DataSourceChanged += (s, e) => dgvTaiKhoan.Refresh();


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

            searchResult = _userBLL.SearchUsers(searchText, selectedRole);
            bindingSource.DataSource = searchResult;
            bindingSource.ResetBindings(false);
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            fDetailTTTK f = new fDetailTTTK(LoadData);
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
                _userBLL.ChangePassword(userSelected.UserID, userSelected.PasswordHash, "123456");
                _userBLL.UpdateUser(userSelected);
                LoadData();
            }
        }

        private void btnDoiVaiTro_Click(object sender, EventArgs e)
        {
            User userSelected = dgvTaiKhoan.CurrentRow.DataBoundItem as User;
            if (userSelected == null)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để thay đổi vai trò!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            fDoiVaiTro f = new fDoiVaiTro(userSelected, LoadData);
            f.Show();
        }
        private void ucQLTK_Load(object sender, EventArgs e)
        {
            MakeButtonRounded(btnLoc, 10, Color.Black);
            MakeButtonRounded(btnTaoTK, 10, Color.FromArgb(0, 102, 204));
            MakeButtonRounded(btnXemChiTiet, 10, Color.MediumPurple);
            MakeButtonRounded(btnXoaTK, 10, Color.Red);
            MakeButtonRounded(btnResetMK, 10, Color.LimeGreen);
            MakeButtonRounded(btnDoiVaiTro, 10, Color.MidnightBlue);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cBVaiTro.SelectedItem.ToString() == "All")
            {
                LoadData(txtTimKiem.Text.Trim());
            }
            else LoadData(txtTimKiem.Text.Trim(), cBVaiTro.SelectedItem.ToString());
        }


        // tabLuong 
        private void TabLich()
        {
            _listLich = new BindingList<ScheduleDTO>();
            dgvLichLamViec_tabLich.DataSource = _listLich;

            LoadUser_tabLich();
            LoadDGVLich_tabLich();
            cbbCaLamViec_tabLich.SelectedIndex = 0;
            cbbTypeSchedule_tabLich.SelectedIndex = 0;
            cbbRole_tabLich.SelectedIndex = 0;
        }

        private void LoadUser_tabLich()
        {
            List<string> listNameUser = _userBLL.GetALlUsers()
                .Where(u => u.Role == "Cashier" || u.Role == "Barista")
                .Select(u => u.FullName)
                .ToList();

            cbbUser_TabLich.Items.Clear();
            cbbUser_TabLich.Items.AddRange(listNameUser.ToArray());
            cbbUser_TabLich.SelectedIndex = 0;
        }

        private void SetupDGVLichLamViec()
        {
            dgvLichLamViec_tabLich.Columns["ScheduleID"].HeaderText = "Mã lịch";
            dgvLichLamViec_tabLich.Columns["FullName"].HeaderText = "Họ và tên";
            dgvLichLamViec_tabLich.Columns["TypeSchedule"].HeaderText = "Ca làm";
            dgvLichLamViec_tabLich.Columns["Date"].HeaderText = "Ngày làm";
        }

        private void LoadDGVLich_tabLich(string txtsearch =  null, string cbb = "Tất cả")
        {
            _listLich.Clear();
            var itemLich = _scheduleBLL.SearchShedule(txtsearch, cbb);
            foreach (var item in itemLich)
            {
                _listLich.Add(item);
            }

            SetupDGVLichLamViec();
        }
        private void cbbTypeSchedule_tabLich_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cbbTypeSchedule_tabLich.SelectedItem?.ToString() ?? "";
            string txtsearch = txtTimKiem_tabLich.Text.ToLower().Trim();

            LoadDGVLich_tabLich(txtsearch, selectedType);
        }

        private void cbbRole_tabLich_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cbbRole_tabLich.SelectedItem.ToString();

            var item = _scheduleBLL.GetSheduleByRole(selectedRole);
            _listLich.Clear();
            foreach (var schedule in item)
            {
                _listLich.Add(schedule);
            }
        }

        private void txtTimKiem_tabLich_TextChanged(object sender, EventArgs e)
        {
            string txtsearch = txtTimKiem_tabLich.Text.ToLower().Trim();
            string selectedType = cbbTypeSchedule_tabLich.SelectedItem?.ToString() ?? "";

            LoadDGVLich_tabLich(txtsearch, selectedType);
        }

        private void btnAddLich_tabLich_Click(object sender, EventArgs e)
        {
            string userID = _userBLL.GetALlUsers()
                                    .FirstOrDefault(u => u.FullName == cbbUser_TabLich.SelectedItem.ToString()).UserID;
            decimal hourlyRate = nudHourlyRate_tabLich.Value;
            string selectedType = cbbCaLamViec_tabLich.SelectedItem.ToString();
            DateTime dateTime = dtpDate_tabLich.Value.Date;
            

            _scheduleBLL.AddSchedule(userID, selectedType, dateTime, hourlyRate);

            _listLich.Clear();
            LoadDGVLich_tabLich();
            LoadDGVLuong_tabLuong();
        }

        private void btnDeleteNL_tabDSNL_Click(object sender, EventArgs e)
        {
            if(dgvLichLamViec_tabLich.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn lịch làm việc để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch làm việc này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var selectedRow = dgvLichLamViec_tabLich.SelectedRows[0];
                var scheduleId = selectedRow.Cells["ScheduleID"].Value.ToString();
                _scheduleBLL.DeleteSchedule(scheduleId);
                _listLich.Clear();
                LoadDGVLich_tabLich();
            }

            LoadDGVLuong_tabLuong();
        }


        // tabLuong
        private void TabLuong()
        {
            _listLuong = new BindingList<SalaryDTO>();
            dgvLuong_tabLuong.DataSource = _listLuong;

            LoadYear();
            LoadDGVLuong_tabLuong();
            cbbThang_tabLuong.SelectedIndex = 0;
            cbbNam_tabLuong.SelectedIndex = 0;
        }

        private void LoadYear()
        {
            string currentYear = DateTime.Now.Year.ToString();
            var years = _salaryBLL.GetYearBySalary();

            cbbNam_tabLuong.Items.Clear();

            if (years == null || years.Count == 0)
            {
                // Không có dữ liệu, chỉ add năm hiện tại
                cbbNam_tabLuong.Items.Add(currentYear);
                cbbNam_tabLuong.SelectedIndex = 0;
            }
            else
            {
                cbbNam_tabLuong.Items.AddRange(years.ToArray());
                int idx = cbbNam_tabLuong.Items.IndexOf(currentYear);
                if (idx >= 0)
                    cbbNam_tabLuong.SelectedIndex = idx;
                else
                    cbbNam_tabLuong.SelectedIndex = 0;
            }
        }
        private void SetupDGVLuong()
        {
            dgvLuong_tabLuong.Columns["SalaryID"].HeaderText = "Mã lương";
            dgvLuong_tabLuong.Columns["FullName"].HeaderText = "Họ tên";
            dgvLuong_tabLuong.Columns["HoursWorked"].HeaderText = "Giờ làm";
            dgvLuong_tabLuong.Columns["HourlyRate"].HeaderText = "Lương/giờ";
            dgvLuong_tabLuong.Columns["TotalSalary"].HeaderText = "Tổng lương";
            dgvLuong_tabLuong.Columns["PaymentDate"].HeaderText = "Ngày trả";
            dgvLuong_tabLuong.Columns["Status"].HeaderText = "Trạng thái";        
        }

        private void LoadDGVLuong_tabLuong(string month = "Tất cả", string year = null, string txtSearch = null)
        {
            if (string.IsNullOrEmpty(year))
                year = DateTime.Now.Year.ToString();

            _listLuong.Clear();
            var itemLuong = _salaryBLL.SearchSalary(month, year, txtSearch);
            if (itemLuong != null)
            {
                foreach (var item in itemLuong)
                {
                    _listLuong.Add(item);
                }
            }

            SetupDGVLuong();

            decimal tongQuyLuong = _listLuong.Sum(s => s.TotalSalary);
            decimal tongGioLamViec = _listLuong.Sum(s => s.HoursWorked);

            lblTongQuyLuong_tabLuong.Text = $" {tongQuyLuong:N0} VNĐ";
            lblTongGioLamViec_tabLuong.Text = $" {tongGioLamViec:N2} giờ";
        }

        private void cbbThang_tabLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month = cbbThang_tabLuong.SelectedItem?.ToString() ?? "Tất cả";
            string year = cbbNam_tabLuong.SelectedItem?.ToString() ?? DateTime.Now.Year.ToString();
            string search = txtSearch_TabLuong.Text.Trim();
            _listLuong.Clear();
            LoadDGVLuong_tabLuong(month, year, search);
        }

        private void cbbNam_tabLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month = cbbThang_tabLuong.SelectedItem?.ToString() ?? "Tất cả";
            string year = cbbNam_tabLuong.SelectedItem?.ToString() ?? DateTime.Now.Year.ToString();
            string search = txtSearch_TabLuong.Text.Trim();
            _listLuong.Clear();
            LoadDGVLuong_tabLuong(month, year, search);
        }

        private void txtSearch_TabLuong_TextChanged(object sender, EventArgs e)
        {
            string month = cbbThang_tabLuong.SelectedItem?.ToString() ?? "Tất cả";
            string year = cbbNam_tabLuong.SelectedItem?.ToString() ?? DateTime.Now.Year.ToString();
            string search = txtSearch_TabLuong.Text.Trim();
            _listLuong.Clear();
            LoadDGVLuong_tabLuong(month, year, search);
        }

        private void btnThanhToan_tabLuong_Click(object sender, EventArgs e)
        {
            if (dgvLuong_tabLuong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn lương để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thanh toán lương này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var selectedRow = dgvLuong_tabLuong.SelectedRows[0];
                var salaryId = selectedRow.Cells["SalaryID"].Value.ToString();
                _salaryBLL.UpdateStatusSalary(salaryId);
                _listLuong.Clear();
                LoadDGVLuong_tabLuong();
                MessageBox.Show("Thanh toán lương thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
