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
           Customer newCustomer = new Customer(txtFirstName.Text, txtLastName.Text, dtpDateOfBirth.Value);
            MessageBox.Show($"First name is {newCustomer.FirstName} and last name is {newCustomer.LastName} with a Date of Birth of {newCustomer.DateOfBirth}");
        }
    }
}
