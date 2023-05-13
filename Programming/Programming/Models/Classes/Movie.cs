namespace Programming.Models.Classes
{
    public class Movie
    {
        private double _duration;
        private int _year;
        private double _rating;

        public string Title { get; set; }
        public string Genre { get; set; }
        public double Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(value, nameof(Rating), 0, 10);
                _rating = value; 
            }
        }

        public double Duration
        {
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                Validator.AssertValueInRange(value, nameof(Year), 1980, 2023);
                _year = value;
            }
        }

        public Movie(string title, int duration, int year, string genre, double rating)
        {
            Title = title;
            Duration = duration;
            Year = year;
            Rating = rating;
            Genre = genre;
        }

        public Movie() 
        {
        }
        public string[] GetMovie()
        {
            string[] mov = { Title, Duration.ToString(), Year.ToString(), Genre, Rating.ToString() };
            return mov;
        }
        public int FindMovieWithMaxRating()
        {
            return (int)Rating;
        }
    }
}
