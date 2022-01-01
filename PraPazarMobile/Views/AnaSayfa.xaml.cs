using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace PraPazarMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnaSayfa : ContentPage
    {
        public AnaSayfa()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //Test4

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
       


        
    }
}