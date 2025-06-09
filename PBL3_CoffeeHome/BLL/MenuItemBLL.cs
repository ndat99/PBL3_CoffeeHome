using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.BLL
{
    public class MenuItemBLL
    {
        private readonly MenuItemDAL _menuItemDAL;
        private readonly OrderDAL _orderDAL;
        private readonly string _imageFolder;

        public MenuItemBLL()
        {
            _menuItemDAL = new MenuItemDAL();
            _orderDAL = new OrderDAL();

            // Lấy đường dẫn tuyệt đối tới thư mục chứa ảnh
            string projectDirectory = GetProjectDirectory();
            _imageFolder = Path.Combine(projectDirectory, "Resources", "MenuImages");
            EnsureImageFolderExists();
        }

        public MenuItems GetMenuItemByName(string name)
        {
            return _menuItemDAL.GetMenuItemByName(name);
        }

        public List<MenuItems> GetAllMenuItems()
        {
            return _menuItemDAL.GetAllMenuItems();
        }

        public List<string> GetAllMenuCategory()
        {
            return _menuItemDAL.GetAllMenuCategory();
        }

        public List<MenuItems> SearchMenuItems(string searchTerm)
        {
            return _menuItemDAL.SearchMenuItems(searchTerm);
        }

        public List<MenuItems> SearchMenuItems(string searchTerm, string category)
        {
            return _menuItemDAL.SearchMenuItems(searchTerm, category);
        }

        public void AddMenuItem(MenuItems menuItem)
        {
            try
            {
                _menuItemDAL.AddMenuItem(menuItem);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm món ăn: " + ex.Message, ex);
            }
        }

        public void DeleteMenuItem(string id)
        {
            try
            {
                _menuItemDAL.DeleteMenuItem(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa món ăn: " + ex.Message, ex);
            }
        }

        public string GenerateNewMenuItemsId()
        {
            try
            {
                var menuItems = GetAllMenuItems();

                if (!menuItems.Any())
                {
                    return "MENU001";
                }

                var validIds = menuItems
                    .Where(u => !string.IsNullOrEmpty(u.MenuItemID) &&
                                u.MenuItemID.StartsWith("MENU") &&
                                u.MenuItemID.Length == 7 &&
                                int.TryParse(u.MenuItemID.Substring(4), out _))
                    .Select(u => int.Parse(u.MenuItemID.Substring(4)));

                int maxId = validIds.Any() ? validIds.Max() : 0;

                return $"MENU{(maxId + 1):D3}";
            }
            catch (Exception)
            {
                throw new Exception("Không thể tạo mã món mới!");
            }
        }

        public void UpdateMenuItem(MenuItems item)
        {
            try
            {
                _menuItemDAL.UpdateMenuItem(item);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật món ăn: " + ex.Message);
            }
        }

        private string GetProjectDirectory()
        {
            string currentDirectory = Application.StartupPath;
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            for (int i = 0; i < 3; i++)
            {
                if (directory.Parent != null)
                    directory = directory.Parent;
            }
            return directory.FullName;
        }

        private void EnsureImageFolderExists()
        {
            try
            {
                if (!Directory.Exists(_imageFolder))
                {
                    Directory.CreateDirectory(_imageFolder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tạo thư mục lưu ảnh: {ex.Message}");
            }
        }

        public string SaveImage(string menuItemId, string sourceFilePath)
        {
            try
            {
                string extension = Path.GetExtension(sourceFilePath);
                string fileName = $"{menuItemId}_{DateTime.Now.Ticks}{extension}";

                string folderPath = Path.Combine(Application.StartupPath, "MenuImages");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string destPath = Path.Combine(folderPath, fileName);
                File.Copy(sourceFilePath, destPath, true);

                // Trả về đường dẫn tương đối so với thư mục chạy của ứng dụng
                return Path.Combine("MenuImages", fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message);
                return null;
            }
        }

        public string GetFullImagePath(string relativePath)
        {
            if (string.IsNullOrEmpty(relativePath))
                return null;

            try
            {
                // Thử cách 1: Sử dụng project directory
                string projectDir = GetProjectDirectory();
                if (!string.IsNullOrEmpty(projectDir))
                {
                    relativePath = relativePath.TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
                    string path1 = Path.Combine(projectDir, relativePath);
                    if (File.Exists(path1))
                        return path1;
                }

                // Thử cách 2: Sử dụng Application.StartupPath
                string path2 = Path.Combine(Application.StartupPath, relativePath);
                if (File.Exists(path2))
                    return path2;

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi tạo đường dẫn ảnh: {ex.Message}");
                return null;
            }
        }


        public bool UpdateMenuItemImage(string menuItemId, string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath))
                return false;

            return _menuItemDAL.UpdateImage(menuItemId, imagePath);
        }

        public String getImagePath(string menuItemId)
        {
            String imagePath = _menuItemDAL.getImagePath(menuItemId);
            if (string.IsNullOrEmpty(imagePath))
            {
                return null;
            }
            return imagePath;
        }
    }
}
