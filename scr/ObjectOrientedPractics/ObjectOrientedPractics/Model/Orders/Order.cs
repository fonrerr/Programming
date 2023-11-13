namespace ObjectOrientedPractics.Model.Orders
{
    public class Order
    {
        /// <summary>
        /// Хранит значение количества заказов.
        /// </summary>
        private static int _allOrderCount;

        /// <summary>
        /// Хранит значение идентификатора.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает дату создания заказа. 
        /// </summary>
        public string Date { get; }

        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список объектов класса <see cref="Item">.
        /// </summary>
        private List<Item> _items;

        public Enums.OrderStatus OrderStatus { get; set; }

        // <summary>
        /// Возвращает идентификатор товара.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает количество покупателей.
        /// </summary>
        public static int AllOrderCount { get { return _allOrderCount; } }

        /// <summary>
        /// Возвращает общую стоимость товаров. 
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items == null)
                {
                    return 0.0;
                }
                double cost = 0.0;
                for (int i = 0; i < _items.Count; i++)
                {
                    cost += _items[i].Cost;
                }
                return cost;
            }

        }

        /// <summary>
        /// Возвращает и задает имя покупателя. 
        /// </summary>
        public string CustomerName { get; set; }

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

        /// <summary>
        /// Возвращает и задает список объектов класса.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задает размер скидки. 
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возвращает общую стоимость заказа с учетом скидки. 
        /// </summary>
        public double Total
        {
            get { return Amount - DiscountAmount; }
        }

        /// <summary>
        /// Создает объект класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            Address = new Address();
            Items = new List<Item>();
            OrderStatus = Enums.OrderStatus.New;
            Date = DateTime.Now.ToLongDateString();
            _allOrderCount++;
            _id = AllOrderCount;
        }

        /// <summary>
        /// Создает объект класса <see cref="Order"/>.
        /// </summary>
        /// <param name="customerName">Имя покупателя. </param>
        /// <param name="address">Адрес доставки. </param>
        /// <param name="items">Список товаров. </param>
        public Order(string customerName, Address address, List<Item> items)
        {
            CustomerName = customerName;
            Address = address;
            Items = items;
            OrderStatus = Enums.OrderStatus.New;
            Date = DateTime.Now.ToLongDateString();
            _allOrderCount++;
            _id = AllOrderCount;
        }
    }
}
