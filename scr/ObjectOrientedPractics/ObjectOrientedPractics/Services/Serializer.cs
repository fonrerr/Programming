using Newtonsoft.Json;
using Customer = ObjectOrientedPractics.Model.Customer;
using Item = ObjectOrientedPractics.Model.Item;


namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит методы по серилизации данных
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Название файла.
        /// </summary>
        private const string NameOfFile = @"\Serialize.json";

        /// <summary>
        /// Путь до папки AppData.
        /// </summary>
        private static string _path = Application.UserAppDataPath;

        /// <summary>
        /// Осуществляет запись данных в файл.
        /// </summary>
        /// <param name="items">Коллекция товаров.</param>
        public static void SaveFromFile(List<Item> items)
        {
            using (StreamWriter writer = new StreamWriter(_path + NameOfFile))
            {
                writer.Write(JsonConvert.SerializeObject(items));
            }
        }

        /// <summary>
        /// Осуществляет выгрузку данных из файла.
        /// </summary>
        /// <returns>Возвращает коллецию товаров.</returns>
        public static List<Item> LoadFromFile()
        {
            var items = new List<Item>();
            try
            {
                using (StreamReader reader = new StreamReader(_path + NameOfFile))
                {
                    items = JsonConvert.DeserializeObject<List<Item>>(reader.ReadToEnd());
                }

                if (items == null) items = new List<Item>();
            }
            catch
            {
                return items;
            }
            return items;
        }

        /// <summary>
        /// Осуществляет запись данных в файл.
        /// </summary>
        /// <param name="customers">Коллекция покупателей.</param>
        public static void SaveFromFile(List<Customer> customers)
        {
            using (StreamWriter writer = new StreamWriter(_path + NameOfFile))
            {
                writer.Write(JsonConvert.SerializeObject(customers));
            }
        }

        /// <summary>
        /// Осуществляет выгрузку данных из файла.
        /// </summary>
        /// <returns>Возвращает коллецию покупателей.</returns>
        public static List<Customer> LoadingFromFile()
        {
            var customers = new List<Customer>();
            try
            {
                using (StreamReader reader = new StreamReader(_path + NameOfFile))
                {
                    customers = JsonConvert.DeserializeObject<List<Customer>>(reader.ReadToEnd());
                }

                if (customers == null) customers = new List<Customer>();
            }
            catch
            {
                return customers;
            }
            return customers;
        }
    }
}
