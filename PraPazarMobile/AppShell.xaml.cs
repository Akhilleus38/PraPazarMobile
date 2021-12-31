using PraPazarMobile.ViewModels;
using PraPazarMobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PraPazarMobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
