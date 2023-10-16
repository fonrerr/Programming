using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl : UserControl
    {
        /// <summary>
        /// Выбранный адрес класса.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает и задаёт адрес.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                WriteInTextBox();
            }
        }

        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод очищает тектовые поля.
        /// </summary>
        public void Clear()
        {
            IndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        /// <summary>
        /// Метод, который записывает значение Address в тектовые поля.
        /// </summary>
        private void WriteInTextBox()
        {
            if (Address == null) return;

            if (Address.Index != 0)
            {
                IndexTextBox.Text = Address.Index.ToString();
            }
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }

        /// <summary>
        /// Ввод почтового индекса.
        /// </summary>
        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Address == null) return;
            try
            {
                Address.Index = Convert.ToInt32(IndexTextBox.Text);
                IndexTextBox.BackColor = Color.White;
            }
            catch
            {
                IndexTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Ввод страны.
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Address == null) return;
            try
            {
                Address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = Color.White;
            }
            catch
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Ввод улицы.
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Address == null) return;
            try
            {
                Address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = Color.White;
            }
            catch
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Ввод города.
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Address == null) return;
            try
            {
                Address.City = CityTextBox.Text;
                CityTextBox.BackColor = Color.White;
            }
            catch
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Ввод номера дома.
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = Color.White;
            }
            catch
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Ввод номера квартиры/ помещения.
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = Color.White;
            }
            catch
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
