namespace Programming.View
{
    partial class MainForm
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
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(12, 230);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TextChanged += new System.EventHandler(this.lengthTextBox_TextChanged);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(12, 260);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(12, 290);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TextChanged += new System.EventHandler(this.colorTextBox_TextChanged);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(12, 320);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(100, 23);
            this.findButton.TabIndex = 0;
            this.findButton.Text = "Find Max Width";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 370);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Button findButton;
    }
}