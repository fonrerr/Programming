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
        /// Список объектов типа <see cref="Order"/>.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        Order currentOrder;

        PriorityOrder currentPriorityOrder;

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
            string[] deliveryTime = new string[6] { "9:00-11:00",
                "11:00-13:00","13:00-15:00",
                "15:00-17:00","17:00-19:00",
                "19:00-21:00" };
            DeliveryTimeComboBox.Items.AddRange(deliveryTime);
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
            Order checkedOrder = _orders[OrderDataGridView.CurrentCell.RowIndex];
            if (checkedOrder.GetType() == typeof(PriorityOrder))
            {
                currentOrder = checkedOrder;
                currentPriorityOrder = (PriorityOrder)checkedOrder;
                PriorityOptionsPanel.Visible = true;
                addressControl.Address = currentPriorityOrder.Address;
                IdTextBox.Text = Convert.ToString(OrderDataGridView.CurrentRow.Cells[0].Value);
                CreatedTextBox.Text = Convert.ToString(OrderDataGridView.CurrentRow.Cells[2].Value);
                StatusComboBox.SelectedItem = OrderDataGridView.CurrentRow.Cells[5].Value;
                OrderListBox.Items.Clear();
                for (int i = 0; i < currentPriorityOrder.Items.Count; i++)
                {
                    OrderListBox.Items.Add(currentPriorityOrder.Items[i].Name);
                }
                AmountLabel.Text = currentPriorityOrder.Amount.ToString();
                DeliveryTimeComboBox.SelectedItem =
                    currentPriorityOrder.DeliveryTime.ToString();
            }
            else
            {
                currentOrder = checkedOrder;
                currentPriorityOrder = null;
                PriorityOptionsPanel.Visible = false;
                addressControl.Address = currentOrder.Address;
                IdTextBox.Text = Convert.ToString(OrderDataGridView.CurrentRow.Cells[0].Value);
                CreatedTextBox.Text = Convert.ToString(OrderDataGridView.CurrentRow.Cells[2].Value);
                StatusComboBox.SelectedItem = OrderDataGridView.CurrentRow.Cells[5].Value;
                OrderListBox.Items.Clear();
                for (int i = 0; i < currentOrder.Items.Count; i++)
                {
                    OrderListBox.Items.Add(currentOrder.Items[i].Name);
                }
                AmountLabel.Text = currentOrder.Amount.ToString();
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order currentOrder = _orders[OrderDataGridView.CurrentCell.RowIndex];
            currentOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPriorityOrder.DeliveryTime = DeliveryTimeComboBox.SelectedItem.ToString();
        }
    }
}
