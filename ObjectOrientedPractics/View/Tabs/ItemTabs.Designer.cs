namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.CheckBox filterAbove5000CheckBox;
        private System.Windows.Forms.Label filterLabel;

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
            itemsListBox = new ListBox();
            idTextBox = new TextBox();
            costTextBox = new TextBox();
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            addButton = new Button();
            removeButton = new Button();
            searchTextBox = new TextBox();
            sortComboBox = new ComboBox();
            searchLabel = new Label();
            sortLabel = new Label();
            idLabel = new Label();
            costLabel = new Label();
            nameLabel = new Label();
            descriptionLabel = new Label();
            categoryLabel = new Label();
            filterAbove5000CheckBox = new CheckBox();
            filterLabel = new Label();
            SuspendLayout();
            // 
            // itemsListBox
            // 
            itemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(10, 40);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(300, 409);
            itemsListBox.TabIndex = 0;
            itemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(350, 40);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(80, 23);
            idTextBox.TabIndex = 1;
            // 
            // costTextBox
            // 
            costTextBox.Location = new Point(395, 70);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(100, 23);
            costTextBox.TabIndex = 2;
            costTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(395, 100);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(185, 23);
            nameTextBox.TabIndex = 3;
            nameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(320, 157);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(260, 80);
            descriptionTextBox.TabIndex = 4;
            descriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(395, 245);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(150, 23);
            categoryComboBox.TabIndex = 5;
            categoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(320, 287);
            addButton.Name = "addButton";
            addButton.Size = new Size(110, 35);
            addButton.TabIndex = 6;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(440, 287);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(110, 35);
            removeButton.TabIndex = 7;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += RemoveButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(55, 10);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(200, 23);
            searchTextBox.TabIndex = 8;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // sortComboBox
            // 
            sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Items.AddRange(new object[] { "По имени (А-Я)", "По стоимости (возрастание)", "По стоимости (убывание)", "По категории (А-Я)" });
            sortComboBox.Location = new Point(340, 10);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(150, 23);
            sortComboBox.TabIndex = 9;
            sortComboBox.SelectedIndexChanged += SortComboBox_SelectedIndexChanged;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(10, 13);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(45, 15);
            searchLabel.TabIndex = 10;
            searchLabel.Text = "Поиск:";
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(258, 13);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(76, 15);
            sortLabel.TabIndex = 11;
            sortLabel.Text = "Сортировка:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(320, 43);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 12;
            idLabel.Text = "ID:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(320, 73);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(70, 15);
            costLabel.TabIndex = 13;
            costLabel.Text = "Стоимость:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(320, 103);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 15);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Название:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(320, 140);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(65, 15);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Описание:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(320, 248);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(66, 15);
            categoryLabel.TabIndex = 16;
            categoryLabel.Text = "Категория:";
            // 
            // filterAbove5000CheckBox
            // 
            filterAbove5000CheckBox.AutoSize = true;
            filterAbove5000CheckBox.Location = new Point(580, 12);
            filterAbove5000CheckBox.Name = "filterAbove5000CheckBox";
            filterAbove5000CheckBox.Size = new Size(61, 19);
            filterAbove5000CheckBox.TabIndex = 17;
            filterAbove5000CheckBox.Text = "> 5000";
            filterAbove5000CheckBox.UseVisualStyleBackColor = true;
            filterAbove5000CheckBox.CheckedChanged += FilterAbove5000CheckBox_CheckedChanged;
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Location = new Point(491, 13);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(83, 15);
            filterLabel.TabIndex = 18;
            filterLabel.Text = "Фильтр цены:";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(filterLabel);
            Controls.Add(filterAbove5000CheckBox);
            Controls.Add(categoryLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(nameLabel);
            Controls.Add(costLabel);
            Controls.Add(idLabel);
            Controls.Add(sortLabel);
            Controls.Add(searchLabel);
            Controls.Add(sortComboBox);
            Controls.Add(searchTextBox);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(categoryComboBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(costTextBox);
            Controls.Add(idTextBox);
            Controls.Add(itemsListBox);
            Name = "ItemsTab";
            Size = new Size(650, 460);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}