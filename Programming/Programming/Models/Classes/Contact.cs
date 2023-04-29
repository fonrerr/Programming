namespace Programming.Models.Classes
{
    internal class Contact
    {
        private string Name { get; set; }
        private int _number;
        private string Surname { get; set; }
        private string Address { get; set; }
        private string Post { get; set; }
        public int Number
        {
            get { return _number; }
            set 
            {
                if (value.ToString().Length == 10)
                {

                    Number = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящим числом", _number),
                                        "number");
                }
            }
        }
        public Contact()
        {
        }
        public Contact(string name, int number, string adress, string post)
        {
            Name = name;
            Address = adress;
            Post = post;
            Number = number;
        }
        private void AssertStringContainsOnlyLetters(string name, string surname)
        {
            for (int i = 0; i < name.Length; ++i)
            {
                if (char.IsLetter(name[i]))
                {
                    Name = name;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящей строкой", name),
                                   "name");
                }
            }
            for (int i = 0; i < surname.Length; ++i)
            {
                if (char.IsLetter(surname[i]))
                {
                    Surname = surname;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящей строкой", surname),
                                   "surname");
                }
            }


        }
    }
}
