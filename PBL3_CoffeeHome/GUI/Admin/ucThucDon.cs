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
using PBL3_CoffeeHome.GUI.Admin;

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucThucDon : UserControl
    {
        private readonly MenuItemBLL _menuItemBLL;
        private BindingSource bindingSource;
        public ucThucDon()
        {
            InitializeComponent();
            _menuItemBLL = new MenuItemBLL();
            List<string> danhMuc = _menuItemBLL.GetAllMenuCategory();

            // Thêm "Tất cả" vào đầu danh sách
            danhMuc.Insert(0, "All");

            cBDanhMuc1.DataSource = danhMuc;
            bindingSource = new BindingSource();

            SetupDataGridView();
            dgvThucDon.DataSource = bindingSource;

            LoadData();
        }

        public void LoadData()
        {
            try
            {
                List<MenuItems> menuItems = _menuItemBLL.GetAllMenuItems();
                if (menuItems != null && menuItems.Any())
                {
                    bindingSource.DataSource = menuItems;
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

        public void LoadData(string searchTerm)
        {

            List<MenuItems> searchResult;
            string searchText = txtTimKiem.Text.Trim();
            searchResult = _menuItemBLL.SearchMenuItems(searchText);
            bindingSource.DataSource = searchResult;
            bindingSource.ResetBindings(false);
        }

        public void LoadData(string searchTerm, string category)
        {
            List<MenuItems> searchResult;

            searchResult = _menuItemBLL.SearchMenuItems(searchTerm, category);
            bindingSource.DataSource = searchResult;
            bindingSource.ResetBindings(false);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            fThemMon f = new fThemMon(LoadData);
            f.Show();
        }

        private void SetupDataGridView()
        {
            // Tắt tự động tạo cột
            dgvThucDon.AutoGenerateColumns = false;

            // Không cho phép thêm hàng mới
            dgvThucDon.AllowUserToAddRows = false;

            dgvThucDon.ReadOnly = true;
            dgvThucDon.AllowUserToDeleteRows = false;
            dgvThucDon.MultiSelect = false;
            dgvThucDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThucDon.DataSourceChanged += (s, e) => dgvThucDon.Refresh();


            // Thiết lập các cột cho DataGridView
            dgvThucDon.Columns.AddRange(new DataGridViewColumn[]
            {
            new DataGridViewTextBoxColumn
            {
                Name = "MenuItemID",
                HeaderText = "Mã món",
                DataPropertyName = "MenuItemID",
                Width = 80
            },
            new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Tên món",
                DataPropertyName = "Name",
                Width = 120
            },
            new DataGridViewTextBoxColumn
            {
                Name = "Category",
                HeaderText = "Danh mục",
                DataPropertyName = "Category",
                Width = 150
            },
            new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Giá",
                DataPropertyName = "Price",
                Width = 100
            },
            });
        }


        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cBDanhMuc1.SelectedItem.ToString() == "All")
            {
                LoadData(txtTimKiem.Text.Trim());
            }
            else LoadData(txtTimKiem.Text.Trim(), cBDanhMuc1.SelectedItem.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MenuItems menuItemSelected = dgvThucDon.CurrentRow.DataBoundItem as MenuItems;

            if (menuItemSelected == null)
            {
                MessageBox.Show("Vui lòng chọn một món để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DialogResult.No == MessageBox.Show($"Bạn có chắc chắn muốn xóa món {menuItemSelected.Name} không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)) return;
            else
            {
                _menuItemBLL.DeleteMenuItem(menuItemSelected.MenuItemID);
                LoadData();
            }

        }
    }
}
