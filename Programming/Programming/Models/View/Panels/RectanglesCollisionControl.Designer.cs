namespace Programming.Models.View.Panels
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            DeleteButton = new Button();
            AddButton = new Button();
            HeightTextBox = new TextBox();
            WidthRectanglesTextBox = new TextBox();
            label23 = new Label();
            label22 = new Label();
            YTextBox = new TextBox();
            label21 = new Label();
            label20 = new Label();
            XTextBox = new TextBox();
            IddTextBox = new TextBox();
            label19 = new Label();
            SelectedRectangleLabel = new Label();
            RectanglesListBox = new ListBox();
            label17 = new Label();
            RectanglesPanel = new Panel();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(215, 258);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(79, 55);
            DeleteButton.TabIndex = 31;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.Location = new Point(86, 258);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(76, 55);
            AddButton.TabIndex = 30;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(86, 499);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(138, 27);
            HeightTextBox.TabIndex = 29;
            HeightTextBox.TextChanged += HeightTextBox_TextChanged;
            // 
            // WidthRectanglesTextBox
            // 
            WidthRectanglesTextBox.Location = new Point(86, 464);
            WidthRectanglesTextBox.Name = "WidthRectanglesTextBox";
            WidthRectanglesTextBox.Size = new Size(138, 27);
            WidthRectanglesTextBox.TabIndex = 28;
            WidthRectanglesTextBox.TextChanged += WhTextBox_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(23, 499);
            label23.Name = "label23";
            label23.Size = new Size(57, 20);
            label23.TabIndex = 27;
            label23.Text = "Height:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(28, 463);
            label22.Name = "label22";
            label22.Size = new Size(52, 20);
            label22.TabIndex = 26;
            label22.Text = "Width:";
            // 
            // YTextBox
            // 
            YTextBox.Location = new Point(86, 431);
            YTextBox.Name = "YTextBox";
            YTextBox.Size = new Size(138, 27);
            YTextBox.TabIndex = 25;
            YTextBox.TextChanged += YTextBox_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(55, 431);
            label21.Name = "label21";
            label21.Size = new Size(20, 20);
            label21.TabIndex = 24;
            label21.Text = "Y:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(55, 402);
            label20.Name = "label20";
            label20.Size = new Size(21, 20);
            label20.TabIndex = 23;
            label20.Text = "X:";
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(86, 395);
            XTextBox.Name = "XTextBox";
            XTextBox.Size = new Size(138, 27);
            XTextBox.TabIndex = 22;
            XTextBox.TextChanged += XTextBox_TextChanged;
            // 
            // IddTextBox
            // 
            IddTextBox.Location = new Point(86, 362);
            IddTextBox.Name = "IddTextBox";
            IddTextBox.ReadOnly = true;
            IddTextBox.Size = new Size(138, 27);
            IddTextBox.TabIndex = 21;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(55, 365);
            label19.Name = "label19";
            label19.Size = new Size(25, 20);
            label19.TabIndex = 20;
            label19.Text = "Id:";
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(23, 327);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(139, 20);
            SelectedRectangleLabel.TabIndex = 19;
            SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 20;
            RectanglesListBox.Location = new Point(23, 68);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(374, 184);
            RectanglesListBox.TabIndex = 18;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(23, 45);
            label17.Name = "label17";
            label17.Size = new Size(84, 20);
            label17.TabIndex = 17;
            label17.Text = "Rectangles:";
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectanglesPanel.AutoSize = true;
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(431, 45);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(466, 481);
            RectanglesPanel.TabIndex = 16;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(HeightTextBox);
            Controls.Add(WidthRectanglesTextBox);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(YTextBox);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(XTextBox);
            Controls.Add(IddTextBox);
            Controls.Add(label19);
            Controls.Add(SelectedRectangleLabel);
            Controls.Add(RectanglesListBox);
            Controls.Add(label17);
            Controls.Add(RectanglesPanel);
            MinimumSize = new Size(920, 570);
            Name = "RectanglesCollisionControl";
            Size = new Size(920, 570);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label IdRectangleLabel;
        private Label XRectangleLabel;
        private Label YRectangleLabel;
        private Label WidthRectangleLabel;
        private Label HeightLabel;
        private Label RectanglesLabel;
        private Button DeleteButton;
        private Button AddButton;
        private TextBox HeightTextBox;
        private TextBox WidthRectanglesTextBox;
        private Label label23;
        private Label label22;
        private TextBox YTextBox;
        private Label label21;
        private Label label20;
        private TextBox XTextBox;
        private TextBox IddTextBox;
        private Label label19;
        private Label SelectedRectangleLabel;
        private ListBox RectanglesListBox;
        private Label label17;
        private Panel RectanglesPanel;
    }
}
