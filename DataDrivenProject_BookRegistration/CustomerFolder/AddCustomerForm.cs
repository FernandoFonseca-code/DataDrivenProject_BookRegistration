using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataDrivenProject_BookRegistration
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newCustomer = new Customer(txtFirstName.Text, txtLastName.Text, dtpDateOfBirth.Value);
                // test code
                MessageBox.Show($"First name is {newCustomer.FirstName} and last name is {newCustomer.LastName} with a Date of Birth of {newCustomer.DateOfBirth.Date}");
            }
            catch (ArgumentException exception)
            {
                var error = exception.Message;
                switch (exception.Message)
                {
                    case "* First name cannot be empty or null":
                        lblFirstNameError.Text = exception.Message;
                        txtFirstName.Focus();
                        break;
                    case "* Last name cannot be empty or null":
                        lblLastNameError.Text = exception.Message;
                        txtLastName.Focus();
                        break;
                    case "* You must be 18 or older to register a book":
                        lblDateOfBirthError.Text = exception.Message;
                        dtpDateOfBirth.Focus();
                        break;
                    default:
                        MessageBox.Show(exception.Message, "Entry Error");
                        break;
                }
                
            }
        }
    }
}
