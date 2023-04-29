namespace Programming.Models.Classes
{
    internal class Discipline
    {
        private string Title { get; set; }
        private int _numberOfhours;
        private int _scores;
        public int Number_of_hours
        {
            get { return _numberOfhours; }
            set
            {
                Validator.AssertOnPositiveValue(value);
            }
        }
        public int Scores
        {
            get { return _scores; }
            set
            {
                Validator.AssertOnPositiveValue(value);
            }
        }
        public Discipline()
        {
        }
        public Discipline(string title, int number, int scores)
        {
            Title = title;
            Number_of_hours = number;
            Scores = scores;
        }
    }
}
