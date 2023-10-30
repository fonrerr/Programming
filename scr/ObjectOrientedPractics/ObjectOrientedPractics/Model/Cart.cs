namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        /// <summary>
        /// Список объектов класса <see cref="Item">.
        /// </summary>
        private List<Item> _items;

        public double Amount 
        { 
            get
            {
                if (_items == null)
                {
                    return 0.0;
                }
                double cost = 0.0;
                for(int i = 0; i < _items.Count; i++)
                {
                    cost += _items[i].Cost;
                }
                return cost;
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

        public Cart(List<Item> items)
        {
            Items = items;
        }
    }
}
