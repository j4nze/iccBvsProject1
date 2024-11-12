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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace iccBvsProject1.Views
{
    public partial class UserControlRental : UserControl
    {
        public UserControlVideoLibrary UCV { get; set; }
        private RentModel rm = new RentModel();
        private VideoModel vm = new VideoModel();
        private CustomerController cc = new CustomerController();
        private VideoController vc = new VideoController();
        private RentController rc = new RentController();
        private DataTable dt;
        private Timer timeChecker;

        public UserControlRental()
        {
            InitializeComponent();

            timeChecker = new Timer();
            timeChecker.Interval = 3600000;
            timeChecker.Tick += (s, e) => CheckOverdue();
            timeChecker.Start();

            LoadCustomerCombobox();
            LoadVideoCombobox();

            if (comboBoxVideoTitle.Items.Count > 0) comboBoxVideoTitle.SelectedIndex = 0;
            if (comboBoxCustomerName.Items.Count > 0) comboBoxCustomerName.SelectedIndex = 0;
            textBoxStatus.Text = "RENTED";
            comboBoxSearchBy.SelectedIndex = 0;

            dt = rc.RetrieveAll();
            dataGridViewRental.DataSource = dt;

            dateTimePickerReturnDate.Value = dateTimePickerRentalDate.Value.AddDays((int)numericUpDownRentLimit.Value);
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

        private void dataGridViewRental_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRental.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewRental.SelectedRows[0];

                textBoxRentalId.Text = selectedRow.Cells["rent_id"].Value.ToString();
                textBoxVideoId.Text = selectedRow.Cells["video_id"].Value.ToString();
                comboBoxVideoTitle.Text = selectedRow.Cells["title"].Value.ToString();
                textBoxVideoFormat.Text = selectedRow.Cells["format"].Value.ToString();
                numericUpDownRentLimit.Value = Convert.ToInt32(selectedRow.Cells["rent_limit"].Value.ToString());
                numericUpDownRentPrice.Value = Convert.ToInt32(selectedRow.Cells["price"].Value.ToString());
                textBoxCustomerId.Text= selectedRow.Cells["customer_id"].Value.ToString();
                comboBoxCustomerName.Text = selectedRow.Cells["name"].Value.ToString();
                dateTimePickerRentalDate.Value = Convert.ToDateTime(selectedRow.Cells["rental_date"].Value);
                dateTimePickerReturnDate.Value = Convert.ToDateTime(selectedRow.Cells["expected_return_date"].Value);
                numericUpDownOverdueDayCount.Value = Convert.ToInt32(selectedRow.Cells["overdue_days"].Value.ToString());
                numericUpDownOverduePrice.Value = Convert.ToInt32(selectedRow.Cells["overdue_price"].Value.ToString());
                numericUpDownTotalPrice.Value = Convert.ToInt32(selectedRow.Cells["total_price"].Value.ToString());
                textBoxStatus.Text = selectedRow.Cells["status"].Value.ToString();
                textBoxNotes.Text = selectedRow.Cells["Notes"].Value.ToString();

                CheckOverdue();
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

            dateTimePickerReturnDate.Value = dateTimePickerRentalDate.Value.AddDays((int)numericUpDownRentLimit.Value);
            numericUpDownTotalPrice.Value = numericUpDownRentPrice.Value + numericUpDownOverduePrice.Value;

            CheckOverdue();
        }

        private void comboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCustomerName.SelectedItem is Models.CustomerNameComboBoxItem selectedItem) textBoxCustomerId.Text = selectedItem.Id;
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStatus.Text == "RENTED") buttonReturn.Enabled = true;
            else buttonReturn.Enabled = false;
        }

        private void dateTimePickerRentalDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerReturnDate.Value = dateTimePickerRentalDate.Value.AddDays((int)numericUpDownRentLimit.Value);

            CheckOverdue();

            numericUpDownTotalPrice.Value = numericUpDownRentPrice.Value + numericUpDownOverduePrice.Value;
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            rm.Id = Nanoid.Generate(size: 10);
            rm.RentalDate = dateTimePickerRentalDate.Value;
            rm.ReturnDate = dateTimePickerReturnDate.Value;
            rm.OverdueDays = 0;
            rm.OverduePrice = 0;
            rm.TotalPrice = (int)numericUpDownTotalPrice.Value;
            rm.Status = "RENTED";
            rm.Notes = textBoxNotes.Text;
            rm.VideoId = textBoxVideoId.Text;
            rm.CustomerId = textBoxCustomerId.Text;

            int currentQuantity = vc.RetrieveSpecificQty(textBoxVideoId.Text);

            if (currentQuantity >= 1)
            {
                vc.RentQty(textBoxVideoId.Text);
                rc.Create(rm);
            }
            else MessageBox.Show("The current quantity of this video is 0");

            dt.Clear();
            dt = rc.RetrieveAll();
            dataGridViewRental.DataSource = dt;

            UCV.LoadList();
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
            rm.Id = textBoxRentalId.Text;
            rm.Status = "RETURNED";

            vc.ReturnQty(textBoxVideoId.Text);
            rc.Update(rm);

            dt.Clear();
            dt = rc.RetrieveAll();
            dataGridViewRental.DataSource = dt;
        }

        private void CheckOverdue()
        {
            if (textBoxStatus.Text == "RENTED" && DateTime.Now > dateTimePickerReturnDate.Value)
            {
                int overdueDays = (DateTime.Now - dateTimePickerReturnDate.Value).Days;
                decimal overduePrice = overdueDays * 5;

                numericUpDownOverdueDayCount.Value = overdueDays;
                numericUpDownOverduePrice.Value = overduePrice;
            }
            else
            {
                numericUpDownOverdueDayCount.Value = 0;
                numericUpDownOverduePrice.Value = 0;
            }
        }
    }
}
