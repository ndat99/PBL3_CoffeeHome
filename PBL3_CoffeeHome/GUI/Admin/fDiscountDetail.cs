using PBL3_CoffeeHome.BLL;
using PBL3_CoffeeHome.DTO;
using System;
using System.Windows.Forms;

namespace PBL3_CoffeeHome.GUI.Admin
{
    public partial class fDiscountDetail : Form
    {
        private readonly Discount _discount;
        private readonly Action _refreshCallback;
        private readonly DiscountBLL _discountBLL;

        public fDiscountDetail(Action refreshCallback)
        {
            InitializeComponent();
            _discount = new Discount();
            _refreshCallback = refreshCallback;
            _discountBLL = new DiscountBLL();
            _discount.DiscountID = _discountBLL.GenerateNewDiscountID(); 
        }

        public fDiscountDetail(Discount discount, Action refreshCallback)
        {
            InitializeComponent();
            _discount = discount;
            _refreshCallback = refreshCallback;
            _discountBLL = new DiscountBLL();
            LoadDataToControls();
        }

        private void LoadDataToControls()
        {
            txtTenma.Text = _discount.Name ?? string.Empty;
            txtPhanTramGiam.Text = _discount.Percentage.ToString("F2");
            txtGiaToiThieu.Text = _discount.MinOrderAmount.ToString("F2");
            txtNgayHieuLuc.Text = _discount.EffectiveDate?.ToString("dd/MM/yyyy") ?? DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenma.Text) || string.IsNullOrWhiteSpace(txtPhanTramGiam.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaToiThieu.Text) || string.IsNullOrWhiteSpace(txtNgayHieuLuc.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPhanTramGiam.Text, out decimal percentage) || percentage < 0 || percentage > 1)
                {
                    MessageBox.Show("Phần trăm giảm phải từ 0 đến 1!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtGiaToiThieu.Text, out decimal minOrderAmount) || minOrderAmount < 0)
                {
                    MessageBox.Show("Giá tối thiểu phải là số dương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!DateTime.TryParseExact(txtNgayHieuLuc.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime effectiveDate))
                {
                    MessageBox.Show("Ngày hiệu lực phải theo định dạng dd/MM/yyyy", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(_discount.DiscountID))
                {
                    _discount.DiscountID = _discountBLL.GenerateNewDiscountID();
                }
                _discount.Name = txtTenma.Text.Trim();
                _discount.Percentage = percentage;
                _discount.MinOrderAmount = minOrderAmount;
                _discount.EffectiveDate = effectiveDate;

                if (_discountBLL.GetAllDiscounts().Find(d => d.DiscountID == _discount.DiscountID) == null) // Thêm mới
  
                    _discountBLL.AddDiscount(_discount);
                else 
                    _discountBLL.UpdateDiscount(_discount);

                _refreshCallback?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu: {ex.Message}\nChi tiết: {ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fDiscountDetail_Load(object sender, EventArgs e)
        {
            txtNgayHieuLuc.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}