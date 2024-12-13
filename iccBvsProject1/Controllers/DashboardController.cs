using iccBvsProject1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace iccBvsProject1.Controllers
{
    class DashboardController
    {
        public int RetrieveAllRentCount()
        {
            int totalRentCount = 0;

            try
            {
                // 7. SQL Introduction
                // Context #8: SQL Select Statement
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM RENTAL WHERE status = 'RENTED';", conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out totalRentCount)) return totalRentCount;
                        else return 0;

                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return totalRentCount;
        }

        public int RetrieveOverdueRentCount()
        {
            int overdueCount = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM RENTAL WHERE status = 'RENTED' AND expected_return_date < @CurrentDate;", conn))
                    {
                        cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Now);

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out overdueCount))
                        {
                            return overdueCount;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return overdueCount;
        }

        public int RetrieveAllAvailableVideoCount()
        {
            int totalVideoQtyCount = 0;

            try
            {
                // 7. SQL Introduction
                // Context #8: SQL Select Statement
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT SUM(in_qty) FROM Video", conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out totalVideoQtyCount)) return totalVideoQtyCount;
                        else return 0;

                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return totalVideoQtyCount;
        }

        public int RetrieveTotalReturnRevenue()
        {
            int totalReturnRevenue = 0;

            try
            {
                // 7. SQL Introduction
                // Context #8: SQL Select Statement
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT SUM(total_price) FROM RENTAL WHERE status = 'RETURNED';", conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out totalReturnRevenue)) return totalReturnRevenue;
                        else return 0;

                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return totalReturnRevenue;
        }

        public DataTable RetrieveAllOverduedRent()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #8: SQL Select Statement (with condition)
                    using (SqlCommand cmd = new SqlCommand("SELECT rent_id, rental_date, expected_return_date FROM RENTAL where status = 'RENTED' AND expected_return_date < @CurrentDate ORDER BY expected_return_date ASC;", conn))
                    {
                        cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Now);
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return dt;
        }

        public DataTable RetrieveAllLowStockAvaibleVideos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #8: SQL Select Statement
                    using (SqlCommand cmd = new SqlCommand("SELECT video_id, title, in_qty, out_qty, total_qty FROM Video WHERE in_qty <= 10 ORDER BY title", conn))
                    {
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return dt;
        }
    }
}
