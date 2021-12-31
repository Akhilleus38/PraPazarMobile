using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using PraPazarMobile.Models;
using PraPazarMobile.Services;
using Xamarin.Forms;

namespace PraPazarMobile.ViewModels
{
    public class ShoppingListViewModel : BindableObject
    {
        ObservableCollection<ShoppingItem> _items;

        public ShoppingListViewModel()
        {
            LoadShoppingList();
        }

        public ObservableCollection<ShoppingItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        void LoadShoppingList()
        {
            var items = ShoppingService.Instance.GetShoppingList();
            Items = new ObservableCollection<ShoppingItem>(items);
        }
    }
}
