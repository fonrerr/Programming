using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Contacts.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
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
