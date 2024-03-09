using Contacts.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private Contact _contacts;
        private ICommand _saveCommand;
        private ICommand _loadCommand;

        public MainVM()
        {
            _contacts = new Contact();
            _saveCommand = new SaveCommand(this);
            _loadCommand = new LoadCommand(this);
        }

        public ICommand SaveCommand
        {
            get { return _saveCommand; }
        }

        public ICommand LoadCommand
        { 
            get { return _loadCommand; } 
        }

        public string Name
        {
            get { return _contacts.Name; }
            set
            {
                if (_contacts.Name != value)
                {
                    _contacts.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string PhoneNumber
        {
            get { return _contacts.PhoneNumber; }
            set
            {
                if (_contacts.PhoneNumber != value)
                {
                    _contacts.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        public string Email
        {
            get { return _contacts.Email; }
            set
            {
                if (_contacts.Email != value)
                {
                    _contacts.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
