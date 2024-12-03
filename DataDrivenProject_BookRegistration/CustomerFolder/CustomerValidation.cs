using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenProject_BookRegistration
{
    internal class CustomerValidation
    {
        public static bool ValidateCustomerFirstName(String FirstName)
        {
            if (FirstName.Length == 0 || FirstName == null)
            {
                return false;
            }
            return true;
        }
        public static bool ValidateCustomerLastName(String LastName)
        {
                if (LastName.Length == 0 || LastName == null)
                {
                    return false;
                }
                return true;
            }
        public static bool ValidateCustomerDateOfBirth(DateTime DateOfBirth)
        { 
            var age = DateTime.Today.Year - DateOfBirth.Year;

            if (age < 18)
            {
                return false;
            }
            return true;
        }
    }
}
