using System;
using System.Text.RegularExpressions;

namespace Contacts.Model
{
    public class Contact
    {
        private string _name;
        private string _email;
        private string _phoneNumber;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!Regex.IsMatch(value, "/^[А-Я][а-яё]*$/"))
                {
                    throw new ArgumentException($"{value} Введено не корректно");
                }
                _name = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
                {
                    throw new ArgumentException($"{value} Введено не корректно");
                }
                _email = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (!Regex.IsMatch(value, @"^[+]\d{11}$") && value != null)
                {
                        throw new ArgumentException($"{value} Введено не корректно");
                }
                _phoneNumber = value;
            }
        }

        public Contact()
        {
        }

        public Contact(string name, string email, string phoneNumber)
        {
            _name = name;
            _email = email;
            _phoneNumber = phoneNumber;
        }
    }
}
