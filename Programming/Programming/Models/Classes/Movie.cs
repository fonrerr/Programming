namespace Programming.Models.Classes
{

    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {

        /// <summary>
        /// Хранит значение продолжительности фильма.
        /// </summary>
        private double _duration;

        /// <summary>
        /// Хранит значение года выпуска фильма.
        /// </summary>
        private int _year;

        /// <summary>
        /// Хранит значение рейтинга фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает рейтинг фильма.Должен быть в диапазоне от 0 до 10.
        /// </summary>
        public double Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(value, nameof(Rating), 0, 10);
                _rating = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает продолжительность фильма в минутах. Должна быть больше нуля.
        /// </summary>
        public double Duration
        {
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выпуска фильма в диапазоне от 1980 до 2023 года. .
        /// </summary>
        public int Year
        {
            get { return _year; }
            set
            {
                Validator.AssertValueInRange(value, nameof(Year), 1980, 2023);
                _year = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса Film.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="duration">Продолжительность фильма. Должна быть больше нуля.</param>
        /// <param name="year">Год выхода. Должен быть в диапазоне от 1980 до 2023.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть в диапазоне от 0 до 10.</param>
        public Movie(string title, int duration, int year, string genre, double rating)
        {
            Title = title;
            Duration = duration;
            Year = year;
            Rating = rating;
            Genre = genre;
        }

        /// <summary>
        /// Создает экземпляр класса Film.
        /// </summary>
        public Movie() 
        {
        }

        /// <summary>
        /// Возвращает индекс фильма с самым большим рейтингом. 
        /// </summary>
        /// <returns>Индекс.</returns>
        public int FindMovieWithMaxRating()
        {
            return (int)Rating;
        }
    }
}
