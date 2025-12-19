namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label postIndexLabel;
        private System.Windows.Forms.TextBox postIndexTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.Label apartmentLabel;
        private System.Windows.Forms.TextBox apartmentTextBox;

        // ErrorProvider компоненты
        private System.Windows.Forms.ErrorProvider postIndexErrorProvider;
        private System.Windows.Forms.ErrorProvider countryErrorProvider;
        private System.Windows.Forms.ErrorProvider cityErrorProvider;
        private System.Windows.Forms.ErrorProvider streetErrorProvider;
        private System.Windows.Forms.ErrorProvider buildingErrorProvider;
        private System.Windows.Forms.ErrorProvider apartmentErrorProvider;

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
            this.components = new System.ComponentModel.Container();
            this.postIndexLabel = new System.Windows.Forms.Label();
            this.postIndexTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.apartmentLabel = new System.Windows.Forms.Label();
            this.apartmentTextBox = new System.Windows.Forms.TextBox();

            // Инициализация ErrorProvider
            this.postIndexErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.countryErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cityErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.streetErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buildingErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.apartmentErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.postIndexErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentErrorProvider)).BeginInit();
            this.SuspendLayout();

            // 
            // postIndexLabel
            // 
            this.postIndexLabel.AutoSize = true;
            this.postIndexLabel.Location = new System.Drawing.Point(10, 10);
            this.postIndexLabel.Name = "postIndexLabel";
            this.postIndexLabel.Size = new System.Drawing.Size(63, 15);
            this.postIndexLabel.TabIndex = 0;
            this.postIndexLabel.Text = "Post Index:";

            // 
            // postIndexTextBox
            // 
            this.postIndexTextBox.Location = new System.Drawing.Point(80, 7);
            this.postIndexTextBox.MaxLength = 6;
            this.postIndexTextBox.Name = "postIndexTextBox";
            this.postIndexTextBox.Size = new System.Drawing.Size(100, 23);
            this.postIndexTextBox.TabIndex = 1;
            this.postIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            this.postIndexTextBox.Leave += new System.EventHandler(this.PostIndexTextBox_Leave);

            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(10, 40);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(53, 15);
            this.countryLabel.TabIndex = 2;
            this.countryLabel.Text = "Country:";

            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(80, 37);
            this.countryTextBox.MaxLength = 50;
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(200, 23);
            this.countryTextBox.TabIndex = 3;
            this.countryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            this.countryTextBox.Leave += new System.EventHandler(this.CountryTextBox_Leave);

            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(10, 70);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 15);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City:";

            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(80, 67);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 23);
            this.cityTextBox.TabIndex = 5;
            this.cityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            this.cityTextBox.Leave += new System.EventHandler(this.CityTextBox_Leave);

            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(10, 100);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(40, 15);
            this.streetLabel.TabIndex = 6;
            this.streetLabel.Text = "Street:";

            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(80, 97);
            this.streetTextBox.MaxLength = 100;
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(250, 23);
            this.streetTextBox.TabIndex = 7;
            this.streetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            this.streetTextBox.Leave += new System.EventHandler(this.StreetTextBox_Leave);

            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.Location = new System.Drawing.Point(10, 130);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(54, 15);
            this.buildingLabel.TabIndex = 8;
            this.buildingLabel.Text = "Building:";

            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Location = new System.Drawing.Point(80, 127);
            this.buildingTextBox.MaxLength = 10;
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(100, 23);
            this.buildingTextBox.TabIndex = 9;
            this.buildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            this.buildingTextBox.Leave += new System.EventHandler(this.BuildingTextBox_Leave);

            // 
            // apartmentLabel
            // 
            this.apartmentLabel.AutoSize = true;
            this.apartmentLabel.Location = new System.Drawing.Point(200, 130);
            this.apartmentLabel.Name = "apartmentLabel";
            this.apartmentLabel.Size = new System.Drawing.Size(66, 15);
            this.apartmentLabel.TabIndex = 10;
            this.apartmentLabel.Text = "Apartment:";

            // 
            // apartmentTextBox
            // 
            this.apartmentTextBox.Location = new System.Drawing.Point(270, 127);
            this.apartmentTextBox.MaxLength = 10;
            this.apartmentTextBox.Name = "apartmentTextBox";
            this.apartmentTextBox.Size = new System.Drawing.Size(100, 23);
            this.apartmentTextBox.TabIndex = 11;
            this.apartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            this.apartmentTextBox.Leave += new System.EventHandler(this.ApartmentTextBox_Leave);

            // 
            // postIndexErrorProvider
            // 
            this.postIndexErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.postIndexErrorProvider.ContainerControl = this;

            // 
            // countryErrorProvider
            // 
            this.countryErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.countryErrorProvider.ContainerControl = this;

            // 
            // cityErrorProvider
            // 
            this.cityErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.cityErrorProvider.ContainerControl = this;

            // 
            // streetErrorProvider
            // 
            this.streetErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.streetErrorProvider.ContainerControl = this;

            // 
            // buildingErrorProvider
            // 
            this.buildingErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.buildingErrorProvider.ContainerControl = this;

            // 
            // apartmentErrorProvider
            // 
            this.apartmentErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.apartmentErrorProvider.ContainerControl = this;

            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.apartmentTextBox);
            this.Controls.Add(this.apartmentLabel);
            this.Controls.Add(this.buildingTextBox);
            this.Controls.Add(this.buildingLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.postIndexTextBox);
            this.Controls.Add(this.postIndexLabel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(380, 160);
            ((System.ComponentModel.ISupportInitialize)(this.postIndexErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}