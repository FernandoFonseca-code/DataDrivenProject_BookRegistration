using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataDrivenProject_BookRegistration
{
    internal static class CustomerTable
    {
        // Add the customer to the customer table in the database
        public static void Add(Customer c)
        {
            DBHelper.InsertCmd.CommandText = """
                                            INSERT INTO Customer (Title, FirstName, LastName, DateOfBirth)
                                            VALUES (@Title, @FirstName, @LastName, @DateOfBirth)
                                            """;

            DBHelper.InsertCmd.Parameters.Clear();

            DBHelper.InsertCmd.Parameters.AddWithValue("@Title", c.Title);
            DBHelper.InsertCmd.Parameters.AddWithValue("@FirstName", c.FirstName);
            DBHelper.InsertCmd.Parameters.AddWithValue("@LastName", c.LastName);
            DBHelper.InsertCmd.Parameters.AddWithValue("@DateOfBirth", c.DateOfBirth);

            // Open connection to the connection
            DBHelper.Connection.Open();

            // Execute the INSERT query statement
            DBHelper.InsertCmd.ExecuteNonQuery();

            // Close the connection to the datablase
            DBHelper.Connection.Close();
        }

        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            // Ensure the connection is assigned
            DBHelper.SelectCmd.Connection = DBHelper.Connection;

            DBHelper.SelectCmd.CommandText = """
                                            SELECT * 
                                            FROM Customer
                                            """;
            DBHelper.Connection.Open();

            using (SqlDataReader reader = DBHelper.SelectCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Customer c = new Customer()
                    {
                        CustomerID = (int)reader["CustomerID"],
                        Title = reader["Title"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        DateOfBirth = (DateTime)reader["DateOfBirth"]
                    };
                    customers.Add(c);
                }
            }
            DBHelper.Connection.Close();
            return customers;
        }
    }
}