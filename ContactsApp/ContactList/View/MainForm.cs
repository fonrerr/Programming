using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ContactList.Model;
using Contact = ContactList.Model.Contact;

namespace ContactList
{
    /// <summary>
    /// Предоставляет реализацию по представлению главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Колекция контактов.
        /// </summary>
        private List<Contact> _contacts = new List<Contact>();

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact _currentContact;

        /// <summary>
        /// Создает экземпляр класса MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            DateOfBirthDateTimePicker.MinDate = new DateTime(1900, 1, 1);
            DateOfBirthDateTimePicker.MaxDate = DateTime.Today;
            _contacts = Serializer.LoadFromFile();
            UpdateContactInfo(-1);
        }

        /// <summary>
        /// Осуществляет сортировку коллекцию контактов.
        /// </summary>
        private void SortOfContacts()
        {
            var orderedListContacts = from contact in _contacts
                                      orderby contact.FullName
                                      select contact;
            _contacts = orderedListContacts.ToList();
        }

        /// <summary>
        /// Осуществляет обновление контактов.
        /// </summary>
        /// <param name="selectedIndex">Выбранный индекс.</param>
        private void UpdateContactInfo(int selectedIndex)
        {
            ContactListBox.Items.Clear();
            
            for (int i = 0; i < _contacts.Count;i++)
            {
                ContactListBox.Items.Add(_contacts[i].FullName);
            }

            ContactListBox.SelectedIndex = selectedIndex;
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            _currentContact = new Contact();
            _currentContact.FullName = "Новый контакт";
            _currentContact.DateOfBirth = DateTime.Today;
            _contacts.Add(_currentContact);
            Serializer.SaveFromFile(_contacts);
            SortOfContacts();
            UpdateContactInfo(_contacts.Count - 1);
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ContactListBox.SelectedIndex == -1) return;

            try
            {
                FullNameTextBox.BackColor = AppColors.CorrectColor;
                _currentContact.FullName = FullNameTextBox.Text;
                SortOfContacts();
                int index = _contacts.IndexOf(_currentContact);
                Serializer.SaveFromFile(_contacts);
                UpdateContactInfo(index);
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ContactListBox.SelectedIndex == -1) return;

            _currentContact.DateOfBirth = DateOfBirthDateTimePicker.Value;
            Serializer.SaveFromFile(_contacts);
        }

        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactListBox.SelectedIndex == -1) return;

            _currentContact = _contacts[ContactListBox.SelectedIndex];
            FullNameTextBox.Text = _currentContact.FullName;
            DateOfBirthDateTimePicker.Value = _currentContact.DateOfBirth;
            PhoneMaskedTextBox.Text = _currentContact.Number;
            UrlTextBox.Text = _currentContact.Url;
        }

        private void PhoneMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ContactListBox.SelectedIndex == -1) return;

            _currentContact.Number = PhoneMaskedTextBox.Text;
            Serializer.SaveFromFile(_contacts);
        }

        private void UrlTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ContactListBox.SelectedIndex == -1) return;

            _currentContact.Url = UrlTextBox.Text;
            Serializer.SaveFromFile(_contacts);
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            if (ContactListBox.SelectedIndex == -1) return;

            _contacts.RemoveAt(ContactListBox.SelectedIndex);
            ContactListBox.Items.Clear();

            for (int i = 0; i < _contacts.Count; i++)
            {
                ContactListBox.Items.Add(_contacts[i].FullName);
            }

            ContactListBox.SelectedIndex = -1;
            Serializer.SaveFromFile(_contacts);
        }

        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.contact_add_24x24;
        }

        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.contact_add_24x24_uncolor;
        }

        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.contact_remove_24x24;
        }

        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.contact_remove_24x24_uncolor;
        }
    }
}
