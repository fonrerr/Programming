namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            Model.Address address1 = new Model.Address();
            panel1 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            RemoveButton = new Button();
            panel3 = new Panel();
            AddButton = new Button();
            panel4 = new Panel();
            CustomersListBox = new ListBox();
            label1 = new Label();
            panel2 = new Panel();
            PriorityCheckBox = new CheckBox();
            FullNameTextBox = new TextBox();
            label4 = new Label();
            IDTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel7 = new Panel();
            AddressControl = new Controls.AddressControl();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(CustomersListBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 520);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Location = new Point(234, 464);
            panel6.Name = "panel6";
            panel6.Size = new Size(113, 53);
            panel6.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(RemoveButton);
            panel5.Location = new Point(117, 464);
            panel5.Name = "panel5";
            panel5.Size = new Size(117, 53);
            panel5.TabIndex = 2;
            // 
            // RemoveButton
            // 
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Location = new Point(3, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(111, 47);
            RemoveButton.TabIndex = 0;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(AddButton);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(3, 464);
            panel3.Name = "panel3";
            panel3.Size = new Size(111, 53);
            panel3.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(105, 47);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // panel4
            // 
            panel4.Location = new Point(114, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(125, 53);
            panel4.TabIndex = 0;
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(3, 34);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(344, 424);
            CustomersListBox.TabIndex = 1;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // panel2
            // 
            panel2.Controls.Add(PriorityCheckBox);
            panel2.Controls.Add(FullNameTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(IDTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(359, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(687, 143);
            panel2.TabIndex = 0;
            // 
            // PriorityCheckBox
            // 
            PriorityCheckBox.AutoSize = true;
            PriorityCheckBox.Location = new Point(84, 114);
            PriorityCheckBox.Name = "PriorityCheckBox";
            PriorityCheckBox.Size = new Size(92, 24);
            PriorityCheckBox.TabIndex = 5;
            PriorityCheckBox.Text = "Is Priority";
            PriorityCheckBox.UseVisualStyleBackColor = true;
            PriorityCheckBox.CheckedChanged += PriorityCheckBox_CheckedChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(84, 81);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(476, 27);
            FullNameTextBox.TabIndex = 4;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 81);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "FullName:";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(84, 40);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(176, 27);
            IDTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 43);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 0;
            label2.Text = "Selected Customer:";
            // 
            // panel7
            // 
            panel7.Controls.Add(AddressControl);
            panel7.Location = new Point(359, 152);
            panel7.Name = "panel7";
            panel7.Size = new Size(687, 371);
            panel7.TabIndex = 1;
            // 
            // AddressControl
            // 
            address1.Apartment = null;
            address1.Building = null;
            address1.City = null;
            address1.Country = null;
            address1.Index = 0;
            address1.Street = null;
            AddressControl.Address = address1;
            AddressControl.Location = new Point(3, 3);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(681, 226);
            AddressControl.TabIndex = 0;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1049, 526);
            MinimumSize = new Size(1049, 526);
            Name = "CustomersTab";
            Size = new Size(1049, 526);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox CustomersListBox;
        private Label label1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Button RemoveButton;
        private Panel panel3;
        private Button AddButton;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private TextBox FullNameTextBox;
        private Label label4;
        private TextBox IDTextBox;
        private Panel panel7;
        private Controls.AddressControl AddressControl;
        private CheckBox PriorityCheckBox;
    }
}
