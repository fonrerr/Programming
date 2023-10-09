using Customer = ObjectOrientedPractics.Model.Customer;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создает экземпляр класса CustomersTab.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Осуществляет сортировку коллекции покупателей.
        /// </summary>
        private void SortOfCustomers()
        {
            var orderedListCustomers = from customer in _customers
                                       orderby customer.FullName
                                       select customer;

            _customers = orderedListCustomers.ToList();
        }

        /// <summary>
        /// Осуществляет обновление покупателей.
        /// </summary>
        /// <param name="selectedIndex">Выбранный индекс.</param>
        private void UpdateCustomerInfo(int selectedIndex)
        {
            CustomersListBox.Items.Clear();

            for (int i = 0; i < _customers.Count; i++)
            {
                CustomersListBox.Items.Add(_customers[i].FullName);
            }

            CustomersListBox.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Все покупатели с полной информацией.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            FullNameTextBox.Text = _currentCustomer.FullName;
            AddressRichTextBox.Text = _currentCustomer.Address;
            IDTextBox.Text = _currentCustomer.Id.ToString();

        }

        /// <summary>
        /// Добавление нового покупателя.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer();
            _currentCustomer.FullName = "Новый покупатель";
            _currentCustomer.Address = "Новый адрес";
            _customers.Add(_currentCustomer);
            SortOfCustomers();
            UpdateCustomerInfo(_customers.Count - 1);
        }

        /// <summary>
        /// Удаление покупателя.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            _customers.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.Clear();

            for (int i = 0; i < _customers.Count; i++)
            {
                CustomersListBox.Items.Add(_customers[i].FullName);
            }

            CustomersListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Ввод полного имени покупателя.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                FullNameTextBox.BackColor = Color.White;
                _currentCustomer.FullName = FullNameTextBox.Text;
                SortOfCustomers();
                int index = _customers.IndexOf(_currentCustomer);
                UpdateCustomerInfo(index);
            }
            catch
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Ввод адреса покупателя.
        /// </summary>
        private void AddressRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                AddressRichTextBox.BackColor = Color.White;
                _currentCustomer.Address = AddressRichTextBox.Text;
                AddressRichTextBox.ReadOnly = false;
            }
            catch
            {
                AddressRichTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
