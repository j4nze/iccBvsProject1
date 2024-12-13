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
                        "r.return_date, " +
                        "r.overdue_days, " +
                        "r.overdue_price, " +
                        "r.total_price, " +
                        "v.format," +
                        "v.rent_limit," +
                        "r.notes " +
                        "FROM Rental r " +
                        "INNER JOIN Video v ON r.video_id = v.video_id " +
                        "INNER JOIN Customer c ON r.customer_id = c.customer_id " +
                        "ORDER BY r.status ASC, r.expected_return_date ASC;", conn))
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
                        "r.return_date, " +
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

                    string query = baseQuery + whereClause + "ORDER BY r.status ASC, r.expected_return_date ASC;";

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
        public void Create(RentModel rm, string video_id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #9: SQL Insert Statement (Without specifying column name)
                    using (SqlCommand cmdCreateRent = new SqlCommand("INSERT INTO Rental VALUES (@Id, @RentalDate, @ExpectedReturnDate, @ReturnDate, @OverdueDays, @OverduePrice, @TotalPrice, @Status, @Notes, @VideoId, @CustomerId)", conn))
                    {
                        cmdCreateRent.Parameters.AddWithValue("@Id", rm.Id);
                        cmdCreateRent.Parameters.AddWithValue("@RentalDate", rm.RentalDate);
                        cmdCreateRent.Parameters.AddWithValue("@ExpectedReturnDate", rm.ExpectedReturnDate);
                        cmdCreateRent.Parameters.AddWithValue("@ReturnDate", "");
                        cmdCreateRent.Parameters.AddWithValue("@OverdueDays", rm.OverdueDays);
                        cmdCreateRent.Parameters.AddWithValue("@OverduePrice", rm.OverduePrice);
                        cmdCreateRent.Parameters.AddWithValue("@TotalPrice", rm.TotalPrice);
                        cmdCreateRent.Parameters.AddWithValue("@Status", rm.Status);
                        cmdCreateRent.Parameters.AddWithValue("@Notes", rm.Notes);
                        cmdCreateRent.Parameters.AddWithValue("@VideoId", rm.VideoId);
                        cmdCreateRent.Parameters.AddWithValue("@CustomerId", rm.CustomerId);

                        int rowsAffected = cmdCreateRent.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            using (SqlCommand cmdUpdateVideoQty = new SqlCommand("UPDATE Video SET in_qty = in_qty - 1, out_qty = out_qty + 1 WHERE video_id = @Id", conn))
                            {
                                cmdUpdateVideoQty.Parameters.AddWithValue("@Id", video_id);

                                rowsAffected = cmdUpdateVideoQty.ExecuteNonQuery();

                                if (rowsAffected > 0) MessageBox.Show("Success");
                                else MessageBox.Show("Failed");
                            }
                        }
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
        public void Update(RentModel rm, string video_id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #10: SQL Update Statement (single)
                    using (SqlCommand cmdReturn = new SqlCommand("UPDATE Rental SET status = @status, return_date = @returnDate WHERE rent_id = @Id", conn))
                    {
                        cmdReturn.Parameters.AddWithValue("@Id", rm.Id);
                        cmdReturn.Parameters.AddWithValue("@status", rm.Status);
                        cmdReturn.Parameters.AddWithValue("@returnDate", rm.ReturnDate);

                        int rowsAffected = cmdReturn.ExecuteNonQuery();

                        if (rowsAffected > 0) 
                        {
                            using (SqlCommand cmdUpdateVideoQty = new SqlCommand("UPDATE Video SET in_qty = in_qty + 1, out_qty = out_qty - 1 WHERE video_id = @Id", conn))
                            {
                                cmdUpdateVideoQty.Parameters.AddWithValue("@Id", video_id);

                                rowsAffected = cmdUpdateVideoQty.ExecuteNonQuery();

                                if (rowsAffected > 0) MessageBox.Show("Success");
                                else MessageBox.Show("Failed");
                            }
                        }
                        else MessageBox.Show("Failed");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Customer Selection
        public List<Models.CustomerNameComboBoxItem> RetrieveAllNames()
        {
            var list = new List<Models.CustomerNameComboBoxItem>();

            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #8: SQL Select Statement
                    using (SqlCommand cmd = new SqlCommand("SELECT customer_id, name FROM Customer ORDER BY name", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader["customer_id"].ToString();
                                string name = reader["name"].ToString();

                                list.Add(new Models.CustomerNameComboBoxItem(id, name));
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return list;
        }

        // Video Selection
        public List<Models.VideoTitleComboBoxItem> RetrieveAllTitles()
        {
            var list = new List<Models.VideoTitleComboBoxItem>();

            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #8: SQL Select Statement
                    using (SqlCommand cmd = new SqlCommand("SELECT video_id, title, format, rent_limit, price, in_qty FROM Video WHERE in_qty > 0 ORDER BY title", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader["video_id"].ToString();
                                string title = reader["title"].ToString();
                                int rentLimit = Convert.ToInt32(reader["rent_limit"].ToString());
                                int price = Convert.ToInt32(reader["price"].ToString());
                                string format = reader["format"].ToString();

                                list.Add(new Models.VideoTitleComboBoxItem(id, title, rentLimit, price, format));
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return list;
        }

        // Selected Video Quantity
        public int RetrieveSpecificQty(string video_id)
        {
            int currentQuantity = 0;

            try
            {
                // 7. SQL Introduction
                // Context #8: SQL Select Statement
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT in_qty FROM Video WHERE video_id = @SearchValue", conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchValue", video_id);
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out currentQuantity)) return currentQuantity;
                        else return 0;

                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return currentQuantity;
        }
    }
}
