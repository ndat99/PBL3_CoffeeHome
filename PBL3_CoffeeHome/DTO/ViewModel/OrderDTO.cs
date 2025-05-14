using System.ComponentModel;

namespace PBL3_CoffeeHome.DTO.ViewModel
{   // cập nhật giao diện đơn hàng khi giá trị thay đổi
    public class OrderDisplayDTO : INotifyPropertyChanged
    {
        private string _name;
        private int _quantity;
        private decimal _costPrice;
        private decimal _totalPrice;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged(nameof(Quantity));
                }
            }
        }

        public decimal CostPrice
        {
            get => _costPrice;
            set
            {
                if (_costPrice != value)
                {
                    _costPrice = value;
                    OnPropertyChanged(nameof(CostPrice));
                }
            }
        }

        public decimal TotalPrice
        {
            get => _totalPrice;
            set
            {
                if (_totalPrice != value)
                {
                    _totalPrice = value;
                    OnPropertyChanged(nameof(TotalPrice));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}