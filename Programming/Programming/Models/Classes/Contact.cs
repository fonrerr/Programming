using System.Text.RegularExpressions;

namespace Programming.Models.Classes
{
    public class Contact
    {
        private string _number;
        private string _lastName;
        private string _firstName;

        //TODO: в string
        public string Number
        {
            get { return _number; }
            set 
            {
                AssertStringContainsOnlyNumbers(value, nameof(Number));
                _number = value;
            }
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(FirstName));
                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(LastName));
                _lastName = value;
            }
        }

        public Contact()
        {
        }

        public Contact(string firstName, string number, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }
        private void AssertStringContainsOnlyLetters(string value, string name)
        {
            if (!Regex.IsMatch(value, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException($"{name}: {value}. Введено не корректно");
            }
        }

        private void AssertStringContainsOnlyNumbers(string value, string name)
        {
            if(!Regex.IsMatch(value, @"^[+]\d{11}$"))
            {
                throw new ArgumentException($"{name}: {value}. Введено не корректно");
            }
        }
    }
}
