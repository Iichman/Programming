namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Label amountTitleLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.CheckBox priorityCheckBox;
        private System.Windows.Forms.Label discountsLabel;
        private System.Windows.Forms.CheckedListBox discountsCheckedListBox;
        private System.Windows.Forms.Label discountAmountTitleLabel;
        private System.Windows.Forms.Label discountAmountLabel;
        private System.Windows.Forms.Label totalTitleLabel;
        private System.Windows.Forms.Label totalLabel;

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
            this.itemsLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.customersLabel = new System.Windows.Forms.Label();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.cartLabel = new System.Windows.Forms.Label();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.amountTitleLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.priorityCheckBox = new System.Windows.Forms.CheckBox();
            this.discountsLabel = new System.Windows.Forms.Label();
            this.discountsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.discountAmountTitleLabel = new System.Windows.Forms.Label();
            this.discountAmountLabel = new System.Windows.Forms.Label();
            this.totalTitleLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.itemsLabel.Location = new System.Drawing.Point(3, 7);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(46, 16);
            this.itemsLabel.TabIndex = 0;
            this.itemsLabel.Text = "Items";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 15;
            this.itemsListBox.Location = new System.Drawing.Point(3, 26);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(300, 604);
            this.itemsListBox.TabIndex = 1;
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Location = new System.Drawing.Point(309, 9);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(64, 15);
            this.customersLabel.TabIndex = 2;
            this.customersLabel.Text = "Customer:";
            // 
            // customersComboBox
            // 
            this.customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(379, 6);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(200, 23);
            this.customersComboBox.TabIndex = 3;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBox_SelectedIndexChanged);
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.cartLabel.Location = new System.Drawing.Point(309, 35);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(37, 16);
            this.cartLabel.TabIndex = 4;
            this.cartLabel.Text = "Cart";
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 15;
            this.cartListBox.Location = new System.Drawing.Point(309, 54);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(270, 169);
            this.cartListBox.TabIndex = 5;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(585, 54);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(120, 30);
            this.addToCartButton.TabIndex = 6;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(585, 90);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(120, 30);
            this.removeItemButton.TabIndex = 7;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Location = new System.Drawing.Point(585, 126);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(120, 30);
            this.clearCartButton.TabIndex = 8;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // amountTitleLabel
            // 
            this.amountTitleLabel.AutoSize = true;
            this.amountTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.amountTitleLabel.Location = new System.Drawing.Point(309, 226);
            this.amountTitleLabel.Name = "amountTitleLabel";
            this.amountTitleLabel.Size = new System.Drawing.Size(78, 20);
            this.amountTitleLabel.TabIndex = 9;
            this.amountTitleLabel.Text = "Amount:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.amountLabel.Location = new System.Drawing.Point(393, 226);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(40, 20);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.Text = "0,00";
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(585, 226);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(120, 30);
            this.createOrderButton.TabIndex = 11;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // priorityCheckBox
            // 
            this.priorityCheckBox.AutoSize = true;
            this.priorityCheckBox.Enabled = false;
            this.priorityCheckBox.Location = new System.Drawing.Point(585, 262);
            this.priorityCheckBox.Name = "priorityCheckBox";
            this.priorityCheckBox.Size = new System.Drawing.Size(64, 19);
            this.priorityCheckBox.TabIndex = 12;
            this.priorityCheckBox.Text = "Priority";
            this.priorityCheckBox.UseVisualStyleBackColor = true;
            this.priorityCheckBox.CheckedChanged += new System.EventHandler(this.PriorityCheckBox_CheckedChanged);
            // 
            // discountsLabel
            // 
            this.discountsLabel.AutoSize = true;
            this.discountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            this.discountsLabel.Location = new System.Drawing.Point(309, 256);
            this.discountsLabel.Name = "discountsLabel";
            this.discountsLabel.Size = new System.Drawing.Size(75, 16);
            this.discountsLabel.TabIndex = 13;
            this.discountsLabel.Text = "Discounts";
            // 
            // discountsCheckedListBox
            // 
            this.discountsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.discountsCheckedListBox.CheckOnClick = true;
            this.discountsCheckedListBox.FormattingEnabled = true;
            this.discountsCheckedListBox.Location = new System.Drawing.Point(309, 275);
            this.discountsCheckedListBox.Name = "discountsCheckedListBox";
            this.discountsCheckedListBox.Size = new System.Drawing.Size(270, 180);
            this.discountsCheckedListBox.TabIndex = 14;
            this.discountsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DiscountsCheckedListBox_ItemCheck);
            // 
            // discountAmountTitleLabel
            // 
            this.discountAmountTitleLabel.AutoSize = true;
            this.discountAmountTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.discountAmountTitleLabel.Location = new System.Drawing.Point(585, 284);
            this.discountAmountTitleLabel.Name = "discountAmountTitleLabel";
            this.discountAmountTitleLabel.Size = new System.Drawing.Size(111, 16);
            this.discountAmountTitleLabel.TabIndex = 15;
            this.discountAmountTitleLabel.Text = "Discount Amount:";
            // 
            // discountAmountLabel
            // 
            this.discountAmountLabel.AutoSize = true;
            this.discountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.discountAmountLabel.Location = new System.Drawing.Point(702, 284);
            this.discountAmountLabel.Name = "discountAmountLabel";
            this.discountAmountLabel.Size = new System.Drawing.Size(31, 16);
            this.discountAmountLabel.TabIndex = 16;
            this.discountAmountLabel.Text = "0,00";
            // 
            // totalTitleLabel
            // 
            this.totalTitleLabel.AutoSize = true;
            this.totalTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.totalTitleLabel.Location = new System.Drawing.Point(585, 310);
            this.totalTitleLabel.Name = "totalTitleLabel";
            this.totalTitleLabel.Size = new System.Drawing.Size(40, 16);
            this.totalTitleLabel.TabIndex = 17;
            this.totalTitleLabel.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.totalLabel.Location = new System.Drawing.Point(702, 310);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 16);
            this.totalLabel.TabIndex = 18;
            this.totalLabel.Text = "0,00";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalTitleLabel);
            this.Controls.Add(this.discountAmountLabel);
            this.Controls.Add(this.discountAmountTitleLabel);
            this.Controls.Add(this.discountsCheckedListBox);
            this.Controls.Add(this.discountsLabel);
            this.Controls.Add(this.priorityCheckBox);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountTitleLabel);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.customersComboBox);
            this.Controls.Add(this.customersLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.itemsLabel);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(900, 650);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}