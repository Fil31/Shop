using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shop
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ProductViewModel();
        }

        private async void OnBuyClicked(object sender, EventArgs e)
        {
            var product = ((Button)sender).BindingContext as Product;
            await DisplayAlert("Купить", $"Вы хотите купить {product.Name} за {product.Price} евро?", "Да", "Нет");
        }
    }
}
