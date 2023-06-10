using System;
using System.Text.RegularExpressions;

namespace ContactList.Model
{
    /// <summary>
    /// Хранит данные о контактах.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Максимальная длина строки.
        /// </summary>
        private const int MaxLengthOfString = 150;

        /// <summary>
        /// Минимальная длина строки.
        /// </summary>
        private const int MinLengthOfString = 0;

        /// <summary>
        /// ФИО контакта.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// Уникальный идентификатор контакта.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Общее количество контактов.
        /// </summary>
        private static int _allContactCount;

        /// <summary>
        /// Создает экземпляр класса Contact.
        /// </summary>
        public Contact()
        {
            _allContactCount++;
            _id = _allContactCount;
        }
        
        /// <summary>
        /// Создает экземпляр класса Contact.
        /// </summary>
        /// <param name="fullName">ФИО контакта.</param>
        /// <param name="dateOfBirth">Дата рождения.</param>
        /// <param name="number">Номер телефона.</param>
        /// <param name="url">Ссылка на социальные сети (ВК).</param>
        public Contact(string fullName, DateTime dateOfBirth,  string number, string url)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Number = number;
            Url = url;
            _allContactCount++;
            _id = _allContactCount;
        }

        //TODO: неиспользуемые свойства
        /// <summary>
        /// Возвращает уникальный идентификатор контакта.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает общее количество контактов.
        /// </summary>
        public static int AllContactCount
        {
            get
            {
                return _allContactCount;
            }
        }

        /// <summary>
        /// Возвращает и задает ФИО контакта.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (!Regex.IsMatch(value, "^[^A-Za-z0-9!@#$%^&]*$"))
                {
                    throw new ArgumentException($"{value}. Введено не корректно");
                }
                Validator.AssertCountSymbolsInRange(value, MinLengthOfString, MaxLengthOfString, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает дату рождения контакта.
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            {
                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Возвращает и задает ссылку на социальные сети (ВК).
        /// </summary>
        public string Url { get; set; }
    }
}
