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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.enumsTabPage = new System.Windows.Forms.TabPage();
            this.classesTabPage = new System.Windows.Forms.TabPage();
            this.collisionTabPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.enumsTabPage);
            this.tabControl.Controls.Add(this.classesTabPage);
            this.tabControl.Controls.Add(this.collisionTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 461);
            this.tabControl.TabIndex = 0;
            // 
            // enumsTabPage
            // 
            this.enumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.enumsTabPage.Name = "enumsTabPage";
            this.enumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.enumsTabPage.Size = new System.Drawing.Size(776, 435);
            this.enumsTabPage.TabIndex = 0;
            this.enumsTabPage.Text = "Enums";
            this.enumsTabPage.UseVisualStyleBackColor = true;
            // 
            // classesTabPage
            // 
            this.classesTabPage.Location = new System.Drawing.Point(4, 22);
            this.classesTabPage.Name = "classesTabPage";
            this.classesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classesTabPage.Size = new System.Drawing.Size(776, 435);
            this.classesTabPage.TabIndex = 1;
            this.classesTabPage.Text = "Classes";
            this.classesTabPage.UseVisualStyleBackColor = true;
            // 
            // collisionTabPage
            // 
            this.collisionTabPage.Location = new System.Drawing.Point(4, 22);
            this.collisionTabPage.Name = "collisionTabPage";
            this.collisionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.collisionTabPage.Size = new System.Drawing.Size(776, 435);
            this.collisionTabPage.TabIndex = 2;
            this.collisionTabPage.Text = "Collision";
            this.collisionTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage enumsTabPage;
        private System.Windows.Forms.TabPage classesTabPage;
        private System.Windows.Forms.TabPage collisionTabPage;
    }
}