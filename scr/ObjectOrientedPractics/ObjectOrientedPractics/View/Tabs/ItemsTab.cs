using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
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

        public void SaveItemsCloseFile()
        {
            Serializer.SaveFromFile(_items);
        }

        /// <summary>
        /// Осуществляет сортировку коллекцию контактов.
        /// </summary>
        private void SortOfItems()
        {
            var orderedListItems = from item in _items
                                       orderby item.Name
            select item;

            _items = orderedListItems.ToList();
        }

        /// <summary>
        /// Осуществляет обновление контактов.
        /// </summary>
        /// <param name="selectedIndex">Выбранный индекс.</param>
        private void UpdateItemInfo(int selectedIndex)
        {
            ItemsListBox.Items.Clear();

            for (int i = 0; i < _items.Count; i++)
            {
                ItemsListBox.Items.Add(_items[i].Name);
            }

            ItemsListBox.SelectedIndex = selectedIndex;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            _currentItem = _items[ItemsListBox.SelectedIndex];
            NameRichTextBox.Text = _currentItem.Name;
            InfoRichTextBox.Text = _currentItem.Info;
            IdTextBox.Text = _currentItem.Id.ToString();
        }
    }
}
