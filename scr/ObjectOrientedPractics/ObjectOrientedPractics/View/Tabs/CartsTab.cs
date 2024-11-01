﻿using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список объектов типа <see cref="Item"/>.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список объектов типа <see cref="Customer"/>.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Объект типа <see cref="Customer"/>.
        /// </summary>
        private Customer CurrentCustomer = new Customer();

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {

                _items = value;
                CartItemsListBox.DataSource = _items;
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                CustomerComboBox.DataSource = _customers;
            }
        }

        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет листбокс с списком товаров в заказе выбранного покупателя. 
        /// </summary>
        private void UpdateCartListBox()
        {
            if (Customers.Count != 0)
            {
                CurrentCustomer = Customers[CustomerComboBox.SelectedIndex];
                List<Item> currentCustomersItems = CurrentCustomer.Cart.Items;
                List<Item> newCurrentCustomersItems = new List<Item>();
                for (int i = 0; i < currentCustomersItems.Count; i++)
                {
                    if (CartItemsListBox.Items.Contains(currentCustomersItems[i]))
                    {
                        CartListBox.Items.Add(currentCustomersItems[i].Name);
                        newCurrentCustomersItems.Add(currentCustomersItems[i]);
                    }
                }
                for (int i = 0; i < currentCustomersItems.Count; i++)
                {
                    if (newCurrentCustomersItems.
                        Contains(currentCustomersItems[i]) == false)
                    {
                        currentCustomersItems.RemoveAt(i);
                    }
                }
                AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }

        }

        /// <summary>
        /// Обновляет данные в листбоксе с товарами и в комбобоксе с покупателями. 
        /// </summary>

        public void RefreshData()
        {
            ((CurrencyManager)CustomerComboBox.BindingContext[_customers]).Refresh();
            CustomerComboBox.DisplayMember = "FullName";
            CustomerComboBox.ValueMember = "Id";
            ((CurrencyManager)CartItemsListBox.BindingContext[_items]).Refresh();
            CartItemsListBox.DisplayMember = "Name";
            CartItemsListBox.ValueMember = "Id";
            CartListBox.Items.Clear();
            UpdateCartListBox();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartListBox.Items.Clear();
            if (CustomerComboBox.SelectedIndex != -1)
            {
                Model.Customer currentCustomer = Customers[CustomerComboBox.SelectedIndex];
                DiscountsCheckedListBox.Items.Clear();
                int i = 0;
                foreach (var discount in currentCustomer.Discounts)
                {
                    DiscountsCheckedListBox.Items.Add(discount.Info);
                    DiscountsCheckedListBox.SetItemChecked(i, true);
                    i++;
                }
                UpdateCartListBox();
            }
            else
            {
                CartListBox.Items.Clear();
            }

        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count != 0)
            {
                if (CurrentCustomer.IsPriority == true)
                {
                    CurrentCustomer.Orders.Add(
                        new PriorityOrder(CurrentCustomer.FullName,
                        CurrentCustomer.Address,
                        CurrentCustomer.Cart.Items, ""));

                    (CurrentCustomer.Orders.Last()).DiscountAmount = Convert.ToDouble(DiscountAmountLabel.Text);
                    for (int i = 0; i < CurrentCustomer.Discounts.Count; i++)
                    {
                        if (DiscountsCheckedListBox.GetItemChecked(i))
                        {
                            CurrentCustomer.Discounts[i].Apply(CurrentCustomer.Cart.Items);
                        }
                        CurrentCustomer.Discounts[i].Update(CurrentCustomer.Cart.Items);
                    }
                    DiscountsCheckedListBox.Items.Clear();
                    int j = 0;
                    foreach (var discount in CurrentCustomer.Discounts)
                    {
                        DiscountsCheckedListBox.Items.Add(discount.Info);
                        DiscountsCheckedListBox.SetItemChecked(j, true);
                        j++;
                    }
                }
                else
                {
                    CurrentCustomer.Orders.Add(
                        new Order(CurrentCustomer.FullName,
                        CurrentCustomer.Address,
                        CurrentCustomer.Cart.Items));
                    (CurrentCustomer.Orders.Last()).DiscountAmount = Convert.ToDouble(DiscountAmountLabel.Text);
                    for (int i = 0; i < CurrentCustomer.Discounts.Count; i++)
                    {
                        if (DiscountsCheckedListBox.GetItemChecked(i))
                        {
                            CurrentCustomer.Discounts[i].Apply(CurrentCustomer.Cart.Items);
                        }
                        CurrentCustomer.Discounts[i].Update(CurrentCustomer.Cart.Items);
                    }

                    DiscountsCheckedListBox.Items.Clear();
                    int j = 0;
                    foreach (var discount in CurrentCustomer.Discounts)
                    {
                        DiscountsCheckedListBox.Items.Add(discount.Info);
                        DiscountsCheckedListBox.SetItemChecked(j, true);
                        j++;
                    }
                }
                CartListBox.Items.Clear();
                CurrentCustomer.Cart.Items = new List<Model.Item>();
                AmountLabel.Text = "0";
                UpdateDiscount();
            }
        }

            private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1 && CartListBox.SelectedIndex != -1)
            {
                int value = CartListBox.SelectedIndex;
                CurrentCustomer = Customers[CustomerComboBox.SelectedIndex];
                CurrentCustomer.Cart.Items.RemoveAt(value);
                CartListBox.Items.RemoveAt(value);
                CartListBox.SelectedIndex = value - 1;
                AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                CartListBox.Items.Clear();
                CurrentCustomer.Cart.Items.Clear();
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (CartItemsListBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Add(_items[CartItemsListBox.SelectedIndex]);
                CartListBox.Items.Add(_items[CartItemsListBox.SelectedIndex].Name);
                AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
        }

        /// <summary>
        /// Обновляет список скидок покупателя. 
        /// </summary>
        public void UpdateDiscount()
        {
            double discountAmount = 0;
            for (int i = 0; i < CurrentCustomer.Discounts.Count; i++)
            {
                if (DiscountsCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                }
            }
            DiscountAmountLabel.Text = discountAmount.ToString();
            TotalAmountLabel.Text = Convert.ToString(CurrentCustomer.Cart.Amount - discountAmount);
        }



        private void CartItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscount();
        }
    }
}
