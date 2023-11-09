namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            addressControl1 = new Controls.AddressControl();
            label1 = new Label();
            label2 = new Label();
            OrderItemsListBox = new ListBox();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            ClearOrderButton = new Button();
            label3 = new Label();
            AmountLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            IdTextBox = new TextBox();
            CreatedTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            DeliveryTimeComboBox = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // addressControl1
            // 
            addressControl1.Address = null;
            addressControl1.Location = new Point(0, 153);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(707, 206);
            addressControl1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 376);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Order Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 10);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Selected Order";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 20;
            OrderItemsListBox.Location = new Point(19, 399);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(651, 104);
            OrderItemsListBox.TabIndex = 3;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(18, 562);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(94, 29);
            AddItemButton.TabIndex = 4;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(139, 562);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(110, 29);
            RemoveItemButton.TabIndex = 5;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Location = new Point(576, 562);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(94, 29);
            ClearOrderButton.TabIndex = 6;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(585, 506);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 7;
            label3.Text = "Amount";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(602, 531);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(50, 28);
            AmountLabel.TabIndex = 8;
            AmountLabel.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 41);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 9;
            label5.Text = "ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 75);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 10;
            label6.Text = "Created:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 118);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 11;
            label7.Text = "Status:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(98, 38);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 12;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Location = new Point(98, 75);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.Size = new Size(125, 27);
            CreatedTextBox.TabIndex = 13;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(98, 115);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(151, 28);
            StatusComboBox.TabIndex = 14;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(484, 37);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(151, 28);
            DeliveryTimeComboBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(375, 41);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 16;
            label8.Text = "Delivery Time:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(375, 10);
            label9.Name = "label9";
            label9.Size = new Size(120, 20);
            label9.TabIndex = 17;
            label9.Text = "Priority Options";
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(DeliveryTimeComboBox);
            Controls.Add(StatusComboBox);
            Controls.Add(CreatedTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(AmountLabel);
            Controls.Add(label3);
            Controls.Add(ClearOrderButton);
            Controls.Add(RemoveItemButton);
            Controls.Add(AddItemButton);
            Controls.Add(OrderItemsListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addressControl1);
            Name = "PriorityOrdersTab";
            Size = new Size(684, 597);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.AddressControl addressControl1;
        private Label label1;
        private Label label2;
        private ListBox OrderItemsListBox;
        private Button AddItemButton;
        private Button RemoveItemButton;
        private Button ClearOrderButton;
        private Label label3;
        private Label AmountLabel;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox IdTextBox;
        private TextBox CreatedTextBox;
        private ComboBox StatusComboBox;
        private ComboBox DeliveryTimeComboBox;
        private Label label8;
        private Label label9;
    }
}
