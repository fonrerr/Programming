using Contacts.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Метод связывающий поля в форме с Contact.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        private ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Индекс выбранного контакта.
        /// </summary>
        private int _indexSelectedContact;

        /// <summary>
        /// Команда добавления контакта.
        /// </summary>
        private IRelayCommand _addCommand;

        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        private IRelayCommand _editCommand;

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        private IRelayCommand _removeCommand;

        /// <summary>
        /// Команда применения изменений.
        /// </summary>
        private IRelayCommand _applyCommand;

        /// <summary>
        /// Переменная режима редактирования.
        /// </summary>
        private bool _isEditMode;

        /// <summary>
        /// Видимость кнопки.
        /// </summary>
        private Visibility _visibilityButton = Visibility.Hidden;

        /// <summary>
        /// Переменная состояния действия.
        /// </summary>
        private bool _actionStates;

        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set
            {
                _contacts = value;
                OnPropertyChanged(nameof(Contact));
            }
        }

        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));
                UpdateUI();

                if (IsEditMode)
                {
                    IsEditMode = false;
                    UpdateUI();
                }
            }
        }

        public bool IsEditMode
        {
            get => _isEditMode;
            set
            {
                _isEditMode = value;
                OnPropertyChanged(nameof(IsEditMode));
                UpdateUI();
            }
        }

        public Visibility Visibility
        {
            get => _visibilityButton;
            set
            {
                _visibilityButton = value;
                OnPropertyChanged(nameof(Visibility));
            }
        }

        public IRelayCommand AddCommand => _addCommand;
        public IRelayCommand EditCommand => _editCommand;
        public IRelayCommand RemoveCommand => _removeCommand;
        public IRelayCommand ApplyCommand => _applyCommand;

        private void AddExecute()
        {
            SelectedContact = new Contact();
            _indexSelectedContact = -1;
            IsEditMode = true;
            _actionStates = true;
        }

        private void EditExecute()
        {
            _indexSelectedContact = Contacts.IndexOf(SelectedContact);
            SelectedContact = new Contact()
            {
                Name = SelectedContact.Name,
                Email = SelectedContact.Email,
                PhoneNumber = SelectedContact.PhoneNumber
            };
            IsEditMode = true;
            _actionStates = false;
        }

        private void RemoveExecute()
        {
            Contacts.Remove(SelectedContact);
            SelectedContact = Contacts.FirstOrDefault();
        }

        private void ApplyExecute()
        {
            if (_actionStates)
            {
                Contacts.Add(SelectedContact);
                IsEditMode = false;
            }
            else
            {
                Contacts[_indexSelectedContact] = SelectedContact;
                IsEditMode = false;
            }
        }

        private bool CanAddExecute() => !IsEditMode;
        private bool CanEditOrRemoveExecute() => SelectedContact != null && !IsEditMode;

        private void UpdateUI()
        {
            AddCommand.NotifyCanExecuteChanged();
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
            if (IsEditMode)
            {
                Visibility = Visibility.Visible;
            }
            else
            {

                Visibility = Visibility.Hidden;
            }
        }

        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            _addCommand = new RelayCommand(AddExecute, CanAddExecute);
            _editCommand = new RelayCommand(EditExecute, CanEditOrRemoveExecute);
            _removeCommand = new RelayCommand(RemoveExecute, CanEditOrRemoveExecute);
            _applyCommand = new RelayCommand(ApplyExecute);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
