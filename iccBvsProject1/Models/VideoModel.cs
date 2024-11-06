using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iccBvsProject1.Models
{
    class VideoModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime Release {  get; set; }
        public int RentLimit { get; set; }
        public int Price { get; set; }
        public string Format { get; set; }
        public int TotalQty { get; set; }
        public int InQty { get; set; }
        public int OutQty { get; set; }
        public string Synopsis { get; set; }

        public int NewInOperation {  get; set; }
        public int NewInQty { get; set; }

        public int SearchBy { get; set; }
        public string SearchByValue { get; set; }
    }

    class VideoTitleComboBoxItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int RentLimit { get; set; }
        public int Price { get; set; }
        public string Format { get; set; }

        public VideoTitleComboBoxItem(string id, string title, int rentLimit, int price, string format)
        {
            this.Id = id;
            this.Title = title;
            this.RentLimit = rentLimit;
            this.Price = price;
            this.Format = format;
        }
    }
}
