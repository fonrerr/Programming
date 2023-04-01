using Programming.Models.Enums;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        
        string[] enums = { "Colors", "EducationForm", "Genre", "Menufactures", "Season", "Weekday" };
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SetSelected(0, true); 
        }

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
                    ValueListBox.Items.AddRange(typeof(Menufactures).GetEnumNames());
                    break;
                case "Weekday":
                    ValueListBox.Items.AddRange(typeof(Weekday).GetEnumNames());
                    break;
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ValueListBox.SelectedIndex.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday week;
            if (Enum.TryParse<Weekday>(ParseTextBox.Text, out week)) 
                ParseLabel.Text = $"«Это день недели ({week} = {((int)week + 1)})»";
            else ParseLabel.Text = "Нет такого дня недели!";
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            string selectedSeason = SeasonComboBox.SelectedItem.ToString();
            switch (selectedSeason)
            {
                case "Winter":
                    MessageBox.Show("Брр, холодища!");
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Spring":
                    GroupBox.BackColor = Color.GreenYellow; 
                    break;
                case "Autumn":
                    GroupBox.BackColor = Color.Orange;
                    break;
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            max = 0;
            int index = 0;
            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (max < _rectangles[i].getWith())
                {
                    max = _rectangles[i].getWith();
                    index = i;

                }

            }
            MessageBox.Show($"Наибольший прямоугольник с индексом - {index}");
            RectListBox.SetSelected(index, true);
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LenghtTextBox.Text != "" & WidthTextBox.Text != "" & ColorTextBox.Text != "")
            {
                try
                {
                    ColorTextBox.BackColor = Color.White;
                    _currentRectangle = new Rectangle(Convert.ToInt32(LenghtTextBox.Text), Convert.ToInt32(WidthTextBox.Text), ColorTextBox.Text);
                    _rectangles[(int)RectListBox.SelectedIndex] = _currentRectangle;
                }
                catch
                {
                    ColorTextBox.BackColor = Color.LightPink;
                }

            }
        }

    }
}