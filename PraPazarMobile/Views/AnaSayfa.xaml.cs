using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraPazarMobile.Models;
using PraPazarMobile.Services;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace PraPazarMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnaSayfa : ContentPage
    {
        private ShoppingService shoppingService = new ShoppingService();


        public AnaSayfa()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //Test4

        }
       

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var sliderList = await shoppingService.GetPraPazarBannerSliderList();

          
        }


        private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var item = (BindableObject)sender;
            var detailItem = (ShoppingDetailItem)item.BindingContext;
            await Navigation.PushAsync(detailItem.Page);
        }

        private async void Go_Messages_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Messages());
        }

        private async void Go_PendingOrders_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PendingOrders());
        }
    }
}