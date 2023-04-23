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
                if(value >= 0)
                {
                    _flightTime = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящим числом"));
                }
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
