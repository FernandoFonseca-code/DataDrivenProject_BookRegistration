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
            return bookISBN.Length == 10 || bookISBN.Length == 13;
        }

        public static bool ValidateBookTitle(string title)
        {
            return !String.IsNullOrWhiteSpace(title);
        }

        public static bool ValidateBookPrice(double price)
        {
            return price > 0;
        }
    }
}
