using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenProject_BookRegistration
{ 
    internal class RegistrationValidation
    {
        public static bool IsISBNRegistered(string ISBN)
        {
            // check if isbn is already in registration table
            if (BookRegistrationTable.RegistrationCheck().Contains(ISBN))
            {
                throw new ArgumentException("* Book is already registered, Please select another Book");
            }
            return false;
        }
    }
}
