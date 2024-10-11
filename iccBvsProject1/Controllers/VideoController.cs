using iccBvsProject1.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace iccBvsProject1.Controllers
{
    class VideoController
    {
        DataTable dt = new DataTable();
        public DataTable RetrieveAll()
        {
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
        public DataTable RetrieveSpecific(VideoModel vm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    string query = "";
                    // 7. SQL Introduction
                    // Context #8: SQL Select Statement (with Comparison Operator (=) and Logical Operator (LIKE))
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
                    using (SqlCommand cmd = new SqlCommand("UPDATE Video SET total_qty = @TotalQty , in_qty = @InQty WHERE video_id = @Id", conn))
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
