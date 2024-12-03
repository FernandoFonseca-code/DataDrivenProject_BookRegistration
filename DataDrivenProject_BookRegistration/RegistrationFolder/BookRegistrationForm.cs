namespace DataDrivenProject_BookRegistration
{
    public partial class BookRegistrationForm : Form
    {
        public BookRegistrationForm()
        {
            InitializeComponent();
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // open addCustomerForm and add customer to the database
            AddCustomerForm newCustomerForm = new AddCustomerForm();
            newCustomerForm.ShowDialog();

        }
    }
}
