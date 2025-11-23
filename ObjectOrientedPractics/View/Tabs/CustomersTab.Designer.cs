namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private ObjectOrientedPractics.View.Controls.AddressControl addressControl;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label fullnameLabel;

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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customersListBox
            // 
            this.customersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.ItemHeight = 16;
            this.customersListBox.Location = new System.Drawing.Point(15, 15);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(300, 500);
            this.customersListBox.TabIndex = 0;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(400, 40);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullnameTextBox.Location = new System.Drawing.Point(400, 100);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(395, 22);
            this.fullnameTextBox.TabIndex = 2;
            this.fullnameTextBox.TextChanged += new System.EventHandler(this.FullnameTextBox_TextChanged);
            // 
            // addressControl
            // 
            this.addressControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressControl.Location = new System.Drawing.Point(330, 150);
            this.addressControl.Name = "addressControl";
            this.addressControl.Size = new System.Drawing.Size(465, 365);
            this.addressControl.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(15, 530);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(145, 40);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(170, 530);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(145, 40);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(330, 43);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 16);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "ID:";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Location = new System.Drawing.Point(330, 103);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(67, 16);
            this.fullnameLabel.TabIndex = 7;
            this.fullnameLabel.Text = "Fullname:";
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addressControl);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.customersListBox);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(820, 590);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}