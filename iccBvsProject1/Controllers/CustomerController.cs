using iccBvsProject1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace iccBvsProject1.Controllers
{
    class CustomerController
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
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn))
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
        
        public DataTable RetrieveSpecific(CustomerModel cm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    string query = "";
                    // 7. SQL Introduction
                    // Context #8: SQL Select Statement (with Comparison Operator (=) and Logical Operator (LIKE))
                    if (cm.SearchBy == 0) query = "SELECT * FROM Customer WHERE customer_id LIKE @SearchValue";

                    if (cm.SearchBy == 1) query = "SELECT * FROM Customer WHERE name LIKE @SearchValue";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchValue", "%" + cm.SearchByValue + "%");
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
        
        public void Create(CustomerModel cm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #9: SQL Insert Statement (Without specifying column name)
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Customer VALUES (@Id, @Name, @Mobile, @Email, @Address)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", cm.Id);
                        cmd.Parameters.AddWithValue("@Name", cm.Name);
                        cmd.Parameters.AddWithValue("@Mobile", cm.Mobile);
                        cmd.Parameters.AddWithValue("@Email", cm.Email);
                        cmd.Parameters.AddWithValue("@Address", cm.Address);

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
        
        public void Update(CustomerModel cm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #10: SQL Update Statement (multiple)
                    using (SqlCommand cmd = new SqlCommand("UPDATE Customer SET name = @name, mobile = @Mobile, email = @Email, address = @Address WHERE customer_id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", cm.Id);
                        cmd.Parameters.AddWithValue("@Name", cm.Name);
                        cmd.Parameters.AddWithValue("@Mobile", cm.Mobile);
                        cmd.Parameters.AddWithValue("@Email", cm.Email);
                        cmd.Parameters.AddWithValue("@Address", cm.Address);

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
        
        public void Delete(CustomerModel cm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
                {
                    conn.Open();
                    // 7. SQL Introduction
                    // Context #11: SQL Delete Statement (single)
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE customer_id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", cm.Id);

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
