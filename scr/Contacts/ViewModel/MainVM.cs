using Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Input;

namespace ViewModel
{
    /// <summary>
    /// Метод связывающий поля в форме с Contact.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Сообщение об ошибке.
        /// </summary>
        private string _error;

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
        private bool _visibilityButton = false;

        /// <summary>
        /// Переменная состояния действия.
        /// </summary>
        private bool _actionStates;

        /// <summary>
        /// Возвращает сообщение об ошибке.
        /// </summary>
        public string Error
        {
            get => _error;
        }

        /// <summary>
        /// Возвращает и задает коллекцию контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
            set
            {
                _contacts = value;
                OnPropertyChanged(nameof(Contact));
            }
        }

        /// <summary>
        /// Возвращает и задает выбранный контакт.
        /// </summary>
        public Contact SelectedContact
        {
            get
            {
                return _selectedContact;
            }
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

        /// <summary>
        /// Возвращает и задает режим редактирования.
        /// </summary>
        public bool IsEditMode
        {
            get
            {
                return _isEditMode;
            }
            set
            {
                _isEditMode = value;
                OnPropertyChanged(nameof(IsEditMode));
                UpdateUI();
            }
        }

        /// <summary>
        /// Возвращает и задает видимость.
        /// </summary>
        public bool Visibility
        {
            get
            {
                return _visibilityButton;
            }
            set
            {
                _visibilityButton = value;
                OnPropertyChanged(nameof(Visibility));
            }
        }

        /// <summary>
        /// Возвращает команду добавления.
        /// </summary>
        public IRelayCommand AddCommand
        {
            get
            {
                return _addCommand;
            }
        }

        /// <summary>
        /// Возвращает команду редактирования.
        /// </summary>
        public IRelayCommand EditCommand
        {
            get
            {
                return _editCommand;
            }
        }

        /// <summary>
        /// Возвращает команду удаления.
        /// </summary>
        public IRelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand;
            }
        }

        /// <summary>
        /// Возвращает команду применения изменений.
        /// </summary>
        public IRelayCommand ApplyCommand
        {
            get
            {
                return _applyCommand;
            }
        }

        /// <summary>
        /// Выполняет действие добавления нового контакта.
        /// </summary>
        private void AddExecute()
        {
            SelectedContact = new Contact();
            _indexSelectedContact = -1;
            IsEditMode = true;
            _actionStates = true;
            UpdateUI();
        }

        /// <summary>
        /// Выполняет действие редактирования контакта.
        /// </summary>
        private void EditExecute()
        {
            _indexSelectedContact = Contacts.IndexOf(SelectedContact);
            SelectedContact = new Contact()
            {
                Name = SelectedContact.Name,
                PhoneNumber = SelectedContact.PhoneNumber,
                Email = SelectedContact.Email
            };
            IsEditMode = true;
            _actionStates = false;
        }

        /// <summary>
        /// Выполняет действие удаления контакта.
        /// </summary>
        private void RemoveExecute()
        {
            Contacts.Remove(SelectedContact);
            SelectedContact = Contacts.FirstOrDefault();
        }

        /// <summary>
        /// Выполняет действие применения изменений.
        /// </summary>
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

        /// <summary>
        /// Определяет, может ли быть выполнено действие добавления контакта.
        /// </summary>
        private bool CanAddExecute()
        {
            return !IsEditMode;
        }

        private bool CanApplyExecute()
        {
            return SelectedContact != null && SelectedContact.Error == "";
        }

        /// <summary>
        /// Определяет, может ли быть выполнено действие редактирования или удаления контакта.
        /// </summary>
        private bool CanEditOrRemoveExecute()
        {
            return SelectedContact != null && !IsEditMode;
        }

        /// <summary>
        /// Обновляет интерфейс пользователя.
        /// </summary>
        private void UpdateUI()
        {
            AddCommand.NotifyCanExecuteChanged();
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
            ApplyCommand.NotifyCanExecuteChanged();
            if (IsEditMode && CanApplyExecute())
            {
                Visibility = true;
            }
            else
            {

                Visibility = false;
            }
        }

        /// <summary>
        /// Создает экземпляр класса MainVM.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            _addCommand = new RelayCommand(AddExecute, CanAddExecute);
            _editCommand = new RelayCommand(EditExecute, CanEditOrRemoveExecute);
            _removeCommand = new RelayCommand(RemoveExecute, CanEditOrRemoveExecute);
            _applyCommand = new RelayCommand(ApplyExecute);
        }


        /// <summary>
        /// Событие изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Вызывает событие изменения свойства.
        /// </summary>
        /// <param name="prop">Имя измененного свойства.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
