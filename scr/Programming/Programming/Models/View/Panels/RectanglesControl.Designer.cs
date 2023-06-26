namespace Programming.Models.View.Panels
{
    partial class RectanglesControl
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
            IdTextBox = new TextBox();
            label16 = new Label();
            label15 = new Label();
            YCoordinateTextBox = new TextBox();
            XCoordinateTextBox = new TextBox();
            label14 = new Label();
            FindButton = new Button();
            ColorTextBox = new TextBox();
            label8 = new Label();
            WidthTextBox = new TextBox();
            label7 = new Label();
            LenghtTextBox = new TextBox();
            label6 = new Label();
            RectListBox = new ListBox();
            SuspendLayout();
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(250, 93);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(187, 27);
            IdTextBox.TabIndex = 27;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(250, 70);
            label16.Name = "label16";
            label16.Size = new Size(22, 20);
            label16.TabIndex = 26;
            label16.Text = "Id";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(249, 379);
            label15.Name = "label15";
            label15.Size = new Size(95, 20);
            label15.TabIndex = 25;
            label15.Text = "Y Coordinate";
            // 
            // YCoordinateTextBox
            // 
            YCoordinateTextBox.Location = new Point(249, 403);
            YCoordinateTextBox.Name = "YCoordinateTextBox";
            YCoordinateTextBox.ReadOnly = true;
            YCoordinateTextBox.Size = new Size(188, 27);
            YCoordinateTextBox.TabIndex = 24;
            // 
            // XCoordinateTextBox
            // 
            XCoordinateTextBox.Location = new Point(249, 349);
            XCoordinateTextBox.Name = "XCoordinateTextBox";
            XCoordinateTextBox.ReadOnly = true;
            XCoordinateTextBox.Size = new Size(188, 27);
            XCoordinateTextBox.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(250, 326);
            label14.Name = "label14";
            label14.Size = new Size(96, 20);
            label14.TabIndex = 22;
            label14.Text = "X Coordinate";
            // 
            // FindButton
            // 
            FindButton.Location = new Point(279, 445);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(94, 29);
            FindButton.TabIndex = 21;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(249, 284);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(188, 27);
            ColorTextBox.TabIndex = 20;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(250, 261);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 19;
            label8.Text = "Color:";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(250, 219);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(188, 27);
            WidthTextBox.TabIndex = 18;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(250, 196);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 17;
            label7.Text = "Width:";
            // 
            // LenghtTextBox
            // 
            LenghtTextBox.Location = new Point(250, 156);
            LenghtTextBox.Name = "LenghtTextBox";
            LenghtTextBox.Size = new Size(188, 27);
            LenghtTextBox.TabIndex = 16;
            LenghtTextBox.TextChanged += LenghtTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 133);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 15;
            label6.Text = "Lenght:";
            // 
            // RectListBox
            // 
            RectListBox.FormattingEnabled = true;
            RectListBox.ItemHeight = 20;
            RectListBox.Items.AddRange(new object[] { "Rectangle1", "Rectangle2", "Rectangle3", "Rectangle4", "Rectangle5" });
            RectListBox.Location = new Point(7, 70);
            RectListBox.Name = "RectListBox";
            RectListBox.Size = new Size(206, 404);
            RectListBox.TabIndex = 14;
            RectListBox.SelectedIndexChanged += RectListBox_SelectedIndexChange;
            // 
            // RectanglesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IdTextBox);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(YCoordinateTextBox);
            Controls.Add(XCoordinateTextBox);
            Controls.Add(label14);
            Controls.Add(FindButton);
            Controls.Add(ColorTextBox);
            Controls.Add(label8);
            Controls.Add(WidthTextBox);
            Controls.Add(label7);
            Controls.Add(LenghtTextBox);
            Controls.Add(label6);
            Controls.Add(RectListBox);
            MinimumSize = new Size(448, 488);
            Name = "RectanglesControl";
            Size = new Size(448, 488);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IdTextBox;
        private Label label16;
        private Label label15;
        private TextBox YCoordinateTextBox;
        private TextBox XCoordinateTextBox;
        private Label label14;
        private Button FindButton;
        private TextBox ColorTextBox;
        private Label label8;
        private TextBox WidthTextBox;
        private Label label7;
        private TextBox LenghtTextBox;
        private Label label6;
        private ListBox RectListBox;
    }
}
