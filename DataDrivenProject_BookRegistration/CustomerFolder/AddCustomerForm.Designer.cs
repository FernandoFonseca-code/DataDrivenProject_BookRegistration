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
            lblFirstNameError = new Label();
            lblLastNameError = new Label();
            lblDateOfBirthError = new Label();
            label4 = new Label();
            cbxTitle = new ComboBox();
            lblTitleError = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(294, 199);
            txtFirstName.Margin = new Padding(6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(267, 43);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(289, 364);
            txtLastName.Margin = new Padding(6);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(272, 43);
            txtLastName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 205);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 3;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 370);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 37);
            label2.TabIndex = 4;
            label2.Text = "Last Name:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(289, 501);
            dtpDateOfBirth.Margin = new Padding(6);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(469, 43);
            dtpDateOfBirth.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 507);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 37);
            label3.TabIndex = 6;
            label3.Text = "Date of Birth:";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(294, 622);
            btnAddCustomer.Margin = new Padding(6);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(302, 146);
            btnAddCustomer.TabIndex = 7;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.Enabled = false;
            lblFirstNameError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFirstNameError.ForeColor = SystemColors.WindowText;
            lblFirstNameError.Location = new Point(605, 192);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(0, 37);
            lblFirstNameError.TabIndex = 11;
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.Enabled = false;
            lblLastNameError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLastNameError.ForeColor = SystemColors.WindowText;
            lblLastNameError.Location = new Point(605, 357);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(0, 37);
            lblLastNameError.TabIndex = 12;
            // 
            // lblDateOfBirthError
            // 
            lblDateOfBirthError.AutoSize = true;
            lblDateOfBirthError.Enabled = false;
            lblDateOfBirthError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDateOfBirthError.ForeColor = SystemColors.WindowText;
            lblDateOfBirthError.Location = new Point(846, 495);
            lblDateOfBirthError.Name = "lblDateOfBirthError";
            lblDateOfBirthError.Size = new Size(0, 37);
            lblDateOfBirthError.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 104);
            label4.Name = "label4";
            label4.Size = new Size(74, 37);
            label4.TabIndex = 14;
            label4.Text = "Title:";
            // 
            // cbxTitle
            // 
            cbxTitle.FormattingEnabled = true;
            cbxTitle.Items.AddRange(new object[] { "Mr.", "Mrs.", "Ms.", "Miss.", "Dr.", "Prof.", "Hon.", "Rev." });
            cbxTitle.Location = new Point(289, 96);
            cbxTitle.Name = "cbxTitle";
            cbxTitle.Size = new Size(272, 45);
            cbxTitle.TabIndex = 15;
            // 
            // lblTitleError
            // 
            lblTitleError.AutoSize = true;
            lblTitleError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitleError.ForeColor = SystemColors.WindowText;
            lblTitleError.Location = new Point(618, 103);
            lblTitleError.Name = "lblTitleError";
            lblTitleError.Size = new Size(0, 37);
            lblTitleError.TabIndex = 16;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 832);
            Controls.Add(lblTitleError);
            Controls.Add(cbxTitle);
            Controls.Add(label4);
            Controls.Add(lblDateOfBirthError);
            Controls.Add(lblLastNameError);
            Controls.Add(lblFirstNameError);
            Controls.Add(btnAddCustomer);
            Controls.Add(label3);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Margin = new Padding(6);
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
        private Label lblFirstNameError;
        private Label lblLastNameError;
        private Label lblDateOfBirthError;
        private Label label4;
        private ComboBox cbxTitle;
        private Label lblTitleError;
    }
}