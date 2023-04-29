namespace Programming.Models.Classes
{
    public class Contact
    {
        public string Name { get; set; }
        public int _number;
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Post { get; set; }

        public int Number
        {
            get { return _number; }
            set 
            {
                if (value.ToString().Length == 10)
                {
                    _number = value;
                }
                else
                {
                    throw new ArgumentException($"{Number} не является подходящим числом");
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
    }
}
