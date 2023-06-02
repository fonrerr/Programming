namespace Programming.Models.View.Panels
{
    partial class SeasonHandleControl
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
            GoButton = new Button();
            SeasonComboBox = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // GoButton
            // 
            GoButton.Location = new Point(269, 93);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(94, 29);
            GoButton.TabIndex = 5;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Items.AddRange(new object[] { "Winter", "Summer", "Spring", "Autumn" });
            SeasonComboBox.Location = new Point(37, 93);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(200, 28);
            SeasonComboBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 70);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "Choose season:";
            // 
            // SeasonHandleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GoButton);
            Controls.Add(SeasonComboBox);
            Controls.Add(label4);
            Name = "SeasonHandleControl";
            Size = new Size(401, 192);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GoButton;
        private ComboBox SeasonComboBox;
        private Label label4;
    }
}
