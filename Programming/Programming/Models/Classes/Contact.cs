namespace Programming.Models.Classes
{
    //TOOD: Класс публичным 
    //TODO: Сначала поля, потом свойства. Разделять пустой строкой
    internal class Contact
    {
       //TODO: Свойства публичные
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
                    //TODO: присвоение в поле
                    Number = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("{0} не является подходящим числом", _number),
                                       nameof(Number));
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
