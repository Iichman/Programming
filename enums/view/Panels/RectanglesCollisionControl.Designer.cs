namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
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
            this.ring1Label = new System.Windows.Forms.Label();
            this.ring1ComboBox = new System.Windows.Forms.ComboBox();
            this.ring2Label = new System.Windows.Forms.Label();
            this.ring2ComboBox = new System.Windows.Forms.ComboBox();
            this.rectangle1Label = new System.Windows.Forms.Label();
            this.rectangle1ComboBox = new System.Windows.Forms.ComboBox();
            this.rectangle2Label = new System.Windows.Forms.Label();
            this.rectangle2ComboBox = new System.Windows.Forms.ComboBox();
            this.checkCollisionButton = new System.Windows.Forms.Button();
            this.collisionResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ring1Label
            // 
            this.ring1Label.AutoSize = true;
            this.ring1Label.Location = new System.Drawing.Point(20, 100);
            this.ring1Label.Name = "ring1Label";
            this.ring1Label.Size = new System.Drawing.Size(40, 13);
            this.ring1Label.TabIndex = 6;
            this.ring1Label.Text = "Ring 1:";
            // 
            // ring1ComboBox
            // 
            this.ring1ComboBox.FormattingEnabled = true;
            this.ring1ComboBox.Location = new System.Drawing.Point(100, 97);
            this.ring1ComboBox.Name = "ring1ComboBox";
            this.ring1ComboBox.Size = new System.Drawing.Size(150, 21);
            this.ring1ComboBox.TabIndex = 7;
            // 
            // ring2Label
            // 
            this.ring2Label.AutoSize = true;
            this.ring2Label.Location = new System.Drawing.Point(20, 140);
            this.ring2Label.Name = "ring2Label";
            this.ring2Label.Size = new System.Drawing.Size(40, 13);
            this.ring2Label.TabIndex = 8;
            this.ring2Label.Text = "Ring 2:";
            // 
            // ring2ComboBox
            // 
            this.ring2ComboBox.FormattingEnabled = true;
            this.ring2ComboBox.Location = new System.Drawing.Point(100, 137);
            this.ring2ComboBox.Name = "ring2ComboBox";
            this.ring2ComboBox.Size = new System.Drawing.Size(150, 21);
            this.ring2ComboBox.TabIndex = 9;
            // 
            // rectangle1Label
            // 
            this.rectangle1Label.AutoSize = true;
            this.rectangle1Label.Location = new System.Drawing.Point(20, 20);
            this.rectangle1Label.Name = "rectangle1Label";
            this.rectangle1Label.Size = new System.Drawing.Size(70, 13);
            this.rectangle1Label.TabIndex = 0;
            this.rectangle1Label.Text = "Rectangle 1:";
            // 
            // rectangle1ComboBox
            // 
            this.rectangle1ComboBox.FormattingEnabled = true;
            this.rectangle1ComboBox.Location = new System.Drawing.Point(100, 17);
            this.rectangle1ComboBox.Name = "rectangle1ComboBox";
            this.rectangle1ComboBox.Size = new System.Drawing.Size(150, 21);
            this.rectangle1ComboBox.TabIndex = 1;
            // 
            // rectangle2Label
            // 
            this.rectangle2Label.AutoSize = true;
            this.rectangle2Label.Location = new System.Drawing.Point(20, 60);
            this.rectangle2Label.Name = "rectangle2Label";
            this.rectangle2Label.Size = new System.Drawing.Size(70, 13);
            this.rectangle2Label.TabIndex = 2;
            this.rectangle2Label.Text = "Rectangle 2:";
            // 
            // rectangle2ComboBox
            // 
            this.rectangle2ComboBox.FormattingEnabled = true;
            this.rectangle2ComboBox.Location = new System.Drawing.Point(100, 57);
            this.rectangle2ComboBox.Name = "rectangle2ComboBox";
            this.rectangle2ComboBox.Size = new System.Drawing.Size(150, 21);
            this.rectangle2ComboBox.TabIndex = 3;
            // 
            // checkCollisionButton
            // 
            this.checkCollisionButton.Location = new System.Drawing.Point(100, 180);
            this.checkCollisionButton.Name = "checkCollisionButton";
            this.checkCollisionButton.Size = new System.Drawing.Size(150, 30);
            this.checkCollisionButton.TabIndex = 4;
            this.checkCollisionButton.Text = "Check Collision";
            this.checkCollisionButton.UseVisualStyleBackColor = true;
            // 
            // collisionResultLabel
            // 
            this.collisionResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.collisionResultLabel.Location = new System.Drawing.Point(20, 230);
            this.collisionResultLabel.Name = "collisionResultLabel";
            this.collisionResultLabel.Size = new System.Drawing.Size(230, 40);
            this.collisionResultLabel.TabIndex = 5;
            this.collisionResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.collisionResultLabel);
            this.Controls.Add(this.checkCollisionButton);
            this.Controls.Add(this.rectangle2ComboBox);
            this.Controls.Add(this.rectangle2Label);
            this.Controls.Add(this.rectangle1ComboBox);
            this.Controls.Add(this.rectangle1Label);
            this.Controls.Add(this.ring2ComboBox);
            this.Controls.Add(this.ring2Label);
            this.Controls.Add(this.ring1ComboBox);
            this.Controls.Add(this.ring1Label);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(776, 435);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label ring1Label;
        private System.Windows.Forms.ComboBox ring1ComboBox;
        private System.Windows.Forms.Label ring2Label;
        private System.Windows.Forms.ComboBox ring2ComboBox;
        private System.Windows.Forms.Label rectangle1Label;
        private System.Windows.Forms.ComboBox rectangle1ComboBox;
        private System.Windows.Forms.Label rectangle2Label;
        private System.Windows.Forms.ComboBox rectangle2ComboBox;
        private System.Windows.Forms.Button checkCollisionButton;
        private System.Windows.Forms.Label collisionResultLabel;
    }
}