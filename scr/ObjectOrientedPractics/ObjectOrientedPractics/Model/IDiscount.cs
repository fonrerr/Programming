using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию о скидке. 
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Считает размер скидки. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <returns>Размер скидки. </returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <returns>Размер скидки. </returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет размер скидки. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        void Update(List<Item> items);
    }
}
