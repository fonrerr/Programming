﻿namespace Programming.Models.Classes
{
    public class Discipline
    {
        public string Title { get; set; }
        public int _numberOfhours;
        public int _scores;

        public int NumberOfHours
        {
            get { return _numberOfhours; }
            set
            {
                if (value > 0)
                {
                    _numberOfhours = value;
                }
                else
                {
                    throw new ArgumentException($"{NumberOfHours} не является подходящим числом");
                }
            }
        }

        public int Scores
        {
            get { return _scores; }
            set
            {
                if (value > 0)
                {
                    _scores = value;
                }
                else
                {
                    throw new ArgumentException($"{Scores} не является подходящим числом");
                }
               
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
