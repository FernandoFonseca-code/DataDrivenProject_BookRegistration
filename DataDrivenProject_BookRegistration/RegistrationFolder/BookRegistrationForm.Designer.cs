namespace DataDrivenProject_BookRegistration
{
    partial class BookRegistrationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbxCustomer = new ComboBox();
            cbxBook = new ComboBox();
            cbxRegistrationDate = new ComboBox();
            btnAddCustomer = new Button();
            btnAddBook = new Button();
            btnRegisterBook = new Button();
            SuspendLayout();
            // 
            // cbxCustomer
            // 
            cbxCustomer.FormattingEnabled = true;
            cbxCustomer.Location = new Point(58, 55);
            cbxCustomer.Name = "cbxCustomer";
            cbxCustomer.Size = new Size(154, 28);
            cbxCustomer.TabIndex = 0;
            // 
            // cbxBook
            // 
            cbxBook.FormattingEnabled = true;
            cbxBook.Location = new Point(60, 142);
            cbxBook.Name = "cbxBook";
            cbxBook.Size = new Size(152, 28);
            cbxBook.TabIndex = 1;
            // 
            // cbxRegistrationDate
            // 
            cbxRegistrationDate.FormattingEnabled = true;
            cbxRegistrationDate.Location = new Point(51, 250);
            cbxRegistrationDate.Name = "cbxRegistrationDate";
            cbxRegistrationDate.Size = new Size(241, 28);
            cbxRegistrationDate.TabIndex = 2;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(387, 44);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(152, 85);
            btnAddCustomer.TabIndex = 3;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(370, 203);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(181, 121);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnRegisterBook
            // 
            btnRegisterBook.Location = new Point(98, 332);
            btnRegisterBook.Name = "btnRegisterBook";
            btnRegisterBook.Size = new Size(197, 89);
            btnRegisterBook.TabIndex = 5;
            btnRegisterBook.Text = "Register Book";
            btnRegisterBook.UseVisualStyleBackColor = true;
            // 
            // BookRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 450);
            Controls.Add(btnRegisterBook);
            Controls.Add(btnAddBook);
            Controls.Add(btnAddCustomer);
            Controls.Add(cbxRegistrationDate);
            Controls.Add(cbxBook);
            Controls.Add(cbxCustomer);
            Name = "BookRegistrationForm";
            Text = "Book Registration Form";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbxCustomer;
        private ComboBox cbxBook;
        private ComboBox cbxRegistrationDate;
        private Button btnAddCustomer;
        private Button btnAddBook;
        private Button btnRegisterBook;
    }
}
