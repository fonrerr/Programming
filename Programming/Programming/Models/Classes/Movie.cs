

namespace Programming.Models.Classes
{
    internal class Movie
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        private double _rating;
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
                    throw new ArgumentException(String.Format("{0} не является подходящим числом", _rating), "rating");
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
        public string[] answRec()
        {
            string[] answ = { Title, Duration.ToString(), Year.ToString(), Genre, Rating.ToString() };
            return answ;
        }
        public int FindMovieWithMaxRating()
        {

            return (int)Rating;
        }
    }
}
