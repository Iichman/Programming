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
            this.enumsListBox = new System.Windows.Forms.ListBox();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.indexListBox = new System.Windows.Forms.ListBox();
            this.parseButton = new System.Windows.Forms.Button();
            this.parseInputTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.goButton = new System.Windows.Forms.Button();
            this.classesTabPage = new System.Windows.Forms.TabPage();
            this.innerTabControl = new System.Windows.Forms.TabControl();
            this.rectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.findRectangleButton = new System.Windows.Forms.Button();
            this.moviesTabPage = new System.Windows.Forms.TabPage();
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.findMovieButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.enumsTabPage.SuspendLayout();
            this.classesTabPage.SuspendLayout();
            this.innerTabControl.SuspendLayout();
            this.rectanglesTabPage.SuspendLayout();
            this.moviesTabPage.SuspendLayout();
            this.SuspendLayout();

            // tabControl
            this.tabControl.Controls.Add(this.enumsTabPage);
            this.tabControl.Controls.Add(this.classesTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(5, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(674, 401);
            this.tabControl.TabIndex = 0;

            // enumsTabPage
            this.enumsTabPage.Controls.Add(this.enumsListBox);
            this.enumsTabPage.Controls.Add(this.valuesListBox);
            this.enumsTabPage.Controls.Add(this.indexListBox);
            this.enumsTabPage.Controls.Add(this.parseButton);
            this.enumsTabPage.Controls.Add(this.parseInputTextBox);
            this.enumsTabPage.Controls.Add(this.resultLabel);
            this.enumsTabPage.Controls.Add(this.seasonComboBox);
            this.enumsTabPage.Controls.Add(this.goButton);
            this.enumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.enumsTabPage.Name = "enumsTabPage";
            this.enumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.enumsTabPage.Size = new System.Drawing.Size(666, 375);
            this.enumsTabPage.TabIndex = 0;
            this.enumsTabPage.Text = "Enums";
            this.enumsTabPage.UseVisualStyleBackColor = true;

            // enumsListBox
            this.enumsListBox.FormattingEnabled = true;
            this.enumsListBox.Location = new System.Drawing.Point(6, 6);
            this.enumsListBox.Name = "enumsListBox";
            this.enumsListBox.Size = new System.Drawing.Size(120, 95);
            this.enumsListBox.TabIndex = 0;

            // valuesListBox
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.Location = new System.Drawing.Point(132, 6);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(120, 95);
            this.valuesListBox.TabIndex = 1;

            // indexListBox
            this.indexListBox.FormattingEnabled = true;
            this.indexListBox.Location = new System.Drawing.Point(258, 6);
            this.indexListBox.Name = "indexListBox";
            this.indexListBox.Size = new System.Drawing.Size(40, 95);
            this.indexListBox.TabIndex = 2;

            // parseButton
            this.parseButton.Location = new System.Drawing.Point(6, 120);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(75, 23);
            this.parseButton.TabIndex = 3;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;

            // parseInputTextBox
            this.parseInputTextBox.Location = new System.Drawing.Point(87, 122);
            this.parseInputTextBox.Name = "parseInputTextBox";
            this.parseInputTextBox.Size = new System.Drawing.Size(165, 20);
            this.parseInputTextBox.TabIndex = 4;

            // resultLabel
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(6, 160);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(400, 40);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // seasonComboBox
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Items.AddRange(new object[] {
            "Summer",
            "Autumn",
            "Winter",
            "Spring"});
            this.seasonComboBox.Location = new System.Drawing.Point(6, 220);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(120, 21);
            this.seasonComboBox.TabIndex = 6;

            // goButton
            this.goButton.Location = new System.Drawing.Point(132, 220);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 7;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;

            // classesTabPage
            this.classesTabPage.Controls.Add(this.innerTabControl);
            this.classesTabPage.Location = new System.Drawing.Point(4, 22);
            this.classesTabPage.Name = "classesTabPage";
            this.classesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classesTabPage.Size = new System.Drawing.Size(666, 375);
            this.classesTabPage.TabIndex = 1;
            this.classesTabPage.Text = "Classes";
            this.classesTabPage.UseVisualStyleBackColor = true;

            // innerTabControl
            this.innerTabControl.Controls.Add(this.rectanglesTabPage);
            this.innerTabControl.Controls.Add(this.moviesTabPage);
            this.innerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerTabControl.Location = new System.Drawing.Point(3, 3);
            this.innerTabControl.Name = "innerTabControl";
            this.innerTabControl.SelectedIndex = 0;
            this.innerTabControl.Size = new System.Drawing.Size(660, 369);
            this.innerTabControl.TabIndex = 0;

            // rectanglesTabPage
            this.rectanglesTabPage.Controls.Add(this.rectanglesListBox);
            this.rectanglesTabPage.Controls.Add(this.lengthLabel);
            this.rectanglesTabPage.Controls.Add(this.lengthTextBox);
            this.rectanglesTabPage.Controls.Add(this.widthLabel);
            this.rectanglesTabPage.Controls.Add(this.widthTextBox);
            this.rectanglesTabPage.Controls.Add(this.colorLabel);
            this.rectanglesTabPage.Controls.Add(this.colorTextBox);
            this.rectanglesTabPage.Controls.Add(this.findRectangleButton);
            this.rectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.rectanglesTabPage.Name = "rectanglesTabPage";
            this.rectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rectanglesTabPage.Size = new System.Drawing.Size(652, 343);
            this.rectanglesTabPage.TabIndex = 0;
            this.rectanglesTabPage.Text = "Rectangles";
            this.rectanglesTabPage.UseVisualStyleBackColor = true;

            // rectanglesListBox
            this.rectanglesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.ItemHeight = 12;
            this.rectanglesListBox.Location = new System.Drawing.Point(6, 6);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(180, 268);
            this.rectanglesListBox.TabIndex = 0;

            // lengthLabel
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(192, 20);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(43, 13);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Length:";

            // lengthTextBox
            this.lengthTextBox.Location = new System.Drawing.Point(260, 17);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(120, 20);
            this.lengthTextBox.TabIndex = 2;

            // widthLabel
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(192, 60);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width:";

            // widthTextBox
            this.widthTextBox.Location = new System.Drawing.Point(260, 57);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(120, 20);
            this.widthTextBox.TabIndex = 4;

            // colorLabel
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(192, 100);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(34, 13);
            this.colorLabel.TabIndex = 5;
            this.colorLabel.Text = "Color:";

            // colorTextBox
            this.colorTextBox.Location = new System.Drawing.Point(260, 97);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(120, 20);
            this.colorTextBox.TabIndex = 6;

            // findRectangleButton
            this.findRectangleButton.Location = new System.Drawing.Point(260, 140);
            this.findRectangleButton.Name = "findRectangleButton";
            this.findRectangleButton.Size = new System.Drawing.Size(120, 30);
            this.findRectangleButton.TabIndex = 7;
            this.findRectangleButton.Text = "Find";
            this.findRectangleButton.UseVisualStyleBackColor = true;

            // moviesTabPage
            this.moviesTabPage.Controls.Add(this.moviesListBox);
            this.moviesTabPage.Controls.Add(this.titleLabel);
            this.moviesTabPage.Controls.Add(this.titleTextBox);
            this.moviesTabPage.Controls.Add(this.durationLabel);
            this.moviesTabPage.Controls.Add(this.durationTextBox);
            this.moviesTabPage.Controls.Add(this.yearLabel);
            this.moviesTabPage.Controls.Add(this.yearTextBox);
            this.moviesTabPage.Controls.Add(this.genreLabel);
            this.moviesTabPage.Controls.Add(this.genreTextBox);
            this.moviesTabPage.Controls.Add(this.ratingLabel);
            this.moviesTabPage.Controls.Add(this.ratingTextBox);
            this.moviesTabPage.Controls.Add(this.findMovieButton);
            this.moviesTabPage.Location = new System.Drawing.Point(4, 22);
            this.moviesTabPage.Name = "moviesTabPage";
            this.moviesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.moviesTabPage.Size = new System.Drawing.Size(652, 343);
            this.moviesTabPage.TabIndex = 1;
            this.moviesTabPage.Text = "Movies";
            this.moviesTabPage.UseVisualStyleBackColor = true;

            // moviesListBox
            this.moviesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.ItemHeight = 12;
            this.moviesListBox.Location = new System.Drawing.Point(6, 6);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(180, 268);
            this.moviesListBox.TabIndex = 0;

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(192, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";

            // titleTextBox
            this.titleTextBox.Location = new System.Drawing.Point(260, 17);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(120, 20);
            this.titleTextBox.TabIndex = 2;

            // durationLabel
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(192, 60);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(50, 13);
            this.durationLabel.TabIndex = 3;
            this.durationLabel.Text = "Duration:";

            // durationTextBox
            this.durationTextBox.Location = new System.Drawing.Point(260, 57);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(120, 20);
            this.durationTextBox.TabIndex = 4;

            // yearLabel
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(192, 100);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Year:";

            // yearTextBox
            this.yearTextBox.Location = new System.Drawing.Point(260, 97);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(120, 20);
            this.yearTextBox.TabIndex = 6;

            // genreLabel
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(192, 140);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Genre:";

            // genreTextBox
            this.genreTextBox.Location = new System.Drawing.Point(260, 137);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(120, 20);
            this.genreTextBox.TabIndex = 8;

            // ratingLabel
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(192, 180);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(41, 13);
            this.ratingLabel.TabIndex = 9;
            this.ratingLabel.Text = "Rating:";

            // ratingTextBox
            this.ratingTextBox.Location = new System.Drawing.Point(260, 177);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(120, 20);
            this.ratingTextBox.TabIndex = 10;

            // findMovieButton
            this.findMovieButton.Location = new System.Drawing.Point(260, 220);
            this.findMovieButton.Name = "findMovieButton";
            this.findMovieButton.Size = new System.Drawing.Size(120, 30);
            this.findMovieButton.TabIndex = 11;
            this.findMovieButton.Text = "Find";
            this.findMovieButton.UseVisualStyleBackColor = true;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Programming Demo";
            this.tabControl.ResumeLayout(false);
            this.enumsTabPage.ResumeLayout(false);
            this.enumsTabPage.PerformLayout();
            this.classesTabPage.ResumeLayout(false);
            this.innerTabControl.ResumeLayout(false);
            this.rectanglesTabPage.ResumeLayout(false);
            this.rectanglesTabPage.PerformLayout();
            this.moviesTabPage.ResumeLayout(false);
            this.moviesTabPage.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage enumsTabPage;
        private System.Windows.Forms.ListBox enumsListBox;
        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.ListBox indexListBox;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.TextBox parseInputTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TabPage classesTabPage;
        private System.Windows.Forms.TabControl innerTabControl;
        private System.Windows.Forms.TabPage rectanglesTabPage;
        private System.Windows.Forms.ListBox rectanglesListBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Button findRectangleButton;
        private System.Windows.Forms.TabPage moviesTabPage;
        private System.Windows.Forms.ListBox moviesListBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Button findMovieButton;
    }
}