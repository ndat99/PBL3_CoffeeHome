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
using PBL3_CoffeeHome.DTO.ViewModel;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.GUI.Barista
{
    public partial class ucNguyenVatLieu : UserControl
    {
        private readonly InventoryTransactionBLL _transactionBLL;
        private readonly InventoryBLL _inventoryBLL;
        private BindingList<InventoryCheckDTO> _listKiemke;
        private User _barista;
        public ucNguyenVatLieu(User barista)
        {
            InitializeComponent();
            _transactionBLL = new InventoryTransactionBLL();
            _inventoryBLL = new InventoryBLL();
            _listKiemke = new BindingList<InventoryCheckDTO>();
            _barista = barista;
        }

        private void ucNguyenVatLieu_Load(object sender, EventArgs e)
        {
            _listKiemke = new BindingList<InventoryCheckDTO>(); 
            LoadInventoryData();
        }

        public void LoadInventoryData(DateTime? filterDate = null)
        {
            var transactions = _transactionBLL.GetTransactionStockOut();
            if(filterDate == null) 
            { 
                filterDate = DateTime.Now.Date;
                transactions = transactions.Where(t => t.TransactionDate == DateTime.Now.Date).ToList();
            }
            else
            {
                transactions = transactions.Where(t => t.TransactionDate == filterDate.Value).ToList();
            }

            dgvStockOut.Rows.Clear();
            foreach (var transaction in transactions)
            {
                dgvStockOut.Rows.Add(
                    transaction.Name,
                    transaction.Quantity,
                    transaction.Unit
                );
            }
        }

        private void dtpDSNLbyDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime filterDate = dtpDSNLbyDate.Value.Date;
            LoadInventoryData(filterDate);
        }

        private void btnThucHienKiemKe_Click(object sender, EventArgs e)
        {
            if (dgvStockOut.SelectedRows.Count == 1)
            {
                txtNameNL.Text = dgvStockOut.SelectedRows[0].Cells[0].Value.ToString();
                txtQuantityNL.Text = dgvStockOut.SelectedRows[0].Cells[1].Value.ToString();
                nudQuantityThucTe.Value = (decimal)dgvStockOut.SelectedRows[0].Cells[1].Value;
            }
        }
        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            var inventoryItem = _inventoryBLL.GetInventoryByName(txtNameNL.Text);
            if (inventoryItem == null)
            {
                MessageBox.Show("Nguyên liệu không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudQuantityThucTe.Value < 0)
            {
                MessageBox.Show("Số lượng không được âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal quantityNL = decimal.Parse(txtQuantityNL.Text);
            if (quantityNL - nudQuantityThucTe.Value == 0)
            {
                MessageBox.Show("Không có sự thay đổi về số lượng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newCheckInventory = new InventoryCheckDTO
            {
                ItemID = inventoryItem.ItemID,
                Name = inventoryItem.Name,
                Category = inventoryItem.Category,
                SystemQuantity = quantityNL,
                ActualQuantity = nudQuantityThucTe.Value,
                Unit = inventoryItem.Unit,
                UserID = _barista.UserID,
                Note = txtGhiChu.Text
            };

            _listKiemke.Add(newCheckInventory);
            dgvListKiemKe.Rows.Add(
                newCheckInventory.Name,
                newCheckInventory.Category,
                newCheckInventory.SystemQuantity,
                newCheckInventory.ActualQuantity,
                newCheckInventory.Unit,
                newCheckInventory.UserID,
                newCheckInventory.Note,
                newCheckInventory.Difference
            );
            MessageBox.Show("Thêm vào danh sách phiếu kiểm kê thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnHoanTac_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_listKiemke.Count == 0)
            {
                MessageBox.Show("Danh sách phiếu kiểm kê trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = true;
            foreach (var item in _listKiemke)
            {
                success &= _transactionBLL.AuditInventory(item.UserID, item.ItemID, item.Difference, item.Note);
            }
            if (success)
            {
                MessageBox.Show("Kiểm kê kho thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _listKiemke.Clear();
                dgvListKiemKe.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Kiểm kê kho thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
