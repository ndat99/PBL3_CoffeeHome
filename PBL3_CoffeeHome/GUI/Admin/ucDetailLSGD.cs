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
    public partial class ucDetailLSGD : UserControl
    {
        private readonly InventoryTransactionBLL _inventoryTransactionBLL;

        private string _itemID;
        private DateTime  _transactionID;
        private BindingList<TransactionInformationDTO> _listDetailTransaction;

        public ucDetailLSGD(string Item, DateTime transactionDate)
        {
            InitializeComponent();
            _inventoryTransactionBLL = new InventoryTransactionBLL();
            _itemID = Item;
            _transactionID = transactionDate;
        }

        private void ucDetailLSGD_Load(object sender, EventArgs e)
        {
            dgvDetailTransaction.DataSource = _listDetailTransaction;

            LoadData();
        }

        private void LoadData()
        {
            List<InventoryTransaction> items = _inventoryTransactionBLL.GetInformationTransaction(_itemID, _transactionID);
            if (items != null)
            {
                foreach (var item in items)
                {
                    dgvDetailTransaction.Rows.Add(item.Inventory.Name, item.Inventory.Category, item.Quantity, item.Inventory.Unit, item.TransactionPrice, item.User.FullName, item.TransactionDate, item.Note);
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin giao dịch nào.");
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            var AdminForm = (fQuanLy)this.ParentForm;
            AdminForm.LoadControlToPanel(new ucKhoHang(), AdminForm.panelChiTiet);
        }
    }
}
