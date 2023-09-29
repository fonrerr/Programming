﻿using ObjectOrientedPractics.Model;
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
            SortOfItems();
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
                SortOfItems();
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
    }
}
