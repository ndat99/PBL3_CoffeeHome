using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.DTO.ViewModel;
using PBL3_CoffeeHome.GUI.Admin;
using PBL3_CoffeeHome.BLL;

namespace PBL3_CoffeeHome.GUI.Barista
{
    public partial class ucLichSuHangHoa: UserControl
    {
        private InventoryTransactionBLL _transactionBLL;
        private UserBLL _userBLL;
        private BindingList<TransactionDisplayDTO> _listLSGD;
        public ucLichSuHangHoa()
        {
            _transactionBLL = new InventoryTransactionBLL();
            _userBLL = new UserBLL();
            _listLSGD = new BindingList<TransactionDisplayDTO>();
            InitializeComponent();
            //dgvLSGD.DataSource = _listLSGD;
            dateStart.Value = dateEnd.Value = DateTime.Today;
            LoadLSGD();
            LoadCBB();
            LoadNgayGD();
        }
        private void LoadLSGD()
        {
            List<TransactionDisplayDTO> items = _transactionBLL.GetAllTransaction();
            _listLSGD.Clear();
            dgvLSGD.Rows.Clear();
            foreach (var item in items)
            {
                _listLSGD.Add(item);

                dgvLSGD.Rows.Add(
                    item.ItemID, item.ItemName, item.Quantity,
                    item.Unit, (item.Price * item.Quantity).ToString("N0"), item.Type,
                    _userBLL.GetUserByUsername(item.UserName).FullName,
                    item.TransactionDate.ToString("dd/MM/yyyy")
                );
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
            cboType.Items.Clear();
            cboType.Items.Insert(0, "Tất cả");
            cboType.Items.AddRange(_transactionBLL.GetTypeTransaction().ToArray());
            cboType.SelectedIndex = 0;
        }
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _listLSGD.Clear();
            dgvLSGD.Rows.Clear();
            List<TransactionDisplayDTO> items = _transactionBLL.GetTransactionsByType(cboType.SelectedItem.ToString());
            foreach (var item in items)
            {
                _listLSGD.Add(item);

                dgvLSGD.Rows.Add(
                    item.ItemID, item.ItemName, item.Quantity,
                    item.Unit, (item.Price * item.Quantity).ToString("N0"), item.Type,
                    _userBLL.GetUserByUsername(item.UserName).FullName,
                    item.TransactionDate.ToString("dd/MM/yyyy")
                );
            }

            LoadNgayGD(cboType.SelectedItem.ToString());
        }
        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateEnd.Value < dateStart.Value)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateEnd.Value = dateStart.Value;
                return;
            }
        }
        private void btnThongTinChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvLSGD.SelectedRows.Count == 1)
            {

                int rowIndex = dgvLSGD.SelectedRows[0].Index;
                if (rowIndex < 0 || rowIndex >= _listLSGD.Count) return;

                var selectedItem = _listLSGD[rowIndex];
                if (selectedItem == null) return;
                
                var transactionDate = selectedItem.TransactionDate.Date;
                var itemID = selectedItem.ItemID;

                var BaristaForm = (fPhaChe)this.ParentForm;
                BaristaForm.LoadControlToPanel(new ucDetailLSGD(itemID, transactionDate), BaristaForm.panelChiTiet);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một giao dịch để xem chi tiết.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateStart.Value;
            DateTime endDate = dateEnd.Value;
            string text = txtSearch.Text;

            _listLSGD.Clear();
            dgvLSGD.Rows.Clear();
            List<TransactionDisplayDTO> items = _transactionBLL.SeaechTransaction(text, startDate, endDate);
            foreach (var item in items)
            {
                _listLSGD.Add(item);

                dgvLSGD.Rows.Add(
                    item.ItemID, item.ItemName, item.Quantity,
                    item.Unit, (item.Price * item.Quantity).ToString("N0"), item.Type,
                    _userBLL.GetUserByUsername(item.UserName).FullName,
                    item.TransactionDate.ToString("dd/MM/yyyy")
                );
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadLSGD();
        }
    }
}
