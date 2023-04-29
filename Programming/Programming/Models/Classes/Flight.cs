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
                if(value > 0.0)
                {
                    _flightTime = value;
                }
                else
                {
                    throw new ArgumentException($"{FlightTime} не является подходящим числом");
                }
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
