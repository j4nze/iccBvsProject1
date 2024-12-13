using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace iccBvsProject1.Controllers
{
    class ReportController
    {
        public List<(DateTime Date, double Value)> RetrieveRevenue()
        {
            var dataPoints = new List<(DateTime Date, double Value)>();

            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT return_date, total_price FROM Rental ORDER BY return_date";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime date = reader.GetDateTime(0);
                                double value = reader.GetDouble(1);
                                dataPoints.Add((date, value));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching chart data: {ex.Message}");
            }

            return dataPoints;
        }

    }
}
