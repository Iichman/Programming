namespace Programming.View.Controls
{
    partial class ClassesTabControl
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
            this.innerTabControl = new System.Windows.Forms.TabControl();
            this.rectanglesTabPage = new System.Windows.Forms.TabPage();
            this.moviesTabPage = new System.Windows.Forms.TabPage();
            this.ringsTabPage = new System.Windows.Forms.TabPage();
            this.innerTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // innerTabControl
            // 
            this.innerTabControl.Controls.Add(this.rectanglesTabPage);
            this.innerTabControl.Controls.Add(this.moviesTabPage);
            this.innerTabControl.Controls.Add(this.ringsTabPage);
            this.innerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerTabControl.Location = new System.Drawing.Point(0, 0);
            this.innerTabControl.Name = "innerTabControl";
            this.innerTabControl.SelectedIndex = 0;
            this.innerTabControl.Size = new System.Drawing.Size(770, 429);
            this.innerTabControl.TabIndex = 0;
            // 
            // rectanglesTabPage
            // 
            this.rectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.rectanglesTabPage.Name = "rectanglesTabPage";
            this.rectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rectanglesTabPage.Size = new System.Drawing.Size(762, 403);
            this.rectanglesTabPage.TabIndex = 0;
            this.rectanglesTabPage.Text = "Rectangles";
            this.rectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // moviesTabPage
            // 
            this.moviesTabPage.Location = new System.Drawing.Point(4, 22);
            this.moviesTabPage.Name = "moviesTabPage";
            this.moviesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.moviesTabPage.Size = new System.Drawing.Size(762, 403);
            this.moviesTabPage.TabIndex = 1;
            this.moviesTabPage.Text = "Movies";
            this.moviesTabPage.UseVisualStyleBackColor = true;
            // 
            // ringsTabPage
            // 
            this.ringsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ringsTabPage.Name = "ringsTabPage";
            this.ringsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ringsTabPage.Size = new System.Drawing.Size(762, 403);
            this.ringsTabPage.TabIndex = 2;
            this.ringsTabPage.Text = "Rings";
            this.ringsTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.innerTabControl);
            this.Name = "ClassesTabControl";
            this.Size = new System.Drawing.Size(770, 429);
            this.innerTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl innerTabControl;
        private System.Windows.Forms.TabPage rectanglesTabPage;
        private System.Windows.Forms.TabPage moviesTabPage;
        private System.Windows.Forms.TabPage ringsTabPage;
    }
}