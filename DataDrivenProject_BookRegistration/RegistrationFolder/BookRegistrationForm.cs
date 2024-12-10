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
            ClearForm();
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
            ClearForm();

        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm newBookForm = new();
            newBookForm.ShowDialog();
            RefreshBookList();
            ClearForm();
        }

        private void btnRegisterBook_Click(object sender, EventArgs e)
        {
            try
            {
                Registered registered = new();
                registered.CustomerID = (int)cbxCustomer.SelectedValue;
                registered.bookISBN = cbxBook.SelectedValue.ToString();
                registered.RegDate = dtpRegistrationDate.Value;
                // test code
                // MessageBox.Show($"Customer ID: {registered.CustomerID}\nRegistered Book ISBN: {registered.bookISBN}\nOn this Registration Date: {registered.RegDate}");
                BookRegistrationTable.Add(registered);
                MessageBox.Show("Book Registered Successfully");
                ClearForm();
            }
            catch (ArgumentException exception)
            {
                var error = exception.Message;
                if (exception.Message == "* Book is already registered, Please select another Book")
                {
                    lblRegistrationError.Text = exception.Message;
                    cbxBook.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            cbxCustomer.SelectedIndex = -1;
            cbxBook.SelectedIndex = -1;
            dtpRegistrationDate.Value = DateTime.Now;
        }
    }
}
