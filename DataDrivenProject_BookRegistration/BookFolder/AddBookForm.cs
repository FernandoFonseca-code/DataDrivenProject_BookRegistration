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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                Book newBook = new(txtBookISBN.Text, txtBookTitle.Text, double.Parse(numbxBookPrice.Text));
                // test code
                //MessageBox.Show($"Title of book is {txtBookTitle.Text} with ISBN {txtBookISBN.Text} and a price of ${numbxBookPrice.Text}");
                BookTable.Add(newBook);
                BookTable.GetAllBooks();
                Close();
            }

            catch (ArgumentException exception)
            {
                var error = exception.Message;
                switch (exception.Message)
                {
                    case "* Please enter a valid 10 or 13 digit ISBN":
                        lblBookISBNError.Text = exception.Message;
                        txtBookISBN.Focus();
                        break;
                    case "* Title cannot be empty/null":
                        lblBookTitleError.Text = exception.Message;
                        txtBookTitle.Focus();
                        break;
                    case "* Price cannot be empty/null or free":
                        lblBookPriceError.Text = exception.Message;
                        numbxBookPrice.Focus();
                        break;
                }
            }
        }
    }
}

