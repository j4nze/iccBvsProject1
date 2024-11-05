using iccBvsProject1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iccBvsProject1.Views
{
    public partial class UserControlRental : UserControl
    {
        private CustomerController cc = new CustomerController();
        private VideoController vc = new VideoController();

        public UserControlRental()
        {
            InitializeComponent();

            comboBoxSearchBy.SelectedIndex = 0;

            LoadCustomerCombobox();
        }

        private void LoadCustomerCombobox()
        {
            var list = cc.RetrieveAllNames();

            comboBoxCustomerName.Items.Clear();

            foreach (var item in list)
            {
                comboBoxCustomerName.Items.Add(item);
            }
        }

        private void comboBoxVideoTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {

        }

        private void buttonRetrieveSpecific_Click(object sender, EventArgs e)
        {

        }

        private void buttonRetrieveAll_Click(object sender, EventArgs e)
        {

        }

        private void UserControlRental_Load(object sender, EventArgs e)
        {

        }
    }
}
