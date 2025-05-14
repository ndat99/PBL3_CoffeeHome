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
    public partial class ucDetailNL : UserControl
    {
        private readonly InventoryBLL _inventoryBLL;
        private InventoryDisplayDTO _selectedItem;
        private bool _isEdit;

        public ucDetailNL(InventoryDisplayDTO selectedItem, bool isEdit = false)
        {
            InitializeComponent();
            _inventoryBLL = new InventoryBLL();
            _selectedItem = selectedItem;
            _isEdit = isEdit;
            SetUpForm();
        }

        private void SetUpForm()
        {
            cboCategory.Items.AddRange(_inventoryBLL.GetCategory().ToArray());
            cboUnit.Items.AddRange(_inventoryBLL.GetUnit().ToArray());

            if (_isEdit && _selectedItem != null)
            {
                txtItemID.Text = _selectedItem.ItemID;
                txtName.Text = _selectedItem.Name;
                cboCategory.SelectedItem = _selectedItem.Category;
                cboUnit.SelectedItem = _selectedItem.Unit;
                nudQuantity.Text = _selectedItem.Quantity.ToString();
                numMinQuantity.Value = _selectedItem.MinimumQuantity;
                nudCostPrice.Value = _selectedItem.CostPrice;
                dtpExpirationDate.Value = _selectedItem.ExpirationDate;
            }
            else
            {
                txtItemID.Text = _inventoryBLL.GenerateNewItemID();
                dtpExpirationDate.Value = DateTime.Now.AddMonths(1);
                nudQuantity.Text = "0";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var AdminForm = (fQuanLy)this.ParentForm;
            AdminForm.LoadControlToPanel(new ucKhoHang(), AdminForm.panelChiTiet);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || cboCategory.SelectedItem == null || cboUnit.SelectedItem == null || numMinQuantity.Value < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và hợp lệ thông tin nguyên liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new Inventory
            {
                ItemID = txtItemID.Text,
                Name = txtName.Text.Trim(),
                Category = cboCategory.SelectedItem.ToString(),
                Unit = cboUnit.SelectedItem.ToString(),

                MinimumQuantity = numMinQuantity.Value,
                CostPrice = nudCostPrice.Value,
                ExpirationDate = dtpExpirationDate.Value
            };
            bool result;
            if (_isEdit)
            {
                result = _inventoryBLL.UpdateInventory(item);
            }
            else
            {
                result = _inventoryBLL.AddInventory(item);
            }
            if (result)
            {
                MessageBox.Show("Lưu thông tin nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var AdminForm = (fQuanLy)this.ParentForm;
                AdminForm.LoadControlToPanel(new ucKhoHang(), AdminForm.panelChiTiet);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu thông tin nguyên liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
