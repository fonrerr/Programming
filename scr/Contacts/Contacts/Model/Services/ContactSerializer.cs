using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Model.Services
{
    public static class ContactSerializer
    {
        /// <summary>
        /// Название файла.
        /// </summary>
        private const string NameOfFile = @"\Serialize.json";

        /// <summary>
        /// Путь до паки AppData.
        /// </summary>
        private static string _path = Application.UserAppDataPath;

        /// <summary>
        /// Осуществляет запись данных в файл.
        /// </summary>
        /// <param name="contacts">Коллекция контактов.</param>
        public static void SaveToFile(Contact contacts)
        {
            using (StreamWriter writer = new StreamWriter(_path + NameOfFile))
            {
                writer.Write(JsonConvert.SerializeObject(contacts));
            }
        }

        /// <summary>
        /// Осуществляет выгрузку данных из файла.
        /// </summary>
        /// <returns>Возвращает коллецию контактов.</returns>
        public static List<Contact> LoadFromFile()
        {
            var contacts = new List<Contact>();
            try
            {
                using (StreamReader reader = new StreamReader(_path + NameOfFile))
                {
                    contacts = JsonConvert.DeserializeObject<List<Contact>>(reader.ReadToEnd());
                }

                if (contacts == null) contacts = new List<Contact>();
            }
            catch
            {
                return contacts;
            }
            return contacts;
        }
    }
}
