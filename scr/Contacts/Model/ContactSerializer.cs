using System;
using System.Collections.ObjectModel;
using System.IO;
using Model;
using Newtonsoft.Json;

namespace Contacts.Model.Services
{
    public static class ContactSerializer
    {
        /// <summary>
        /// Название файла.
        /// </summary>
        private const string NameOfFile = @"\Contacts.json";

        /// <summary>
        /// Путь до файла.
        /// </summary>
        private static string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "Сontacts.json");

        /// <summary>
        /// Осуществляет запись данных в файл.
        /// </summary>
        /// <param name="contacts">Коллекция контактов.</param>
        public static void SaveToFile(ObservableCollection<Contact> contacts)
        {
            using (StreamWriter writer = new StreamWriter(_path))
            {
                writer.Write(JsonConvert.SerializeObject(contacts));
            }
        }

        /// <summary>
        /// Осуществляет выгрузку данных из файла.
        /// </summary>
        /// <returns>Возвращает коллецию контактов.</returns>
        public static ObservableCollection<Contact> LoadFromFile()
        {
            var contacts = new ObservableCollection<Contact>();
            try
            {
                using (StreamReader reader = new StreamReader(_path))
                {
                    contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(reader.ReadToEnd());
                }

                if (contacts == null) contacts = new ObservableCollection<Contact>();
            }
            catch
            {
                return contacts;
            }
            return contacts;
        }
    }
}
