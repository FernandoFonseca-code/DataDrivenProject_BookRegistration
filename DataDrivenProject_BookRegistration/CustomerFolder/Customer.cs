using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataDrivenProject_BookRegistration
{
    /// <summary>
    /// Represents a customer that wants to register a book.
    /// </summary>
    internal class Customer
    {
        private int _customerID;
        private string _title;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        public string FullName
        {
            get { return $"{LastName}, {FirstName}"; }
        }

        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public Customer(ComboBox title, string fname, string lname, DateTime dob)
        {
            Title = title.Text;
            FirstName = fname;
            LastName = lname;
            DateOfBirth = dob.Date;
        }

        public Customer()
        {
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (CustomerValidation.ValidateCustomerTitle(value))
                {
                    _title = value;
                }
                else
                {
                    throw new ArgumentException("* Please select a title");
                }
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (CustomerValidation.ValidateCustomerFirstName(value))
                {
                    _firstName = value.Trim();
                }
                else
                {
                    throw new ArgumentException("* First name cannot be empty or null");
                }
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (CustomerValidation.ValidateCustomerLastName(value))
                {
                    _lastName = value.Trim();
                }
                else
                {
                    throw new ArgumentException("* Last name cannot be empty or null");
                }
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (CustomerValidation.ValidateCustomerDateOfBirth(value))
                {
                    _dateOfBirth = value.Date;
                }
                else
                {
                    throw new ArgumentException("* You must be 18 or older to register a book");
                }
            }
        }
    }
}
