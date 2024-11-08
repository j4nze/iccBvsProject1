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
    public partial class UserControlVideoLibrary : UserControl
    {
        public UserControlRental UCR { get; set; }  // holds reference from this uc
        private VideoModel vm = new VideoModel();
        private VideoController vc = new VideoController();
        private DataTable dt;

        public UserControlVideoLibrary()
        {
            InitializeComponent();

            comboBoxFormat.SelectedIndex = 0;
            comboBoxNewQtyOperation.SelectedIndex = 0;
            comboBoxSearchBy.SelectedIndex = 0;

            dt = vc.RetrieveAll();
            dataGridViewVideoLibrary.DataSource = dt;
        }

        public void ReloadList()
        {
            dt = vc.RetrieveAll();
            dataGridViewVideoLibrary.DataSource = dt;
        }

        private void comboBoxVideoFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFormat.SelectedIndex == 0) numericUpDownRentPrice.Value = 25;
            else if (comboBoxFormat.SelectedIndex == 1) numericUpDownRentPrice.Value = 50;
        }

        private void dataGridViewVideoLibrary_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVideoLibrary.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewVideoLibrary.SelectedRows[0];

                textBoxId.Text = selectedRow.Cells["video_id"].Value.ToString();
                textBoxTitle.Text = selectedRow.Cells["title"].Value.ToString();
                textBoxDirector.Text = selectedRow.Cells["director"].Value.ToString();
                dateTimePickerReleaseDate.Value = Convert.ToDateTime(selectedRow.Cells["release_date"].Value);
                numericUpDownRentLimit.Value = Convert.ToInt32(selectedRow.Cells["rent_limit"].Value);
                numericUpDownRentPrice.Value = Convert.ToInt32(selectedRow.Cells["price"].Value);
                comboBoxFormat.Text = selectedRow.Cells["format"].Value.ToString();
                numericUpDownTotalQty.Value = Convert.ToInt32(selectedRow.Cells["total_qty"].Value);
                numericUpDownInQty.Value = Convert.ToInt32(selectedRow.Cells["in_qty"].Value);
                numericUpDownOutQty.Value = Convert.ToInt32(selectedRow.Cells["out_qty"].Value);
                textBoxSynopsis.Text = selectedRow.Cells["synopsis"].Value.ToString();

                textBoxVideoIdNewIn.Text = selectedRow.Cells["video_id"].Value.ToString();
            }
        }

        private void buttonVideoRetrieve_Click(object sender, EventArgs e)
        {
            vm.SearchBy = comboBoxSearchBy.SelectedIndex;
            vm.SearchByValue = textBoxSearchValue.Text;

            dt.Clear();
            dt = vc.RetrieveSpecific(vm);
            dataGridViewVideoLibrary.DataSource = dt;
        }

        private void buttonVideoRetrieveAll_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = vc.RetrieveAll();
            dataGridViewVideoLibrary.DataSource = dt;
        }

        private void buttonCreateVideoRecord_Click(object sender, EventArgs e)
        {
            vm.Id = Nanoid.Generate(size: 10);
            vm.Title = textBoxTitle.Text;
            vm.Director = textBoxDirector.Text;
            vm.Release = dateTimePickerReleaseDate.Value;
            vm.RentLimit = (int)numericUpDownRentLimit.Value;
            vm.Price = (int)numericUpDownRentPrice.Value;
            vm.Format = comboBoxFormat.Text;
            vm.TotalQty = (int)numericUpDownTotalQty.Value;
            vm.InQty = (int)numericUpDownInQty.Value;
            vm.OutQty = (int)numericUpDownOutQty.Value;
            vm.Synopsis = textBoxSynopsis.Text;

            vm.TotalQty = 0;
            vm.InQty = 0;
            vm.OutQty = 0;

            vc.Create(vm);

            dt.Clear();
            dt = vc.RetrieveAll();
            dataGridViewVideoLibrary.DataSource = dt;

            UCR.LoadVideoCombobox();
        }

        private void buttonSubmitStockQtyOperation_Click(object sender, EventArgs e)
        {
            vm.Id = textBoxId.Text;
            vm.NewInOperation = comboBoxNewQtyOperation.SelectedIndex;
            vm.NewInQty = (int)numericUpDownNewQty.Value;
            vm.InQty = (int)numericUpDownInQty.Value;
            vm.TotalQty = (int)numericUpDownTotalQty.Value;

            vc.UpdateQty(vm);

            dt.Clear();
            dt = vc.RetrieveAll();
            dataGridViewVideoLibrary.DataSource = dt;

            UCR.LoadVideoCombobox();
        }

        private void buttonVideoUpdateRecord_Click(object sender, EventArgs e)
        {
            vm.Id = textBoxId.Text;
            vm.Title = textBoxTitle.Text;
            vm.Director = textBoxDirector.Text;
            vm.Release = dateTimePickerReleaseDate.Value;
            vm.RentLimit = (int)numericUpDownRentLimit.Value;
            vm.Price = (int)numericUpDownRentPrice.Value;
            vm.Format = comboBoxFormat.Text;
            vm.Synopsis = textBoxSynopsis.Text;

            vc.Update(vm);

            dt.Clear();
            dt = vc.RetrieveAll();
            dataGridViewVideoLibrary.DataSource = dt;

            UCR.LoadVideoCombobox();
        }


        private void buttonVideoDeleteButton_Click(object sender, EventArgs e)
        {
            vm.Id = textBoxId.Text;
            vc.Delete(vm);

            dt.Clear();
            dt = vc.RetrieveAll();
            dataGridViewVideoLibrary.DataSource = dt;

            UCR.LoadVideoCombobox();
        }
    }
}
