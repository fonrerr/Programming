namespace Programming.Models.Classes
{
    public class Flight
    {
        private double _flightTime;

        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public double FlightTime
        {
            get { return _flightTime; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTime));
                _flightTime = value;
            }
        }

        public Flight()
        {
        } 

        public Flight(string departurepoint, string destination, int time)
        {
            DeparturePoint = departurepoint;
            Destination = destination;
            _flightTime = time;
        }
    }
}
