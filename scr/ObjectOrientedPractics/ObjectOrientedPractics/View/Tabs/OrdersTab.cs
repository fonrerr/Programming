using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список объектов типа <see cref="Customer"/>. 
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Список объектов типа <see cref="Model.Order"/>.
        /// </summary>
        private List<Order> _orders = new List<Order>();
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

        public OrdersTab()
        {
            InitializeComponent();
            var statuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in statuses)
            {
                StatusComboBox.Items.Add(status);
            }
        }

        /// <summary>
        /// Обновляет данные в таблице. 
        /// </summary>
        public void UpdateOrders()
        {
            _orders.Clear();

            if (_customers == null) return;
            foreach (var customer in _customers)
            {
                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                }
            }
            orderBindingSource.DataSource = null;
            orderBindingSource.DataSource = _orders;
        }

        /// <summary>
        /// Обновляет данные в текстовых полях при выборе заказа в таблице. 
        /// </summary>
        private void OrderDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Order currentOrder = _orders[OrderDataGridView.CurrentCell.RowIndex];
            addressControl.Address = currentOrder.Address;
            IdTextBox.Text = Convert.ToString(OrderDataGridView.CurrentRow.Cells[3].Value);
            CreatedTextBox.Text = Convert.ToString(OrderDataGridView.CurrentRow.Cells[2].Value);
            StatusComboBox.SelectedItem = OrderDataGridView.CurrentRow.Cells[5].Value;
            for (int i = 0; i < currentOrder.Items.Count; i++)
            {
                OrderListBox.Items.Add(currentOrder.Items[i].Name);
            }
            AmountLabel.Text = currentOrder.Amount.ToString();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order currentOrder = _orders[OrderDataGridView.CurrentCell.RowIndex];
            currentOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
        }
    }
}
