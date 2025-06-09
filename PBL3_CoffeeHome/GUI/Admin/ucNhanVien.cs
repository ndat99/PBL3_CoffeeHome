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

namespace PBL3_CoffeeHome.GUI.Admin
{
    public partial class ucNhanVien : UserControl
    {
        private readonly ScheduleBLL _scheduleBLL;
        private readonly UserBLL _userBLL;

        private BindingList<Schedule> _listLich;

        private readonly string _userId;
        public ucNhanVien()
        {
            InitializeComponent();
            _scheduleBLL = new ScheduleBLL();
            _userBLL = new UserBLL();
        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            TabNhanVien();
            TabLich();
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

        private void LoadDGVLich_tabLich()
        {
            var itemLich = _scheduleBLL.GetAllSchedule();
            foreach(var item in itemLich)
            {
                _listLich.Add(item);
            }
        }
        private void cbbTypeSchedule_tabLich_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtTimKiem_tabLich_TextChanged(object sender, EventArgs e)
        {
            string txtsearch = txtTimKiem_tabLich.Text.ToLower().Trim();
            string txtCbbitemTypeSchedule = cbbTypeSchedule_tabLich.SelectedItem.ToString();
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

        
    }
}
