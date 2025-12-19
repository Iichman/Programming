namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.Label selectedOrderLabel;
        private System.Windows.Forms.GroupBox selectedOrderGroupBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox deliveryAddressGroupBox;
        private Controls.AddressControl addressControl;
        private System.Windows.Forms.GroupBox orderItemsGroupBox;
        private System.Windows.Forms.ListBox orderItemsListBox;
        private System.Windows.Forms.Label amountTitleLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.ComboBox deliveryTimeComboBox;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.Label totalTitleLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label discountAmountTitleLabel;
        private System.Windows.Forms.Label discountAmountLabel;

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
            Model.Address address1 = new Model.Address();
            ordersDataGridView = new DataGridView();
            ordersLabel = new Label();
            selectedOrderLabel = new Label();
            selectedOrderGroupBox = new GroupBox();
            totalLabel = new Label();
            totalTitleLabel = new Label();
            discountAmountLabel = new Label();
            discountAmountTitleLabel = new Label();
            deliveryTimeComboBox = new ComboBox();
            deliveryTimeLabel = new Label();
            amountLabel = new Label();
            amountTitleLabel = new Label();
            orderItemsGroupBox = new GroupBox();
            orderItemsListBox = new ListBox();
            deliveryAddressGroupBox = new GroupBox();
            addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            statusComboBox = new ComboBox();
            statusLabel = new Label();
            createdTextBox = new TextBox();
            createdLabel = new Label();
            idTextBox = new TextBox();
            idLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            selectedOrderGroupBox.SuspendLayout();
            orderItemsGroupBox.SuspendLayout();
            deliveryAddressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.AllowUserToDeleteRows = false;
            ordersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Location = new Point(7, 75);
            ordersDataGridView.Margin = new Padding(6, 6, 6, 6);
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.ReadOnly = true;
            ordersDataGridView.RowHeadersVisible = false;
            ordersDataGridView.RowHeadersWidth = 82;
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.Size = new Size(1192, 1280);
            ordersDataGridView.TabIndex = 0;
            ordersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ordersLabel.Location = new Point(7, 17);
            ordersLabel.Margin = new Padding(6, 0, 6, 0);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(121, 37);
            ordersLabel.TabIndex = 1;
            ordersLabel.Text = "Orders";
            // 
            // selectedOrderLabel
            // 
            selectedOrderLabel.AutoSize = true;
            selectedOrderLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectedOrderLabel.Location = new Point(1211, 17);
            selectedOrderLabel.Margin = new Padding(6, 0, 6, 0);
            selectedOrderLabel.Name = "selectedOrderLabel";
            selectedOrderLabel.Size = new Size(244, 37);
            selectedOrderLabel.TabIndex = 2;
            selectedOrderLabel.Text = "Selected Order";
            // 
            // selectedOrderGroupBox
            // 
            selectedOrderGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectedOrderGroupBox.Controls.Add(totalLabel);
            selectedOrderGroupBox.Controls.Add(totalTitleLabel);
            selectedOrderGroupBox.Controls.Add(discountAmountLabel);
            selectedOrderGroupBox.Controls.Add(discountAmountTitleLabel);
            selectedOrderGroupBox.Controls.Add(deliveryTimeComboBox);
            selectedOrderGroupBox.Controls.Add(deliveryTimeLabel);
            selectedOrderGroupBox.Controls.Add(amountLabel);
            selectedOrderGroupBox.Controls.Add(amountTitleLabel);
            selectedOrderGroupBox.Controls.Add(orderItemsGroupBox);
            selectedOrderGroupBox.Controls.Add(deliveryAddressGroupBox);
            selectedOrderGroupBox.Controls.Add(statusComboBox);
            selectedOrderGroupBox.Controls.Add(statusLabel);
            selectedOrderGroupBox.Controls.Add(createdTextBox);
            selectedOrderGroupBox.Controls.Add(createdLabel);
            selectedOrderGroupBox.Controls.Add(idTextBox);
            selectedOrderGroupBox.Controls.Add(idLabel);
            selectedOrderGroupBox.Location = new Point(1211, 75);
            selectedOrderGroupBox.Margin = new Padding(6, 6, 6, 6);
            selectedOrderGroupBox.Name = "selectedOrderGroupBox";
            selectedOrderGroupBox.Padding = new Padding(6, 6, 6, 6);
            selectedOrderGroupBox.Size = new Size(732, 1280);
            selectedOrderGroupBox.TabIndex = 3;
            selectedOrderGroupBox.TabStop = false;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            totalLabel.Location = new Point(516, 1116);
            totalLabel.Margin = new Padding(6, 0, 6, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(66, 30);
            totalLabel.TabIndex = 14;
            totalLabel.Text = "0,00";
            // 
            // totalTitleLabel
            // 
            totalTitleLabel.AutoSize = true;
            totalTitleLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            totalTitleLabel.Location = new Point(371, 1116);
            totalTitleLabel.Margin = new Padding(6, 0, 6, 0);
            totalTitleLabel.Name = "totalTitleLabel";
            totalTitleLabel.Size = new Size(83, 30);
            totalTitleLabel.TabIndex = 13;
            totalTitleLabel.Text = "Total:";
            // 
            // discountAmountLabel
            // 
            discountAmountLabel.AutoSize = true;
            discountAmountLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            discountAmountLabel.Location = new Point(228, 1116);
            discountAmountLabel.Margin = new Padding(6, 0, 6, 0);
            discountAmountLabel.Name = "discountAmountLabel";
            discountAmountLabel.Size = new Size(62, 30);
            discountAmountLabel.TabIndex = 12;
            discountAmountLabel.Text = "0,00";
            // 
            // discountAmountTitleLabel
            // 
            discountAmountTitleLabel.AutoSize = true;
            discountAmountTitleLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            discountAmountTitleLabel.Location = new Point(13, 1116);
            discountAmountTitleLabel.Margin = new Padding(6, 0, 6, 0);
            discountAmountTitleLabel.Name = "discountAmountTitleLabel";
            discountAmountTitleLabel.Size = new Size(215, 30);
            discountAmountTitleLabel.TabIndex = 11;
            discountAmountTitleLabel.Text = "Discount Amount:";
            // 
            // deliveryTimeComboBox
            // 
            deliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deliveryTimeComboBox.FormattingEnabled = true;
            deliveryTimeComboBox.Location = new Point(468, 181);
            deliveryTimeComboBox.Margin = new Padding(6, 6, 6, 6);
            deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            deliveryTimeComboBox.Size = new Size(234, 40);
            deliveryTimeComboBox.TabIndex = 1;
            deliveryTimeComboBox.Visible = false;
            deliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // deliveryTimeLabel
            // 
            deliveryTimeLabel.AutoSize = true;
            deliveryTimeLabel.Location = new Point(468, 126);
            deliveryTimeLabel.Margin = new Padding(6, 0, 6, 0);
            deliveryTimeLabel.Name = "deliveryTimeLabel";
            deliveryTimeLabel.Size = new Size(173, 32);
            deliveryTimeLabel.TabIndex = 0;
            deliveryTimeLabel.Text = "Delivery Time: ";
            deliveryTimeLabel.Visible = false;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountLabel.Location = new Point(169, 1073);
            amountLabel.Margin = new Padding(6, 0, 6, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(66, 30);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "0,00";
            // 
            // amountTitleLabel
            // 
            amountTitleLabel.AutoSize = true;
            amountTitleLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountTitleLabel.Location = new Point(13, 1073);
            amountTitleLabel.Margin = new Padding(6, 0, 6, 0);
            amountTitleLabel.Name = "amountTitleLabel";
            amountTitleLabel.Size = new Size(115, 30);
            amountTitleLabel.TabIndex = 8;
            amountTitleLabel.Text = "Amount:";
            // 
            // orderItemsGroupBox
            // 
            orderItemsGroupBox.Controls.Add(orderItemsListBox);
            orderItemsGroupBox.Location = new Point(13, 634);
            orderItemsGroupBox.Margin = new Padding(6, 6, 6, 6);
            orderItemsGroupBox.Name = "orderItemsGroupBox";
            orderItemsGroupBox.Padding = new Padding(6, 6, 6, 6);
            orderItemsGroupBox.Size = new Size(706, 369);
            orderItemsGroupBox.TabIndex = 7;
            orderItemsGroupBox.TabStop = false;
            orderItemsGroupBox.Text = "Order Items";
            // 
            // orderItemsListBox
            // 
            orderItemsListBox.Dock = DockStyle.Fill;
            orderItemsListBox.FormattingEnabled = true;
            orderItemsListBox.Location = new Point(6, 38);
            orderItemsListBox.Margin = new Padding(6, 6, 6, 6);
            orderItemsListBox.Name = "orderItemsListBox";
            orderItemsListBox.Size = new Size(694, 325);
            orderItemsListBox.TabIndex = 0;
            // 
            // deliveryAddressGroupBox
            // 
            deliveryAddressGroupBox.Controls.Add(addressControl);
            deliveryAddressGroupBox.Location = new Point(13, 250);
            deliveryAddressGroupBox.Margin = new Padding(6, 6, 6, 6);
            deliveryAddressGroupBox.Name = "deliveryAddressGroupBox";
            deliveryAddressGroupBox.Padding = new Padding(6, 6, 6, 6);
            deliveryAddressGroupBox.Size = new Size(706, 369);
            deliveryAddressGroupBox.TabIndex = 6;
            deliveryAddressGroupBox.TabStop = false;
            deliveryAddressGroupBox.Text = "Delivery Address";
            // 
            // addressControl
            // 
            address1.Apartment = null;
            address1.Building = null;
            address1.City = null;
            address1.Country = null;
            address1.PostIndex = null;
            address1.Street = null;
            addressControl.Address = address1;
            addressControl.Location = new Point(9, 43);
            addressControl.Margin = new Padding(11, 13, 11, 13);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(680, 326);
            addressControl.TabIndex = 0;
            addressControl.AddressChanged += AddressControl_AddressChanged;
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(130, 181);
            statusComboBox.Margin = new Padding(6, 6, 6, 6);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(255, 40);
            statusComboBox.TabIndex = 5;
            statusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(13, 190);
            statusLabel.Margin = new Padding(6, 0, 6, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(90, 32);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Status: ";
            // 
            // createdTextBox
            // 
            createdTextBox.Location = new Point(130, 117);
            createdTextBox.Margin = new Padding(6, 6, 6, 6);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(212, 39);
            createdTextBox.TabIndex = 3;
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new Point(13, 126);
            createdLabel.Margin = new Padding(6, 0, 6, 0);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new Size(109, 32);
            createdLabel.TabIndex = 2;
            createdLabel.Text = "Created: ";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(130, 53);
            idTextBox.Margin = new Padding(6, 6, 6, 6);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(212, 39);
            idTextBox.TabIndex = 1;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(13, 62);
            idLabel.Margin = new Padding(6, 0, 6, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(49, 32);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID: ";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(selectedOrderGroupBox);
            Controls.Add(selectedOrderLabel);
            Controls.Add(ordersLabel);
            Controls.Add(ordersDataGridView);
            Margin = new Padding(6, 6, 6, 6);
            Name = "OrdersTab";
            Size = new Size(1950, 1361);
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            selectedOrderGroupBox.ResumeLayout(false);
            selectedOrderGroupBox.PerformLayout();
            orderItemsGroupBox.ResumeLayout(false);
            deliveryAddressGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}