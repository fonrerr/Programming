using Contacts.Model.Services;
using Contacts.Model;
using System;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    public class SaveCommand : ICommand
    {
        public MainVM DataContext { get; set; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var name = DataContext.Name;
            var phoneNumber = DataContext.PhoneNumber;
            var email = DataContext.Email;
            var contacts = new Contact(name, phoneNumber, email);

            ContactSerializer.SaveToFile(contacts);
        }

        public SaveCommand(MainVM dataContext)
        {
            DataContext = dataContext;
        }
    }
}
