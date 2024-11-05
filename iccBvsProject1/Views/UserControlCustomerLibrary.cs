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
    public partial class UserControlCustomerLibrary : UserControl
    {
        CustomerModel cm = new CustomerModel();
        CustomerController cc = new CustomerController();
        DataTable dt;

        public UserControlCustomerLibrary()
        {
            InitializeComponent();

            comboBoxSearchBy.SelectedIndex = 0;

            dt = cc.RetrieveAll();
            dataGridViewCustomerLibrary.DataSource = dt;
        }

        private void buttonRetrieveAll_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = cc.RetrieveAll();
            dataGridViewCustomerLibrary.DataSource = dt;
        }

        private void buttonRetrieveSpecific_Click(object sender, EventArgs e)
        {
            cm.SearchBy = comboBoxSearchBy.SelectedIndex;
            cm.SearchByValue = textBoxSearchValue.Text;

            dt.Clear();
            dt = cc.RetrieveSpecific(cm);
            dataGridViewCustomerLibrary.DataSource = dt;
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            cm.Id = Nanoid.Generate(size: 10);
            cm.Name = textBoxName.Text;
            cm.Mobile = textBoxMobile.Text;
            cm.Email = textBoxEmail.Text;
            cm.Address = textBoxAddress.Text;

            cc.Create(cm);

            dt.Clear();
            dt = cc.RetrieveAll();
            dataGridViewCustomerLibrary.DataSource = dt;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            cm.Id = textBoxId.Text;
            cm.Name = textBoxName.Text;
            cm.Mobile = textBoxMobile.Text;
            cm.Email = textBoxEmail.Text;
            cm.Address = textBoxAddress.Text;

            cc.Update(cm);

            dt.Clear();
            dt = cc.RetrieveAll();
            dataGridViewCustomerLibrary.DataSource = dt;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            cm.Id = textBoxId.Text;

            cc.Delete(cm);

            dt.Clear();
            dt = cc.RetrieveAll();
            dataGridViewCustomerLibrary.DataSource = dt;
        }

        private void dataGridViewCustomerLibrary_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCustomerLibrary.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCustomerLibrary.SelectedRows[0];

                textBoxId.Text = selectedRow.Cells["customer_id"].Value.ToString();
                textBoxName.Text = selectedRow.Cells["name"].Value.ToString();
                textBoxMobile.Text = selectedRow.Cells["mobile"].Value.ToString();
                textBoxEmail.Text = selectedRow.Cells["email"].Value.ToString();
                textBoxAddress.Text = selectedRow.Cells["Address"].Value.ToString();
            }
        }
    }
}
