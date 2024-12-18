﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenProject_BookRegistration
{
    internal class CustomerValidation
    {
        public static bool ValidateCustomerTitle(String Title)
        {
            if (String.IsNullOrWhiteSpace(Title))
            {
                return false;
            }
            return true;
        }
        public static bool ValidateCustomerFirstName(String FirstName)
        {
            if (String.IsNullOrWhiteSpace(FirstName.Trim()))
            {
                return false;
            }
            return true;
        }
        public static bool ValidateCustomerLastName(String LastName)
        {
                if (String.IsNullOrWhiteSpace(LastName.Trim()))
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
