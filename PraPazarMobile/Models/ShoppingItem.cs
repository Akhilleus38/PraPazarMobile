using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PraPazarMobile.Models
{
    public class ShoppingItem : BindableObject
    {
        bool _isDetailVisible;

        public string Name { get; set; }
        public string Icon { get; set; }
        public Color Color { get; set; }

        public bool IsDetailVisible
        {
            get { return _isDetailVisible; }
            set
            {
                Task.Run(async () =>
                {
                    await Task.Delay(value ? 0 : 250);
                    _isDetailVisible = value;
                    OnPropertyChanged();
                });
            }
        }

        public List<ShoppingDetailItem> Items { get; set; }
    }

    public class ShoppingDetailItem
    {
        public ContentPage Page { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public bool Done { get; set; }
        public bool IsLatest { get; set; }

    }

    public class PraPazarSliderImageModel
    {
        public string ImageFileName { get; set; }
    }
    public class PraPazarSliderModel
    {
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("SortOrder", NullValueHandling = NullValueHandling.Ignore)]
        public long? SortOrder { get; set; }

        [JsonProperty("FileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        [JsonProperty("Title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("Alt", NullValueHandling = NullValueHandling.Ignore)]
        public string Alt { get; set; }

        [JsonProperty("Active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("Link")]
        public Uri Link { get; set; }
    }
}
