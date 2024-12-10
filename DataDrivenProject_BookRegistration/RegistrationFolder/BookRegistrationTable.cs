using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DataDrivenProject_BookRegistration
{
    internal static class BookRegistrationTable
    {
        public static void Add(Registered r)
        {
            DBHelper.InsertCmd.CommandText = """
                                        INSERT INTO Registration (CustomerID, ISBN, RegDate)
                                        VALUES (@CustomerID, @ISBN, @RegDate)
                                        """;
            DBHelper.InsertCmd.Parameters.Clear();

            DBHelper.InsertCmd.Parameters.AddWithValue("@CustomerID", r.CustomerID);
            DBHelper.InsertCmd.Parameters.AddWithValue("@ISBN", r.bookISBN);
            DBHelper.InsertCmd.Parameters.AddWithValue("@RegDate", r.RegDate);
            
            DBHelper.Connection.Open();
            DBHelper.InsertCmd.ExecuteNonQuery();
            DBHelper.Connection.Close();
        }
        public static List<string> RegistrationCheck()
        {
            List<string> ISBNs = new List<string>();
            DBHelper.SelectCmd.CommandText = """
                                        SELECT ISBN 
                                        FROM Registration
                                        """;
            DBHelper.Connection.Open();
            DBHelper.SelectCmd.ExecuteNonQuery();
            SqlDataReader reader = DBHelper.SelectCmd.ExecuteReader();
            while (reader.Read())
            {
                ISBNs.Add(reader["ISBN"].ToString());
            }
            DBHelper.Connection.Close();
            return ISBNs;
        }
        public static List<Registered> GetAllRegistrations()
        {
            List<Registered> registrations = new List<Registered>();
            DBHelper.SelectCmd.CommandText = """
                                        SELECT * 
                                        FROM Registration
                                        """;
            DBHelper.Connection.Open();
            SqlDataReader reader = DBHelper.SelectCmd.ExecuteReader();
            while (reader.Read())
            {
                Registered r = new Registered()
                {
                    CustomerID = (int)reader["CustomerID"],
                    bookISBN = reader["ISBN"].ToString(),
                    RegDate = (DateTime)reader["RegDate"]
                };
                registrations.Add(r);
            }
            DBHelper.Connection.Close();
            return registrations;
        }
    }
}
