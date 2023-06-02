using Programming.Models.Enums;

namespace Programming.Models.View.Panels
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday week;
            if (Enum.TryParse<Weekday>(ParseTextBox.Text, out week))
                ParseLabel.Text = $"«Ýòî äåíü íåäåëè ({week} = {((int)week + 1)})»";
            else ParseLabel.Text = "Íåò òàêîãî äíÿ íåäåëè!";
        }
    }
}
