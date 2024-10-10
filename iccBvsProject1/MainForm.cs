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
        }

        private void InitializeUserControls()
        {
            ucVideoLibrary.Visible = false;
            ucCustomerLibrary.Visible = false;
            ucRental.Visible = false;
        }

        private void HideAllUserControls()
        {
            ucVideoLibrary.Visible = false;
            ucCustomerLibrary.Visible = false;
            ucRental.Visible = false;
        }

        private void ShowUserControl(UserControl uc)
        {
            HideAllUserControls();
            uc.Visible = true;   
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            contextMenuStripLibrary.Show(buttonLibrary, new Point(buttonLibrary.Width, 0));
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(ucVideoLibrary);
            labelBreadCrumbHeader.Text = "Video Library";
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserControl(ucCustomerLibrary);
            labelBreadCrumbHeader.Text = "Customer Library";
        }

        private void buttonRental_Click(object sender, EventArgs e)
        {
            ShowUserControl(ucRental);
            labelBreadCrumbHeader.Text = "Rental Records";
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            labelBreadCrumbHeader.Text = "Dashboard";
        }
    }
}
