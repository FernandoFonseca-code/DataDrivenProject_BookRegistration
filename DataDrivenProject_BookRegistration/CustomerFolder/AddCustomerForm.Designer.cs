namespace DataDrivenProject_BookRegistration
{
    partial class AddCustomerForm
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label3 = new Label();
            btnAddCustomer = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(157, 104);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(127, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(154, 193);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 111);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 3;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 200);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "Last Name:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(154, 267);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(273, 27);
            dtpDateOfBirth.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 274);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 6;
            label3.Text = "Date of Birth:";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(157, 336);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(161, 79);
            btnAddCustomer.TabIndex = 7;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 450);
            Controls.Add(btnAddCustomer);
            Controls.Add(label3);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "AddCustomerForm";
            Text = "Add Customer Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpDateOfBirth;
        private Label label3;
        private Button btnAddCustomer;
    }
}