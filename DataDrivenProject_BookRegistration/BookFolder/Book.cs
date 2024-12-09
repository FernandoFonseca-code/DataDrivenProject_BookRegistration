using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenProject_BookRegistration
{
    internal class Book
    {
        private string _bookISBN;
        private string _bookTitle;
        private double _price;

        public Book(string bookISBN, string bookTitle, double price)
        {
            BookISBN = bookISBN;
            BookTitle = bookTitle;
            Price = price;
        }

        public string BookISBN
        {
            get
            {
                return _bookISBN;
            }
            set
            {
                if (BookValidation.ValidateBookISBN(value))
                {
                    _bookISBN = value;
                }
                else
                {
                    throw new ArgumentException("* Please enter a valid 10 or 13 digit ISBN");
                }
            }
        }

        public string BookTitle
        {
            get
            {
                return _bookTitle;
            }
            set
            {
                if (BookValidation.ValidateBookTitle(value))
                {
                    _bookTitle = value;
                }
                else
                {
                    throw new ArgumentException("* Title cannot be empty or null");
                }
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (BookValidation.ValidateBookPrice(value))
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException("* Price cannot be empty or null and more than zero");
                }
            }
        }
    }
}
