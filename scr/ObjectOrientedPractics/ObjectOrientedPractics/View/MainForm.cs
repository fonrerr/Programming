using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using ItemsTab = ObjectOrientedPractics.View.Tabs.ItemsTab;
using CustomersTab = ObjectOrientedPractics.View.Tabs.CustomersTab;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            OrdersTab.Customers = _store.Customers;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 3)
            {
                CartsTab.RefreshData();
            }
            if (TabControl.SelectedIndex == 2)
            {
                OrdersTab.UpdateOrders();
            }
        }
    }
}