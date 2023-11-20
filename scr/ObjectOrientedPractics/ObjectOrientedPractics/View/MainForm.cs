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
            //OrdersTab.Customers = _store.Customers;
            //priorityOrdersTab1.Items = _store.Items;
            ItemsTab.ItemsChanged += ItemsTab_ItemsChanged;
            CustomersTab.CustomersChanged += CustomersTab_CustomersChanged;
        }

        private void CustomersTab_CustomersChanged(object? sender, EventArgs e)
        {
            CartsTab.RefreshData();
            OrdersTab.UpdateOrders();
        }

        private void ItemsTab_ItemsChanged(object? sender, EventArgs e)
        {
            CartsTab.RefreshData();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (TabControl.SelectedIndex == 2)
            //{
            //    cartsTab.RefreshData();
            //}
            //if(TabControl.SelectedIndex == 3)
            //{
            //    ordersTab.UpdateOders();
            //}
        }
    }
}