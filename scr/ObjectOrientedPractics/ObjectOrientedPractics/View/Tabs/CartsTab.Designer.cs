﻿namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            AmountLabel = new Label();
            label3 = new Label();
            ClearCartButton = new Button();
            RemoveItemButton = new Button();
            CreateOrderButton = new Button();
            AddToCartButton = new Button();
            CartListBox = new ListBox();
            label2 = new Label();
            label1 = new Label();
            CustomerComboBox = new ComboBox();
            CartItemsListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AmountLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ClearCartButton);
            groupBox1.Controls.Add(RemoveItemButton);
            groupBox1.Controls.Add(CreateOrderButton);
            groupBox1.Controls.Add(AddToCartButton);
            groupBox1.Controls.Add(CartListBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CustomerComboBox);
            groupBox1.Controls.Add(CartItemsListBox);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(817, 560);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(733, 294);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(53, 28);
            AmountLabel.TabIndex = 10;
            AmountLabel.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(713, 269);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 9;
            label3.Text = "Amount:";
            // 
            // ClearCartButton
            // 
            ClearCartButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearCartButton.Location = new Point(705, 325);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(94, 37);
            ClearCartButton.TabIndex = 8;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveItemButton.Location = new Point(580, 325);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(119, 37);
            RemoveItemButton.TabIndex = 7;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CreateOrderButton.Location = new Point(356, 325);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(117, 37);
            CreateOrderButton.TabIndex = 6;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddToCartButton.Location = new Point(6, 516);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(122, 29);
            AddToCartButton.TabIndex = 5;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 20;
            CartListBox.Location = new Point(356, 122);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(444, 144);
            CartListBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 99);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 3;
            label2.Text = "Cart";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 29);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Customer";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(439, 26);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(361, 28);
            CustomerComboBox.TabIndex = 1;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // CartItemsListBox
            // 
            CartItemsListBox.FormattingEnabled = true;
            CartItemsListBox.ItemHeight = 20;
            CartItemsListBox.Location = new Point(6, 26);
            CartItemsListBox.Name = "CartItemsListBox";
            CartItemsListBox.Size = new Size(332, 484);
            CartItemsListBox.TabIndex = 0;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "CartsTab";
            Size = new Size(823, 564);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox CartItemsListBox;
        private Button CreateOrderButton;
        private Button AddToCartButton;
        private ListBox CartListBox;
        private Label label2;
        private Label label1;
        private ComboBox CustomerComboBox;
        private Label label3;
        private Button ClearCartButton;
        private Button RemoveItemButton;
        private Label AmountLabel;
    }
}
