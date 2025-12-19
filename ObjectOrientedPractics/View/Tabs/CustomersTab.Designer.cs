namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.Label selectedCustomerLabel;
        private System.Windows.Forms.GroupBox selectedCustomerGroupBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.GroupBox addressGroupBox;
        private Controls.AddressControl addressControl;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label discountsLabel;
        private System.Windows.Forms.ListBox discountsListBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button addDiscountButton;
        private System.Windows.Forms.Button removeDiscountButton;
        private System.Windows.Forms.CheckBox isPriorityCheckBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.customersLabel = new System.Windows.Forms.Label();
            this.selectedCustomerLabel = new System.Windows.Forms.Label();
            this.selectedCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.isPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.removeDiscountButton = new System.Windows.Forms.Button();
            this.addDiscountButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.discountsListBox = new System.Windows.Forms.ListBox();
            this.discountsLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addressGroupBox = new System.Windows.Forms.GroupBox();
            this.addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.selectedCustomerGroupBox.SuspendLayout();
            this.addressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersListBox
            // 
            this.customersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.ItemHeight = 15;
            this.customersListBox.Location = new System.Drawing.Point(3, 30);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(300, 604);
            this.customersListBox.TabIndex = 0;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.customersLabel.Location = new System.Drawing.Point(3, 7);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(85, 20);
            this.customersLabel.TabIndex = 1;
            this.customersLabel.Text = "Customers";
            // 
            // selectedCustomerLabel
            // 
            this.selectedCustomerLabel.AutoSize = true;
            this.selectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.selectedCustomerLabel.Location = new System.Drawing.Point(309, 7);
            this.selectedCustomerLabel.Name = "selectedCustomerLabel";
            this.selectedCustomerLabel.Size = new System.Drawing.Size(149, 20);
            this.selectedCustomerLabel.TabIndex = 2;
            this.selectedCustomerLabel.Text = "Selected Customer";
            // 
            // selectedCustomerGroupBox
            // 
            this.selectedCustomerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCustomerGroupBox.Controls.Add(this.isPriorityCheckBox);
            this.selectedCustomerGroupBox.Controls.Add(this.removeDiscountButton);
            this.selectedCustomerGroupBox.Controls.Add(this.addDiscountButton);
            this.selectedCustomerGroupBox.Controls.Add(this.categoryLabel);
            this.selectedCustomerGroupBox.Controls.Add(this.categoryComboBox);
            this.selectedCustomerGroupBox.Controls.Add(this.discountsListBox);
            this.selectedCustomerGroupBox.Controls.Add(this.discountsLabel);
            this.selectedCustomerGroupBox.Controls.Add(this.removeButton);
            this.selectedCustomerGroupBox.Controls.Add(this.addButton);
            this.selectedCustomerGroupBox.Controls.Add(this.addressGroupBox);
            this.selectedCustomerGroupBox.Controls.Add(this.fullNameTextBox);
            this.selectedCustomerGroupBox.Controls.Add(this.fullNameLabel);
            this.selectedCustomerGroupBox.Controls.Add(this.idTextBox);
            this.selectedCustomerGroupBox.Controls.Add(this.idLabel);
            this.selectedCustomerGroupBox.Location = new System.Drawing.Point(309, 30);
            this.selectedCustomerGroupBox.Name = "selectedCustomerGroupBox";
            this.selectedCustomerGroupBox.Size = new System.Drawing.Size(588, 604);
            this.selectedCustomerGroupBox.TabIndex = 3;
            this.selectedCustomerGroupBox.TabStop = false;
            // 
            // isPriorityCheckBox
            // 
            this.isPriorityCheckBox.AutoSize = true;
            this.isPriorityCheckBox.Location = new System.Drawing.Point(250, 58);
            this.isPriorityCheckBox.Name = "isPriorityCheckBox";
            this.isPriorityCheckBox.Size = new System.Drawing.Size(80, 19);
            this.isPriorityCheckBox.TabIndex = 13;
            this.isPriorityCheckBox.Text = "Is Priority";
            this.isPriorityCheckBox.UseVisualStyleBackColor = true;
            this.isPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // removeDiscountButton
            // 
            this.removeDiscountButton.Location = new System.Drawing.Point(497, 350);
            this.removeDiscountButton.Name = "removeDiscountButton";
            this.removeDiscountButton.Size = new System.Drawing.Size(85, 25);
            this.removeDiscountButton.TabIndex = 12;
            this.removeDiscountButton.Text = "Remove";
            this.removeDiscountButton.UseVisualStyleBackColor = true;
            this.removeDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // addDiscountButton
            // 
            this.addDiscountButton.Location = new System.Drawing.Point(406, 350);
            this.addDiscountButton.Name = "addDiscountButton";
            this.addDiscountButton.Size = new System.Drawing.Size(85, 25);
            this.addDiscountButton.TabIndex = 11;
            this.addDiscountButton.Text = "Add";
            this.addDiscountButton.UseVisualStyleBackColor = true;
            this.addDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(6, 354);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(58, 15);
            this.categoryLabel.TabIndex = 10;
            this.categoryLabel.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(70, 351);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(330, 23);
            this.categoryComboBox.TabIndex = 9;
            // 
            // discountsListBox
            // 
            this.discountsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.discountsListBox.FormattingEnabled = true;
            this.discountsListBox.ItemHeight = 15;
            this.discountsListBox.Location = new System.Drawing.Point(6, 380);
            this.discountsListBox.Name = "discountsListBox";
            this.discountsListBox.Size = new System.Drawing.Size(576, 214);
            this.discountsListBox.TabIndex = 8;
            // 
            // discountsLabel
            // 
            this.discountsLabel.AutoSize = true;
            this.discountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.discountsLabel.Location = new System.Drawing.Point(6, 331);
            this.discountsLabel.Name = "discountsLabel";
            this.discountsLabel.Size = new System.Drawing.Size(75, 16);
            this.discountsLabel.TabIndex = 7;
            this.discountsLabel.Text = "Discounts";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(497, 300);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(85, 25);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(406, 300);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 25);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // addressGroupBox
            // 
            this.addressGroupBox.Controls.Add(this.addressControl);
            this.addressGroupBox.Location = new System.Drawing.Point(6, 101);
            this.addressGroupBox.Name = "addressGroupBox";
            this.addressGroupBox.Size = new System.Drawing.Size(576, 196);
            this.addressGroupBox.TabIndex = 4;
            this.addressGroupBox.TabStop = false;
            this.addressGroupBox.Text = "Delivery Address";
            // 
            // addressControl
            // 
            this.addressControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressControl.Location = new System.Drawing.Point(3, 19);
            this.addressControl.Name = "addressControl";
            this.addressControl.Size = new System.Drawing.Size(570, 174);
            this.addressControl.TabIndex = 0;
            this.addressControl.AddressChanged += new System.EventHandler(this.AddressControl_AddressChanged);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(70, 55);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(170, 23);
            this.fullNameTextBox.TabIndex = 3;
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(6, 58);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.fullNameLabel.TabIndex = 2;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(70, 26);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 23);
            this.idTextBox.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(6, 29);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectedCustomerGroupBox);
            this.Controls.Add(this.selectedCustomerLabel);
            this.Controls.Add(this.customersLabel);
            this.Controls.Add(this.customersListBox);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(900, 637);
            this.selectedCustomerGroupBox.ResumeLayout(false);
            this.selectedCustomerGroupBox.PerformLayout();
            this.addressGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}