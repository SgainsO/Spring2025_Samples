using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Library.eCommerce.Services;

namespace Maui.eCommerce.ViewModels
{
    public class TotalCostViewModel : INotifyPropertyChanged
    {
        private ShoppingCartService __svc = ShoppingCartService.Current;

        public event PropertyChangedEventHandler? PropertyChanged;

        public double CheckoutCost
        {
            get {
                return Math.Round(__svc.CheckoutPrice + (__svc.CheckoutPrice * .07), 2);
                }
            set 
            { 
                __svc.CheckoutPrice = value;
            }
        }

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (propertyName is null)
            {
                throw new ArgumentNullException(nameof(propertyName));
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RefreshUI()
        {
            NotifyPropertyChanged(nameof(CheckoutCost));
        }
    }
}
