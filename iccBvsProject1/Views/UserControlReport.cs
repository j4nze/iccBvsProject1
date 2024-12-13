using iccBvsProject1.Controllers;
using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class UserControlReport : UserControl
    {
        private ReportController rc = new ReportController();

        public UserControlReport()
        {
            InitializeComponent();

            LoadRevenueData();
        }

        public void LoadRevenueData()
        {
            var dataPoints = rc.RetrieveRevenue();

            // Prepare the X and Y values
            var dates = dataPoints.Select(dp => dp.Date.ToShortDateString()).ToArray();
            var values = dataPoints.Select(dp => dp.Value).ToArray();

            // Set up the chart
            cartesianChartRevenue.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Data",
                    Values = new ChartValues<double>(values)
                }
            };

            // Configure the X-Axis
            cartesianChartRevenue.AxisX.Clear();
            cartesianChartRevenue.AxisX.Add(new Axis
            {
                Title = "return_date",
                Labels = dates
            });

            // Configure the Y-Axis
            cartesianChartRevenue.AxisY.Clear();
            cartesianChartRevenue.AxisY.Add(new Axis
            {
                Title = "total_price"
            });
        }

        private void buttonRevenueFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
