using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iccBvsProject1.Models
{
    class RentModel
    {
        public string Id { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int OverdueDays { get; set; }
        public int OverduePrice { get; set; }
        public int TotalPrice { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }

        public string VideoId { get; set; }
        public string Title { get; set; }
        public string Format { get; set; }
        public int RentLimit { get; set; }
        public int Price { get; set; }

        public string CustomerId { get; set; }
        public string Name { get; set; }

        public int SearchBy { get; set; }
        public string SearchByValue { get; set; }
    }
}
