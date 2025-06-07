using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DTO.ViewModel;
using PBL3_CoffeeHome.GUI.Barista;

namespace PBL3_CoffeeHome.GUI.Admin
{
    public partial class ucDetailLSGD : UserControl
    {
        private readonly InventoryTransactionBLL _inventoryTransactionBLL;
        private string _itemID;
        private string _type;
        private DateTime _transactionID;
        private User _user;
        private BindingList<TransactionInformationDTO> _listDetailTransaction;

        public ucDetailLSGD(string Item, DateTime transactionDate, string Type, User user)
        {
            InitializeComponent();
            _inventoryTransactionBLL = new InventoryTransactionBLL();
            _itemID = Item;
            _transactionID = transactionDate;
            _type = Type;
            _user = user;
        }

        private void ucDetailLSGD_Load(object sender, EventArgs e)
        {
            _listDetailTransaction = new BindingList<TransactionInformationDTO>();

            LoadData();
        }

        private void LoadData()
        {
            List<InventoryTransaction> items = _inventoryTransactionBLL.GetDetailTransaction(_itemID, _transactionID, _type);
            if (items != null)
            {
                foreach (var item in items)
                {
                    dgvDetailTransaction.Rows.Add(item.Inventory.Name, item.Quantity, item.Inventory.Unit, item.TransactionPrice.ToString("N0"), item.User.FullName, item.TransactionDate, item.Note);
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin giao dịch nào.");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (_user.Role == "Admin")
            {
                var AdminForm = (fQuanLy)this.ParentForm;
                AdminForm.LoadControlToPanel(new ucKhoHang(_user ,2), AdminForm.panelChiTiet);
            }
            else if (_user.Role == "Barista")
            {
                var BaristaForm = (fPhaChe)this.ParentForm;
                BaristaForm.LoadControlToPanel(new ucLichSuHangHoa(_user), BaristaForm.panelChiTiet);
            }
        }
    }
}
