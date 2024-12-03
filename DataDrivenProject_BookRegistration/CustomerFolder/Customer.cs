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
        private int _customerId;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;

        public Customer(string fname, string lname, DateTime dob)
        {
            FirstName = fname;
            LastName = lname;
            DateOfBirth = dob;
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
                    _firstName = value;
                }
                else
                {
                    MessageBox.Show("First name cannot be empty or null","Entry Error");
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
                    _lastName = value;
                }
                else
                {
                    MessageBox.Show("Last name cannot be empty or null","Entry Error");
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
                    _dateOfBirth = value;
                }
                else
                {
                    MessageBox.Show("You must be 18 or older to register a book");
                }
            }
        }
    }
}
