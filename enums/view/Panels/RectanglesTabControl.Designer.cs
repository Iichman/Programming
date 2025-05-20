namespace Programming.View.Controls
{
    partial class RectanglesControl
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
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.addRectangleButton = new System.Windows.Forms.Button();
            this.removeRectangleButton = new System.Windows.Forms.Button();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.centerLabel = new System.Windows.Forms.Label();
            this.centerXLabel = new System.Windows.Forms.Label();
            this.centerXTextBox = new System.Windows.Forms.TextBox();
            this.centerYLabel = new System.Windows.Forms.Label();
            this.centerYTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // canvasPanel
            // 
            this.canvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPanel.Location = new System.Drawing.Point(200, 6);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(556, 391);
            this.canvasPanel.TabIndex = 15;
            // 
            // addRectangleButton
            // 
            this.addRectangleButton.Location = new System.Drawing.Point(6, 220);
            this.addRectangleButton.Name = "addRectangleButton";
            this.addRectangleButton.Size = new System.Drawing.Size(180, 30);
            this.addRectangleButton.TabIndex = 14;
            this.addRectangleButton.Text = "Add";
            this.addRectangleButton.UseVisualStyleBackColor = true;
            // 
            // removeRectangleButton
            // 
            this.removeRectangleButton.Location = new System.Drawing.Point(6, 260);
            this.removeRectangleButton.Name = "removeRectangleButton";
            this.removeRectangleButton.Size = new System.Drawing.Size(180, 30);
            this.removeRectangleButton.TabIndex = 13;
            this.removeRectangleButton.Text = "Remove";
            this.removeRectangleButton.UseVisualStyleBackColor = true;
            // 
            // rectanglesListBox
            // 
            this.rectanglesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.Location = new System.Drawing.Point(6, 6);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(180, 199);
            this.rectanglesListBox.TabIndex = 0;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(6, 300);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(43, 13);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Length:";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(60, 297);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(120, 20);
            this.lengthTextBox.TabIndex = 2;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(6, 330);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width:";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(60, 327);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(120, 20);
            this.widthTextBox.TabIndex = 4;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(6, 360);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(60, 357);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(60, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // centerLabel
            // 
            this.centerLabel.AutoSize = true;
            this.centerLabel.Location = new System.Drawing.Point(6, 390);
            this.centerLabel.Name = "centerLabel";
            this.centerLabel.Size = new System.Drawing.Size(41, 13);
            this.centerLabel.TabIndex = 10;
            this.centerLabel.Text = "Center:";
            // 
            // centerXLabel
            // 
            this.centerXLabel.AutoSize = true;
            this.centerXLabel.Location = new System.Drawing.Point(50, 390);
            this.centerXLabel.Name = "centerXLabel";
            this.centerXLabel.Size = new System.Drawing.Size(17, 13);
            this.centerXLabel.TabIndex = 11;
            this.centerXLabel.Text = "X:";
            // 
            // centerXTextBox
            // 
            this.centerXTextBox.Location = new System.Drawing.Point(70, 387);
            this.centerXTextBox.Name = "centerXTextBox";
            this.centerXTextBox.Size = new System.Drawing.Size(50, 20);
            this.centerXTextBox.TabIndex = 12;
            // 
            // centerYLabel
            // 
            this.centerYLabel.AutoSize = true;
            this.centerYLabel.Location = new System.Drawing.Point(130, 390);
            this.centerYLabel.Name = "centerYLabel";
            this.centerYLabel.Size = new System.Drawing.Size(17, 13);
            this.centerYLabel.TabIndex = 13;
            this.centerYLabel.Text = "Y:";
            // 
            // centerYTextBox
            // 
            this.centerYTextBox.Location = new System.Drawing.Point(150, 387);
            this.centerYTextBox.Name = "centerYTextBox";
            this.centerYTextBox.Size = new System.Drawing.Size(50, 20);
            this.centerYTextBox.TabIndex = 14;
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.centerYTextBox);
            this.Controls.Add(this.centerYLabel);
            this.Controls.Add(this.centerXTextBox);
            this.Controls.Add(this.centerXLabel);
            this.Controls.Add(this.centerLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.rectanglesListBox);
            this.Controls.Add(this.removeRectangleButton);
            this.Controls.Add(this.addRectangleButton);
            this.Controls.Add(this.canvasPanel);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(762, 403);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Button addRectangleButton;
        private System.Windows.Forms.Button removeRectangleButton;
        private System.Windows.Forms.ListBox rectanglesListBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label centerLabel;
        private System.Windows.Forms.Label centerXLabel;
        private System.Windows.Forms.TextBox centerXTextBox;
        private System.Windows.Forms.Label centerYLabel;
        private System.Windows.Forms.TextBox centerYTextBox;
    }
}