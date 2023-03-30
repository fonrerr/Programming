namespace Programming
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 608);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.GroupBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enum";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ParseLabel);
            this.groupBox3.Controls.Add(this.ParseButton);
            this.groupBox3.Controls.Add(this.ParseTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(9, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 171);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Weekday Parsing";
            // 
            // ParseLabel
            // 
            this.ParseLabel.AutoSize = true;
            this.ParseLabel.Location = new System.Drawing.Point(19, 123);
            this.ParseLabel.Name = "ParseLabel";
            this.ParseLabel.Size = new System.Drawing.Size(0, 20);
            this.ParseLabel.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(263, 76);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(94, 29);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(19, 76);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(216, 27);
            this.ParseTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Type value for parsing:";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.GoButton);
            this.GroupBox.Controls.Add(this.SeasonComboBox);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Location = new System.Drawing.Point(399, 372);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(372, 171);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(254, 74);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(94, 29);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Items.AddRange(new object[] {
            "Winter",
            "Summer",
            "Spring",
            "Autumn"});
            this.SeasonComboBox.Location = new System.Drawing.Point(22, 74);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(200, 28);
            this.SeasonComboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Choose season:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IntTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ValueListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EnumsListBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumerations";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(544, 65);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(168, 27);
            this.IntTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Int value:";
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.ItemHeight = 20;
            this.ValueListBox.Location = new System.Drawing.Point(284, 65);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(205, 244);
            this.ValueListBox.TabIndex = 3;
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(19, 65);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(206, 244);
            this.EnumsListBox.TabIndex = 1;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose enumeration:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox3;
        private GroupBox GroupBox;
        private GroupBox groupBox1;
        private ListBox ValueListBox;
        private Label label2;
        private ListBox EnumsListBox;
        private Label label1;
        private TextBox IntTextBox;
        private Label label3;
        private ComboBox SeasonComboBox;
        private Label label4;
        private Button ParseButton;
        private TextBox ParseTextBox;
        private Label label5;
        private Button GoButton;
        private Label ParseLabel;
    }
}