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

            // Thêm "Tất cả" vào đầu danh sách
            danhMuc.Insert(0, "All");

            cBDanhMuc1.DataSource = danhMuc;
            bindingSource = new BindingSource();

            SetupDataGridView();
            dgvThucDon.DataSource = bindingSource;
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (s, e) => {
                timer.Stop();
                LoadData(""); // ← Bị delay 100ms
            };
            timer.Start();
        }

        public void LoadData(string searchTerm)
        {
            try
            {
                List<MenuItems> searchResult = _menuItemBLL.SearchMenuItems(searchTerm);
                LoadDataFromList(searchResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData(string searchTerm, string category)
        {
            try
            {
                List<MenuItems> searchResult = _menuItemBLL.SearchMenuItems(searchTerm, category);
                LoadDataFromList(searchResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức helper để tránh lặp code
        private void LoadDataFromList(List<MenuItems> items)
        {
            CleanupImages();
            if (items != null && items.Any())
            {
                var displayData = items.Select(item => new
                {
                    item.MenuItemID,
                    item.Name,
                    item.Category,
                    item.Price,
                    item.IsAvailable,
                    MenuItem = item
                }).ToList();

                bindingSource.DataSource = displayData;
                bindingSource.ResetBindings(false);

                foreach (DataGridViewRow row in dgvThucDon.Rows)
                {
                    var menuItem = (row.DataBoundItem as dynamic).MenuItem as MenuItems;
                    if (menuItem != null && !string.IsNullOrEmpty(menuItem.ImagePath))
                    {
                        try
                        {
                            string fullPath = _menuItemBLL.GetFullImagePath(menuItem.ImagePath);
                            if (File.Exists(fullPath))
                            {
                                using (var originalImage = Image.FromFile(fullPath))
                                {
                                    row.Cells["Image"].Value = new Bitmap(originalImage);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi load ảnh: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                bindingSource.DataSource = null;
            }

        }




        // Thêm phương thức để giải phóng tài nguyên hình ảnh
        private void CleanupImages()
        {
            if (dgvThucDon.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvThucDon.Rows)
                {
                    var img = row.Cells["Image"].Value as Image;
                    img?.Dispose();
                }
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            fThemMon f = new fThemMon(LoadData);
            f.Show();
        }

        private void SetupDataGridView()
        {
            // Tắt tự động tạo cột
            dgvThucDon.AutoGenerateColumns = false;

            // Không cho phép thêm hàng mới
            dgvThucDon.AllowUserToAddRows = false;

            dgvThucDon.ReadOnly = true;
            dgvThucDon.AllowUserToDeleteRows = false;
            dgvThucDon.MultiSelect = false;
            dgvThucDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThucDon.DataSourceChanged += (s, e) => dgvThucDon.Refresh();
            dgvThucDon.RowTemplate.Height = 100;

            // Thiết lập các cột cho DataGridView
            dgvThucDon.Columns.AddRange(new DataGridViewColumn[]
            {
            new DataGridViewTextBoxColumn
            {
                Name = "MenuItemID",
                HeaderText = "Mã món",
                DataPropertyName = "MenuItemID",
                Width = 80
            },
            new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Tên món",
                DataPropertyName = "Name",
                Width = 120
            },
            new DataGridViewTextBoxColumn
            {
                Name = "Category",
                HeaderText = "Danh mục",
                DataPropertyName = "Category",
                Width = 150
            },
            new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Giá",
                DataPropertyName = "Price",
                Width = 100
            },
            });

            var imageColumn = new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "Hình ảnh",
                DataPropertyName = "ImagePath",
                Width = 100,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };

            imageColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThucDon.Columns.Add(imageColumn);
        }


        private void btnSua_Click(object sender, EventArgs e)
        {

            MenuItems menuItems = new MenuItems();
            menuItems.MenuItemID = dgvThucDon.CurrentRow.Cells["MenuItemID"].Value?.ToString();
            menuItems.Name = dgvThucDon.CurrentRow.Cells["Name"].Value?.ToString();
            menuItems.Category = dgvThucDon.CurrentRow.Cells["Category"].Value?.ToString();
            menuItems.Price = decimal.Parse(dgvThucDon.CurrentRow.Cells["Price"].Value?.ToString() ?? "0");
            menuItems.ImagePath = _menuItemBLL.getImagePath(menuItems.MenuItemID);
            if (menuItems.MenuItemID == null)
            {
                MessageBox.Show("Vui lòng chọn một món để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            fCongThuc f = new fCongThuc(menuItems);
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cBDanhMuc1.SelectedItem.ToString() == "All")
            {
                LoadData(txtTimKiem.Text.Trim());
            }
            else LoadData(txtTimKiem.Text.Trim(), cBDanhMuc1.SelectedItem.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String menuItemSelectedId = dgvThucDon.CurrentRow.Cells["MenuItemID"].Value?.ToString();
            String menuItemSelectedName = dgvThucDon.CurrentRow.Cells["Name"].Value?.ToString();
            String menuItemSelectedImagePath = _menuItemBLL.getImagePath(menuItemSelectedId);

            if (menuItemSelectedId == null)
            {
                MessageBox.Show("Vui lòng chọn một món để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DialogResult.No == MessageBox.Show($"Bạn có chắc chắn muốn xóa món {menuItemSelectedName} không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)) return;
            else 
            {
                string oldImagePath = Path.Combine(Application.StartupPath, menuItemSelectedImagePath);
                if (File.Exists(oldImagePath))
                    File.Delete(oldImagePath);
                _menuItemBLL.DeleteMenuItem(menuItemSelectedId);
                LoadData("");
            }

        }

        private void ucThucDon_Load(object sender, EventArgs e)
        {
            MakeButtonRounded(btnLoc, 10, Color.Black);
            MakeButtonRounded(btnThemMon, 10, Color.FromArgb(0, 102, 204));
            MakeButtonRounded(btnSua, 10, Color.Orange);
            MakeButtonRounded(btnXoa, 10, Color.Red);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có hàng nào được chọn không
                if (dgvThucDon.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn món cần thêm/sửa ảnh!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy MenuItemID từ dòng được chọn
                var menuItemId = dgvThucDon.CurrentRow.Cells["MenuItemID"].Value?.ToString();
                if (string.IsNullOrEmpty(menuItemId))
                {
                    MessageBox.Show("Không thể xác định mã món!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    openFileDialog.Title = "Chọn ảnh món";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedImage = openFileDialog.FileName;

                        // Lưu ảnh và cập nhật đường dẫn trong database
                        string savedImagePath = _menuItemBLL.SaveImage(menuItemId, selectedImage);
                        if (savedImagePath != null)
                        {
                            bool updated = _menuItemBLL.UpdateMenuItemImage(menuItemId, savedImagePath);
                            if (updated)
                            {
                                LoadData("");
                                MessageBox.Show("Cập nhật ảnh thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không thể cập nhật ảnh trong cơ sở dữ liệu!", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể lưu file ảnh!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
