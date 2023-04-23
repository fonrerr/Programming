namespace Programming.Models.Classes
{
    internal class Contact
    {
        private string Name { get; set; }
        private int _number;
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
    }
}
