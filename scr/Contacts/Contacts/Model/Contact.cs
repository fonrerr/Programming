using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Contacts.Model
{
    /// <summary>
    /// Хранит данные о контактах.
    /// </summary>
    public class Contact: INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// Сообщение об ошибке.
        /// </summary>
        private string _error;

        /// <summary>
        /// ФИО контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Почта контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Видимость кнопки.
        /// </summary>
        private bool _visibility = false;

        /// <summary>
        /// Возвращает сообщение об ошибке.
        /// </summary>
        public string Error
        {
            get => _error;
        }

        /// <summary>
        /// Проверяет значение на наличие ошибок.
        /// </summary>
        /// <param name="columnName">Имя свойства значения, которое нужно проверить.</param>
        /// <returns>Возвращает сообщение об ошибке.</returns>
        public string this[string columnName]
        {
            get
            {
                _error = System.String.Empty;
                switch(columnName) 
                {
                    case "Name":
                        if (Name != null) 
                        {
                            if(Name.Length > 100) 
                            {
                                _error = "Length of name should be less 100 symbols";
                            }
                        }
                        break;
                    case "PhoneNumber":
                        if (PhoneNumber != null) 
                        {
                            if (PhoneNumber.Length > 100) 
                            {
                                _error = "Length of phone number should be less 100 symbols";
                            }
                            for(int i = 0; i < PhoneNumber.Length; i++) 
                            {
                                if (PhoneNumber[i] != '+' && PhoneNumber[i] != '-' && PhoneNumber[i] != '(' &&
                                    PhoneNumber[i] != ')' && PhoneNumber[i] != ' ' && !(PhoneNumber[i] >= '0' && PhoneNumber[i] <= '9'))
                                {
                                    _error = "Phone number can contains only numbers and symbols '+()-'";
                                }
                            }
                        }
                        break;
                    case "Email":
                        if (Email != null)
                        {
                            if (Email.Length > 100)
                            {
                                _error = "Length of email should be less 100 symbols";
                            }
                            if(!Email.Contains("@"))
                            {
                                _error = "Email should contains symbol '@'";
                            }
                        }
                        break;
                        
                }
                if (_error != System.String.Empty)
                {
                    Visibility = false;
                }
                else
                {
                    Visibility = true;
                }
                return _error;
            }
        }

        /// <summary>
        /// Возвращает и задает видимость.
        /// </summary>
        public bool Visibility
        {
            get
            {
                return _visibility;
            }
            set
            {
                _visibility = value;
                OnPropertyChanged(nameof(Visibility));
            }
        }

        /// <summary>
        /// Возвращает и задает ФИО контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        public string PhoneNumber 
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает почту контакта.
        /// </summary>
        public string Email 
        {
            get
            {
                return _email;
            }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
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
        /// <param name="name">ФИО контакта.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Почта контакта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Вызывается при изменении значения свойства.
        /// </summary>
        /// <param name="propertyName">Имя измененного свойства.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
