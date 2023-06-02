namespace Programming.Models.View.Panels
{
    partial class EnumerationsControl
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
            IntTextBox = new TextBox();
            label3 = new Label();
            ValueListBox = new ListBox();
            label2 = new Label();
            EnumsListBox = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // IntTextBox
            // 
            IntTextBox.Location = new Point(564, 67);
            IntTextBox.Name = "IntTextBox";
            IntTextBox.Size = new Size(168, 27);
            IntTextBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(564, 34);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 10;
            label3.Text = "Int value:";
            // 
            // ValueListBox
            // 
            ValueListBox.FormattingEnabled = true;
            ValueListBox.ItemHeight = 20;
            ValueListBox.Location = new Point(304, 67);
            ValueListBox.Name = "ValueListBox";
            ValueListBox.Size = new Size(205, 244);
            ValueListBox.TabIndex = 9;
            ValueListBox.SelectedIndexChanged += ValueListBox_selectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 34);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 8;
            label2.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Location = new Point(39, 67);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(206, 244);
            EnumsListBox.TabIndex = 7;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 34);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 6;
            label1.Text = "Choose enumeration:";
            // 
            // EnumerationsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IntTextBox);
            Controls.Add(label3);
            Controls.Add(ValueListBox);
            Controls.Add(label2);
            Controls.Add(EnumsListBox);
            Controls.Add(label1);
            Name = "EnumerationsControl";
            Size = new Size(771, 344);
            Load += EnumerationsControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IntTextBox;
        private Label label3;
        private ListBox ValueListBox;
        private Label label2;
        private ListBox EnumsListBox;
        private Label label1;
    }
}
