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
            txtPrice = new TextBox();
            btnAddBook = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 81);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 179);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 259);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // txtBookISBN
            // 
            txtBookISBN.Location = new Point(135, 78);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(151, 27);
            txtBookISBN.TabIndex = 3;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(135, 172);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(207, 27);
            txtBookTitle.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(135, 252);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(148, 27);
            txtPrice.TabIndex = 5;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(135, 333);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(155, 69);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 450);
            Controls.Add(btnAddBook);
            Controls.Add(txtPrice);
            Controls.Add(txtBookTitle);
            Controls.Add(txtBookISBN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBookForm";
            Text = "Add Book Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBookISBN;
        private TextBox txtBookTitle;
        private TextBox txtPrice;
        private Button btnAddBook;
    }
}