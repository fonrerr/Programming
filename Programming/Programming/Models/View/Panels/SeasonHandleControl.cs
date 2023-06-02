using Programming.Models.Classes;
using Programming.Models.Enums;

namespace Programming.Models.View.Panels
{
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
            SeasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch(SeasonComboBox.Text)
            {
                case "Spring":
                    BackColor = AppColors.SpringColor;
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    BackColor = AppColors.AutumnColor;
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                }
            }
    }
}
