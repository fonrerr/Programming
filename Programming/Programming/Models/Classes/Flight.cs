namespace Programming.Models.Classes
{

    /// <summary>
    /// Хранит данные о полете.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Хранит значение времени полета.
        /// </summary>
        private double _flightTime;

        /// <summary>
        /// Возвращает и задает место отправления.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задает место назначения.
        /// </summary>>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает время полета. Должно быть больше нуля.
        /// </summary>
        public double FlightTime
        {
            get { return _flightTime; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTime));
                _flightTime = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса Flight.
        /// </summary>
        public Flight()
        {
        }

        /// <summary>
        /// Создает экземпляр класса Flight.
        /// </summary>
        /// <param name="departurePoint">Место отправления.</param>
        /// <param name="destination">Место назначения.</param>
        /// <param name="time">Время полета. Должно быть больше нуля.</param>
        public Flight(string departurePoint, string destination, int time)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            _flightTime = time;
        }
    }
}
