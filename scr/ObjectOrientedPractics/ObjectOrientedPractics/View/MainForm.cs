using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using ItemsTab = ObjectOrientedPractics.View.Tabs.ItemsTab;
using CustomersTab = ObjectOrientedPractics.View.Tabs.CustomersTab;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Store _store = new Store();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
        }
    }
}