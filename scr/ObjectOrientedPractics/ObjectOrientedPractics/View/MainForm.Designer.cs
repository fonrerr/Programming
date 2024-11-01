﻿namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TabControl = new TabControl();
            Item = new TabPage();
            ItemsTab = new View.Tabs.ItemsTab();
            Customers = new TabPage();
            CustomersTab = new View.Tabs.CustomersTab();
            Orders = new TabPage();
            OrdersTab = new View.Tabs.OrdersTab();
            Carts = new TabPage();
            CartsTab = new View.Tabs.CartsTab();
            PriorityOrder = new TabPage();
            priorityOrdersTab1 = new View.Tabs.PriorityOrdersTab();
            TabControl.SuspendLayout();
            Item.SuspendLayout();
            Customers.SuspendLayout();
            Orders.SuspendLayout();
            Carts.SuspendLayout();
            PriorityOrder.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(Item);
            TabControl.Controls.Add(Customers);
            TabControl.Controls.Add(Orders);
            TabControl.Controls.Add(Carts);
            TabControl.Controls.Add(PriorityOrder);
            TabControl.Location = new Point(2, 1);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1090, 650);
            TabControl.TabIndex = 0;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // Item
            // 
            Item.Controls.Add(ItemsTab);
            Item.Location = new Point(4, 29);
            Item.Name = "Item";
            Item.Padding = new Padding(3);
            Item.Size = new Size(1082, 617);
            Item.TabIndex = 0;
            Item.Text = "Items";
            Item.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(1076, 611);
            ItemsTab.TabIndex = 0;
            // 
            // Customers
            // 
            Customers.Controls.Add(CustomersTab);
            Customers.Location = new Point(4, 29);
            Customers.Name = "Customers";
            Customers.Padding = new Padding(3);
            Customers.Size = new Size(1082, 617);
            Customers.TabIndex = 1;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Location = new Point(0, 0);
            CustomersTab.MaximumSize = new Size(1069, 626);
            CustomersTab.MinimumSize = new Size(1049, 526);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(1069, 589);
            CustomersTab.TabIndex = 0;
            // 
            // Orders
            // 
            Orders.Controls.Add(OrdersTab);
            Orders.Location = new Point(4, 29);
            Orders.Name = "Orders";
            Orders.Padding = new Padding(3);
            Orders.Size = new Size(1082, 617);
            Orders.TabIndex = 2;
            Orders.Text = "Orders";
            Orders.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.Customers = null;
            OrdersTab.Location = new Point(-4, 0);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(1090, 566);
            OrdersTab.TabIndex = 0;
            // 
            // Carts
            // 
            Carts.Controls.Add(CartsTab);
            Carts.Location = new Point(4, 29);
            Carts.Name = "Carts";
            Carts.Padding = new Padding(3);
            Carts.Size = new Size(1082, 617);
            Carts.TabIndex = 3;
            Carts.Text = "Carts";
            Carts.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            CartsTab.Customers = null;
            CartsTab.Items = null;
            CartsTab.Location = new Point(0, 0);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(1069, 599);
            CartsTab.TabIndex = 0;
            // 
            // PriorityOrder
            // 
            PriorityOrder.Controls.Add(priorityOrdersTab1);
            PriorityOrder.Location = new Point(4, 29);
            PriorityOrder.Name = "PriorityOrder";
            PriorityOrder.Padding = new Padding(3);
            PriorityOrder.Size = new Size(1082, 617);
            PriorityOrder.TabIndex = 4;
            PriorityOrder.Text = "PriorityOrder";
            PriorityOrder.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            priorityOrdersTab1.Items = null;
            priorityOrdersTab1.Location = new Point(0, 0);
            priorityOrdersTab1.Name = "priorityOrdersTab1";
            priorityOrdersTab1.Size = new Size(685, 601);
            priorityOrdersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 623);
            Controls.Add(TabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1110, 670);
            Name = "MainForm";
            Text = "MainForm";
            TabControl.ResumeLayout(false);
            Item.ResumeLayout(false);
            Customers.ResumeLayout(false);
            Orders.ResumeLayout(false);
            Carts.ResumeLayout(false);
            PriorityOrder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage Item;
        private TabPage Customers;
        private View.Tabs.ItemsTab ItemsTab;
        private View.Tabs.CustomersTab CustomersTab;
        private TabPage Orders;
        private View.Tabs.OrdersTab OrdersTab;
        private TabPage Carts;
        private View.Tabs.CartsTab CartsTab;
        private TabPage PriorityOrder;
        private View.Tabs.PriorityOrdersTab priorityOrdersTab1;
    }
}