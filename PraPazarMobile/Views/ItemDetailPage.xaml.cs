using PraPazarMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PraPazarMobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}