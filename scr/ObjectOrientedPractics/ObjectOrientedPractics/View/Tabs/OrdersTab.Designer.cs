namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            components = new System.ComponentModel.Container();
            addressControl = new Controls.AddressControl();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            IdTextBox = new TextBox();
            CreatedTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            OrderDataGridView = new DataGridView();
            orderBindingSource = new BindingSource(components);
            Orders = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            AmountLabel = new Label();
            label1 = new Label();
            OrderListBox = new ListBox();
            PriorityOptionsPanel = new Panel();
            groupBox3 = new GroupBox();
            DeliveryTimeComboBox = new ComboBox();
            label2 = new Label();
            CustomerName = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            Orders.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            PriorityOptionsPanel.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // addressControl
            // 
            addressControl.Address = null;
            addressControl.Location = new Point(424, 147);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(683, 210);
            addressControl.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 26);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 4;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 67);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 5;
            label4.Text = "Created:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 114);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 6;
            label5.Text = "Status:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(79, 23);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(158, 27);
            IdTextBox.TabIndex = 7;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Location = new Point(79, 64);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.Size = new Size(158, 27);
            CreatedTextBox.TabIndex = 8;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(79, 106);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(158, 28);
            StatusComboBox.TabIndex = 9;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // OrderDataGridView
            // 
            OrderDataGridView.AutoGenerateColumns = false;
            OrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataGridView.Columns.AddRange(new DataGridViewColumn[] { CustomerName, idDataGridViewTextBoxColumn, Date, addressDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, orderStatusDataGridViewTextBoxColumn, Total });
            OrderDataGridView.DataSource = orderBindingSource;
            OrderDataGridView.Location = new Point(6, 26);
            OrderDataGridView.Name = "OrderDataGridView";
            OrderDataGridView.RowHeadersWidth = 51;
            OrderDataGridView.RowTemplate.Height = 29;
            OrderDataGridView.Size = new Size(404, 504);
            OrderDataGridView.TabIndex = 10;
            OrderDataGridView.RowHeaderMouseClick += OrderDataGridView_RowHeaderMouseClick;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Model.Orders.Order);
            // 
            // Orders
            // 
            Orders.Controls.Add(OrderDataGridView);
            Orders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Orders.Location = new Point(0, 3);
            Orders.Name = "Orders";
            Orders.Size = new Size(420, 536);
            Orders.TabIndex = 11;
            Orders.TabStop = false;
            Orders.Text = "Orders";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(IdTextBox);
            groupBox1.Controls.Add(StatusComboBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(CreatedTextBox);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(426, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 141);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Order:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AmountLabel);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(OrderListBox);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(426, 356);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(681, 183);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Items";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(603, 152);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(41, 28);
            AmountLabel.TabIndex = 2;
            AmountLabel.Text = "0.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(582, 133);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 1;
            label1.Text = "Amount:";
            // 
            // OrderListBox
            // 
            OrderListBox.FormattingEnabled = true;
            OrderListBox.ItemHeight = 20;
            OrderListBox.Location = new Point(6, 26);
            OrderListBox.Name = "OrderListBox";
            OrderListBox.Size = new Size(669, 104);
            OrderListBox.TabIndex = 0;
            // 
            // PriorityOptionsPanel
            // 
            PriorityOptionsPanel.Controls.Add(groupBox3);
            PriorityOptionsPanel.Location = new Point(732, 3);
            PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            PriorityOptionsPanel.Size = new Size(375, 141);
            PriorityOptionsPanel.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DeliveryTimeComboBox);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(366, 135);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Priority Options";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(143, 60);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(192, 28);
            DeliveryTimeComboBox.TabIndex = 1;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 64);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 0;
            label2.Text = "Delivery Time:";
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "CustomerName";
            CustomerName.HeaderText = "CustomerName";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            orderStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            orderStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 125;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PriorityOptionsPanel);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Orders);
            Controls.Add(addressControl);
            Name = "OrdersTab";
            Size = new Size(1110, 542);
            ((System.ComponentModel.ISupportInitialize)OrderDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            Orders.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            PriorityOptionsPanel.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Controls.AddressControl addressControl;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox IdTextBox;
        private TextBox CreatedTextBox;
        private ComboBox StatusComboBox;
        private DataGridView OrderDataGridView;
        private DataGridViewTextBoxColumn dateOfOrderCreationDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
        private GroupBox Orders;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox OrderListBox;
        private Label AmountLabel;
        private Label label1;
        private Panel PriorityOptionsPanel;
        private GroupBox groupBox3;
        private Label label2;
        private ComboBox DeliveryTimeComboBox;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Total;
    }
}
