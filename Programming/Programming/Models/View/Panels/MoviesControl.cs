using Programming.Models.Classes;

namespace Programming.Models.View.Panels
{

    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса MoviesControl.
    /// </summary>
    public partial class MoviesControl : UserControl
    {

        //TODO: пустая строка перед комментарием
        /// <summary>
        /// Текущий выбранный фильм.
        /// </summary>
        private Movie _currentMovie = new Movie();

        /// <summary>
        /// Текущий фильм.
        /// </summary>
        private Movie[] _movie;

        /// <summary>
        /// Переменная для максимума.
        /// </summary>
        private int _max = 0;

        /// <summary>
        /// Создает экземпляр класса MoviesControl.
        /// </summary>
        public MoviesControl()
        {
            _movie = new Movie[5];
            InitializeComponent();
            InitMovies();
        }

        /// <summary>
        /// Заполнение массива фильмов.
        /// </summary>
        private void InitMovies()
        {
            var Movie = new[]
            {
                new Movie("Äðàêóëà", 320, 1999, "Óæàñû", 7),
                new Movie("Çîëóøêà", 170, 1989, "Ìóëüòôèëüì", 8),
                new Movie("Çåáðà", 620, 2013, "Íàó÷íûé", 5),
                new Movie("Àâàòàð2", 330, 2023, "Ôàíòàñòèêà", 9),
                new Movie("Ïèíîêèî", 120, 2013, "Ìóëüòôèëüì", 6)
            };
            _movie = Movie.ToArray();
            for (int j = 0; j < _movie.Length; j++)
            {
                MovieListBox.Items[j] = ($"Ôèëüì {j + 1}");
            }

            MovieListBox.SetSelected(0, true);
        }

        /// <summary>
        /// Выбор элемента в MovieListBox с последующим обновлением информации в TextBox.
        /// </summary>
        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie answr = _movie[MovieListBox.SelectedIndex];
            TitleTextBox.Text = answr.Title.ToString();
            DurationTextBox.Text = answr.Duration.ToString();
            YearTextBox.Text = answr.Year.ToString();
            GenreTextBox.Text = answr.Genre.ToString();
            RatingTextBox.Text = answr.Rating.ToString();
            _currentMovie = _movie[(int)MovieListBox.SelectedIndex];
        }

        /// <summary>
        /// Обработчик, который выбирает элемент с максимальным рейтингом.
        /// </summary>
        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            _max = 0;
            int index = 0;
            for (int i = 0; i < _movie.Length; i++)
            {
                if (_max < _movie[i].FindMovieWithMaxRating())
                {
                    _max = _movie[i].FindMovieWithMaxRating();
                    index = i;
                }
            }
            MessageBox.Show($"Ñàìûé ðåéòèíãîâûé ôèëüì ñ èíäåêñîì - {index}");
            MovieListBox.SetSelected(index, true);
        }

        /// <summary>
        /// Изменение данных в DurationTextBox.
        /// </summary>
        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DurationTextBox.Text != "" && YearTextBox.Text != "" && RatingTextBox.Text != "" && GenreTextBox.Text != "" && TitleTextBox.Text != "")
            {
                try
                {
                    DurationTextBox.BackColor = AppColors.NormalColor;
                    _currentMovie = new Models.Classes.Movie(
                        TitleTextBox.Text,
                        Convert.ToInt32(DurationTextBox.Text),
                        Convert.ToInt32(YearTextBox.Text),
                        GenreTextBox.Text,
                        Convert.ToInt32(RatingTextBox.Text));
                    _movie[(int)MovieListBox.SelectedIndex] = _currentMovie;
                }
                catch
                {
                    DurationTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        /// <summary>
        /// Изменение данных в YearTextBox.
        /// </summary>
        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DurationTextBox.Text != "" && YearTextBox.Text != "" && RatingTextBox.Text != "" && GenreTextBox.Text != "" && TitleTextBox.Text != "")
            {
                try
                {
                    YearTextBox.BackColor = AppColors.NormalColor;
                    _currentMovie = new Models.Classes.Movie(
                        TitleTextBox.Text,
                        Convert.ToInt32(DurationTextBox.Text),
                        Convert.ToInt32(YearTextBox.Text),
                        GenreTextBox.Text,
                        Convert.ToInt32(RatingTextBox.Text));
                    _movie[(int)MovieListBox.SelectedIndex] = _currentMovie;
                }
                catch
                {
                    YearTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        /// <summary>
        /// Изменение данных в GenreTextBox.
        /// </summary>
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DurationTextBox.Text != "" && YearTextBox.Text != "" && RatingTextBox.Text != "" && GenreTextBox.Text != "" && TitleTextBox.Text != "")
            {
                try
                {
                    GenreTextBox.BackColor = AppColors.NormalColor;
                    _currentMovie = new Models.Classes.Movie(
                        TitleTextBox.Text,
                        Convert.ToInt32(DurationTextBox.Text),
                        Convert.ToInt32(YearTextBox.Text),
                        GenreTextBox.Text,
                        Convert.ToInt32(RatingTextBox.Text));
                    _movie[(int)MovieListBox.SelectedIndex] = _currentMovie;
                }
                catch
                {
                    GenreTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        /// <summary>
        /// Изменение данных в RatingTextBox.
        /// </summary>
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DurationTextBox.Text != "" && YearTextBox.Text != "" && RatingTextBox.Text != "" && GenreTextBox.Text != "" && TitleTextBox.Text != "")
            {
                try
                {
                    RatingTextBox.BackColor = AppColors.NormalColor;
                    _currentMovie = new Models.Classes.Movie(
                        TitleTextBox.Text,
                        Convert.ToInt32(DurationTextBox.Text),
                        Convert.ToInt32(YearTextBox.Text),
                        GenreTextBox.Text,
                        Convert.ToInt32(RatingTextBox.Text));
                    _movie[(int)MovieListBox.SelectedIndex] = _currentMovie;
                }
                catch
                {
                    RatingTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }
    }
}
