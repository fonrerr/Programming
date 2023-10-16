namespace ObjectOrientedPractics.Model
{
    internal class Store
    {
        /// <summary>
        /// Список объектов класса <see cref="Item">.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список объектов класса.
        /// </summary>
        private List<Customer> _customers;

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
        /// Возвращает и задает список объектов класса.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }

        }

        /// <summary>
        /// Создает экземпляр класса.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}
