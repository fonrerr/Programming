using Programming.Models.Enums;

namespace Programming.Models.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса WeekdayParsingControl.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса WeekdayParsingControl.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик, который считывает текст из ParseTextBox и проверяет есть ли такой день недели.
        /// </summary>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday week;
            if (Enum.TryParse<Weekday>(ParseTextBox.Text, out week))
                ParseLabel.Text = $"«Ýòî äåíü íåäåëè ({week} = {((int)week + 1)})»";
            else ParseLabel.Text = "Íåò òàêîãî äíÿ íåäåëè!";
        }
    }
}
