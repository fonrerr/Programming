using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Contacts.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactsControl.xaml
    /// </summary>
    public partial class ContactsControl : UserControl
    {
        public ContactsControl()
        {
            InitializeComponent();
            DataObject.AddPastingHandler(PhoneTextBox, TextBoxPaste);
        }

        private void PhoneTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            int val;
            if (e.Text != "+" && e.Text != "-" && e.Text != "(" && e.Text != ")" && e.Text != " "
                && !Int32.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void TextBoxPaste(object sender, DataObjectPastingEventArgs e)
        {
            TextBox tb = sender as TextBox;
            bool isCorrectText = false;

            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string pasteText = e.DataObject.GetData(typeof(string)) as string;
                Regex pattern = new Regex(@"^(\+7)(\s)(\()([0-9]){3}(\))(\s)([0-9]){3}(\-)([0-9]){2}(\-)([0-9]){2}$");
                if (pattern.IsMatch(pasteText))
                    isCorrectText = true;
            }

            if (!isCorrectText)
            {
                e.CancelCommand();
            }
        }
    }
}
