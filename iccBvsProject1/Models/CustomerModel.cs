using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iccBvsProject1.Models
{
    class CustomerModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public int SearchBy { get; set; }
        public string SearchByValue { get; set; }

    }

    class CustomerNameComboBoxItem
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public CustomerNameComboBoxItem(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
