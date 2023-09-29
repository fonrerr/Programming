namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Хранит значение количества покупателей.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Хранит значение идентификатора товара.
        /// </summary>
        private int _id;

        /// <summary>_
        /// Хранит значение названия товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит значение описания товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Хранит значение стоимости товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает идентификатор товара.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает количество товаров.
        /// </summary>
        public static int AllItemsCount { get { return _allItemsCount; } }

        /// <summary>
        /// Возвращает и задает имя товара.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertSimbols(value);
                ValueValidator.AssertStringOnLength(value, 1, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertSimbols(value);
                ValueValidator.AssertStringOnLength(value, 1, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1, 100000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса Item.
        /// </summary>
        public Item()
        {
            _allItemsCount++;
            _id = AllItemsCount;
        }

        /// <summary>
        /// Создает экземпляр класса Item.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _allItemsCount++;
            _id = AllItemsCount;
        }
    }
}
