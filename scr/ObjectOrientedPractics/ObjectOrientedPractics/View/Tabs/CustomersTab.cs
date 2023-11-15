using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using Customer = ObjectOrientedPractics.Model.Customer;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей <see cref="Customer"/>.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

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
            _customers.Sort((a, b) => a.FullName.CompareTo(b.FullName));
        }

        private void Clear()
        {
            IDTextBox.Clear();
            FullNameTextBox.Clear();
            AddressControl.Clear();
            DiscountsListBox.Items.Clear();
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
            PriorityCheckBox.Checked = _currentCustomer.IsPriority;

            DiscountsListBox.Items.Clear();
            foreach (var discount in _currentCustomer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }

        }

        /// <summary>
        /// Все покупатели с полной информацией.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                Clear();
                return;
            }

            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            FullNameTextBox.Text = _currentCustomer.FullName;
            AddressControl.Address = _currentCustomer.Address;
            IDTextBox.Text = _currentCustomer.Id.ToString();
            UpdateInfo();

        }

        private void UpdateInfo()
        {
            FullNameTextBox.Text = _currentCustomer.FullName;
            IDTextBox.Text = _currentCustomer.Id.ToString();
            AddressControl.Address = _currentCustomer.Address;
            PriorityCheckBox.Checked = _currentCustomer.IsPriority;
            DiscountsListBox.Items.Clear();
            foreach (var discount in _currentCustomer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        /// <summary>
        /// Добавление нового покупателя.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer("Новый покупатель");
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
            Clear();
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

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                if (PriorityCheckBox.Checked)
                {
                    _currentCustomer.IsPriority = true;
                }
                else
                {
                    _currentCustomer.IsPriority = false;
                }
            }

        }

        /// <summary>
        /// Вызывает всплывающее окно для добавления скидки.
        /// </summary>
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                AddDiscount addDiscountForm = new AddDiscount();
                addDiscountForm.CurrentCustomer = _currentCustomer;
                var dialogResult = addDiscountForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    DiscountsListBox.Items.Clear();
                    foreach (var discount in _currentCustomer.Discounts)
                    {
                        DiscountsListBox.Items.Add(discount.Info);
                    }
                }

            }
        }


        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (DiscountsListBox.SelectedIndex != -1 && DiscountsListBox.SelectedIndex != 0)
            {
                _currentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
                UpdateCustomerInfo(CustomersListBox.SelectedIndex);
            }
        }
    }
}
