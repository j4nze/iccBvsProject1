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
using System.Windows.Forms.VisualStyles;

namespace iccBvsProject1.Views
{
    public partial class UserControlDashboard : UserControl
    {
        private DashboardController dc = new DashboardController();
        private DataTable dt;
        public UserControlDashboard()
        {
            InitializeComponent();

            LoadSummary();
            LoadOverduedRentals();
            LoadLowStockAvailableVideos();
        }

        public void LoadSummary()
        {
            labelTotalRent.Text = dc.RetrieveAllRentCount().ToString();
            labelTotalOverduedRent.Text = dc.RetrieveOverdueRentCount().ToString();
            labelTotalVideo.Text = dc.RetrieveAllAvailableVideoCount().ToString();
            labelTotalReturnProfit.Text = "₱ " + dc.RetrieveTotalReturnRevenue().ToString();
            
        }
        
        public void LoadOverduedRentals()
        {
            dt = dc.RetrieveAllOverduedRent();
            dataGridViewOverduedRentals.DataSource = dt;

            dataGridViewOverduedRentals.Columns["rent_id"].HeaderText = "Rent ID";
            dataGridViewOverduedRentals.Columns["rental_date"].HeaderText = "Rental Date";
            dataGridViewOverduedRentals.Columns["expected_return_date"].HeaderText = "Expected Return Date";
        }

        public void LoadLowStockAvailableVideos()
        {
            dt = dc.RetrieveAllLowStockAvaibleVideos();
            dataGridViewLowStockVideos.DataSource = dt;

            dataGridViewLowStockVideos.Columns["video_id"].HeaderText = "Video ID";
            dataGridViewLowStockVideos.Columns["title"].HeaderText = "Title";
            dataGridViewLowStockVideos.Columns["in_qty"].HeaderText = "In (Qty)";
            dataGridViewLowStockVideos.Columns["out_qty"].HeaderText = "Out (Qty)";
            dataGridViewLowStockVideos.Columns["total_qty"].HeaderText = "Total (Qty)";
        }
    }
}
