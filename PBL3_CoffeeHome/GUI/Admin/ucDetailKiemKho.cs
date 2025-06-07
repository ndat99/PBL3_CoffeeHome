//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using PBL3_CoffeeHome.BLL;
//using PBL3_CoffeeHome.DTO.ViewModel;

//namespace PBL3_CoffeeHome.GUI.Admin
//{
//    public partial class ucDetailKiemKho : UserControl
//    {
//        private readonly InventoryTransactionBLL _transactionBLL;
//        private readonly InventoryBLL _inventoryBLL;
//        private BindingList<InventoryCheckDTO> _listKiemke;
//        private User _user;
//        public ucDetailKiemKho(User user)
//        {
//            InitializeComponent();
//            _transactionBLL = new InventoryTransactionBLL();
//            _inventoryBLL = new InventoryBLL();
//            _user = user;
//        }

//        private void ucDetailDiemKho_Load(object sender, EventArgs e)
//        {
//            _listKiemke = new BindingList<InventoryCheckDTO>();
//            dgvListKiemKe.DataSource = _listKiemke;

//            LoadInventoryData();
//        }

//        private void LoadInventoryData(DateTime? fiterDate = null)
//        {
//            var transactions = _transactionBLL.GetTransactionStockOut();
//            if (fiterDate == null)
//            {
//                fiterDate = DateTime.Now.Date;
//                transactions = transactions.Where(t => t.TransactionDate == fiterDate.Value.Date).ToList();
//            }
//            else
//            {
//                transactions = transactions.Where(t => t.TransactionDate == fiterDate.Value.Date).ToList();
//            }
//            dgvStockOut.DataSource = transactions;
//            dgvStockOut.Columns["TransactionDate"].Visible = false;
//        }

//        private void dtpDSNLbyDate_ValueChanged(object sender, EventArgs e)
//        {
//            DateTime fiterDate = dtpDSNLbyDate.Value.Date;
//            LoadInventoryData(fiterDate);
//        }

//        private void btnThucHienKiemKe_Click(object sender, EventArgs e)
//        {
//            if (dgvStockOut.SelectedRows.Count == 1)
//            {
//                txtNameNL.Text = dgvStockOut.SelectedRows[0].Cells["Name"].Value.ToString();
//                nudQuantityNL.Value = (decimal)dgvStockOut.SelectedRows[0].Cells["Quantity"].Value;
//                nudQuantityThucTe.Value = (decimal)dgvStockOut.SelectedRows[0].Cells["Quantity"].Value;
//            }
//        }

//        private void btnThemVaoDS_Click(object sender, EventArgs e)
//        {
//            var inventoryItem = _inventoryBLL.GetInventoryByName(txtNameNL.Text);
//            if (inventoryItem == null)
//            {
//                MessageBox.Show("Nguyên liệu không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            if (nudQuantityThucTe.Value < 0)
//            {
//                MessageBox.Show("Số lượng không được âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            if (nudQuantityNL.Value - nudQuantityThucTe.Value == 0)
//            {
//                MessageBox.Show("Không có sự thay đổi về số lượng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            var newCheckInventory = new InventoryCheckDTO
//            {
//                ItemID = inventoryItem.ItemID,
//                Name = inventoryItem.Name,
//                Category = inventoryItem.Category,
//                SystemQuantity = nudQuantityNL.Value,
//                ActualQuantity = nudQuantityThucTe.Value,
//                Unit = inventoryItem.Unit,
//                UserID = "USR001",
//                Note = txtGhiChu.Text
//            };

//            _listKiemke.Add(newCheckInventory);
//            MessageBox.Show("Thêm vào danh sách phiếu kiểm kê thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }
//        private void btnHoanTac_Click(object sender, EventArgs e)
//        {
//            if (dgvListKiemKe.SelectedRows.Count == 1)
//            {
//                var selectedItem = (InventoryCheckDTO)dgvListKiemKe.SelectedRows[0].DataBoundItem;
//                if (selectedItem == null) return;
//                if (MessageBox.Show($"Bạn có muốn hoàn tác.'{selectedItem.Name}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//                {
//                    _listKiemke.Remove(selectedItem);
//                    MessageBox.Show("Hoàn tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//            }
//            else
//            {
//                MessageBox.Show("Vui lòng chọn một nguyên liệu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            }
//        }

//        private void btnLuu_Click(object sender, EventArgs e)
//        {
//            if (_listKiemke.Count == 0)
//            {
//                MessageBox.Show("Danh sách phiếu kiểm kê trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            bool success = true;
//            foreach (var item in _listKiemke)
//            {
//                MessageBox.Show($"ItemID: {item.ItemID}, UserID: {item.UserID}, Difference: {item.Difference}");
//                success &= _transactionBLL.AuditInventory(item.UserID, item.ItemID, item.Difference, item.Note);
//            }

//            if (success)
//            {
//                MessageBox.Show("Kiểm kê kho thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                var AdminForm = (fQuanLy)this.ParentForm;
//                AdminForm.LoadControlToPanel(new ucKhoHang(0), AdminForm.panelChiTiet);
//                _listKiemke.Clear();
//            }
//            else
//            {
//                MessageBox.Show("Kiểm kê kho thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btnExit_Click(object sender, EventArgs e)
//        {
//            var AdminForm = (fQuanLy)this.ParentForm;
//            AdminForm.LoadControlToPanel(new ucKhoHang(0), AdminForm.panelChiTiet);
//        }


//    }
//}
