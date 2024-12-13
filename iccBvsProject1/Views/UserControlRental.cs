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
        public UserControlDashboard UCD { get; set; }
        private RentModel rm = new RentModel();
        private VideoModel vm = new VideoModel();
        private RentController rc = new RentController();
        private DataTable dt;

        public UserControlRental()
        {
            InitializeComponent();

            LoadCustomerCombobox();
            LoadVideoCombobox();

            if (comboBoxVideoTitle.Items.Count > 0) comboBoxVideoTitle.SelectedIndex = 0;
            if (comboBoxCustomerName.Items.Count > 0) comboBoxCustomerName.SelectedIndex = 0;
            textBoxStatus.Text = "RENTED";
            comboBoxSearchBy.SelectedIndex = 0;

            LoadList();

            dateTimePickerReturnDate.Value = dateTimePickerRentalDate.Value.AddDays((int)numericUpDownRentLimit.Value);
        }

        public void LoadList()
        {
            dt = rc.RetrieveAll();

            foreach (DataRow row in dt.Rows)
            {
                if (row["return_date"] != DBNull.Value && Convert.ToDateTime(row["return_date"]) == new DateTime(1900, 1, 1))
                {
                    row["return_date"] = DBNull.Value; 
                }
            }

            dataGridViewRental.DataSource = dt;

            dataGridViewRental.Columns["rent_id"].HeaderText = "Rent ID";
            dataGridViewRental.Columns["status"].HeaderText = "Status";
            dataGridViewRental.Columns["customer_id"].HeaderText = "Customer ID";
            dataGridViewRental.Columns["name"].HeaderText = "Name";
            dataGridViewRental.Columns["video_id"].HeaderText = "Video ID";
            dataGridViewRental.Columns["title"].HeaderText = "Title";
            dataGridViewRental.Columns["price"].HeaderText = "Price";
            dataGridViewRental.Columns["rental_date"].HeaderText = "Rental Date";
            dataGridViewRental.Columns["expected_return_date"].HeaderText = "Expected Return Date";
            dataGridViewRental.Columns["return_date"].HeaderText = "Return Date";
            dataGridViewRental.Columns["overdue_days"].HeaderText = "Overdue Day/s";
            dataGridViewRental.Columns["overdue_price"].HeaderText = "Overdue Price";
            dataGridViewRental.Columns["total_price"].HeaderText = "Total Price";
            dataGridViewRental.Columns["format"].HeaderText = "Format";
            dataGridViewRental.Columns["rent_limit"].HeaderText = "Rent Limit";
            dataGridViewRental.Columns["notes"].HeaderText = "Notes";
        }

        public void LoadCustomerCombobox()
        {
            var list = rc.RetrieveAllNames();

            comboBoxCustomerName.DisplayMember = "Name";
            comboBoxCustomerName.Items.Clear();

            foreach (var item in list)
            {
                comboBoxCustomerName.Items.Add(item);
            }
        }

        public void LoadVideoCombobox()
        {
            var list = rc.RetrieveAllTitles();

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
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            rm.Id = Nanoid.Generate(size: 10);
            rm.RentalDate = dateTimePickerRentalDate.Value;
            rm.ExpectedReturnDate = dateTimePickerReturnDate.Value;
            rm.OverdueDays = 0;
            rm.OverduePrice = 0;
            rm.TotalPrice = (int)numericUpDownRentPrice.Value;
            rm.Status = "RENTED";
            rm.Notes = textBoxNotes.Text;
            rm.VideoId = textBoxVideoId.Text;
            rm.CustomerId = textBoxCustomerId.Text;

            int currentQuantity = rc.RetrieveSpecificQty(textBoxVideoId.Text);

            if (currentQuantity >= 1) rc.Create(rm, textBoxVideoId.Text);
            else MessageBox.Show("The current quantity of this video is 0");

            dt.Clear();
            dt = rc.RetrieveAll();
            dataGridViewRental.DataSource = dt;

            UCV.LoadList();
            UCD.LoadSummary();
            UCD.LoadOverduedRentals();
            UCD.LoadLowStockAvailableVideos();
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
            rm.ReturnDate = DateTime.Now;

            rc.Update(rm, textBoxVideoId.Text);

            dt.Clear();
            dt = rc.RetrieveAll();
            dataGridViewRental.DataSource = dt;

            UCV.LoadList();
            UCD.LoadSummary();
            UCD.LoadOverduedRentals();
            UCD.LoadLowStockAvailableVideos();
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

            numericUpDownTotalPrice.Value = numericUpDownRentPrice.Value + numericUpDownOverduePrice.Value;
        }

        // Suppress any keys to video title combobox
        private void comboBoxVideoTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxVideoTitle_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxVideoTitle_KeyUp(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
