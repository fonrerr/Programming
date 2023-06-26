namespace Programming.Models.View.Panels
{
    partial class MoviesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            FindMovieButton = new Button();
            label13 = new Label();
            label12 = new Label();
            RatingTextBox = new TextBox();
            GenreTextBox = new TextBox();
            YearTextBox = new TextBox();
            DurationTextBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            TitleTextBox = new TextBox();
            label9 = new Label();
            MovieListBox = new ListBox();
            SuspendLayout();
            // 
            // FindMovieButton
            // 
            FindMovieButton.Location = new Point(304, 427);
            FindMovieButton.Name = "FindMovieButton";
            FindMovieButton.Size = new Size(94, 29);
            FindMovieButton.TabIndex = 23;
            FindMovieButton.Text = "Find";
            FindMovieButton.UseVisualStyleBackColor = true;
            FindMovieButton.Click += FindMovieButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(262, 358);
            label13.Name = "label13";
            label13.Size = new Size(55, 20);
            label13.TabIndex = 22;
            label13.Text = "Rating:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(262, 289);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 21;
            label12.Text = "Genre:";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(262, 381);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(187, 27);
            RatingTextBox.TabIndex = 20;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(262, 312);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(187, 27);
            GenreTextBox.TabIndex = 19;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(262, 242);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(187, 27);
            YearTextBox.TabIndex = 18;
            YearTextBox.TextChanged += YearTextBox_TextChanged;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(262, 167);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(187, 27);
            DurationTextBox.TabIndex = 17;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(262, 212);
            label11.Name = "label11";
            label11.Size = new Size(113, 20);
            label11.TabIndex = 16;
            label11.Text = "Year_of_release:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(262, 144);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 15;
            label10.Text = "Duration:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(262, 95);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(187, 27);
            TitleTextBox.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(262, 72);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 13;
            label9.Text = "Title:";
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.ItemHeight = 20;
            MovieListBox.Items.AddRange(new object[] { "Movie1", "Movie2", "Movie3", "Movie4", "Movie5" });
            MovieListBox.Location = new Point(25, 72);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(211, 384);
            MovieListBox.TabIndex = 12;
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FindMovieButton);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(RatingTextBox);
            Controls.Add(GenreTextBox);
            Controls.Add(YearTextBox);
            Controls.Add(DurationTextBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(TitleTextBox);
            Controls.Add(label9);
            Controls.Add(MovieListBox);
            Name = "MoviesControl";
            Size = new Size(475, 528);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FindMovieButton;
        private Label label13;
        private Label label12;
        private TextBox RatingTextBox;
        private TextBox GenreTextBox;
        private TextBox YearTextBox;
        private TextBox DurationTextBox;
        private Label label11;
        private Label label10;
        private TextBox TitleTextBox;
        private Label label9;
        private ListBox MovieListBox;
    }
}
