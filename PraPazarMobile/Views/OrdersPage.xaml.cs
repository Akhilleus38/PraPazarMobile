using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraPazarMobile.Models;
using PraPazarMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PraPazarMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersPage : ContentPage
    {
        
        public OrdersPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           
            MainDatePicker.Date = DateTime.Now.AddDays(-15);
            SearchTPicker.Time = new TimeSpan(0, 0, 0);
            MainDatePicker2.Date = DateTime.Now;
            MainTPicker.Time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);

        }

        private void ColorSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {

        }

        private void ColorSearchBar_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private async void Filters_Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Filters_Label_Visible_Change_Tap(object sender, EventArgs e)
        {
          
            if (FiltersLayout.IsVisible)
            {
                FiltersLayout.IsVisible = false;
            }
            else
            {
                FiltersLayout.IsVisible = true;
            }
        }

        private async void OrderDetail_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderDetailPage());
        }

        private async void Back_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PopAsync();
        }
    }
}