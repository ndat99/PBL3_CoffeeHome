using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.GUI.Admin
{
    public partial class ucNhanVien : UserControl
    {
        private readonly ScheduleBLL _scheduleBLL;
        private readonly SalaryBLL _salaryBLL;
        private readonly UserBLL _userBLL;

        private BindingList<Schedule> _listLich;
        private BindingList<Salary> _listLuong;

        private readonly string _userId;
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

        }

        // tabLuong 
        private void TabLich()
        {
            _listLich = new BindingList<Schedule>();
            dgvLichLamViec_tabLich.DataSource = _listLich;

            LoadUser_tabLich();
            LoadDGVLich_tabLich();
            cbbCaLamViec_tabLich.SelectedIndex = 0;
            cbbTypeSchedule_tabLich.SelectedIndex = 0;
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
      
        private void LoadDGVLich_tabLich(string txtsearch =  null, string cbb = "Tất cả")
        {
            _listLich.Clear();
            var itemLich = _scheduleBLL.SearchShedule(txtsearch, cbb);
            foreach (var item in itemLich)
            {
                _listLich.Add(item);
            }
        }
        private void cbbTypeSchedule_tabLich_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cbbTypeSchedule_tabLich.SelectedItem?.ToString() ?? "";
            string txtsearch = txtTimKiem_tabLich.Text.ToLower().Trim();

            LoadDGVLich_tabLich(txtsearch, selectedType);
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
        }

        private void btnDeleteNL_tabDSNL_Click(object sender, EventArgs e)
        {

        }
        // tabLuong


        private void TabLuong()
        {
            _listLuong = new BindingList<Salary>();
            dgvLuong_tabLuong.DataSource = _listLuong;

            LoadYear();
            LoadDGVLuong_tabLuong();
            cbbThang_tabLuong.SelectedIndex = 0;
            cbbNam_tabLuong.SelectedIndex = 0;
        }

        private void LoadYear()
        {
            cbbNam_tabLuong.Items.Clear();
            cbbNam_tabLuong.Items.AddRange(_salaryBLL.GetYearBySalary().ToArray());
        }

        private void LoadDGVLuong_tabLuong(string month = "Tất cả", string year = null, string txtSearch = null)
        {
            if (string.IsNullOrEmpty(year))
                year = DateTime.Now.Year.ToString();

            var itemLuong = _salaryBLL.SearchSalary(month, year, txtSearch);
            if (itemLuong != null)
            {
                foreach (var item in itemLuong)
                {
                    _listLuong.Add(item);
                }
            }
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

       
    }
}
