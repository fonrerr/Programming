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

        /// <summary>
        /// Обработчик предварительного ввода текста в поле ввода телефонного номера.
        /// </summary>
        /// <param name="sender">Элемент, вызвавший событие.</param>
        /// <param name="e">Аргументы события TextCompositionEventArgs, содержащие информацию о введенном тексте.</param>
        private void PhoneTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            int value;
            if (e.Text != "+" && e.Text != "-" && e.Text != "(" && e.Text != ")" && e.Text != " "
                && !Int32.TryParse(e.Text, out value))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Обработчик вставки текста в текстовое поле.
        /// </summary>
        /// <param name="sender">Элемент, вызвавший событие.</param>
        /// <param name="e">Аргументы события DataObjectPastingEventArgs, содержащие информацию о вставляемом тексте.</param>
        private void TextBoxPaste(object sender, DataObjectPastingEventArgs e)
        {
            TextBox tb = sender as TextBox;
            bool isCorrectText = false;

            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string pasteText = e.DataObject.GetData(typeof(string)) as string;
                //Регулярное выражение, проверяющее номер на вставку. Пример правильно вставленного номера: +7(904)483-62-16, +7(890)123-54-21
                //Сначала идет +7, дальше в скобках три цифры от 0 до 9, дальше три цифры от 0 до 9, дефис, две цифры, дефис, две цифры.
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
