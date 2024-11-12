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
        private CustomerController cc = new CustomerController();
        private VideoController vc = new VideoController();
        private RentController rc = new RentController();
        private DataTable dt;
        public UserControlDashboard()
        {
            InitializeComponent();

            LoadSummary();
        }

        public void LoadSummary()
        {
            labelTotalRent.Text = rc.RetrieveAllRentCount().ToString();
            labelTotalVideo.Text = vc.RetrieveAllVideoCount().ToString();
            labelTotalReturnProfit.Text = "₱ " + rc.RetrieveTotalReturnRevenue().ToString();

            dt = rc.RetrieveAllRent();
            dataGridViewRent.DataSource = dt;

            labelTotalOverduedRent.Text = CountOverdueRentals(dt).ToString();
        }

        private int CountOverdueRentals(DataTable rentalData)
        {
            DateTime currentDate = DateTime.Now;
            int overdueCount = 0;

            foreach (DataRow row in rentalData.Rows)
            {
                if (row["expected_return_date"] != DBNull.Value)
                {
                    DateTime expectedReturnDate = Convert.ToDateTime(row["expected_return_date"]);
                    if (expectedReturnDate < currentDate) overdueCount++;
                }
            }

            return overdueCount;
        }
    }
}
