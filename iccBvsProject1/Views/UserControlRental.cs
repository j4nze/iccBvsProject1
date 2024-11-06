using iccBvsProject1.Controllers;
using iccBvsProject1.Models;
using NanoidDotNet;
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
        private RentModel rm = new RentModel();
        private CustomerController cc = new CustomerController();
        private VideoController vc = new VideoController();
        private RentController rc = new RentController();
        private DataTable dt;

        public UserControlRental()
        {
            InitializeComponent();
           
            LoadCustomerCombobox();
            LoadVideoCombobox();

            comboBoxVideoTitle.SelectedIndex = 0;
            comboBoxCustomerName.SelectedIndex = 0;
            textBoxStatus.Text = "RENTED";
            comboBoxSearchBy.SelectedIndex = 0;

            dt = rc.RetrieveAll();
            dataGridViewRental.DataSource = dt;
        }

        public void LoadCustomerCombobox()
        {
            var list = cc.RetrieveAllNames();

            comboBoxCustomerName.DisplayMember = "Name";
            comboBoxCustomerName.Items.Clear();

            foreach (var item in list)
            {
                comboBoxCustomerName.Items.Add(item);
            }
        }

        public void LoadVideoCombobox()
        {
            var list = vc.RetrieveAllTitles();

            comboBoxVideoTitle.DisplayMember = "Title";
            comboBoxVideoTitle.Items.Clear();

            foreach (var item in list)
            {
                comboBoxVideoTitle.Items.Add(item);
            }
        }

        private void comboBoxVideoTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVideoTitle.SelectedItem is Models.VideoTitleComboBoxItem selectedItem)
            {
                textBoxVideoId.Text = selectedItem.Id;
                numericUpDownRentLimit.Value = selectedItem.RentLimit;
                textBoxVideoFormat.Text = selectedItem.Format;
                numericUpDownRentPrice.Value = selectedItem.Price;
            }
        }

        private void comboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCustomerName.SelectedItem is Models.CustomerNameComboBoxItem selectedItem) textBoxCustomerId.Text = selectedItem.Id;
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            rm.Id = Nanoid.Generate(size: 10);
            rm.RentalDate = dateTimePickerRentalDate.Value;
            rm.ReturnDate = dateTimePickerReturnDate.Value;
            rm.OverdueDays = (int)numericUpDownOverdueDayCount.Value;
            rm.OverduePrice = (int)numericUpDownOverduePrice.Value;
            rm.TotalPrice = (int)numericUpDownTotalPrice.Value;
            rm.Status = textBoxStatus.Text;
            rm.Notes = textBoxNotes.Text;
            rm.VideoId = textBoxVideoId.Text;
            rm.CustomerId = textBoxCustomerId.Text;

            rc.Create(rm);

            dt.Clear();
            dt = rc.RetrieveAll();
            dataGridViewRental.DataSource = dt;
        }

        private void buttonRetrieveSpecific_Click(object sender, EventArgs e)
        {
            rm.SearchBy = comboBoxSearchBy.SelectedIndex;
            rm.SearchByValue = textBoxSearchValue.Text;

            dt.Clear();
            dt = rc.RetrieveSpecific(rm);
            dataGridViewRental.DataSource = dt;
        }

        private void buttonRetrieveAll_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = rc.RetrieveAll();
            dataGridViewRental.DataSource = dt;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
