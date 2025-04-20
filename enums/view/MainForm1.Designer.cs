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
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.centerLabel = new System.Windows.Forms.Label();
            this.centerXLabel = new System.Windows.Forms.Label();
            this.centerXTextBox = new System.Windows.Forms.TextBox();
            this.centerYLabel = new System.Windows.Forms.Label();
            this.centerYTextBox = new System.Windows.Forms.TextBox();
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
            this.ringsTabPage = new System.Windows.Forms.TabPage();
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
            this.collisionTabPage = new System.Windows.Forms.TabPage();
            this.rectangle1Label = new System.Windows.Forms.Label();
            this.rectangle1ComboBox = new System.Windows.Forms.ComboBox();
            this.rectangle2Label = new System.Windows.Forms.Label();
            this.rectangle2ComboBox = new System.Windows.Forms.ComboBox();
            this.checkCollisionButton = new System.Windows.Forms.Button();
            this.collisionResultLabel = new System.Windows.Forms.Label();
            this.ring1Label = new System.Windows.Forms.Label();
            this.ring1ComboBox = new System.Windows.Forms.ComboBox();
            this.ring2Label = new System.Windows.Forms.Label();
            this.ring2ComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.enumsTabPage.SuspendLayout();
            this.classesTabPage.SuspendLayout();
            this.innerTabControl.SuspendLayout();
            this.rectanglesTabPage.SuspendLayout();
            this.moviesTabPage.SuspendLayout();
            this.ringsTabPage.SuspendLayout();
            this.collisionTabPage.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(684, 411);
            this.tabControl.TabIndex = 0;
            // 
            // enumsTabPage
            // 
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
            this.enumsTabPage.Size = new System.Drawing.Size(676, 385);
            this.enumsTabPage.TabIndex = 0;
            this.enumsTabPage.Text = "Enums";
            this.enumsTabPage.UseVisualStyleBackColor = true;
            // 
            // enumsListBox
            // 
            this.enumsListBox.FormattingEnabled = true;
            this.enumsListBox.Location = new System.Drawing.Point(6, 6);
            this.enumsListBox.Name = "enumsListBox";
            this.enumsListBox.Size = new System.Drawing.Size(120, 95);
            this.enumsListBox.TabIndex = 0;
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.Location = new System.Drawing.Point(132, 6);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(120, 95);
            this.valuesListBox.TabIndex = 1;
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
            this.seasonComboBox.Items.AddRange(new object[] {
            "Summer",
            "Autumn",
            "Winter",
            "Spring"});
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
            // 
            // classesTabPage
            // 
            this.classesTabPage.Controls.Add(this.innerTabControl);
            this.classesTabPage.Location = new System.Drawing.Point(4, 22);
            this.classesTabPage.Name = "classesTabPage";
            this.classesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classesTabPage.Size = new System.Drawing.Size(676, 385);
            this.classesTabPage.TabIndex = 1;
            this.classesTabPage.Text = "Classes";
            this.classesTabPage.UseVisualStyleBackColor = true;
            // 
            // innerTabControl
            // 
            this.innerTabControl.Controls.Add(this.rectanglesTabPage);
            this.innerTabControl.Controls.Add(this.moviesTabPage);
            this.innerTabControl.Controls.Add(this.ringsTabPage);
            this.innerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerTabControl.Location = new System.Drawing.Point(3, 3);
            this.innerTabControl.Name = "innerTabControl";
            this.innerTabControl.SelectedIndex = 0;
            this.innerTabControl.Size = new System.Drawing.Size(670, 379);
            this.innerTabControl.TabIndex = 0;
            // 
            // rectanglesTabPage
            // 
            this.rectanglesTabPage.Controls.Add(this.rectanglesListBox);
            this.rectanglesTabPage.Controls.Add(this.lengthLabel);
            this.rectanglesTabPage.Controls.Add(this.lengthTextBox);
            this.rectanglesTabPage.Controls.Add(this.widthLabel);
            this.rectanglesTabPage.Controls.Add(this.widthTextBox);
            this.rectanglesTabPage.Controls.Add(this.colorLabel);
            this.rectanglesTabPage.Controls.Add(this.colorTextBox);
            this.rectanglesTabPage.Controls.Add(this.findRectangleButton);
            this.rectanglesTabPage.Controls.Add(this.idLabel);
            this.rectanglesTabPage.Controls.Add(this.idTextBox);
            this.rectanglesTabPage.Controls.Add(this.centerLabel);
            this.rectanglesTabPage.Controls.Add(this.centerXLabel);
            this.rectanglesTabPage.Controls.Add(this.centerXTextBox);
            this.rectanglesTabPage.Controls.Add(this.centerYLabel);
            this.rectanglesTabPage.Controls.Add(this.centerYTextBox);
            this.rectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.rectanglesTabPage.Name = "rectanglesTabPage";
            this.rectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rectanglesTabPage.Size = new System.Drawing.Size(662, 353);
            this.rectanglesTabPage.TabIndex = 0;
            this.rectanglesTabPage.Text = "Rectangles";
            this.rectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesListBox
            // 
            this.rectanglesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.Location = new System.Drawing.Point(6, 6);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(180, 329);
            this.rectanglesListBox.TabIndex = 0;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(192, 20);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(43, 13);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Length:";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(260, 17);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(120, 20);
            this.lengthTextBox.TabIndex = 2;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(192, 60);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width:";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(260, 57);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(120, 20);
            this.widthTextBox.TabIndex = 4;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(192, 100);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(34, 13);
            this.colorLabel.TabIndex = 5;
            this.colorLabel.Text = "Color:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(260, 97);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(120, 20);
            this.colorTextBox.TabIndex = 6;
            // 
            // findRectangleButton
            // 
            this.findRectangleButton.Location = new System.Drawing.Point(260, 220);
            this.findRectangleButton.Name = "findRectangleButton";
            this.findRectangleButton.Size = new System.Drawing.Size(120, 30);
            this.findRectangleButton.TabIndex = 7;
            this.findRectangleButton.Text = "Find";
            this.findRectangleButton.UseVisualStyleBackColor = true;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(192, 140);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(260, 137);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(60, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // centerLabel
            // 
            this.centerLabel.AutoSize = true;
            this.centerLabel.Location = new System.Drawing.Point(192, 180);
            this.centerLabel.Name = "centerLabel";
            this.centerLabel.Size = new System.Drawing.Size(41, 13);
            this.centerLabel.TabIndex = 10;
            this.centerLabel.Text = "Center:";
            // 
            // centerXLabel
            // 
            this.centerXLabel.AutoSize = true;
            this.centerXLabel.Location = new System.Drawing.Point(240, 180);
            this.centerXLabel.Name = "centerXLabel";
            this.centerXLabel.Size = new System.Drawing.Size(17, 13);
            this.centerXLabel.TabIndex = 11;
            this.centerXLabel.Text = "X:";
            // 
            // centerXTextBox
            // 
            this.centerXTextBox.Location = new System.Drawing.Point(260, 177);
            this.centerXTextBox.Name = "centerXTextBox";
            this.centerXTextBox.Size = new System.Drawing.Size(60, 20);
            this.centerXTextBox.TabIndex = 12;
            // 
            // centerYLabel
            // 
            this.centerYLabel.AutoSize = true;
            this.centerYLabel.Location = new System.Drawing.Point(330, 180);
            this.centerYLabel.Name = "centerYLabel";
            this.centerYLabel.Size = new System.Drawing.Size(17, 13);
            this.centerYLabel.TabIndex = 13;
            this.centerYLabel.Text = "Y:";
            // 
            // centerYTextBox
            // 
            this.centerYTextBox.Location = new System.Drawing.Point(350, 177);
            this.centerYTextBox.Name = "centerYTextBox";
            this.centerYTextBox.Size = new System.Drawing.Size(60, 20);
            this.centerYTextBox.TabIndex = 14;
            // 
            // moviesTabPage
            // 
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
            this.moviesTabPage.Size = new System.Drawing.Size(662, 353);
            this.moviesTabPage.TabIndex = 1;
            this.moviesTabPage.Text = "Movies";
            this.moviesTabPage.UseVisualStyleBackColor = true;
            // 
            // moviesListBox
            // 
            this.moviesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.Location = new System.Drawing.Point(6, 6);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(180, 329);
            this.moviesListBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(192, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(260, 17);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(120, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(192, 60);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(50, 13);
            this.durationLabel.TabIndex = 3;
            this.durationLabel.Text = "Duration:";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(260, 57);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(120, 20);
            this.durationTextBox.TabIndex = 4;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(192, 100);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(260, 97);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(120, 20);
            this.yearTextBox.TabIndex = 6;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(192, 140);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Genre:";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(260, 137);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(120, 20);
            this.genreTextBox.TabIndex = 8;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(192, 180);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(41, 13);
            this.ratingLabel.TabIndex = 9;
            this.ratingLabel.Text = "Rating:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(260, 177);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(120, 20);
            this.ratingTextBox.TabIndex = 10;
            // 
            // findMovieButton
            // 
            this.findMovieButton.Location = new System.Drawing.Point(260, 220);
            this.findMovieButton.Name = "findMovieButton";
            this.findMovieButton.Size = new System.Drawing.Size(120, 30);
            this.findMovieButton.TabIndex = 11;
            this.findMovieButton.Text = "Find";
            this.findMovieButton.UseVisualStyleBackColor = true;
            // 
            // ringsTabPage
            // 
            this.ringsTabPage.Controls.Add(this.ringsListBox);
            this.ringsTabPage.Controls.Add(this.outerRadiusLabel);
            this.ringsTabPage.Controls.Add(this.outerRadiusTextBox);
            this.ringsTabPage.Controls.Add(this.innerRadiusLabel);
            this.ringsTabPage.Controls.Add(this.innerRadiusTextBox);
            this.ringsTabPage.Controls.Add(this.ringCenterLabel);
            this.ringsTabPage.Controls.Add(this.ringCenterXLabel);
            this.ringsTabPage.Controls.Add(this.ringCenterXTextBox);
            this.ringsTabPage.Controls.Add(this.ringCenterYLabel);
            this.ringsTabPage.Controls.Add(this.ringCenterYTextBox);
            this.ringsTabPage.Controls.Add(this.findRingButton);
            this.ringsTabPage.Controls.Add(this.ringIdLabel);
            this.ringsTabPage.Controls.Add(this.ringIdTextBox);
            this.ringsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ringsTabPage.Name = "ringsTabPage";
            this.ringsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ringsTabPage.Size = new System.Drawing.Size(662, 353);
            this.ringsTabPage.TabIndex = 2;
            this.ringsTabPage.Text = "Rings";
            this.ringsTabPage.UseVisualStyleBackColor = true;
            // 
            // ringsListBox
            // 
            this.ringsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ringsListBox.FormattingEnabled = true;
            this.ringsListBox.Location = new System.Drawing.Point(6, 6);
            this.ringsListBox.Name = "ringsListBox";
            this.ringsListBox.Size = new System.Drawing.Size(180, 329);
            this.ringsListBox.TabIndex = 0;
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
            // 
            // findRingButton
            // 
            this.findRingButton.Location = new System.Drawing.Point(270, 220);
            this.findRingButton.Name = "findRingButton";
            this.findRingButton.Size = new System.Drawing.Size(120, 30);
            this.findRingButton.TabIndex = 10;
            this.findRingButton.Text = "Find";
            this.findRingButton.UseVisualStyleBackColor = true;
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
            // collisionTabPage
            // 
            this.collisionTabPage.Controls.Add(this.ring1Label);
            this.collisionTabPage.Controls.Add(this.ring1ComboBox);
            this.collisionTabPage.Controls.Add(this.ring2Label);
            this.collisionTabPage.Controls.Add(this.ring2ComboBox);
            this.collisionTabPage.Controls.Add(this.rectangle1Label);
            this.collisionTabPage.Controls.Add(this.rectangle1ComboBox);
            this.collisionTabPage.Controls.Add(this.rectangle2Label);
            this.collisionTabPage.Controls.Add(this.rectangle2ComboBox);
            this.collisionTabPage.Controls.Add(this.checkCollisionButton);
            this.collisionTabPage.Controls.Add(this.collisionResultLabel);
            this.collisionTabPage.Location = new System.Drawing.Point(4, 22);
            this.collisionTabPage.Name = "collisionTabPage";
            this.collisionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.collisionTabPage.Size = new System.Drawing.Size(676, 385);
            this.collisionTabPage.TabIndex = 2;
            this.collisionTabPage.Text = "Collision";
            this.collisionTabPage.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "MainForm";
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
            this.ringsTabPage.ResumeLayout(false);
            this.ringsTabPage.PerformLayout();
            this.collisionTabPage.ResumeLayout(false);
            this.collisionTabPage.PerformLayout();
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
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label centerLabel;
        private System.Windows.Forms.Label centerXLabel;
        private System.Windows.Forms.TextBox centerXTextBox;
        private System.Windows.Forms.Label centerYLabel;
        private System.Windows.Forms.TextBox centerYTextBox;
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
        private System.Windows.Forms.TabPage ringsTabPage;
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
        private System.Windows.Forms.TabPage collisionTabPage;
        private System.Windows.Forms.Label rectangle1Label;
        private System.Windows.Forms.ComboBox rectangle1ComboBox;
        private System.Windows.Forms.Label rectangle2Label;
        private System.Windows.Forms.ComboBox rectangle2ComboBox;
        private System.Windows.Forms.Button checkCollisionButton;
        private System.Windows.Forms.Label collisionResultLabel;
        private System.Windows.Forms.Label ring1Label;
        private System.Windows.Forms.ComboBox ring1ComboBox;
        private System.Windows.Forms.Label ring2Label;
        private System.Windows.Forms.ComboBox ring2ComboBox;
    }
}