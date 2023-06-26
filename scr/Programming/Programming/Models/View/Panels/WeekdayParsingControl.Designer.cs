namespace Programming.Models.View.Panels
{
    partial class WeekdayParsingControl
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
            ParseButton = new Button();
            ParseTextBox = new TextBox();
            label5 = new Label();
            ParseLabel = new Label();
            SuspendLayout();
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(273, 95);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 5;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ParseTextBox
            // 
            ParseTextBox.Location = new Point(29, 95);
            ParseTextBox.Name = "ParseTextBox";
            ParseTextBox.Size = new Size(216, 27);
            ParseTextBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 70);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 3;
            label5.Text = "Type value for parsing:";
            // 
            // ParseLabel
            // 
            ParseLabel.AutoSize = true;
            ParseLabel.Location = new Point(29, 134);
            ParseLabel.Name = "ParseLabel";
            ParseLabel.Size = new Size(0, 20);
            ParseLabel.TabIndex = 6;
            // 
            // WeekdayParsingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ParseLabel);
            Controls.Add(ParseButton);
            Controls.Add(ParseTextBox);
            Controls.Add(label5);
            Name = "WeekdayParsingControl";
            Size = new Size(396, 194);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ParseButton;
        private TextBox ParseTextBox;
        private Label label5;
        private Label ParseLabel;
    }
}
