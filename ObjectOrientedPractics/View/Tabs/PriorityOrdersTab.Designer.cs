namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label selectedOrderLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label priorityOptionsLabel;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.ComboBox deliveryTimeComboBox;
        private System.Windows.Forms.Label deliveryAddressLabel;
        private Controls.AddressControl addressControl;
        private System.Windows.Forms.Label orderItemsLabel;
        private System.Windows.Forms.ListBox orderItemsListBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label amountTitleLabel;

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
            Model.Address address2 = new Model.Address();
            selectedOrderLabel = new Label();
            idLabel = new Label();
            idTextBox = new TextBox();
            createdLabel = new Label();
            createdTextBox = new TextBox();
            statusLabel = new Label();
            statusComboBox = new ComboBox();
            priorityOptionsLabel = new Label();
            deliveryTimeLabel = new Label();
            deliveryTimeComboBox = new ComboBox();
            deliveryAddressLabel = new Label();
            addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            orderItemsLabel = new Label();
            orderItemsListBox = new ListBox();
            amountTitleLabel = new Label();
            amountLabel = new Label();
            clearOrderButton = new Button();
            removeItemButton = new Button();
            addItemButton = new Button();
            SuspendLayout();
            // 
            // selectedOrderLabel
            // 
            selectedOrderLabel.AutoSize = true;
            selectedOrderLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectedOrderLabel.Location = new Point(19, 21);
            selectedOrderLabel.Margin = new Padding(6, 0, 6, 0);
            selectedOrderLabel.Name = "selectedOrderLabel";
            selectedOrderLabel.Size = new Size(244, 37);
            selectedOrderLabel.TabIndex = 0;
            selectedOrderLabel.Text = "Selected Order";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(19, 85);
            idLabel.Margin = new Padding(6, 0, 6, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(42, 32);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(74, 79);
            idTextBox.Margin = new Padding(6, 6, 6, 6);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(182, 39);
            idTextBox.TabIndex = 2;
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new Point(19, 149);
            createdLabel.Margin = new Padding(6, 0, 6, 0);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new Size(102, 32);
            createdLabel.TabIndex = 3;
            createdLabel.Text = "Created:";
            // 
            // createdTextBox
            // 
            createdTextBox.Location = new Point(130, 143);
            createdTextBox.Margin = new Padding(6, 6, 6, 6);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(275, 39);
            createdTextBox.TabIndex = 4;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(19, 213);
            statusLabel.Margin = new Padding(6, 0, 6, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(83, 32);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(111, 207);
            statusComboBox.Margin = new Padding(6, 6, 6, 6);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(219, 40);
            statusComboBox.TabIndex = 6;
            statusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // priorityOptionsLabel
            // 
            priorityOptionsLabel.AutoSize = true;
            priorityOptionsLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            priorityOptionsLabel.Location = new Point(464, 21);
            priorityOptionsLabel.Margin = new Padding(6, 0, 6, 0);
            priorityOptionsLabel.Name = "priorityOptionsLabel";
            priorityOptionsLabel.Size = new Size(194, 29);
            priorityOptionsLabel.TabIndex = 7;
            priorityOptionsLabel.Text = "Priority Options";
            // 
            // deliveryTimeLabel
            // 
            deliveryTimeLabel.AutoSize = true;
            deliveryTimeLabel.Location = new Point(464, 85);
            deliveryTimeLabel.Margin = new Padding(6, 0, 6, 0);
            deliveryTimeLabel.Name = "deliveryTimeLabel";
            deliveryTimeLabel.Size = new Size(166, 32);
            deliveryTimeLabel.TabIndex = 8;
            deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // deliveryTimeComboBox
            // 
            deliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deliveryTimeComboBox.FormattingEnabled = true;
            deliveryTimeComboBox.Location = new Point(464, 128);
            deliveryTimeComboBox.Margin = new Padding(6, 6, 6, 6);
            deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            deliveryTimeComboBox.Size = new Size(275, 40);
            deliveryTimeComboBox.TabIndex = 9;
            deliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deliveryAddressLabel.Location = new Point(19, 299);
            deliveryAddressLabel.Margin = new Padding(6, 0, 6, 0);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new Size(211, 29);
            deliveryAddressLabel.TabIndex = 10;
            deliveryAddressLabel.Text = "Delivery Address";
            // 
            // addressControl
            // 
            address2.Apartment = null;
            address2.Building = null;
            address2.City = null;
            address2.Country = null;
            address2.PostIndex = null;
            address2.Street = null;
            addressControl.Address = address2;
            addressControl.Location = new Point(19, 341);
            addressControl.Margin = new Padding(11, 13, 11, 13);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(743, 320);
            addressControl.TabIndex = 11;
            addressControl.AddressChanged += AddressControl_AddressChanged;
            // 
            // orderItemsLabel
            // 
            orderItemsLabel.AutoSize = true;
            orderItemsLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            orderItemsLabel.Location = new Point(19, 683);
            orderItemsLabel.Margin = new Padding(6, 0, 6, 0);
            orderItemsLabel.Name = "orderItemsLabel";
            orderItemsLabel.Size = new Size(151, 29);
            orderItemsLabel.TabIndex = 12;
            orderItemsLabel.Text = "Order Items";
            // 
            // orderItemsListBox
            // 
            orderItemsListBox.FormattingEnabled = true;
            orderItemsListBox.Location = new Point(19, 725);
            orderItemsListBox.Margin = new Padding(6, 6, 6, 6);
            orderItemsListBox.Name = "orderItemsListBox";
            orderItemsListBox.Size = new Size(799, 324);
            orderItemsListBox.TabIndex = 13;
            // 
            // amountTitleLabel
            // 
            amountTitleLabel.AutoSize = true;
            amountTitleLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountTitleLabel.Location = new Point(613, 1074);
            amountTitleLabel.Margin = new Padding(6, 0, 6, 0);
            amountTitleLabel.Name = "amountTitleLabel";
            amountTitleLabel.Size = new Size(145, 37);
            amountTitleLabel.TabIndex = 17;
            amountTitleLabel.Text = "Amount:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountLabel.Location = new Point(752, 1074);
            amountLabel.Margin = new Padding(6, 0, 6, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(84, 37);
            amountLabel.TabIndex = 18;
            amountLabel.Text = "0,00";
            // 
            // clearOrderButton
            // 
            clearOrderButton.Location = new Point(415, 1061);
            clearOrderButton.Margin = new Padding(6);
            clearOrderButton.Name = "clearOrderButton";
            clearOrderButton.Size = new Size(186, 64);
            clearOrderButton.TabIndex = 16;
            clearOrderButton.Text = "Clear Order";
            clearOrderButton.UseVisualStyleBackColor = true;
            clearOrderButton.Click += ClearOrderButton_Click;
            // 
            // removeItemButton
            // 
            removeItemButton.Location = new Point(217, 1061);
            removeItemButton.Margin = new Padding(6);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(186, 64);
            removeItemButton.TabIndex = 15;
            removeItemButton.Text = "Remove Item";
            removeItemButton.UseVisualStyleBackColor = true;
            removeItemButton.Click += RemoveItemButton_Click;
            // 
            // addItemButton
            // 
            addItemButton.Location = new Point(19, 1061);
            addItemButton.Margin = new Padding(6);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(186, 64);
            addItemButton.TabIndex = 14;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += AddItemButton_Click;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(amountLabel);
            Controls.Add(amountTitleLabel);
            Controls.Add(clearOrderButton);
            Controls.Add(removeItemButton);
            Controls.Add(addItemButton);
            Controls.Add(orderItemsListBox);
            Controls.Add(orderItemsLabel);
            Controls.Add(addressControl);
            Controls.Add(deliveryAddressLabel);
            Controls.Add(deliveryTimeComboBox);
            Controls.Add(deliveryTimeLabel);
            Controls.Add(priorityOptionsLabel);
            Controls.Add(statusComboBox);
            Controls.Add(statusLabel);
            Controls.Add(createdTextBox);
            Controls.Add(createdLabel);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(selectedOrderLabel);
            Margin = new Padding(6, 6, 6, 6);
            Name = "PriorityOrdersTab";
            Size = new Size(836, 1131);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button clearOrderButton;
        private Button removeItemButton;
        private Button addItemButton;
    }
}