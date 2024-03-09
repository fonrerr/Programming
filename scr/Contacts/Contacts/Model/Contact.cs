namespace Contacts.Model
{
    /// <summary>
    /// Хранит данные о контактах.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// ФИО контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Почта контакта.
        /// </summary>
        public string Email { get; set; }

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
    }
}
