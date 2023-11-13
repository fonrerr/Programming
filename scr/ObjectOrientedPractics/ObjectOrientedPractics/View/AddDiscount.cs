using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discount;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    public partial class AddDiscount : Form
    {
        /// <summary>
        /// Объект типа <see cref="Customer"/>. 
        /// </summary>
        private Customer _currentCustomer;

        public Customer CurrentCustomer
        {
            get { return _currentCustomer; }
            set
            {
                _currentCustomer = value;
            }
        }

        public AddDiscount()
        {
            InitializeComponent();
            var categories = Enum.GetValues(typeof(Category));
            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }
            CategoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Добавляет скидку выбранной категории.
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            PercentDiscount discount = new PercentDiscount();
            discount.Category = (Category)CategoryComboBox.SelectedItem;
            _currentCustomer.Discounts.Add(discount);
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Закрывает форму. 
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
