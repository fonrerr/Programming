using Programming.Models.Enums;

namespace Programming.Models.View.Panels
{
    public partial class EnumerationsControl : UserControl
    {
        string[] _enums = { "Colors", "EducationForm", "Genre", "Menufactures", "Season", "Weekday" };

        public EnumerationsControl()
        {
            InitializeComponent();
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
                    ValueListBox.Items.AddRange(typeof(Manufactures).GetEnumNames());
                    break;
                case "Weekday":
                    ValueListBox.Items.AddRange(typeof(Weekday).GetEnumNames());
                    break;
            }
        }

        private void ValueListBox_selectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ValueListBox.SelectedIndex.ToString();
        }

        private void EnumerationsControl_Load(object sender, EventArgs e)
        {
            EnumsListBox.Items.AddRange(_enums);
            EnumsListBox.SetSelected(0, true);
        }
    }
}
