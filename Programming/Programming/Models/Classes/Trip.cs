namespace Programming.Models.Classes
{
    internal class Trip
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTime;

        public int Flight_Time
        {
            get { return _flightTime; }
            set
            {
                Validator.AssertOnPositiveValue(value);
            }
        }

        public Trip()
        {
        } 
        public Trip(string dp, string ds, int time)
        {
            _departurePoint = dp;
            _destination = ds;
            _flightTime = time;
        }
    }
}
