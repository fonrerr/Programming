using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Discount;

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
        private Address _address;

        private Cart _cart;

        /// <summary>
        /// Возвращает идентификатор товара.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает количество покупателей.
        /// </summary>
        public static int AllCustomersCount { get { return _allCustomersCount; } }

        /// <summary>
        /// Возвращает и задает список заказов. 
        /// </summary>
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Возвращает и задает список скидок. 
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

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
                ValueValidator.AssertSimbols(value);
                ValueValidator.AssertStringOnLength(value, 1, 200, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set 
            {
                _cart = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает являет ли покупатель приоритетным. 
        /// </summary>
        public bool IsPriority { get; set; }

        public Customer()
        {
        }
        /// <summary>
        /// Создает экземпляр класса Customer.
        /// </summary>
        /// <param name="fullName">Полное имя покупателя.</param>
        public Customer(string fullName)
        {
            FullName = fullName;
            Address = new Address(606060, "Country", "City", "Street", "00", "00");
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = false;
            Discounts = new List<IDiscount>() { new PointsDiscount() };
            _allCustomersCount++;
            _id = AllCustomersCount;
        }
    }
}
