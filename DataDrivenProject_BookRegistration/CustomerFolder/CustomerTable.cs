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
        // Add the customer to the database
        public static void Add(Customer c)
        {
            // Establish connection to the database
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            {
                // Create a SQL INSERT Command
                SqlCommand insertCmd = new SqlCommand();
                insertCmd.Connection = conn;
                insertCmd.CommandText = """
                                         INSERT INTO Customer (Title, FirstName, LastName, DateOfBirth)
                                         VALUES (@Title, @FirstName, @LastName, @DateOfBirth)
                                         """;
                insertCmd.Parameters.AddWithValue("@Title", c.Title);
                insertCmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                insertCmd.Parameters.AddWithValue("@LastName", c.LastName);
                insertCmd.Parameters.AddWithValue("@DateOfBirth", c.DateOfBirth);

                // Open connection to the connection
                conn.Open();

                // Execute the INSERT query statement
                insertCmd.ExecuteNonQuery();

                // Close the connection to the datablase
                conn.Close();
            }
        }

        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                SqlCommand selectCmd = new SqlCommand();
                selectCmd.Connection = conn;
                selectCmd.CommandText = """
                                        SELECT * 
                                        FROM Customer
                                        """;
                conn.Open();
                SqlDataReader reader = selectCmd.ExecuteReader();
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
            return customers;
        }

        public static void Update(Customer c)
        {
            throw new NotImplementedException();
        }

        public static void Delete(Customer c)
        {
            throw new NotImplementedException();
        }

        public static void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public static Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}