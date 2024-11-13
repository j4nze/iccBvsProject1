using iccBvsProject1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace iccBvsProject1.Controllers
{
    class VideoController
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
                    // Context #8: SQL Select Statement
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Video", conn))
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

        public int RetrieveAllVideoCount()
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

        public DataTable RetrieveSpecific(VideoModel vm)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    string query = "";
                    // 7. SQL Introduction
                    // Context #8: SQL Select Statement (with Logical Operator (LIKE))
                    if (vm.SearchBy == 0) query = "SELECT * FROM Video WHERE video_id LIKE @SearchValue";

                    if (vm.SearchBy == 1) query = "SELECT * FROM Video WHERE title LIKE @SearchValue";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchValue", "%" + vm.SearchByValue + "%");
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
                    using (SqlCommand cmd = new SqlCommand("SELECT video_id, title, format, rent_limit, price FROM Video ORDER BY title", conn))
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
        
        public void Create(VideoModel vm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #9: SQL Insert Statement (Without specifying column name)
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Video VALUES (@Id, @Title, @Director, @Release, @RentLimit, @Price, @Format, @TotalQty, @InQty, @OutQty, @Synopsis)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", vm.Id);
                        cmd.Parameters.AddWithValue("@Title", vm.Title);
                        cmd.Parameters.AddWithValue("@Director", vm.Director);
                        cmd.Parameters.AddWithValue("@Release", vm.Release);
                        cmd.Parameters.AddWithValue("@RentLimit", vm.RentLimit);
                        cmd.Parameters.AddWithValue("@Price", vm.Price);
                        cmd.Parameters.AddWithValue("@Format", vm.Format);
                        cmd.Parameters.AddWithValue("@TotalQty", vm.TotalQty);
                        cmd.Parameters.AddWithValue("@InQty", vm.InQty);
                        cmd.Parameters.AddWithValue("@OutQty", vm.OutQty);
                        cmd.Parameters.AddWithValue("@Synopsis", vm.Synopsis);

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
        
        public void Update(VideoModel vm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #10: SQL Update Statement (multiple)
                    using (SqlCommand cmd = new SqlCommand("UPDATE Video SET title = @Title, director = @Director, release_date = @Release, rent_limit = @RentLimit, price = @Price, format = @Format, synopsis = @Synopsis WHERE video_id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", vm.Id);
                        cmd.Parameters.AddWithValue("@Title", vm.Title);
                        cmd.Parameters.AddWithValue("@Director", vm.Director);
                        cmd.Parameters.AddWithValue("@Release", vm.Release);
                        cmd.Parameters.AddWithValue("@RentLimit", vm.RentLimit);
                        cmd.Parameters.AddWithValue("@Price", vm.Price);
                        cmd.Parameters.AddWithValue("@Format", vm.Format);
                        cmd.Parameters.AddWithValue("@Synopsis", vm.Synopsis);

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
        
        public void UpdateQty(VideoModel vm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();

                    if (vm.NewInOperation == 0)         // Addition
                    {
                        vm.InQty += vm.NewInQty;
                        vm.TotalQty += vm.NewInQty;
                    }
                    else if (vm.NewInOperation == 1)    // Subtraction
                    {
                        if (vm.NewInQty > vm.InQty)
                        {
                            MessageBox.Show("Quantity must be less than the available (In) quantity");
                            return;
                        }

                        vm.InQty -= vm.NewInQty;
                        vm.TotalQty -= vm.NewInQty;
                    }
                    // 7. SQL Introduction
                    // Context #10: SQL Update Statement (multiple)
                    using (SqlCommand cmd = new SqlCommand("UPDATE Video SET total_qty = @TotalQty, in_qty = @InQty WHERE video_id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", vm.Id);
                        cmd.Parameters.AddWithValue("@TotalQty", vm.TotalQty);
                        cmd.Parameters.AddWithValue("@InQty", vm.InQty);

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

        public void RentQty(string video_id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #10: SQL Update Statement (multiple)
                    using (SqlCommand cmd = new SqlCommand("UPDATE Video SET in_qty = in_qty - 1, out_qty = out_qty + 1 WHERE video_id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", video_id);

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

        public void ReturnQty(string video_id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #10: SQL Update Statement (multiple)
                    using (SqlCommand cmd = new SqlCommand("UPDATE Video SET in_qty = in_qty + 1, out_qty = out_qty - 1 WHERE video_id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", video_id);

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

        public void Delete(VideoModel vm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #11: SQL Delete Statement (single)
                    using (SqlCommand command = new SqlCommand("DELETE FROM Video WHERE video_id = @Id", conn))
                    {
                        command.Parameters.AddWithValue("@Id", vm.Id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0) MessageBox.Show("Success");
                        else MessageBox.Show("Failed");
                    }
                }
            }
            catch (SqlException sqlExc)
            {
                if (sqlExc.Number == 547)
                {
                    MessageBox.Show("Failed. This video is currently used in the rental record/s.");
                }
                else
                {
                    // For other SQL exceptions
                    MessageBox.Show($"SQL Error: {sqlExc.Message}");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
