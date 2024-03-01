using Contacts.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private Contact _contact;
        private ICommand _saveCommand;
        private ICommand _loadCommand;

        public MainVM()
        {
            _contact = new Contact();
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
            get { return Name; }
            set
            {
                if (Name != value)
                {
                    Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string PhoneNumber
        {
            get { return PhoneNumber; }
            set
            {
                if (PhoneNumber != value)
                {
                    PhoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }
        }

        public string Email
        {
            get { return Email; }
            set
            {
                if (Email != value)
                {
                    Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
