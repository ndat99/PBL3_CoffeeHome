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
using PBL3_CoffeeHome.DAL.Repository;
using System.IO;

namespace PBL3_CoffeeHome.GUI.Admin
{
    public partial class fCongThuc : Form
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

            btnUpLoad.Enabled = false;
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
            btnUpLoad.Enabled = true;
            dgvNguyenLieu.Columns["QuantityRequired"].ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                _menuItem.Name = txtTenMon.Text;
                _menuItem.Price = decimal.Parse(txtGia.Text);
                _menuItem.Category = txtDanhMuc.Text;
                _menuItemBLL.UpdateMenuItem(_menuItem);

                txtTenMon.Enabled = false;
                txtGia.Enabled = false;
                txtDanhMuc.Enabled = false;

                currentIngredients = _menuItemIngredientBLL.GetMenuItemIngredient(_menuItem.MenuItemID);
                for (int i = 0; i < currentIngredients.Count; i++)
                {
                    var ingredient = currentIngredients[i];
                    var quantityCell = dgvNguyenLieu.Rows[i].Cells["QuantityRequired"];
                    if (quantityCell.Value != null)
                    {
                        ingredient.QuantityRequired = decimal.Parse(quantityCell.Value.ToString());
                    }
                }
                _menuItemIngredientBLL.SaveMenuItemIngredients(_menuItem.MenuItemID, currentIngredients);
                dgvNguyenLieu.Columns["QuantityRequired"].ReadOnly = true;
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Định dạng không hợp lệ: " + fe.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show("Thiếu dữ liệu hoặc chưa chọn dòng: " + ne.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            try
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
            catch (FormatException fe)
            {
                MessageBox.Show("Định dạng không hợp lệ: " + fe.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show("Thiếu dữ liệu hoặc chưa chọn dòng: " + ne.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNguyenLieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                _menuItemIngredientBLL.DeleteMenuItemIngredientById(
                    currentIngredients[dgvNguyenLieu.CurrentRow.Index].Id.ToString()
                );
                LoadIngredients();
            }
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = ofd.FileName;
                    string fileName = Path.GetFileName(selectedFile);
                    string destFolder = Path.Combine(Application.StartupPath, "MenuImages");

                    if (!Directory.Exists(destFolder))
                        Directory.CreateDirectory(destFolder);

                    string destFile = Path.Combine(destFolder, fileName);

                    File.Copy(selectedFile, destFile, overwrite: true);

                    // Lưu tên file (tương đối) vào DB
                    string relativePath = fileName;

                    // Gán lại cho đối tượng _menuItem
                    _menuItem.ImagePath = relativePath;

                    // Update vào database
                    _menuItemBLL.UpdateMenuItem(_menuItem);

                    MessageBox.Show("Đã lưu ảnh thành công!", "OK");
                }
            }
        }
    }
}
