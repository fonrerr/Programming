using System.Diagnostics;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item: ICloneable, IEquatable<Item>, IComparable<Item>
    {
        public event EventHandler<EventArgs> CostChanged;
        public event EventHandler<EventArgs> NameChanged;
        public event EventHandler<EventArgs> InfoChanged;
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

        public Category Category { get; set; }

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
                NameChanged?.Invoke(this, EventArgs.Empty);
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
                InfoChanged?.Invoke(this, EventArgs.Empty);
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
                ValueValidator.AssertStringOnLength(value, 0, 100000, nameof(Cost));
                _cost = value;
                CostChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <inheritdoc cref="ICloneable"/>
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        /// <inheritdoc cref="IEquatable{T}.Equals(T?)"/>
        public bool Equals(Item other)
        {
            if (other == null)
            {
                return false;
            }
            return this.Id == other.Id;
        }

        /// <inheritdoc cref="IComparable{T}.CompareTo(T?)"/>
        public int CompareTo(Item other)
        {
            if (other == null)
            {
                return 1;
            }
            return this.Cost.CompareTo(other.Cost);
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
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            _allItemsCount++;
            _id = AllItemsCount;
        }
    }
}
