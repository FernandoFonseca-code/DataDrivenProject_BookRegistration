namespace DataDrivenProject_BookRegistration
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBookISBN = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            numbxBookPrice = new NumericUpDown();
            lblBookISBNError = new Label();
            lblBookTitleError = new Label();
            lblBookPriceError = new Label();
            ((System.ComponentModel.ISupportInitialize)numbxBookPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 150);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 37);
            label1.TabIndex = 0;
            label1.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 331);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 37);
            label2.TabIndex = 1;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 479);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 37);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // txtBookISBN
            // 
            txtBookISBN.Location = new Point(253, 144);
            txtBookISBN.Margin = new Padding(6);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(280, 43);
            txtBookISBN.TabIndex = 3;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(253, 318);
            txtBookTitle.Margin = new Padding(6);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(385, 43);
            txtBookTitle.TabIndex = 4;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(253, 616);
            btnAddBook.Margin = new Padding(6);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(291, 128);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // numbxBookPrice
            // 
            numbxBookPrice.DecimalPlaces = 2;
            numbxBookPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numbxBookPrice.Location = new Point(253, 473);
            numbxBookPrice.Name = "numbxBookPrice";
            numbxBookPrice.Size = new Size(270, 43);
            numbxBookPrice.TabIndex = 7;
            numbxBookPrice.ThousandsSeparator = true;
            // 
            // lblBookISBNError
            // 
            lblBookISBNError.AutoSize = true;
            lblBookISBNError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookISBNError.Location = new Point(601, 149);
            lblBookISBNError.Name = "lblBookISBNError";
            lblBookISBNError.Size = new Size(0, 37);
            lblBookISBNError.TabIndex = 8;
            // 
            // lblBookTitleError
            // 
            lblBookTitleError.AutoSize = true;
            lblBookTitleError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookTitleError.Location = new Point(680, 325);
            lblBookTitleError.Name = "lblBookTitleError";
            lblBookTitleError.Size = new Size(0, 37);
            lblBookTitleError.TabIndex = 9;
            // 
            // lblBookPriceError
            // 
            lblBookPriceError.AutoSize = true;
            lblBookPriceError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookPriceError.Location = new Point(579, 481);
            lblBookPriceError.Name = "lblBookPriceError";
            lblBookPriceError.Size = new Size(0, 37);
            lblBookPriceError.TabIndex = 10;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 832);
            Controls.Add(lblBookPriceError);
            Controls.Add(lblBookTitleError);
            Controls.Add(lblBookISBNError);
            Controls.Add(numbxBookPrice);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtBookISBN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "AddBookForm";
            Text = "Add Book Form";
            ((System.ComponentModel.ISupportInitialize)numbxBookPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBookISBN;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private NumericUpDown numbxBookPrice;
        private Label lblBookISBNError;
        private Label lblBookTitleError;
        private Label lblBookPriceError;
    }
}