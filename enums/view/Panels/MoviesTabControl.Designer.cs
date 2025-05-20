namespace Programming.View.Controls
{
    partial class MoviesControl
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
            this.SuspendLayout();
            // 
            // moviesListBox
            // 
            this.moviesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.Location = new System.Drawing.Point(6, 6);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(180, 381);
            this.moviesListBox.TabIndex = 0;
            this.moviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
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
            this.durationTextBox.TextChanged += new System.EventHandler(this.MovieTextBox_TextChanged);
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
            this.yearTextBox.TextChanged += new System.EventHandler(this.MovieTextBox_TextChanged);
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
            this.ratingTextBox.TextChanged += new System.EventHandler(this.MovieTextBox_TextChanged);
            // 
            // findMovieButton
            // 
            this.findMovieButton.Location = new System.Drawing.Point(260, 220);
            this.findMovieButton.Name = "findMovieButton";
            this.findMovieButton.Size = new System.Drawing.Size(120, 30);
            this.findMovieButton.TabIndex = 11;
            this.findMovieButton.Text = "Find";
            this.findMovieButton.UseVisualStyleBackColor = true;
            this.findMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.findMovieButton);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.moviesListBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(762, 403);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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