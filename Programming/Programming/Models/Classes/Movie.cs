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
                if (value > 0.0 && value <= 10.0)
                {
                    _rating = value;
                }
                else
                {
                    throw new ArgumentException($"{Rating} не является подходящим числом");
                }
            }
        }

        public double Duration
        {
            get { return _duration; }
            set
            {
                if (value > 0.0)
                {
                    _duration = value;
                }
                else
                {
                    throw new ArgumentException($"{Duration} не является подходящим числом");
                }
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if(value > 0 && value <= 2023)
                {
                    _year = value;
                }
                else
                {
                    throw new ArgumentException($"{Year} не является подходящим числом");
                }
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
