namespace Programming.Models.Classes
{
    public class Discipline
    {
        private int _numberOfhours;
        private int _scores;

        public string Title { get; set; }
        public int NumberOfHours
        {
            get { return _numberOfhours; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(NumberOfHours));
                _numberOfhours = value;
            }
        }

        public int Scores
        {
            get { return _scores; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Scores));
                _scores = value;
            }
        }

        public Discipline()
        {
        }

        public Discipline(string title, int number, int scores)
        {
            Title = title;
            NumberOfHours = number;
            Scores = scores;
        }
    }
}
