namespace ObjectOrientedPractics
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
            tabControl1 = new TabControl();
            Item = new TabPage();
            ItemsTab = new View.Tabs.ItemsTab();
            Customers = new TabPage();
            customers1 = new View.Tabs.CustomersTab();
            tabControl1.SuspendLayout();
            Item.SuspendLayout();
            Customers.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Item);
            tabControl1.Controls.Add(Customers);
            tabControl1.Location = new Point(2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(870, 579);
            tabControl1.TabIndex = 0;
            // 
            // Item
            // 
            Item.Controls.Add(ItemsTab);
            Item.Location = new Point(4, 29);
            Item.Name = "Item";
            Item.Padding = new Padding(3);
            Item.Size = new Size(862, 546);
            Item.TabIndex = 0;
            Item.Text = "Items";
            Item.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(856, 540);
            ItemsTab.TabIndex = 0;
            // 
            // Customers
            // 
            Customers.Controls.Add(customers1);
            Customers.Location = new Point(4, 29);
            Customers.Name = "Customers";
            Customers.Padding = new Padding(3);
            Customers.Size = new Size(862, 546);
            Customers.TabIndex = 1;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            // 
            // customers1
            // 
            customers1.Location = new Point(0, 0);
            customers1.Name = "customers1";
            customers1.Size = new Size(750, 530);
            customers1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 563);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(785, 610);
            Name = "MainForm";
            Text = "MainForm";
            tabControl1.ResumeLayout(false);
            Item.ResumeLayout(false);
            Customers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Item;
        private TabPage Customers;
        private View.Tabs.ItemsTab ItemsTab;
        private View.Tabs.CustomersTab customers1;
    }
}