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
                Customer newCustomer = new(cbxTitle, txtFirstName.Text, txtLastName.Text, dtpDateOfBirth.Value);
                // test code
                //MessageBox.Show($"Title is {cbxTitle.Text} First name is {newCustomer.FirstName} and last name is {newCustomer.LastName} with a Date of Birth of {newCustomer.DateOfBirth.ToString("d")}");
                CustomerTable.Add(newCustomer);
                CustomerTable.GetAllCustomers();
                Close();
            }

            catch (ArgumentException exception)
            {
                var error = exception.Message;
                switch (exception.Message)
                {
                    case "* Please select a title":
                        lblTitleError.Text = exception.Message;
                        cbxTitle.Focus();
                        break;
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
