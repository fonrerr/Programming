namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            panel1 = new Panel();
            FindTextBox = new TextBox();
            label8 = new Label();
            SortComboBox = new ComboBox();
            label7 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            RemoveButton = new Button();
            ItemsListBox = new ListBox();
            ItemsLabel = new Label();
            panel3 = new Panel();
            AddButton = new Button();
            panel2 = new Panel();
            CategoryComboBox = new ComboBox();
            label6 = new Label();
            NameTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            InfoRichTextBox = new RichTextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(FindTextBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(SortComboBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(ItemsListBox);
            panel1.Controls.Add(ItemsLabel);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 569);
            panel1.TabIndex = 0;
            // 
            // FindTextBox
            // 
            FindTextBox.Location = new Point(71, 38);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(270, 27);
            FindTextBox.TabIndex = 8;
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 481);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 7;
            label8.Text = "Sort:";
            // 
            // SortComboBox
            // 
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Location = new Point(71, 478);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(270, 28);
            SortComboBox.TabIndex = 6;
            SortComboBox.SelectedIndexChanged += SortComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 41);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 5;
            label7.Text = "Find:";
            // 
            // panel5
            // 
            panel5.Location = new Point(228, 512);
            panel5.Name = "panel5";
            panel5.Size = new Size(113, 54);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(RemoveButton);
            panel4.Location = new Point(120, 512);
            panel4.Name = "panel4";
            panel4.Size = new Size(108, 54);
            panel4.TabIndex = 3;
            // 
            // RemoveButton
            // 
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Location = new Point(5, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(97, 45);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(13, 76);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(328, 384);
            ItemsListBox.TabIndex = 2;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsLabel.Location = new Point(13, 9);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(49, 20);
            ItemsLabel.TabIndex = 1;
            ItemsLabel.Text = "Items";
            // 
            // panel3
            // 
            panel3.Controls.Add(AddButton);
            panel3.Location = new Point(13, 512);
            panel3.Name = "panel3";
            panel3.Size = new Size(106, 54);
            panel3.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(98, 45);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(CategoryComboBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(InfoRichTextBox);
            panel2.Controls.Add(CostTextBox);
            panel2.Controls.Add(IdTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(350, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(678, 569);
            panel2.TabIndex = 1;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(95, 138);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(151, 28);
            CategoryComboBox.TabIndex = 11;
            CategoryComboBox.SelectedValueChanged += SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 138);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 10;
            label6.Text = "Category:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(12, 202);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(649, 108);
            NameTextBox.TabIndex = 9;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 325);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 8;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 179);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Name:";
            // 
            // InfoRichTextBox
            // 
            InfoRichTextBox.Location = new Point(12, 348);
            InfoRichTextBox.Name = "InfoRichTextBox";
            InfoRichTextBox.Size = new Size(649, 192);
            InfoRichTextBox.TabIndex = 6;
            InfoRichTextBox.Text = "";
            InfoRichTextBox.TextChanged += InfoRichTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(95, 94);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(151, 27);
            CostTextBox.TabIndex = 4;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(95, 50);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(151, 27);
            IdTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Cost:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ItemsTab";
            Size = new Size(1031, 575);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label ItemsLabel;
        private Panel panel3;
        private Label label1;
        private ListBox ItemsListBox;
        private Button RemoveButton;
        private Button AddButton;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private RichTextBox InfoRichTextBox;
        private Panel panel4;
        private Panel panel5;
        private TextBox NameTextBox;
        private ComboBox CategoryComboBox;
        private Label label6;
        private ComboBox SortComboBox;
        private Label label7;
        private TextBox FindTextBox;
        private Label label8;
    }
}
