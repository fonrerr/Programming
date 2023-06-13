using System;

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
        /// Ссылка на соц.сеть
        /// </summary>
        private string _url;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _dateOfBirth;

        private string _number;

        /// <summary>
        /// Создает экземпляр класса Contact.
        /// </summary>
        public Contact()
        {
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

        ///<summary>
        ///Возвращает и задает ссылку для ВК.
        ///</summary>
        public string Url
        {
            get { return _url; }
            set
            {
                if(value != null)
                {
                    Validator.AssertLink(value);
                    Validator.AssertCountSymbolsInRange(value, 0, 150, nameof(Url));
                }
                _url = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона человека.
        /// </summary>
        public string Number
        {
            get { return _number; }
            set
            {
                if (value != null)
                {
                    Validator.AssertStringContainsOnlyNumbers(value, nameof(Number));
                    Validator.AssertCountSymbolsInRange(value, 0, 150, nameof(Number));
                }
                _number = value;
            }
        }
    }
}
