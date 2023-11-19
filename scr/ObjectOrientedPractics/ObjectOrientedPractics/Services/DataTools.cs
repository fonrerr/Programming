using ObjectOrientedPractics.Model;
namespace ObjectOrientedPractics.Services
{
    public class DataTools
    {
        /// <summary>
        /// Делегат для сортировки. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <returns>Список отсортированных товаров. </returns>
        public delegate List<Item> SortingDelegate(List<Item> items);

        /// <summary>
        /// Проверяет, совпадает ли выбранная категория с категорией проверяемого товара. 
        /// </summary>
        /// <param name="item">Товар. </param>
        /// <param name="category">Категория товара. </param>
        /// <returns>Булевое значение. </returns>
        public bool AssertCategory(Item item, object category)
        {
            return item.Category == (Category)category;
        }


        /// <summary>
        /// Проверяет, превышает ли цена товара указанную цену. 
        /// </summary>
        /// <param name="item">Товар. </param>
        /// <param name="price">Цена. </param>
        /// <returns>Булевое значение. </returns>
        public bool AssertPrice(Item item, object cost)
        {
            return item.Cost > (double)cost;
        }

        /// <summary>
        /// Фильтрует товары относительно заданного критерия. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <param name="filterCriteria">Критерий фильтрации. </param>
        /// <param name="obj">Параметр учитываемый в критерии. </param>
        /// <returns>Новый отфильтрованный список. </returns>
        public static List<Item> Filter(List<Item> items, Func<Item, object, bool> filterCriteria, object obj)
        {
            List<Item> newItems = new List<Item>();
            foreach (Item item in items)
            {
                if (filterCriteria(item, obj))
                {
                    newItems.Add(item);
                }
            }
            return newItems;
        }

        /// <summary>
        /// Сортирует список товаров по цене по возрастанию. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <returns>Отсортированный список. </returns>
        public static List<Item> SortCostAscending(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 1; j < items.Count; j++)
                {
                    if (items[j].Cost < items[j - 1].Cost)
                    {
                        Item temp = items[j];
                        items[j] = items[j - 1];
                        items[j - 1] = temp;
                    }
                }
            }
            return items;
        }

        /// <summary>
        /// Сортирует список товаров по цене по убыванию. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <returns>Отсортированный список товаров. </returns>
        public static List<Item> SortCostDescending(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 1; j < items.Count; j++)
                {
                    if (items[j].Cost > items[j - 1].Cost)
                    {
                        Item temp = items[j];
                        items[j] = items[j - 1];
                        items[j - 1] = temp;
                    }
                }
            }
            return items;
        }

        /// <summary>
        /// Сортирует список товаров по имени в алфавитном порядке. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <returns>Отсортированный список. </returns>
        public static List<Item> SortName(List<Item> items)
        {
            items.Sort((left, right) => left.Name.CompareTo(right.Name));
            return items;
        }

        /// <summary>
        /// Сортирует список товаров по указанному критерию. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <param name="sortingDelegate">Критерий сортировки. </param>
        /// <returns>Отсортированный список. </returns>
        public static List<Item> Sort(List<Item> items, SortingDelegate sortingDelegate)
        {
            return sortingDelegate(items);
        }
    }
    }
