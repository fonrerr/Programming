namespace Programming.Models.Classes
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get { return _hours; }
            set
            {
                Validator.AssertValueInRange(value, nameof(Hours), 0, 23);
                _hours = value;
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                //TODO: 59 sec
                Validator.AssertValueInRange(value, nameof(Minutes), 0, 60);
                _minutes = value;
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                Validator.AssertValueInRange(value, nameof(Seconds), 0, 60);
                _seconds = value;
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
