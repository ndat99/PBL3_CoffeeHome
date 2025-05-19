using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Windows.Forms;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DTO.ViewModel;
using PBL3_CoffeeHome.GUI.Admin;

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucKhoHang : UserControl
    {

        private readonly InventoryBLL _inventoryBLL;
        private readonly InventoryTransactionBLL _transactionBLL;

        private BindingList<InventoryDisplayDTO> _listDSNL;
        private BindingList<ImportInventoryDTO> _listPhieuNhap;
        private BindingList<TransactionDisplayDTO> _listLSGD;

        string _userID;
        public ucKhoHang(string userID)
        {
            InitializeComponent();
            _inventoryBLL = new InventoryBLL();
            _transactionBLL = new InventoryTransactionBLL();
            _userID = userID;
        }

        public ucKhoHang(int TabIndex)
        {
            InitializeComponent();
            tabControlMain.SelectedIndex = TabIndex;

            _inventoryBLL = new InventoryBLL();
            _transactionBLL = new InventoryTransactionBLL();
        }


        private void ucKhoHang_Load(object sender, EventArgs e)
        {
            TabDSNL();
            TabNhapKho();
            TabLSGD();
        }

        // tab DSNL
        private void TabDSNL()
        {
            _listDSNL = new BindingList<InventoryDisplayDTO>();
            dgvDSNL.DataSource = _listDSNL;

            LoadCategory_tabDSNL();
            LoadCountDSNL_tabDSNL();
            LoadDSNL();
        }


        private void LoadCategory_tabDSNL()
        {
            cboDanhMucNL_tabDSNL.Items.Clear();
            cboDanhMucNL_tabDSNL.Items.Insert(0, "Tất cả");
            cboDanhMucNL_tabDSNL.Items.AddRange(_inventoryBLL.GetCategory().ToArray());
            cboDanhMucNL_tabDSNL.SelectedIndex = 0;
        }

        private void LoadCountDSNL_tabDSNL()
        {
            btnLowStock_tabDSNL.Text = $"Tồn kho thấp: {_inventoryBLL.GetLowStock().Count}";
            btnExpiring_tabDSNL.Text = $"Sắp hết hạn: {_inventoryBLL.GetExpiring(7).Count}";
        }

        private void LoadDSNL(string category = "Tất cả", string keyword = null)
        {
            List<InventoryDisplayDTO> items = _inventoryBLL.SearchInventory(category, keyword).Select(_inventoryBLL.InventoryDisplay).ToList();
            _listDSNL.Clear();
            foreach (var item in items)
            {
                _listDSNL.Add(item);
            }
        }

        private void btnReset_tabDSNL_Click(object sender, EventArgs e)
        {
            cboDanhMucNL_tabDSNL.SelectedIndex = 0;
            txtSearchNL_tabDSNL.Clear();
            btnLowStock_tabDSNL.Text = $"Tồn kho thấp: {_inventoryBLL.GetLowStock().Count}";
            btnExpiring_tabDSNL.Text = $"Sắp hết hạn: {_inventoryBLL.GetExpiring(7).Count}";

            LoadDSNL();
            LoadCountDSNL_tabDSNL();
        }

        private void btnSubmit_tabDSNL_Click(object sender, EventArgs e)
        {
            LoadDSNL(cboDanhMucNL_tabDSNL.SelectedItem.ToString(), txtSearchNL_tabDSNL.Text);
        }

        private void btnLowStock_tabDSNL_Click(object sender, EventArgs e)
        {
            List<InventoryDisplayDTO> lowStock = _inventoryBLL.GetLowStock().Select(_inventoryBLL.InventoryDisplay).ToList();
            _listDSNL.Clear();
            foreach (var item in lowStock) _listDSNL.Add(item);
        }

        private void btnExpiring_tabDSNL_Click(object sender, EventArgs e)
        {
            List<InventoryDisplayDTO> expiring = _inventoryBLL.GetExpiring(7).Select(_inventoryBLL.InventoryDisplay).ToList();
            _listDSNL.Clear();
            foreach (var item in expiring) _listDSNL.Add(item);
        }

        private void btnAddNL_TabDSNL_Click(object sender, EventArgs e)
        {
            var AdminForm = (fQuanLy)this.ParentForm;
            AdminForm.LoadControlToPanel(new ucDetailNL(null, false), AdminForm.panelChiTiet);
        }

        private void btnUpdateNL_tabDSNL_Click(object sender, EventArgs e)
        {
            if (dgvDSNL.SelectedRows.Count == 1)
            {
                var selectedItem = (InventoryDisplayDTO)dgvDSNL.SelectedRows[0].DataBoundItem;
                if (selectedItem == null) return;
                var AdminForm = (fQuanLy)this.ParentForm;
                AdminForm.LoadControlToPanel(new ucDetailNL(selectedItem, true), AdminForm.panelChiTiet);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteNL_tabDSNL_Click(object sender, EventArgs e)
        {
            if (dgvDSNL.SelectedRows.Count == 1)
            {
                var selectedItem = (InventoryDisplayDTO)dgvDSNL.SelectedRows[0].DataBoundItem;
                if (selectedItem == null) return;
                if (MessageBox.Show($"Bạn có chắc muốn xóa nguyên liệu '{selectedItem.Name}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (_inventoryBLL.DeleteInventory(selectedItem.ItemID))
                    {
                        MessageBox.Show("Xóa nguyên liệu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSNL(cboDanhMucNL_tabDSNL.SelectedItem.ToString(), txtSearchNL_tabDSNL.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Xóa nguyên liệu thất bại. Nguyên liệu có thể đang được sử dụng hoặc có lỗi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKiemKeNL_tabDSNL_Click(object sender, EventArgs e)
        {
            var AdminForm = (fQuanLy)this.ParentForm;
            AdminForm.LoadControlToPanel(new ucDetailKiemKho(), AdminForm.panelChiTiet);
        }

        // Tab Nhap Kho
        private void TabNhapKho()
        {
            _listPhieuNhap = new BindingList<ImportInventoryDTO>();
            dgvNhapKho.DataSource = _listPhieuNhap;

            LoadCategory_TabNhapKho();
            LoadNameInventory_TabNhapKho();
            LoadUnit_tabNhapKho();
        }

        private void LoadCategory_TabNhapKho()
        {
            cboCategoryNL_tabNhapKho.Items.Clear();
            cboCategoryNL_tabNhapKho.Items.Insert(0, "Tất cả");
            cboCategoryNL_tabNhapKho.Items.AddRange(_inventoryBLL.GetCategory().ToArray());
            cboCategoryNL_tabNhapKho.SelectedIndex = 0;
        }

        private void LoadNameInventory_TabNhapKho()
        {
            cboNameNL_tabNhapKho.Items.Clear();
            string selectedCategory = cboCategoryNL_tabNhapKho.SelectedItem?.ToString();
            var inventoryList = selectedCategory == "Tất cả" ? _inventoryBLL.GetAllInventory() : _inventoryBLL.GetInventoryByCategory(selectedCategory);

            cboNameNL_tabNhapKho.Items.AddRange(inventoryList.Select(i => i.Name).ToArray());
            cboNameNL_tabNhapKho.SelectedIndex = 0;
        }

        private void LoadUnit_tabNhapKho()
        {
            cboDonVi_TabNhapKho.Items.Clear();
            cboDonVi_TabNhapKho.Items.AddRange(_inventoryBLL.GetUnit().ToArray());

            var selectedName = cboNameNL_tabNhapKho.SelectedItem.ToString();
            var inventoryItem = _inventoryBLL.GetAllInventory().FirstOrDefault(i => i.Name == selectedName);
            cboDonVi_TabNhapKho.SelectedItem = inventoryItem.Unit;
        }

        private void cboNameNL_tabNhapKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUnit_tabNhapKho();
        }
        private void cboCategoryNL_tabNhapKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNameInventory_TabNhapKho();
        }

        private void dtpHSDNL_tabNhapKho_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHSDNL_tabNhapKho.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpHSDNL_tabNhapKho.Value = DateTime.Now.AddDays(1);
                return;
            }
        }
        private void btnXacNhan_tabNhapKho_Click(object sender, EventArgs e)
        {
            if (cboNameNL_tabNhapKho.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectName = cboNameNL_tabNhapKho.SelectedItem.ToString();
            var inventoryItem = _inventoryBLL.GetAllInventory().FirstOrDefault(i => i.Name == selectName);
            if (inventoryItem == null)
            {
                MessageBox.Show("Nguyên liệu không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudQuantityNL_tabNhapKho.Value <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingItem = _listPhieuNhap.FirstOrDefault(t => t.Name == selectName);
            if (existingItem == null)
            {
                var newImportInventory = new ImportInventoryDTO
                {
                    ItemID = inventoryItem.ItemID,
                    Name = inventoryItem.Name,
                    Quantity = nudQuantityNL_tabNhapKho.Value,
                    Unit = inventoryItem.Unit,
                    Price = nudCostPriceNL_tabNhapKho.Value,
                    ExpirationDate = dtpHSDNL_tabNhapKho.Value,
                    UserID = _userID,
                    Note = txtGhiChu_tabNhapKho.Text
                };

                _listPhieuNhap.Add(newImportInventory);
                MessageBox.Show("Thêm vào danh sách phiếu nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                existingItem.Quantity += nudQuantityNL_tabNhapKho.Value;
                dgvNhapKho.Refresh();
                MessageBox.Show("Cập nhật và danh sách phiếu nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHoanTac_tabNhapKho_Click(object sender, EventArgs e)
        {
            if (dgvNhapKho.SelectedRows.Count == 1)
            {
                var selectedItem = (ImportInventoryDTO)dgvNhapKho.SelectedRows[0].DataBoundItem;
                if (selectedItem == null) return;
                if (MessageBox.Show($"Bạn có muốn hoàn tác.'{selectedItem.Name}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _listPhieuNhap.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuuPhieuNhap_tabNhapKho_Click(object sender, EventArgs e)
        {
            if (_listPhieuNhap.Count == 0)
            {
                MessageBox.Show("Danh sách phiếu nhập trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = true;
            foreach (var item in _listPhieuNhap)
            {
                success &= _transactionBLL.StockIn(item.ItemID, item.Quantity, item.UserID, item.Price, item.ExpirationDate, item.Note);
            }

            if (success)
            {
                MessageBox.Show("Nhập kho thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _listPhieuNhap.Clear();
                LoadDSNL();
            }
            else
            {
                MessageBox.Show("Nhập kho thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Tab LSGD
        private void TabLSGD()
        {
            _listLSGD = new BindingList<TransactionDisplayDTO>();
            dgvLSGD.DataSource = _listLSGD;

            dateStart_TabLSGD.Value = dateEnd_TabLSGD.Value = DateTime.Today;
            LoadLSGD();
            LoadCBB();
            LoadNgayGD();
        }



        private void LoadLSGD()
        {
            List<TransactionDisplayDTO> items = _transactionBLL.GetAllTransaction();
            _listLSGD.Clear();
            foreach (var item in items)
            {
                _listLSGD.Add(item);
            }
        }

        private void LoadNgayGD(string type = null)
        {
            dgvNgayGD.Rows.Clear();
            List<DateTime> items = _transactionBLL.GetTransactionsByType(type).Select(t => t.TransactionDate).Distinct().ToList();

            foreach (var item in items)
            {
                dgvNgayGD.Rows.Add(item.ToString("dd/MM/yyyy"));
            }
        }

        private void LoadCBB()
        {
            cboType_tabLSGD.Items.Clear();
            cboType_tabLSGD.Items.Insert(0, "Tất cả");
            cboType_tabLSGD.Items.AddRange(_transactionBLL.GetTypeTransaction().ToArray());
            cboType_tabLSGD.SelectedIndex = 0;
        }

        private void cboType_tabLSGD_SelectedIndexChanged(object sender, EventArgs e)
        {

            _listLSGD.Clear();
            List<TransactionDisplayDTO> items = _transactionBLL.GetTransactionsByType(cboType_tabLSGD.SelectedItem.ToString());
            foreach (var item in items)
            {
                _listLSGD.Add(item);
            }

            LoadNgayGD(cboType_tabLSGD.SelectedItem.ToString());
        }
        private void dateEnd_TabLSGD_ValueChanged(object sender, EventArgs e)
        {
            if (dateEnd_TabLSGD.Value < dateStart_TabLSGD.Value)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateEnd_TabLSGD.Value = dateStart_TabLSGD.Value;
                return;
            }
        }
        private void btnSubmit_tabLSGD_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateStart_TabLSGD.Value;
            DateTime endDate = dateEnd_TabLSGD.Value;
            string txtSearch = txtSearch_tabLSGD.Text;

            _listLSGD.Clear();
            List<TransactionDisplayDTO> items = _transactionBLL.SeaechTransaction(txtSearch, startDate, endDate);
            foreach (var item in items)
            {
                _listLSGD.Add(item);
            }
        }
        private void btnReset_tabLSGD_Click(object sender, EventArgs e)
        {
            txtSearch_tabLSGD.Clear();
            LoadLSGD();
        }

        private void btnDetailTransaction_tabLSGD_Click(object sender, EventArgs e)
        {
            if (dgvLSGD.SelectedRows.Count == 1)
            {
                var selectedItem = (TransactionDisplayDTO)dgvLSGD.SelectedRows[0].DataBoundItem;
                if (selectedItem == null) return;
                var transactionDate = selectedItem.TransactionDate.Date;
                var itemID = selectedItem.ItemID;
                var type = selectedItem.Type;
                string user = "admin";

                var AdminForm = (fQuanLy)this.ParentForm;
                AdminForm.LoadControlToPanel(new ucDetailLSGD(itemID, transactionDate, type, user), AdminForm.panelChiTiet);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một giao dịch để xem chi tiết.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
