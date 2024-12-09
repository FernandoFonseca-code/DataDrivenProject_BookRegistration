using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataDrivenProject_BookRegistration
{
    internal class BookValidation
    {
        public static bool ValidateBookISBN(string bookISBN)
        {
            return bookISBN.Length == 10 || bookISBN.Length == 13 && bookISBN.All(char.IsDigit);
        }

        public static bool ValidateBookTitle(string title)
        {
            if (String.IsNullOrWhiteSpace(title))
            {
                return false;
            }
            return true;
        }

        public static bool ValidateBookPrice(double price)
        {
            if (price <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
