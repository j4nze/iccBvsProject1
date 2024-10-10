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
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Video", conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
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
                    if (vm.SearchBy == 0) query = "SELECT * FROM Video WHERE video_id LIKE @SearchValue";

                    if (vm.SearchBy == 1) query = "SELECT * FROM Video WHERE title LIKE @SearchValue";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@SearchValue", "%" + vm.SearchByValue + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
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
                    using (SqlCommand command = new SqlCommand("INSERT INTO Video VALUES (@Id, @Title, @Director, @Release, @RentLimit, @Price, @Format, @TotalQty, @InQty, @OutQty, @Synopsis)", conn))
                    {
                        command.Parameters.AddWithValue("@Id", vm.Id);
                        command.Parameters.AddWithValue("@Title", vm.Title);
                        command.Parameters.AddWithValue("@Director", vm.Director);
                        command.Parameters.AddWithValue("@Release", vm.Release);
                        command.Parameters.AddWithValue("@RentLimit", vm.RentLimit);
                        command.Parameters.AddWithValue("@Price", vm.Price);
                        command.Parameters.AddWithValue("@Format", vm.Format);
                        command.Parameters.AddWithValue("@TotalQty", vm.TotalQty);
                        command.Parameters.AddWithValue("@InQty", vm.InQty);
                        command.Parameters.AddWithValue("@OutQty", vm.OutQty);
                        command.Parameters.AddWithValue("@Synopsis", vm.Synopsis);

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
        public void Update(VideoModel vm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE Video SET title = @Title, director = @Director, release_date = @Release, rent_limit = @RentLimit, price = @Price, format = @Format, synopsis = @Synopsis WHERE video_id = @Id", conn))
                    {
                        command.Parameters.AddWithValue("@Id", vm.Id);
                        command.Parameters.AddWithValue("@Title", vm.Title);
                        command.Parameters.AddWithValue("@Director", vm.Director);
                        command.Parameters.AddWithValue("@Release", vm.Release);
                        command.Parameters.AddWithValue("@RentLimit", vm.RentLimit);
                        command.Parameters.AddWithValue("@Price", vm.Price);
                        command.Parameters.AddWithValue("@Format", vm.Format);
                        command.Parameters.AddWithValue("@Synopsis", vm.Synopsis);

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

                    using (SqlCommand command = new SqlCommand("UPDATE Video SET total_qty = @TotalQty , in_qty = @InQty WHERE video_id = @Id", conn))
                    {
                        command.Parameters.AddWithValue("@Id", vm.Id);
                        command.Parameters.AddWithValue("@TotalQty", vm.TotalQty);
                        command.Parameters.AddWithValue("@InQty", vm.InQty);

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
        public void Delete(VideoModel vm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
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
