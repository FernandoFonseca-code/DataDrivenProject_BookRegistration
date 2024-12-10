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
            RefreshCustomerList();
            RefreshBookList();
        }
        /// <summary>
        /// Get all customers list from the database and display them in the combobox
        /// </summary>
        private void RefreshCustomerList()
        {
            List<Customer> customers = CustomerTable.GetAllCustomers();
            cbxCustomer.DataSource = customers;
            cbxCustomer.DisplayMember = "FullName";
            cbxCustomer.ValueMember = "CustomerID";
        }
        /// <summary>
        /// Get all books list from the database and display them in the combobox
        /// </summary>
        private void RefreshBookList()
        {
            List<Book> books = BookTable.GetAllBooks();
            cbxBook.DataSource = books;
            cbxBook.DisplayMember = "BookTitle";
            cbxBook.ValueMember = "BookISBN";
        }
        /// <summary>
        /// Open the AddCustomerForm to add a new customer to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm newCustomerForm = new();
            newCustomerForm.ShowDialog();
            RefreshCustomerList();

        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm newBookForm = new();
            newBookForm.ShowDialog();
            RefreshBookList();
        }
    }
}
