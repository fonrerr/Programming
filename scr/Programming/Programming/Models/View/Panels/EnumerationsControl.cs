using Programming.Models.Enums;

namespace Programming.Models.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса EnumerationsControl.
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        /// <summary>
        /// Массив перечислений.
        /// </summary>
        string[] _enums = { "Colors", "EducationForm", "Genre", "Menufactures", "Season", "Weekday" };

        /// <summary>
        /// Создает экземпляр класса EnumerationsControl.
        /// </summary>
        public EnumerationsControl()
        {
            InitializeComponent();
            // Заполнение EnumsListBox всеми перечислениями.
            EnumsListBox.Items.AddRange(_enums);
            //Выбрать все элементы, которые не выбраны.
            EnumsListBox.SetSelected(0, true);
        }

        /// <summary>
        /// Изменения элементов ValuesListBox, при выборе другого элемента в EnumsListBox.
        /// </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();
            ListBox listbox = (ListBox)sender;
            string elem = listbox.SelectedItem as string;
            switch (elem)
            {
                case "Colors":

                    ValueListBox.Items.AddRange(typeof(Colors).GetEnumNames());
                    break;
                case "EducationForm":
                    ValueListBox.Items.AddRange(typeof(EducationForm).GetEnumNames());
                    break;
                case "Genre":
                    ValueListBox.Items.AddRange(typeof(Genre).GetEnumNames());
                    break;
                case "Season":
                    ValueListBox.Items.AddRange(typeof(Season).GetEnumNames());
                    break;
                case "Menufactures":
                    ValueListBox.Items.AddRange(typeof(Manufactures).GetEnumNames());
                    break;
                case "Weekday":
                    ValueListBox.Items.AddRange(typeof(Weekday).GetEnumNames());
                    break;
            }
        }

        /// <summary>
        /// Запись индекса ValuesListBox в TextBox.
        /// </summary>
        private void ValueListBox_selectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ValueListBox.SelectedIndex.ToString();
        }
    }
}
