using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PraPazarMobile.Models;
using PraPazarMobile.Views;
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
                new ShoppingItem { Name = "Grafikler", Icon = "chartss.png", Color = Color.FromRgb(77,77,77),
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem { Name = "Dashboard" , Page = new Hesabım()},
                        new ShoppingDetailItem { Name = "Günün Analizi", Page = new Hesabım()},
                        new ShoppingDetailItem { Name = "Ürün Analizi", IsLatest = true, Page = new Hesabım() },
                    } },
                new ShoppingItem { Name = "Siparişler", Icon = "inbox.png", Color = Color.Green,
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem { Name = "Siparişleri Listele" , Page = new OrdersPage() , IsLatest = true},
                    } },
                new ShoppingItem { Name = "Ürünler", Icon = "urunler.png", Color = Color.DodgerBlue,
                    Items = new List<ShoppingDetailItem>
                    {
                        new ShoppingDetailItem { Name = "Ürünleri Listele" , Page = new Hesabım()},
                        new ShoppingDetailItem { Name = "Ürünleri İçe Aktar" , Page = new Hesabım()},
                        new ShoppingDetailItem { Name = "Ürünleri Dışa Aktar", IsLatest = true , Page = new Hesabım()},
                    } },


            };
        }


        public async Task<List<PraPazarSliderImageModel>> GetPraPazarBannerSliderList()
        {
            var sliderList = new List<PraPazarSliderImageModel>();
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://prapazar.com/Api/PraPazarAkademiApi/GetBannerSliderListFor"))
                {
                    request.Headers.TryAddWithoutValidation("ApiSecret", "X0bmEZ5QVlOB5J1D");
                    request.Headers.TryAddWithoutValidation("ApiKey", "M+zVvCLt+/55UkaQNZ7gf/vXRHj4v1Mw724LPRdkV48");

                    var response = await httpClient.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var model = JsonConvert.DeserializeObject<List<PraPazarSliderModel>>(result);
                        if (model != null && model.Any())
                        {
                            sliderList.AddRange(model.Select(a =>
                                new PraPazarSliderImageModel() { ImageFileName = $"https://prapazar.com/uploads/praPazarAdvertisements/images/{a.FileName}" }));
                        }
                    }





                    //System.IO.File.WriteAllText(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + SystemConstants.JsonDataUrl, "faqJson.json"), stream);
                }
                return sliderList;
            }
        }
    }
}
