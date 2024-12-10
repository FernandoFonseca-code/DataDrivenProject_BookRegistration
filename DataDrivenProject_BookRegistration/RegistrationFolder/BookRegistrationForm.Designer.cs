
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
            btnAddCustomer = new Button();
            btnAddBook = new Button();
            btnRegisterBook = new Button();
            btnCancel = new Button();
            dtpRegistrationDate = new DateTimePicker();
            lblRegistrationError = new Label();
            SuspendLayout();
            // 
            // cbxCustomer
            // 
            cbxCustomer.FormattingEnabled = true;
            cbxCustomer.Location = new Point(35, 27);
            cbxCustomer.Margin = new Padding(6);
            cbxCustomer.Name = "cbxCustomer";
            cbxCustomer.Size = new Size(468, 45);
            cbxCustomer.TabIndex = 0;
            // 
            // cbxBook
            // 
            cbxBook.FormattingEnabled = true;
            cbxBook.Location = new Point(35, 220);
            cbxBook.Margin = new Padding(6);
            cbxBook.Name = "cbxBook";
            cbxBook.Size = new Size(468, 45);
            cbxBook.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(575, 27);
            btnAddCustomer.Margin = new Padding(6);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(194, 116);
            btnAddCustomer.TabIndex = 3;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(575, 220);
            btnAddBook.Margin = new Padding(6);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(194, 116);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnRegisterBook
            // 
            btnRegisterBook.Location = new Point(575, 439);
            btnRegisterBook.Margin = new Padding(6);
            btnRegisterBook.Name = "btnRegisterBook";
            btnRegisterBook.Size = new Size(194, 116);
            btnRegisterBook.TabIndex = 5;
            btnRegisterBook.Text = "Register Book";
            btnRegisterBook.UseVisualStyleBackColor = true;
            btnRegisterBook.Click += btnRegisterBook_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(575, 606);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(194, 116);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpRegistrationDate
            // 
            dtpRegistrationDate.Location = new Point(35, 439);
            dtpRegistrationDate.Name = "dtpRegistrationDate";
            dtpRegistrationDate.Size = new Size(468, 43);
            dtpRegistrationDate.TabIndex = 7;
            // 
            // lblRegistrationError
            // 
            lblRegistrationError.AutoSize = true;
            lblRegistrationError.Location = new Point(35, 578);
            lblRegistrationError.Name = "lblRegistrationError";
            lblRegistrationError.Size = new Size(0, 37);
            lblRegistrationError.TabIndex = 8;
            // 
            // BookRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 737);
            Controls.Add(lblRegistrationError);
            Controls.Add(dtpRegistrationDate);
            Controls.Add(btnCancel);
            Controls.Add(btnRegisterBook);
            Controls.Add(btnAddBook);
            Controls.Add(btnAddCustomer);
            Controls.Add(cbxBook);
            Controls.Add(cbxCustomer);
            Margin = new Padding(6);
            Name = "BookRegistrationForm";
            Text = "Book Registration Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox cbxCustomer;
        public ComboBox cbxBook;
        private Button btnAddCustomer;
        private Button btnAddBook;
        private Button btnRegisterBook;
        private Button btnCancel;
        private DateTimePicker dtpRegistrationDate;
        private Label lblRegistrationError;
    }
}
