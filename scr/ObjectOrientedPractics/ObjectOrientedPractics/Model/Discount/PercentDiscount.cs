using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discount
{
    public class PercentDiscount: IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Процент. 
        /// </summary>
        private int _percent = 1;

        /// <summary>
        /// Возвращает и задает сумму скидки. 
        /// </summary>
        public double Total { get; private set; }

        /// <summary>
        /// Возвращает и задает список товаров. 
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задает категорию товара. 
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает процент скидки. Должен быть больше 0. 
        /// </summary>
        public int Percent
        {
            get
            {
                return _percent;
            }
            private set
            {
                if (value >= 1)
                {
                    _percent = value;
                }
            }
        }

        /// <summary>
        /// Возвращает информацию о скидке. 
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная {Category} - {Percent}% ";
            }
        }

        /// <summary>
        /// Считает размер скидки. 
        /// </summary>
        /// <param name="items">Список товаров, к которым применяется скидка. </param>
        /// <returns>Размер скидки. </returns>
        public double Calculate(List<Item> items)
        {
            Total = 0;
            double discountAmount = 0;
            if (items.Count == 0 || items == null) return 0;
            int counter = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == Category)
                {
                    counter++;
                    Total += items[i].Cost;
                    discountAmount += items[i].Cost * Percent / 100;
                }
            }
            if (counter == 0) return 0;
            else
            {
                return discountAmount;
            }
        }

        /// <summary>
        /// Применяет скидку. 
        /// </summary>
        /// <param name="items">Список товаров, к которым применяется скидка. </param>
        /// <returns>Размер скидки. </returns>
        public double Apply(List<Item> items)
        {
            Total = 0;
            if (items.Count == 0 || items == null) return Percent;
            int counter = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == Category)
                {
                    counter++;
                    items[i].Cost -= items[i].Cost / 100 * Percent;
                    Total += items[i].Cost;
                }
            }
            if (counter == 0) return Percent;
            return Percent;

        }

        /// <summary>
        /// Обновляет скидку. 
        /// </summary>
        /// <param name="items"></param>
        public void Update(List<Item> items)
        {
            if (Total > 1000 && Percent < 10)
            {
                Percent += 1;
            }
        }

        /// <inheritdoc cref="IComparable{T}.CompareTo(T?)"/>
        public int CompareTo(PercentDiscount other)
        {
            if (other == null)
            {
                return 1;
            }
            return this.Percent.CompareTo(other.Percent);
        }
    }
}
