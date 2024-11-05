using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iccBvsProject1.Models
{
    class RentModel
    {
        public string rentalId { get; set; }
        public DateTime rentalDate { get; set; }
        public DateTime returnDate { get; set; }
        public int overdueDays { get; set; }
        public int overduePrice { get; set; }
        public int totalPrice { get; set; }
        public string status { get; set; }
        public string notes { get; set; }

        public string videoId { get; set; }
        public string title { get; set; }
        public string format { get; set; }
        public int rentLimit { get; set; }
        public int price { get; set; }

        public string customerId { get; set; }
        public string name { get; set; }

        public int SearchBy { get; set; }
        public string SearchByValue { get; set; }
    }
}
