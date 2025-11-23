namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Label amountTextLabel;

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
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.cartLabel = new System.Windows.Forms.Label();
            this.amountTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 16;
            this.itemsListBox.Location = new System.Drawing.Point(15, 40);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(300, 450);
            this.itemsListBox.TabIndex = 0;
            // 
            // customersComboBox
            // 
            this.customersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(330, 40);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(465, 24);
            this.customersComboBox.TabIndex = 1;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBox_SelectedIndexChanged);
            // 
            // cartListBox
            // 
            this.cartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 16;
            this.cartListBox.Location = new System.Drawing.Point(330, 100);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(465, 250);
            this.cartListBox.TabIndex = 2;
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.amountLabel.Location = new System.Drawing.Point(695, 420);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(105, 25);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "0,00 ₽";
            // 
            // addToCartButton
            // 
            this.addToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addToCartButton.Location = new System.Drawing.Point(15, 500);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(300, 40);
            this.addToCartButton.TabIndex = 4;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeItemButton.Location = new System.Drawing.Point(455, 420);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(120, 40);
            this.removeItemButton.TabIndex = 5;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearCartButton.Location = new System.Drawing.Point(585, 420);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(120, 40);
            this.clearCartButton.TabIndex = 6;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // createOrderButton
            // 
            this.createOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createOrderButton.Location = new System.Drawing.Point(325, 420);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(120, 40);
            this.createOrderButton.TabIndex = 7;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.itemsLabel.Location = new System.Drawing.Point(12, 20);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(49, 17);
            this.itemsLabel.TabIndex = 8;
            this.itemsLabel.Text = "Items";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.customerLabel.Location = new System.Drawing.Point(327, 20);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(78, 17);
            this.customerLabel.TabIndex = 9;
            this.customerLabel.Text = "Customer:";
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.cartLabel.Location = new System.Drawing.Point(327, 80);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(41, 17);
            this.cartLabel.TabIndex = 10;
            this.cartLabel.Text = "Cart:";
            // 
            // amountTextLabel
            // 
            this.amountTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextLabel.AutoSize = true;
            this.amountTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.amountTextLabel.Location = new System.Drawing.Point(585, 425);
            this.amountTextLabel.Name = "amountTextLabel";
            this.amountTextLabel.Size = new System.Drawing.Size(104, 20);
            this.amountTextLabel.TabIndex = 11;
            this.amountTextLabel.Text = "Amount:";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.amountTextLabel);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.customersComboBox);
            this.Controls.Add(this.itemsListBox);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(820, 550);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}