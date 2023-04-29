namespace Programming.Models.Classes
{
    public class Time
    {
        public int _hours;
        public int _minutes;
        public int _seconds;

        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    _hours = value;
                }
                else
                {
                    throw new ArgumentException($"{Hours} не является подходящим числом");
                }
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    _minutes = value;
                }
                else
                {
                    throw new ArgumentException($"{Minutes} не является подходящим числом");
                }
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    _seconds = value;
                }
                else
                {
                    throw new ArgumentException($"{Seconds} не является подходящим числом");
                }
            }
        }

        public Time()
        {
        } 

        public Time(int hours, int minutes, int seconds)
        {
            Seconds = seconds;  
            Hours = hours;
            Minutes = minutes;
        }
    }
}
