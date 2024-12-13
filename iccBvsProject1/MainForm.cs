using iccBvsProject1.Controllers;
using iccBvsProject1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iccBvsProject1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeUserControls();

            ucVideoLibrary.UCR = ucRental;  // enable ucVideoLibrary to have access (ex. calling methods) in the ucRental
            ucVideoLibrary.UCD = ucDashboard;
            ucCustomerLibrary.UCR = ucRental;
            ucRental.UCV = ucVideoLibrary;
            ucRental.UCD = ucDashboard;

            ShowUserControl(ucDashboard);
            labelSectionHeader.Text = "Dashboard";
        }

        private void InitializeUserControls()
        {
            ucVideoLibrary.Visible = false;
            ucCustomerLibrary.Visible = false;
            ucRental.Visible = false;
            ucDashboard.Visible = false;
            ucReports.Visible = false;
        }

        private void HideAllUserControls()
        {
            ucVideoLibrary.Visible = false;
            ucCustomerLibrary.Visible = false;
            ucRental.Visible = false;
            ucDashboard.Visible = false;
            ucReports.Visible = false;
        }

        private void ShowUserControl(UserControl uc)
        {
            HideAllUserControls();
            uc.Visible = true;   
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ShowUserControl(ucDashboard);
            labelSectionHeader.Text = "Dashboard";
        }

        private void buttonRental_Click(object sender, EventArgs e)
        {
            ShowUserControl(ucRental);
            labelSectionHeader.Text = "Rental Records";
        }

        private void buttonVideoLibrary_Click(object sender, EventArgs e)
        {
            ShowUserControl(ucVideoLibrary);
            labelSectionHeader.Text = "Video Library";
        }

        private void buttonCustomerLibrary_Click(object sender, EventArgs e)
        {
            ShowUserControl(ucCustomerLibrary);
            labelSectionHeader.Text = "Customer Library";
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            ShowUserControl(ucReports);
            labelSectionHeader.Text = "Reports";
        }
    }
}
