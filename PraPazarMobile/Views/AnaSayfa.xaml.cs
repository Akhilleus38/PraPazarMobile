using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public class Image
        {
            public string Url { get; set; }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var sliderList = await shoppingService.GetPraPazarBannerSliderList();

            List<Image> images = new List<Image>()
            {
                new Image(){Url="https://prapazar.com/uploads/praPazarAdvertisements/images/4e9be64ead244ffbbf2876fee6812e7b.jpg"},
                new Image(){Url="https://prapazar.com/uploads/praPazarAdvertisements/images/881fcbfd761d4479a7f1501a7f16b70d.png"},
                new Image(){Url="https://prapazar.com/uploads/praPazarAdvertisements/images/1a2bac503eb946c5976bd3ca0bae2124.png"},
                new Image(){Url="https://prapazar.com/uploads/praPazarAdvertisements/images/dc0793fc3dbc429f949896fd9ed622cf.png"},
                new Image(){Url="https://prapazar.com/uploads/praPazarAdvertisements/images/4bb6c6061dc84fee9984b20f65cd9f86.jpg"}
              
            };
            Carousel.ItemsSource = images;
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                Carousel.Position = (Carousel.Position + 1) % images.Count;
                return true;
            }));


        }




    }
}