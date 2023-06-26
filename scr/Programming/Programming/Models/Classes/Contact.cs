using System.Text.RegularExpressions;

namespace Programming.Models.Classes
{
    /// <summary>
    /// Хранит данные о человеке и его контактных данных.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Хранит значение номера телефона.
        /// </summary>
        private string _number;

        /// <summary>
        /// Хранит значение фамилии человека.
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Хранит значение имени человека.
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Возвращает и задает номер телефона человека.
        /// </summary>
        public string Number
        {
            get { return _number; }
            set 
            {
                AssertStringContainsOnlyNumbers(value, nameof(Number));
                _number = value;
            }
        }

        /// <summary>
        /// Возвращает и задает имя человека.
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(FirstName));
                _firstName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию человека.
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(LastName));
                _lastName = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса Contact.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Создает экземпляр класса Contact. 
        /// </summary>
        /// <param name="firstName">Имя. Должно состоять только из
        /// букв.</param>
        /// <param name="lastName">Фамилия. Должна состоять только из
        /// букв.</param>
        /// <param name="number">Номер телефона.</param>
        public Contact(string firstName, string number, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        /// <summary>
        /// Проверяет, что строка состоит из букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="name">Имя свойства, которая подлежит проверки.</param>
        private void AssertStringContainsOnlyLetters(string value, string name)
        {
            if (!Regex.IsMatch(value, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException($"{name}: {value}. Введено не корректно");
            }
        }

        /// <summary>
        /// Проверяет, что строка состоит из цифр.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="name">Имя свойства, которая подлежит проверки.</param>
        private void AssertStringContainsOnlyNumbers(string value, string name)
        {
            if(!Regex.IsMatch(value, @"^[+]\d{11}$"))
            {
                throw new ArgumentException($"{name}: {value}. Введено не корректно");
            }
        }
    }
}
