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
    class RentController
    {
        public DataTable RetrieveAll()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #16: SQL JOIN (INNER)
                    using (SqlCommand cmd = new SqlCommand("SELECT " +
                        "r.rent_id, " +
                        "r.status, " +
                        "c.customer_id," +
                        "c.name," +
                        "v.video_id," +
                        "v.title," +
                        "v.price," +
                        "r.rental_date, " +
                        "r.expected_return_date, " +
                        "r.overdue_days, " +
                        "r.overdue_price, " +
                        "r.total_price, " +
                        "v.format," +
                        "v.rent_limit," +
                        "r.notes " +
                        "FROM Rental r " +
                        "INNER JOIN Video v ON r.video_id = v.video_id " +
                        "INNER JOIN Customer c ON r.customer_id = c.customer_id " +
                        "ORDER BY r.status;", conn))
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

        public DataTable RetrieveAllRent()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #8: SQL Select Statement (with condition)
                    using (SqlCommand cmd = new SqlCommand("SELECT rent_id, customer_id, video_id, overdue_days, overdue_price, total_price, rental_date, expected_return_date FROM RENTAL where status = 'RENTED';", conn))
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

        public DataTable RetrieveSpecific(RentModel rm)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    string baseQuery = "SELECT " +
                        "r.rent_id, " +
                        "r.status, " +
                        "c.customer_id, " +
                        "c.name, " +
                        "v.video_id, " +
                        "v.title, " +
                        "v.price, " +
                        "r.rental_date, " +
                        "r.expected_return_date, " +
                        "r.overdue_days, " +
                        "r.overdue_price, " +
                        "r.total_price, " +
                        "v.format, " +
                        "v.rent_limit, " +
                        "r.notes " +
                        "FROM Rental r " +
                        "INNER JOIN Video v ON r.video_id = v.video_id " +
                        "INNER JOIN Customer c ON r.customer_id = c.customer_id ";
                    // 7. SQL Introduction
                    // Context #16: SQL JOIN (INNER) (with Comparison Operator (=) and Logical Operator (LIKE))
                    string whereClause = string.Empty;
                    switch (rm.SearchBy)
                    {
                        case 0:
                            whereClause = "WHERE r.rent_id LIKE @SearchValue ";
                            break;
                        case 1:
                            whereClause = "WHERE v.title LIKE @SearchValue ";
                            break;
                        case 2:
                            whereClause = "WHERE c.name LIKE @SearchValue ";
                            break;
                        default:
                            whereClause = "WHERE r.rent_id LIKE @SearchValue ";
                            break;
                    }

                    string query = baseQuery + whereClause + "ORDER BY r.status;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchValue", "%" + rm.SearchByValue + "%");
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);
                    }
                }

                if (dt.Rows.Count <= 0) MessageBox.Show("Does Not Exist");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return dt;
        }
        
        // RENT
        public void Create(RentModel rm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #9: SQL Insert Statement (Without specifying column name)
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Rental VALUES (@Id, @RentalDate, @ExpectedReturnDate, @OverdueDays, @OverduePrice, @TotalPrice, @Status, @Notes, @VideoId, @CustomerId)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", rm.Id);
                        cmd.Parameters.AddWithValue("@RentalDate", rm.RentalDate);
                        cmd.Parameters.AddWithValue("@ExpectedReturnDate", rm.ReturnDate);
                        cmd.Parameters.AddWithValue("@OverdueDays", rm.OverdueDays);
                        cmd.Parameters.AddWithValue("@OverduePrice", rm.OverduePrice);
                        cmd.Parameters.AddWithValue("@TotalPrice", rm.TotalPrice);
                        cmd.Parameters.AddWithValue("@Status", rm.Status);
                        cmd.Parameters.AddWithValue("@Notes", rm.Notes);
                        cmd.Parameters.AddWithValue("@VideoId", rm.VideoId);
                        cmd.Parameters.AddWithValue("@CustomerId", rm.CustomerId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0) MessageBox.Show("Success");
                        else MessageBox.Show("Failed");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        
        // RETURN
        public void Update(RentModel rm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #10: SQL Update Statement (single)
                    using (SqlCommand cmd = new SqlCommand("UPDATE Rental SET status = @Status WHERE rent_id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", rm.Id);
                        cmd.Parameters.AddWithValue("@status", rm.Status);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0) MessageBox.Show("Success");
                        else MessageBox.Show("Failed");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
