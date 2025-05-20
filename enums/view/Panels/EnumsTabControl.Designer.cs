namespace Programming.View.Controls
{
    partial class EnumsTabControl
    {
        private System.ComponentModel.IContainer components = null;

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
            this.enumsListBox = new System.Windows.Forms.ListBox();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.indexListBox = new System.Windows.Forms.ListBox();
            this.parseButton = new System.Windows.Forms.Button();
            this.parseInputTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enumsListBox
            // 
            this.enumsListBox.FormattingEnabled = true;
            this.enumsListBox.Location = new System.Drawing.Point(6, 6);
            this.enumsListBox.Name = "enumsListBox";
            this.enumsListBox.Size = new System.Drawing.Size(120, 95);
            this.enumsListBox.TabIndex = 0;
            this.enumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.Location = new System.Drawing.Point(132, 6);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(120, 95);
            this.valuesListBox.TabIndex = 1;
            this.valuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // indexListBox
            // 
            this.indexListBox.FormattingEnabled = true;
            this.indexListBox.Location = new System.Drawing.Point(258, 6);
            this.indexListBox.Name = "indexListBox";
            this.indexListBox.Size = new System.Drawing.Size(40, 95);
            this.indexListBox.TabIndex = 2;
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(6, 120);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(75, 23);
            this.parseButton.TabIndex = 3;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // parseInputTextBox
            // 
            this.parseInputTextBox.Location = new System.Drawing.Point(87, 122);
            this.parseInputTextBox.Name = "parseInputTextBox";
            this.parseInputTextBox.Size = new System.Drawing.Size(165, 20);
            this.parseInputTextBox.TabIndex = 4;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(6, 160);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(400, 40);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Location = new System.Drawing.Point(6, 220);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(120, 21);
            this.seasonComboBox.TabIndex = 6;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(132, 220);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 7;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // EnumsTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.seasonComboBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.parseInputTextBox);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.indexListBox);
            this.Controls.Add(this.valuesListBox);
            this.Controls.Add(this.enumsListBox);
            this.Name = "EnumsTabControl";
            this.Size = new System.Drawing.Size(776, 435);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox enumsListBox;
        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.ListBox indexListBox;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.TextBox parseInputTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.Button goButton;
    }
}