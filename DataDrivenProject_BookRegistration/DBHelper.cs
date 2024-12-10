using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenProject_BookRegistration
{
    public static class DBHelper
    {
        public static SqlCommand SelectCmd { get; set; }
        public static SqlCommand InsertCmd { get; set; }
        public static SqlConnection Connection { get; set; }

        static DBHelper()
        {
            Connection = new SqlConnection("Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            SelectCmd = new SqlCommand();
            SelectCmd.Connection = Connection;
            InsertCmd = new SqlCommand();
            InsertCmd.Connection = Connection;
        }
    }
}
