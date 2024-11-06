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
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Rental", conn))
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
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    string query = "";
                    // 7. SQL Introduction
                    // Context #8: SQL Select Statement (with Comparison Operator (=) and Logical Operator (LIKE))
                    if (rm.SearchBy == 0) query = "SELECT * FROM Rental WHERE customer_id LIKE @SearchValue";

                    if (rm.SearchBy == 1) query = "SELECT * FROM Rental WHERE name LIKE @SearchValue";

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
                    // Context #10: SQL Update Statement (multiple)
                    using (SqlCommand cmd = new SqlCommand("UPDATE Rental SET name = @name, mobile = @Mobile, email = @Email, address = @Address WHERE customer_id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", rm.Id);
                        //cmd.Parameters.AddWithValue("@Name", rm.Name);
                        //cmd.Parameters.AddWithValue("@Mobile", rm.Mobile);
                        //cmd.Parameters.AddWithValue("@Email", rm.Email);
                        //cmd.Parameters.AddWithValue("@Address", rm.Address);

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
