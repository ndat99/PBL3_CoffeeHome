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

namespace PBL3_CoffeeHome.GUI.Admin
{
    public partial class fThemMon : Form
    {
        public delegate void MyDel(string searchTerm);
        public MyDel d { get; set; }
        private readonly MenuItemBLL _menuItemBLL;
        public fThemMon(MyDel d)
        {
            InitializeComponent();
            this.d = d;
            _menuItemBLL = new MenuItemBLL();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                MenuItems menuItem = new MenuItems
                {
                    MenuItemID = _menuItemBLL.GenerateNewMenuItemsId(),
                    Name = txtTenMon.Text,
                    Price = decimal.Parse(txtGia.Text),
                    Category = txtDanhMuc.Text,
                    IsAvailable = true,
                };
                _menuItemBLL.AddMenuItem(menuItem);
                d("");
                this.Close();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Định dạng không hợp lệ: " + fe.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show("Thiếu dữ liệu : " + ne.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
