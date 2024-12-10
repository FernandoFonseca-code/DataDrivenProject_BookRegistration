using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenProject_BookRegistration
{
    internal class Registered
    {
        // create registered object with properties customer id, isbn, and regdate
        private int _customerID;
        private string _ISBN;
        private DateTime _regDate;
 
    // create constructor for registered object
        public Registered()
        {
        }

        // create constructor for registered object with customer id, isbn, and regdate
        public Registered(int customerID, string ISBN, DateTime regDate)
        {
            CustomerID = customerID;
            bookISBN = ISBN;
            RegDate = regDate;
        }

        // create property for customer id from user selected customer from customer table in cbxCustomer
        public int CustomerID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value;
            }
        }

        public string bookISBN
        {
            get
            {
                return _ISBN;
            }
            set
            {
                // if isbn is already in registration table, throw exception
                if (RegistrationValidation.IsISBNRegistered(value))
                {
                    throw new ArgumentException("* ISBN already registered");
                }
                _ISBN = value;
            }
        }
        public DateTime RegDate
        {
            get
            {
                return _regDate;
            }
            set
            {
                _regDate = value;
            }
        }
    }
}
