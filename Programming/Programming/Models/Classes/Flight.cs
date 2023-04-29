namespace Programming.Models.Classes
{
    public class Flight
    {
        public string _departurePoint;
        public string _destination;
        public double _flightTime;

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
            _departurePoint = departurepoint;
            _destination = destination;
            _flightTime = time;
        }
    }
}
