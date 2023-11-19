using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Data;
using Item = ObjectOrientedPractics.Model.Item;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список объектов класса <see cref="Item"/>.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса ItemsTab.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            CategoryComboBox.Items.AddRange(Enum.GetNames(typeof(Category)));
            string[] sortTypes = new string[3]
            {"Cost (Ascending)", "Cost (Descending)", "Name"};
            SortComboBox.Items.AddRange(sortTypes);
            SortComboBox.SelectedIndex = 2;
        }

        /*
        /// <summary>
        /// Осуществляет сортировку коллекции товаров.
        /// </summary>
        private void SortOfItems()
        {
            var orderedListItems = from item in _items
                                   orderby item.Name
                                   select item;

            _items = orderedListItems.ToList();
        }
        */

        /// <summary>
        /// Осуществляет обновление информации о товарах.
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

        /// <summary>
        /// Обновляет текстовые поля. 
        /// </summary>
        private void UpdateInfo(List<Item> items)
        {
            _currentItem = items[ItemsListBox.SelectedIndex];
            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name;
            InfoRichTextBox.Text = _currentItem.Info;
            CategoryComboBox.SelectedItem = _currentItem.Category;
        }

        /// <summary>
        /// Очищает текстовые поля. 
        /// </summary>
        private void ClearInfo()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            InfoRichTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Все товары с полной информацией.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            _currentItem = _items[ItemsListBox.SelectedIndex];
            NameTextBox.Text = _currentItem.Name;
            InfoRichTextBox.Text = _currentItem.Info;
            CostTextBox.Text = _currentItem.Cost.ToString();
            IdTextBox.Text = _currentItem.Id.ToString();
            CategoryComboBox.Text = _currentItem.Category.ToString();
        }

        /// <summary>
        /// Добавление нового товара.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item();
            _currentItem.Name = "Новый товар";
            _currentItem.Info = "Описание товара";
            _currentItem.Cost = Convert.ToDouble("1000");
            _items.Add(_currentItem);
            UpdateItemInfo(_items.Count - 1);
        }

        /// <summary>
        /// Удаление товара.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            _items.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.Clear();

            for (int i = 0; i < _items.Count; i++)
            {
                ItemsListBox.Items.Add(_items[i].Name);
            }

            ItemsListBox.SelectedIndex = -1;
            UpdateItemInfo(_items.Count - 1);
        }

        /// <summary>
        /// Ввод именования товара.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                NameTextBox.BackColor = Color.White;
                _currentItem.Name = NameTextBox.Text;
                int index = _items.IndexOf(_currentItem);
                UpdateItemInfo(index);
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Ввод стоимости товара товара.
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                CostTextBox.BackColor = Color.White;
                _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
            }
            catch
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Ввод описания товара.
        /// </summary>
        private void InfoRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                InfoRichTextBox.BackColor = Color.White;
                _currentItem.Info = InfoRichTextBox.Text;
            }
            catch
            {
                InfoRichTextBox.BackColor = Color.LightPink;
            }
        }

        private void SelectedValueChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            _currentItem.Category = (Category)CategoryComboBox.SelectedIndex;
            int index = _items.IndexOf(_currentItem);
            UpdateItemInfo(index);
        }

        /// <summary>
        /// Сортирует листбокс с товарами в зависимости от выбранного значения в 
        /// комбобоксе. 
        /// </summary>
        public void SortItemsInListBox()
        {
            if (Items == null) return;
            Item selectedItem = _currentItem;
            foreach (Item item in Items)
            {
                if (item.Name == (string)ItemsListBox.SelectedItem)
                {
                    selectedItem = item;
                }
            }
            List<Item> sortedItems = new List<Item>();
            if (SortComboBox.SelectedIndex == 0)
            {
                sortedItems = DataTools.Sort(Items, DataTools.SortCostAscending);
            }
            if (SortComboBox.SelectedIndex == 1)
            {
                sortedItems = DataTools.Sort(Items, DataTools.SortCostDescending);
            }
            if (SortComboBox.SelectedIndex == 2)
            {
                sortedItems = DataTools.Sort(Items, DataTools.SortName);
            }
            ItemsListBox.Items.Clear();
            foreach (Item item in sortedItems)
            {
                ItemsListBox.Items.Add(item.Name);
            }
            ItemsListBox.SelectedIndex = sortedItems.IndexOf(selectedItem);
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortComboBox.SelectedIndex != -1 && Items != null)
            {
                SortItemsInListBox();
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text != null && Items != null)
            {
                Item selectedItem = _currentItem;
                foreach (Item item in Items)
                {
                    if (item.Name == (string)ItemsListBox.SelectedItem)
                    {
                        selectedItem = item;
                    }
                }
                List<Item> filteredItems =
                    DataTools.Filter(Items, AssertString, FindTextBox.Text);
                ItemsListBox.Items.Clear();
                foreach (Item item in filteredItems)
                {
                    ItemsListBox.Items.Add(item.Name);
                }
                if (filteredItems.Contains(selectedItem))
                {
                    ItemsListBox.SelectedIndex = filteredItems.IndexOf(selectedItem);
                    UpdateInfo(filteredItems);
                }
                else
                {
                    ClearInfo();
                }

            }
        }

        /// <summary>
        /// Проверяет содердит ли имя товара подстроку. 
        /// </summary>
        /// <param name="item">Товар. </param>
        /// <param name="str">Подстрока. </param>
        /// <returns>Булевое значение. </returns>
        public bool AssertString(Item item, object str)
        {
            if (item.Name.Contains((string)str))
            {
                return true;
            }
            return false;
        }
    }
}
