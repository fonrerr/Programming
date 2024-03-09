using Contacts.Model.Services;
using System;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    public class LoadCommand: ICommand
    {
        public MainVM DataContext { get; set; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var contact = ContactSerializer.LoadFromFile();
            DataContext.Name = contact.Name;
            DataContext.PhoneNumber = contact.PhoneNumber;
            DataContext.Email = contact.Email;
        }

        public LoadCommand(MainVM dataContext)
        {
            DataContext = dataContext;
        }
    }
}
