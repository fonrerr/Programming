using Item = ObjectOrientedPractics.Model.Item;
namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создает экземпляр класса ItemsTab.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
