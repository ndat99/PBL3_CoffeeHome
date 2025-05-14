using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DAL.Repository;
using PBL3_CoffeeHome.DTO;

namespace PBL3_CoffeeHome.GUI
{
    public partial class fLichSuDonHang : Form
    {
        private MenuItemBLL _menuItemBLL;

        public fLichSuDonHang()
        {
            InitializeComponent();
            _menuItemBLL = new MenuItemBLL(); // Sử dụng constructor mặc định

            // Thiết lập DateTimePicker với ngày hiện tại
            dateLichSuDon.Format = DateTimePickerFormat.Short;
            dateLichSuDon.Value = DateTime.Today; // Mặc định là 13/05/2025

            // Tải dữ liệu ban đầu cho ngày hiện tại
            LoadOrderHistory(dateLichSuDon.Value.Date);

            // Gắn sự kiện thay đổi ngày
            dateLichSuDon.ValueChanged += dateLichSuDon_ValueChanged;
        }

        private void dateLichSuDon_ValueChanged(object sender, EventArgs e)
        {
            LoadOrderHistory(dateLichSuDon.Value.Date);
        }

        private void LoadOrderHistory(DateTime selectedDate)
        {
            listDonHang.Items.Clear();
            try
            {
                var orders = _menuItemBLL.GetOrdersCompletedOnDate("Completed", selectedDate)
                            .OrderByDescending(o => o.BaristaQueues.FirstOrDefault()?.CompletedAt);

                foreach (var order in orders)
                {
                    var completedQueue = order.BaristaQueues.FirstOrDefault();
                    var completedAt = completedQueue?.CompletedAt.HasValue == true
                        ? completedQueue.CompletedAt.Value.ToString("HH:mm") : "N/A";
                    var item = new ListViewItem(new string[]
                    {
                        order.OrderID,
                        completedAt,
                        order.FinalAmount.ToString("N0") // Định dạng giá trị với số 0 thập phân
                    });
                    item.Tag = order;
                    listDonHang.Items.Add(item);
                }

                Console.WriteLine($"Đã tải {listDonHang.Items.Count} đơn hàng cho ngày {selectedDate.ToString("dd/MM/yyyy")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải lịch sử đơn hàng: {ex.Message}");
                MessageBox.Show($"Lỗi khi tải lịch sử đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}