﻿namespace Programming.Models.Classes
{
    //TODO: Именование
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
                if (value > 0)
                {
                    Number_of_hours = value;
                }
                else
                {
                    throw new ArgumentException($"{Number_of_hours} не является подходящим числом");
                }
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
