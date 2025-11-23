namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox apartmentTextBox;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.Label apartmentLabel;

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
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.apartmentTextBox = new System.Windows.Forms.TextBox();
            this.indexLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.apartmentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(80, 20);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(100, 22);
            this.indexTextBox.TabIndex = 0;
            this.indexTextBox.TextChanged += new System.EventHandler(this.IndexTextBox_TextChanged);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(80, 60);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(180, 22);
            this.countryTextBox.TabIndex = 1;
            this.countryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(300, 60);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(180, 22);
            this.cityTextBox.TabIndex = 2;
            this.cityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // streetTextBox
            // 
            this.streetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streetTextBox.Location = new System.Drawing.Point(80, 100);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(400, 22);
            this.streetTextBox.TabIndex = 3;
            this.streetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Location = new System.Drawing.Point(80, 140);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(180, 22);
            this.buildingTextBox.TabIndex = 4;
            this.buildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // apartmentTextBox
            // 
            this.apartmentTextBox.Location = new System.Drawing.Point(300, 140);
            this.apartmentTextBox.Name = "apartmentTextBox";
            this.apartmentTextBox.Size = new System.Drawing.Size(180, 22);
            this.apartmentTextBox.TabIndex = 5;
            this.apartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Location = new System.Drawing.Point(20, 23);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(44, 16);
            this.indexLabel.TabIndex = 6;
            this.indexLabel.Text = "Index:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(20, 63);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(55, 16);
            this.countryLabel.TabIndex = 7;
            this.countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(270, 63);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(32, 16);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "City:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(20, 103);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(48, 16);
            this.streetLabel.TabIndex = 9;
            this.streetLabel.Text = "Street:";
            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.Location = new System.Drawing.Point(20, 143);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(60, 16);
            this.buildingLabel.TabIndex = 10;
            this.buildingLabel.Text = "Building:";
            // 
            // apartmentLabel
            // 
            this.apartmentLabel.AutoSize = true;
            this.apartmentLabel.Location = new System.Drawing.Point(270, 143);
            this.apartmentLabel.Name = "apartmentLabel";
            this.apartmentLabel.Size = new System.Drawing.Size(39, 16);
            this.apartmentLabel.TabIndex = 11;
            this.apartmentLabel.Text = "Apt.:";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.apartmentLabel);
            this.Controls.Add(this.buildingLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.apartmentTextBox);
            this.Controls.Add(this.buildingTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.indexTextBox);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(500, 180);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}