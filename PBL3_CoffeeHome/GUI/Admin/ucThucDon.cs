using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_CoffeeHome.DAL;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.GUI.Admin;
using System.IO;
using PBL3_CoffeeHome.GUI.Cashier;

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucThucDon : UserControl
    {
        private readonly MenuItemBLL _menuItemBLL;
        private BindingSource bindingSource;
        public ucThucDon()
        {
            InitializeComponent();
            _menuItemBLL = new MenuItemBLL();
            List<string> danhMuc = _menuItemBLL.GetAllMenuCategory();

            danhMuc.Insert(0, "Tất cả");
            cBDanhMuc1.DataSource = danhMuc;

            LoadMenuItems(txtTimKiem.Text.Trim());
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            fThemMon f = new fThemMon(LoadMenuItems);
            f.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cBDanhMuc1.SelectedItem.ToString() == "Tất cả")
            {
                LoadMenuItems(txtTimKiem.Text.Trim());
            }
            else
                LoadMenuItems(txtTimKiem.Text.Trim());
        }

        private void LoadMenuItems(string searchTerm = "")
        {
            flpMenu.Visible = false;
            flpMenu.Controls.Clear();

            string selectedCategory = cBDanhMuc1.SelectedItem?.ToString();

            var menuItems = _menuItemBLL.SearchMenuItems(searchTerm, selectedCategory);

            foreach (var item in menuItems)
            {
                var card = new ucCardThucDon();
                card.ItemId = item.MenuItemID;
                card.ItemName = item.Name;
                card.Price = item.Price;

                string fullImagePath = _menuItemBLL.GetFullImagePath(item.ImagePath);
                if (File.Exists(fullImagePath))
                {
                    using (var img = Image.FromFile(fullImagePath))
                    {
                        card.ItemImage = new Bitmap(img);
                    }
                }
                else
                {
                    card.ItemImage = Properties.Resources.DefaultImage;
                }

                card.Margin = new Padding(3);
                card.Width = 150;
                card.Height = 160;
                card.btnXoaMonClick += (s, e) => RemoveMenuItem(card.ItemId);
                card.btnSuaMonClick += (s, e) => EditMenuItem(card.ItemId);
                card.btnThemMon.Visible = false;
                flpMenu.Controls.Add(card);
            }

            flpMenu.Visible = true;
        }

        public void RemoveMenuItem(string ID)
        {
            var menuItem = _menuItemBLL.GetMenuItemByID(ID);
            if (DialogResult.No == MessageBox.Show($"Bạn có chắc chắn muốn xóa món {menuItem.Name} không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)) return;
            else
            {
                if(menuItem.ImagePath == null)
                {
                    _menuItemBLL.DeleteMenuItem(menuItem.MenuItemID);
                }
                else
                {
                    string oldImagePath = Path.Combine(Application.StartupPath, menuItem.ImagePath);
                    if (File.Exists(oldImagePath))
                        File.Delete(oldImagePath);
                    _menuItemBLL.DeleteMenuItem(menuItem.MenuItemID);
                }
            }
            LoadMenuItems(txtTimKiem.Text.Trim());
        }

        public void EditMenuItem(string ID)
        {
            var menuItem = _menuItemBLL.GetMenuItemByID(ID);
            fCongThuc f = new fCongThuc(menuItem);
            f.Show();
        }

        private void ucThucDon_Load(object sender, EventArgs e)
        {
            MakeButtonRounded(btnLoc, 10, Color.Black);
            MakeButtonRounded(btnThemMon, 10, Color.FromArgb(0, 102, 204));
        }

        private void cBDanhMuc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMenuItems(txtTimKiem.Text.Trim());
        }

    }
}
