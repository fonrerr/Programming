using Programming.Models.Enums;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        //список всех перечислений
        string[] enums = { "Colors", "EducationForm", "Genre", "Menufactures", "Season", "Weekday" };
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.Items.AddRange(enums); //заполняем первый листбокс
            EnumsListBox.SetSelected(0, true); // будет выделен первый элемент
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();// для чистой записи 
            ListBox lb = (ListBox)sender;// создаем объект листбокса 
            string elem = lb.SelectedItem as string;// переменная для записи выбора 
            switch (elem)
            {
                case "Colors":

                    ValueListBox.Items.AddRange(typeof(Colors).GetEnumNames());// получаем весь список 
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
                    ValueListBox.Items.AddRange(typeof(Menufactures).GetEnumNames());
                    break;
                case "Weekday":
                    ValueListBox.Items.AddRange(typeof(Weekday).GetEnumNames());
                    break;
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ValueListBox.SelectedIndex.ToString(); // получаем нужный индекс
        }

        private void ParseButton_Click_1(object sender, EventArgs e)
        {
            Weekday week;//переменная перечисления 
            if (Enum.TryParse<Weekday>(ParseTextBox.Text, out week)) // условие проверки ввода пользователя 
                ParseLabel.Text = $"«Это день недели ({week} = {((int)week + 1)})»";
            else ParseLabel.Text = "Нет такого дня недели!";

        }

        private void GoButton_Click_1(object sender, EventArgs e)
        {
            string selectedSeason = SeasonComboBox.SelectedItem.ToString(); // получаем выбоанный объект
            switch (selectedSeason)
            {
                case "Winter":
                    MessageBox.Show("Брр, холодища!");
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Spring":
                    splitContainer1.Panel2.BackColor = Color.GreenYellow; // меняем цвет окна 
                    break;
                case "Autumn":
                    splitContainer1.Panel2.BackColor = Color.Orange;
                    break;
            }
        }
    }
}