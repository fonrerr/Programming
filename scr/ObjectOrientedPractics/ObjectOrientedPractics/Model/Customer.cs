namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателях.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Хранит значение количества покупателей.
        /// </summary>
        private static int _allCustomersCount;

        /// <summary>
        /// Хранит значение идентификатора покупателя.
        /// </summary>
        private int _id;

        /// <summary>
        /// Хранит значение полного имени покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Хранит значение адреса покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает идентификатор товара.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает количество покупателей.
        /// </summary>
        public static int AllCustomersCount { get { return _allCustomersCount; } }

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 200, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса Customer.
        /// </summary>
        public Customer() 
        {
            _allCustomersCount++;
            _id = AllCustomersCount;
        }

        /// <summary>
        /// Создает экземпляр класса Customer.
        /// </summary>
        /// <param name="fullName">Полное имя покупателя.</param>
        /// <param name="address">Адрес покупателя.</param>
        public Customer(string fullName, string address)
        {
            FullName = fullName;
            Address = address;
            _allCustomersCount++;
            _id = AllCustomersCount;
        }
    }
}
