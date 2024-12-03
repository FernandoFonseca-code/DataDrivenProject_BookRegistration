namespace DataDrivenProject_BookRegistration
{
    public partial class BookRegistrationForm : Form
    {
        public BookRegistrationForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(BookRegistrationForm_Load);
        }
        private void BookRegistrationForm_Load(object sender, EventArgs e)
        {
            List<Customer> customers = CustomerTable.GetAllCustomers();
            cbxCustomer.DataSource = customers;
            cbxCustomer.DisplayMember = "FullName";
            cbxCustomer.ValueMember = "CustomerID";
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
