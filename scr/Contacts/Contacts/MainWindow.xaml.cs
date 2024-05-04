using Contacts.Model.Services;
using ViewModel;
using System;
using System.Windows;

namespace Contacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Экземпляр класса <see cref="MainVM">.
        /// </summary>
        private MainVM contactModel;

        /// <summary>
        /// Конструктор главного окна.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            contactModel = new MainVM() { Contacts = ContactSerializer.LoadFromFile()};
            DataContext = contactModel;
        }

        /// <summary>
        /// Обработчик события закрытия окна.
        /// Сохраняет контакты в файл.
        /// </summary>
        private void Window_Closed(object sender, EventArgs e)
        {
            ContactSerializer.SaveToFile(contactModel.Contacts);
        }
    }
}
