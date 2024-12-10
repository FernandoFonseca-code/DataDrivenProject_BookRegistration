using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenProject_BookRegistration
{
    internal static class BookTable
    {
        // Add the book to the book table in the database
        public static void Add(Book b)
        {
            DBHelper.InsertCmd.CommandText = """
                                        INSERT INTO Book (ISBN, Title, Price)
                                        VALUES (@BookISBN, @BookTitle, @Price)
                                        """;

            DBHelper.InsertCmd.Parameters.Clear();

            DBHelper.InsertCmd.Parameters.AddWithValue("@BookISBN", b.BookISBN);
            DBHelper.InsertCmd.Parameters.AddWithValue("@BookTitle", b.BookTitle);
            DBHelper.InsertCmd.Parameters.AddWithValue("@Price", b.Price);

            // Open connection to the connection
            DBHelper.Connection.Open();

            // Execute the INSERT query statement
            DBHelper.InsertCmd.ExecuteNonQuery();

            // Close the connection to the datablase
            DBHelper.Connection.Close();
        }
        public static List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            DBHelper.SelectCmd.CommandText = """
                                             SELECT * 
                                             FROM Book
                                             """;
            DBHelper.Connection.Open();

            SqlDataReader reader = DBHelper.SelectCmd.ExecuteReader();
            while (reader.Read())
            {
                Book b = new Book()
                {
                    BookISBN = reader["ISBN"].ToString(),
                    Price = Convert.ToDouble(reader["Price"]),
                    BookTitle = reader["Title"].ToString(),
                };
                books.Add(b);
            }
            DBHelper.Connection.Close();
            return books;
        }
    }
}
