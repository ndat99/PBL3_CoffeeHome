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
using PBL3_CoffeeHome.DTO.ViewModel;

namespace PBL3_CoffeeHome.GUI.Admin
{
    public partial class fCongThuc: Form
    {
        private readonly MenuItemIngredientBLL _menuItemIngredientBLL;
        private readonly MenuItemBLL _menuItemBLL;
        private readonly InventoryBLL _inventoryBLL;
        private BindingSource bindingSource;
        private MenuItems _menuItem;
        private List<MenuItemIngredient> currentIngredients;
        public fCongThuc(MenuItems menuItems)
        {
            InitializeComponent();
            _menuItem = menuItems;

            _menuItemIngredientBLL = new MenuItemIngredientBLL();
            _menuItemBLL = new MenuItemBLL();
            _inventoryBLL = new InventoryBLL();

            SetUpComboBox();
            SetUpDatagridview();

            bindingSource = new BindingSource();
            dgvNguyenLieu.DataSource = bindingSource;
            LoadIngredients();

            txtTenMon.Text = _menuItem.Name;
            txtTenMon.Enabled = false;

            txtDanhMuc.Text = _menuItem.Category;
            txtDanhMuc.Enabled = false;

            txtGia.Text = _menuItem.Price.ToString();
            txtGia.Enabled = false;
        }

        private void SetUpComboBox()
        {
            // Load nguyên liệu từ Inventory vào ComboBox
            var nguyenLieus = _inventoryBLL.GetAllInventory();
            cbNguyenLieu.DataSource = nguyenLieus;
            cbNguyenLieu.DisplayMember = "Name";
            cbNguyenLieu.ValueMember = "ItemID";
        }

        private void SetUpDatagridview()
        {
            // Thiết lập DataGridView
            dgvNguyenLieu.AutoGenerateColumns = false;
            dgvNguyenLieu.Columns.Clear();
            // Thêm các cột vào DataGridView
            dgvNguyenLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên Nguyên Liệu",
                DataPropertyName = "Name",
                ReadOnly = true,
                Width = 200
            });
            dgvNguyenLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Số Lượng",
                DataPropertyName = "QuantityRequired",
                Name = "QuantityRequired",
                ReadOnly = true,
                Width = 100
            });
            dgvNguyenLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Đơn vị",
                DataPropertyName = "Unit",
                ReadOnly = true,
                Width = 100
            });
        }

        private void LoadIngredients()
        {
            var ingredients = _menuItemIngredientBLL.GetMenuItemIngredient(_menuItem.MenuItemID);

            if (ingredients != null && ingredients.Any())
            {
                var viewList = ingredients.Select(i => new IngredientView
                {
                    Name = i.Inventory?.Name ?? "(Không tên)",
                    QuantityRequired = i.QuantityRequired,
                    Unit = i.Unit
                }).ToList();

                bindingSource.DataSource = viewList;
            }
            currentIngredients = ingredients;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenMon.Enabled = true;
            txtGia.Enabled = true;
            txtDanhMuc.Enabled = true;
            dgvNguyenLieu.Columns["QuantityRequired"].ReadOnly = false;
        }   

        private void btnLuu_Click(object sender, EventArgs e)
        {
            _menuItem.Name = txtTenMon.Text;
            _menuItem.Price = decimal.Parse(txtGia.Text);
            _menuItem.Category = txtDanhMuc.Text;
            _menuItemBLL.UpdateMenuItem(_menuItem);

            txtTenMon.Enabled = false;
            txtGia.Enabled = false;
            txtDanhMuc.Enabled = false;

            currentIngredients = _menuItemIngredientBLL.GetMenuItemIngredient(_menuItem.MenuItemID);
            for(int i = 0; i < currentIngredients.Count; i++)
            {
                var ingredient = currentIngredients[i];
                var quantityCell = dgvNguyenLieu.Rows[i].Cells["QuantityRequired"];
                if (quantityCell.Value != null)
                {
                    ingredient.QuantityRequired = decimal.Parse(quantityCell.Value.ToString());
                }
            }
            _menuItemIngredientBLL.SaveMenuItemIngredients(_menuItem.MenuItemID, currentIngredients );
            dgvNguyenLieu.Columns["QuantityRequired"].ReadOnly = true;
        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            Inventory selectedInventory = _inventoryBLL.GetInventoryByID(cbNguyenLieu.SelectedValue.ToString());
            _menuItemIngredientBLL.AddMenuItemIngredient(new MenuItemIngredient
            {
                MenuItemID = _menuItem.MenuItemID,
                Id = _menuItemIngredientBLL.GenerateNewIngredientId(),
                QuantityRequired = 0,
                ItemID = selectedInventory.ItemID,
                Unit = selectedInventory.Unit,
            });
          
            _menuItemIngredientBLL.SaveMenuItemIngredients(_menuItem.MenuItemID, currentIngredients);
            LoadIngredients();
        }

        private void btnXoaNguyenLieu_Click(object sender, EventArgs e)
        {
            _menuItemIngredientBLL.DeleteMenuItemIngredientById(currentIngredients[dgvNguyenLieu.CurrentRow.Index].Id.ToString());
            LoadIngredients();
        }
    }
}
