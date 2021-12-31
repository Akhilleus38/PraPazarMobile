using System;
using System.Collections.Generic;
using System.Text;
using PraPazarMobile.Models;
using Xamarin.Forms;

namespace PraPazarMobile.Services
{
    public class ShoppingService
    {
        static ShoppingService _instance;

        public static ShoppingService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ShoppingService();
                return _instance;
            }
        }

        public List<ShoppingItem> GetShoppingList()
        {
            return new List<ShoppingItem>
            {
                new ShoppingItem { Name = "Siparişler", Icon = "inbox.png", Color = Color.DeepPink,
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem { Name = "Siparişleri Listele" },
                        new ShoppingDetailItem { Name = "Siparişleri Onayla" },
                        new ShoppingDetailItem { Name = "E-Faturaya Gönder" },
                        new ShoppingDetailItem { Name = "Muhasebeye Gönder" },
                        new ShoppingDetailItem { Name = "Sipariş Detay" },
                        new ShoppingDetailItem { Name = "Sipariş Silme", IsLatest = true },
                    } },
                new ShoppingItem { Name = "Ürünler", Icon = "urunler.png", Color = Color.Orange,
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem { Name = "Ürünleri Listele" },
                        new ShoppingDetailItem { Name = "Ürünleri İçe Aktar" },
                        new ShoppingDetailItem { Name = "Ürünleri Dışa Aktar", IsLatest = true },
                    } },
                new ShoppingItem { Name = "Grafikler", Icon = "chartss.png", Color = Color.YellowGreen,
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem { Name = "Dashboard" },
                        new ShoppingDetailItem { Name = "Günün Analizi" },
                        new ShoppingDetailItem { Name = "Ürün Analizi", IsLatest = true },
                    } },
                new ShoppingItem { Name = "Toplu İşlemler", Icon = "urunler.png", Color = Color.Purple,
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem { Name = "Satışı Durdur" },
                        new ShoppingDetailItem { Name = "Satışa Çıkart" },
                        new ShoppingDetailItem { Name = "Fiyat Güncelle", IsLatest = true },
                    } },
                new ShoppingItem { Name = "Yönetim", Icon = "profil.png", Color = Color.Green,
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem { Name = "Kullanıcılar" },
                        new ShoppingDetailItem { Name = "Genel Ayarlarım" },
                        new ShoppingDetailItem { Name = "Fatura Ayarlarım", IsLatest = true },
                    } },
            };
        }
    }
}
