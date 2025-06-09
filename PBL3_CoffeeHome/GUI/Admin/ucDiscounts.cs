using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;
using PBL3_CoffeeHome.GUI.Admin;

namespace PBL3_CoffeeHome.GUI
{
    public partial class ucDiscounts : UserControl
    {
        private readonly DiscountBLL _discountBLL;
        private BindingSource bindingSource;

        public ucDiscounts()
        {
            InitializeComponent();
            _discountBLL = new DiscountBLL();
            bindingSource = new BindingSource();
            SetupDataGridView();
            dgvDiscounts.DataSource = bindingSource;
            LoadDiscountsData();
        }

        private void LoadDiscountsData()
        {
            try
            {
                var discounts = _discountBLL.GetAllDiscounts();
                if (discounts != null && discounts.Any())
                {
                    bindingSource.DataSource = discounts;
                    bindingSource.ResetBindings(true);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu giảm giá!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSource.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDiscountsData(DateTime? startDate, DateTime? endDate)
        {
            try
            {
                var discounts = _discountBLL.GetAllDiscounts();
                if (startDate.HasValue && endDate.HasValue)
                {
                    discounts = discounts.Where(d => d.EffectiveDate.HasValue &&
                        d.EffectiveDate.Value >= startDate.Value &&
                        d.EffectiveDate.Value <= endDate.Value).ToList();
                }
                if (discounts != null && discounts.Any())
                {
                    bindingSource.DataSource = discounts;
                    bindingSource.ResetBindings(true);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu giảm giá trong khoảng thời gian này!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSource.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dgvDiscounts.AutoGenerateColumns = false;
            dgvDiscounts.AllowUserToAddRows = false;
            dgvDiscounts.ReadOnly = true;
            dgvDiscounts.AllowUserToDeleteRows = false;
            dgvDiscounts.MultiSelect = false;
            dgvDiscounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiscounts.DataSourceChanged += (s, e) => dgvDiscounts.Refresh();

            dgvDiscounts.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn
                {
                    Name = "DiscountID",
                    HeaderText = "Mã giảm giá",
                    DataPropertyName = "DiscountID",
                    Width = 100
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Name",
                    HeaderText = "Tên giảm giá",
                    DataPropertyName = "Name",
                    Width = 150
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "Percentage",
                    HeaderText = "Phần trăm (%)",
                    DataPropertyName = "Percentage",
                    Width = 100
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "MinOrderAmount",
                    HeaderText = "Đơn hàng tối thiểu",
                    DataPropertyName = "MinOrderAmount",
                    Width = 120
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "EffectiveDate",
                    HeaderText = "Ngày hiệu lực",
                    DataPropertyName = "EffectiveDate",
                    Width = 120
                }
            });
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            using (var f = new fDiscountDetail(LoadDiscountsData))
            {
                f.ShowDialog();
            }
            LoadDiscountsData();
        }

        private void btnEditDiscount_Click(object sender, EventArgs e)
        {
            if (dgvDiscounts.SelectedRows.Count > 0)
            {
                var discount = (Discount)dgvDiscounts.SelectedRows[0].DataBoundItem;
                using (var f = new fDiscountDetail(discount, LoadDiscountsData))
                {
                    f.ShowDialog();
                }
                LoadDiscountsData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mã giảm giá để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            if (dgvDiscounts.SelectedRows.Count > 0)
            {
                var discount = (Discount)dgvDiscounts.SelectedRows[0].DataBoundItem;
                if (DialogResult.Yes == MessageBox.Show($"Bạn có chắc chắn muốn xóa mã giảm giá {discount.Name} không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        _discountBLL.DeleteDiscount(discount.DiscountID);
                        LoadDiscountsData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mã giảm giá để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpBatDau.Value;
            DateTime endDate = dtpKetThuc.Value;
            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadDiscountsData(startDate, endDate);
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            LoadDiscountsData();
        }

        private void ucDiscounts_Load(object sender, EventArgs e)
        {
            MakeButtonRounded(btnLoc, 10, Color.Black);
            MakeButtonRounded(btnHienThiTatCa, 10, Color.Black);
            MakeButtonRounded(btnAddDiscount, 10, Color.FromArgb(0, 102, 204));
            MakeButtonRounded(btnEditDiscount, 10, Color.Orange);
            MakeButtonRounded(btnDeleteDiscount, 10, Color.Red);
        }
    }

}