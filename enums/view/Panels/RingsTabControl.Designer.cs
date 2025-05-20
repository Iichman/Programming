namespace Programming.View.Controls
{
    partial class RingsControl
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
            this.ringsListBox = new System.Windows.Forms.ListBox();
            this.outerRadiusLabel = new System.Windows.Forms.Label();
            this.outerRadiusTextBox = new System.Windows.Forms.TextBox();
            this.innerRadiusLabel = new System.Windows.Forms.Label();
            this.innerRadiusTextBox = new System.Windows.Forms.TextBox();
            this.ringCenterLabel = new System.Windows.Forms.Label();
            this.ringCenterXLabel = new System.Windows.Forms.Label();
            this.ringCenterXTextBox = new System.Windows.Forms.TextBox();
            this.ringCenterYLabel = new System.Windows.Forms.Label();
            this.ringCenterYTextBox = new System.Windows.Forms.TextBox();
            this.findRingButton = new System.Windows.Forms.Button();
            this.ringIdLabel = new System.Windows.Forms.Label();
            this.ringIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ringsListBox
            // 
            this.ringsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ringsListBox.FormattingEnabled = true;
            this.ringsListBox.Location = new System.Drawing.Point(6, 6);
            this.ringsListBox.Name = "ringsListBox";
            this.ringsListBox.Size = new System.Drawing.Size(180, 381);
            this.ringsListBox.TabIndex = 0;
            this.ringsListBox.SelectedIndexChanged += new System.EventHandler(this.RingsListBox_SelectedIndexChanged);
            // 
            // outerRadiusLabel
            // 
            this.outerRadiusLabel.AutoSize = true;
            this.outerRadiusLabel.Location = new System.Drawing.Point(192, 20);
            this.outerRadiusLabel.Name = "outerRadiusLabel";
            this.outerRadiusLabel.Size = new System.Drawing.Size(72, 13);
            this.outerRadiusLabel.TabIndex = 1;
            this.outerRadiusLabel.Text = "Outer Radius:";
            // 
            // outerRadiusTextBox
            // 
            this.outerRadiusTextBox.Location = new System.Drawing.Point(270, 17);
            this.outerRadiusTextBox.Name = "outerRadiusTextBox";
            this.outerRadiusTextBox.Size = new System.Drawing.Size(120, 20);
            this.outerRadiusTextBox.TabIndex = 2;
            this.outerRadiusTextBox.TextChanged += new System.EventHandler(this.RingTextBox_TextChanged);
            // 
            // innerRadiusLabel
            // 
            this.innerRadiusLabel.AutoSize = true;
            this.innerRadiusLabel.Location = new System.Drawing.Point(192, 60);
            this.innerRadiusLabel.Name = "innerRadiusLabel";
            this.innerRadiusLabel.Size = new System.Drawing.Size(70, 13);
            this.innerRadiusLabel.TabIndex = 3;
            this.innerRadiusLabel.Text = "Inner Radius:";
            // 
            // innerRadiusTextBox
            // 
            this.innerRadiusTextBox.Location = new System.Drawing.Point(270, 57);
            this.innerRadiusTextBox.Name = "innerRadiusTextBox";
            this.innerRadiusTextBox.Size = new System.Drawing.Size(120, 20);
            this.innerRadiusTextBox.TabIndex = 4;
            this.innerRadiusTextBox.TextChanged += new System.EventHandler(this.RingTextBox_TextChanged);
            // 
            // ringCenterLabel
            // 
            this.ringCenterLabel.AutoSize = true;
            this.ringCenterLabel.Location = new System.Drawing.Point(192, 140);
            this.ringCenterLabel.Name = "ringCenterLabel";
            this.ringCenterLabel.Size = new System.Drawing.Size(41, 13);
            this.ringCenterLabel.TabIndex = 5;
            this.ringCenterLabel.Text = "Center:";
            // 
            // ringCenterXLabel
            // 
            this.ringCenterXLabel.AutoSize = true;
            this.ringCenterXLabel.Location = new System.Drawing.Point(240, 140);
            this.ringCenterXLabel.Name = "ringCenterXLabel";
            this.ringCenterXLabel.Size = new System.Drawing.Size(17, 13);
            this.ringCenterXLabel.TabIndex = 6;
            this.ringCenterXLabel.Text = "X:";
            // 
            // ringCenterXTextBox
            // 
            this.ringCenterXTextBox.Location = new System.Drawing.Point(270, 137);
            this.ringCenterXTextBox.Name = "ringCenterXTextBox";
            this.ringCenterXTextBox.Size = new System.Drawing.Size(60, 20);
            this.ringCenterXTextBox.TabIndex = 7;
            this.ringCenterXTextBox.TextChanged += new System.EventHandler(this.RingTextBox_TextChanged);
            // 
            // ringCenterYLabel
            // 
            this.ringCenterYLabel.AutoSize = true;
            this.ringCenterYLabel.Location = new System.Drawing.Point(340, 140);
            this.ringCenterYLabel.Name = "ringCenterYLabel";
            this.ringCenterYLabel.Size = new System.Drawing.Size(17, 13);
            this.ringCenterYLabel.TabIndex = 8;
            this.ringCenterYLabel.Text = "Y:";
            // 
            // ringCenterYTextBox
            // 
            this.ringCenterYTextBox.Location = new System.Drawing.Point(360, 137);
            this.ringCenterYTextBox.Name = "ringCenterYTextBox";
            this.ringCenterYTextBox.Size = new System.Drawing.Size(60, 20);
            this.ringCenterYTextBox.TabIndex = 9;
            this.ringCenterYTextBox.TextChanged += new System.EventHandler(this.RingTextBox_TextChanged);
            // 
            // findRingButton
            // 
            this.findRingButton.Location = new System.Drawing.Point(270, 220);
            this.findRingButton.Name = "findRingButton";
            this.findRingButton.Size = new System.Drawing.Size(120, 30);
            this.findRingButton.TabIndex = 10;
            this.findRingButton.Text = "Find";
            this.findRingButton.UseVisualStyleBackColor = true;
            this.findRingButton.Click += new System.EventHandler(this.FindRingButton_Click);
            // 
            // ringIdLabel
            // 
            this.ringIdLabel.AutoSize = true;
            this.ringIdLabel.Location = new System.Drawing.Point(192, 100);
            this.ringIdLabel.Name = "ringIdLabel";
            this.ringIdLabel.Size = new System.Drawing.Size(21, 13);
            this.ringIdLabel.TabIndex = 11;
            this.ringIdLabel.Text = "ID:";
            // 
            // ringIdTextBox
            // 
            this.ringIdTextBox.Location = new System.Drawing.Point(270, 97);
            this.ringIdTextBox.Name = "ringIdTextBox";
            this.ringIdTextBox.ReadOnly = true;
            this.ringIdTextBox.Size = new System.Drawing.Size(60, 20);
            this.ringIdTextBox.TabIndex = 12;
            // 
            // RingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ringIdTextBox);
            this.Controls.Add(this.ringIdLabel);
            this.Controls.Add(this.findRingButton);
            this.Controls.Add(this.ringCenterYTextBox);
            this.Controls.Add(this.ringCenterYLabel);
            this.Controls.Add(this.ringCenterXTextBox);
            this.Controls.Add(this.ringCenterXLabel);
            this.Controls.Add(this.ringCenterLabel);
            this.Controls.Add(this.innerRadiusTextBox);
            this.Controls.Add(this.innerRadiusLabel);
            this.Controls.Add(this.outerRadiusTextBox);
            this.Controls.Add(this.outerRadiusLabel);
            this.Controls.Add(this.ringsListBox);
            this.Name = "RingsControl";
            this.Size = new System.Drawing.Size(762, 403);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox ringsListBox;
        private System.Windows.Forms.Label outerRadiusLabel;
        private System.Windows.Forms.TextBox outerRadiusTextBox;
        private System.Windows.Forms.Label innerRadiusLabel;
        private System.Windows.Forms.TextBox innerRadiusTextBox;
        private System.Windows.Forms.Label ringCenterLabel;
        private System.Windows.Forms.Label ringCenterXLabel;
        private System.Windows.Forms.TextBox ringCenterXTextBox;
        private System.Windows.Forms.Label ringCenterYLabel;
        private System.Windows.Forms.TextBox ringCenterYTextBox;
        private System.Windows.Forms.Button findRingButton;
        private System.Windows.Forms.Label ringIdLabel;
        private System.Windows.Forms.TextBox ringIdTextBox;
    }
}