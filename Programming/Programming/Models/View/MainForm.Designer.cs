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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ClassTabPage = new TabPage();
            groupBox4 = new GroupBox();
            FindMovieButton = new Button();
            label13 = new Label();
            label12 = new Label();
            RatingTextBox = new TextBox();
            GenreTextBox = new TextBox();
            YearTextBox = new TextBox();
            DurationTextBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            TitleTextBox = new TextBox();
            label9 = new Label();
            MovieListBox = new ListBox();
            groupBox2 = new GroupBox();
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
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            ParseLabel = new Label();
            ParseButton = new Button();
            ParseTextBox = new TextBox();
            label5 = new Label();
            GroupBox = new GroupBox();
            GoButton = new Button();
            SeasonComboBox = new ComboBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            IntTextBox = new TextBox();
            label3 = new Label();
            ValueListBox = new ListBox();
            label2 = new Label();
            EnumsListBox = new ListBox();
            label1 = new Label();
            TabControl = new TabControl();
            Rectangles = new TabPage();
            DeleteButton = new Button();
            AddButton = new Button();
            HeightTextBox = new TextBox();
            WhTextBox = new TextBox();
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
            ClassTabPage.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            GroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            TabControl.SuspendLayout();
            Rectangles.SuspendLayout();
            SuspendLayout();
            // 
            // ClassTabPage
            // 
            ClassTabPage.Controls.Add(groupBox4);
            ClassTabPage.Controls.Add(groupBox2);
            ClassTabPage.Location = new Point(4, 29);
            ClassTabPage.Name = "ClassTabPage";
            ClassTabPage.Padding = new Padding(3);
            ClassTabPage.Size = new Size(962, 537);
            ClassTabPage.TabIndex = 1;
            ClassTabPage.Text = "Classes";
            ClassTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(FindMovieButton);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(RatingTextBox);
            groupBox4.Controls.Add(GenreTextBox);
            groupBox4.Controls.Add(YearTextBox);
            groupBox4.Controls.Add(DurationTextBox);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(TitleTextBox);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(MovieListBox);
            groupBox4.Location = new Point(463, 20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(445, 495);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Movie";
            // 
            // FindMovieButton
            // 
            FindMovieButton.Location = new Point(285, 390);
            FindMovieButton.Name = "FindMovieButton";
            FindMovieButton.Size = new Size(94, 29);
            FindMovieButton.TabIndex = 11;
            FindMovieButton.Text = "Find";
            FindMovieButton.UseVisualStyleBackColor = true;
            FindMovieButton.Click += FindMovieButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(243, 321);
            label13.Name = "label13";
            label13.Size = new Size(55, 20);
            label13.TabIndex = 10;
            label13.Text = "Rating:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(243, 252);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 9;
            label12.Text = "Genre:";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(243, 344);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(187, 27);
            RatingTextBox.TabIndex = 8;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(243, 275);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(187, 27);
            GenreTextBox.TabIndex = 7;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(243, 205);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(187, 27);
            YearTextBox.TabIndex = 6;
            YearTextBox.TextChanged += YearTextBox_TextChanged;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(243, 130);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(187, 27);
            DurationTextBox.TabIndex = 5;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(243, 175);
            label11.Name = "label11";
            label11.Size = new Size(113, 20);
            label11.TabIndex = 4;
            label11.Text = "Year_of_release:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(243, 107);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 3;
            label10.Text = "Duration:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(243, 58);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(187, 27);
            TitleTextBox.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(243, 35);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 1;
            label9.Text = "Title:";
            // 
            // MovieListBox
            // 
            MovieListBox.FormattingEnabled = true;
            MovieListBox.ItemHeight = 20;
            MovieListBox.Items.AddRange(new object[] { "Movie1", "Movie2", "Movie3", "Movie4", "Movie5" });
            MovieListBox.Location = new Point(6, 35);
            MovieListBox.Name = "MovieListBox";
            MovieListBox.Size = new Size(211, 384);
            MovieListBox.TabIndex = 0;
            MovieListBox.SelectedIndexChanged += MovieListBox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(IdTextBox);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(YCoordinateTextBox);
            groupBox2.Controls.Add(XCoordinateTextBox);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(FindButton);
            groupBox2.Controls.Add(ColorTextBox);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(WidthTextBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(LenghtTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(RectListBox);
            groupBox2.Location = new Point(9, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 495);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(249, 58);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(187, 27);
            IdTextBox.TabIndex = 13;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(249, 35);
            label16.Name = "label16";
            label16.Size = new Size(22, 20);
            label16.TabIndex = 12;
            label16.Text = "Id";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(248, 344);
            label15.Name = "label15";
            label15.Size = new Size(95, 20);
            label15.TabIndex = 11;
            label15.Text = "Y Coordinate";
            // 
            // YCoordinateTextBox
            // 
            YCoordinateTextBox.Location = new Point(248, 368);
            YCoordinateTextBox.Name = "YCoordinateTextBox";
            YCoordinateTextBox.ReadOnly = true;
            YCoordinateTextBox.Size = new Size(188, 27);
            YCoordinateTextBox.TabIndex = 10;
            // 
            // XCoordinateTextBox
            // 
            XCoordinateTextBox.Location = new Point(248, 314);
            XCoordinateTextBox.Name = "XCoordinateTextBox";
            XCoordinateTextBox.ReadOnly = true;
            XCoordinateTextBox.Size = new Size(188, 27);
            XCoordinateTextBox.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(249, 291);
            label14.Name = "label14";
            label14.Size = new Size(96, 20);
            label14.TabIndex = 8;
            label14.Text = "X Coordinate";
            // 
            // FindButton
            // 
            FindButton.Location = new Point(278, 410);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(94, 29);
            FindButton.TabIndex = 7;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(248, 249);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(188, 27);
            ColorTextBox.TabIndex = 6;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(249, 226);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 5;
            label8.Text = "Color:";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(249, 184);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(188, 27);
            WidthTextBox.TabIndex = 4;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(249, 161);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 3;
            label7.Text = "Width:";
            // 
            // LenghtTextBox
            // 
            LenghtTextBox.Location = new Point(249, 121);
            LenghtTextBox.Name = "LenghtTextBox";
            LenghtTextBox.Size = new Size(188, 27);
            LenghtTextBox.TabIndex = 2;
            LenghtTextBox.TextChanged += LenghtTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 98);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 1;
            label6.Text = "Lenght:";
            // 
            // RectListBox
            // 
            RectListBox.FormattingEnabled = true;
            RectListBox.ItemHeight = 20;
            RectListBox.Items.AddRange(new object[] { "Rectangle1", "Rectangle2", "Rectangle3", "Rectangle4", "Rectangle5" });
            RectListBox.Location = new Point(6, 35);
            RectListBox.Name = "RectListBox";
            RectListBox.Size = new Size(206, 404);
            RectListBox.TabIndex = 0;
            RectListBox.SelectedIndexChanged += RectListBox_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(GroupBox);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(962, 537);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ParseLabel);
            groupBox3.Controls.Add(ParseButton);
            groupBox3.Controls.Add(ParseTextBox);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(9, 358);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(384, 157);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Weekday Parsing";
            // 
            // ParseLabel
            // 
            ParseLabel.AutoSize = true;
            ParseLabel.Location = new Point(19, 123);
            ParseLabel.Name = "ParseLabel";
            ParseLabel.Size = new Size(0, 20);
            ParseLabel.TabIndex = 3;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(263, 76);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 2;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ParseTextBox
            // 
            ParseTextBox.Location = new Point(19, 76);
            ParseTextBox.Name = "ParseTextBox";
            ParseTextBox.Size = new Size(216, 27);
            ParseTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 51);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 0;
            label5.Text = "Type value for parsing:";
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(GoButton);
            GroupBox.Controls.Add(SeasonComboBox);
            GroupBox.Controls.Add(label4);
            GroupBox.Location = new Point(515, 358);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(355, 157);
            GroupBox.TabIndex = 1;
            GroupBox.TabStop = false;
            GroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            GoButton.Location = new Point(254, 74);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(94, 29);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Items.AddRange(new object[] { "Winter", "Summer", "Spring", "Autumn" });
            SeasonComboBox.Location = new Point(22, 74);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(200, 28);
            SeasonComboBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 51);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 0;
            label4.Text = "Choose season:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IntTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ValueListBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumerations";
            // 
            // IntTextBox
            // 
            IntTextBox.Location = new Point(544, 65);
            IntTextBox.Name = "IntTextBox";
            IntTextBox.Size = new Size(168, 27);
            IntTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 32);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Int value:";
            // 
            // ValueListBox
            // 
            ValueListBox.FormattingEnabled = true;
            ValueListBox.ItemHeight = 20;
            ValueListBox.Location = new Point(284, 65);
            ValueListBox.Name = "ValueListBox";
            ValueListBox.Size = new Size(205, 244);
            ValueListBox.TabIndex = 3;
            ValueListBox.SelectedIndexChanged += ValueListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 32);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Location = new Point(19, 65);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(206, 244);
            EnumsListBox.TabIndex = 1;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose enumeration:";
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(ClassTabPage);
            TabControl.Controls.Add(Rectangles);
            TabControl.ItemSize = new Size(60, 25);
            TabControl.Location = new Point(0, 0);
            TabControl.MinimumSize = new Size(970, 570);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(970, 570);
            TabControl.TabIndex = 0;
            // 
            // Rectangles
            // 
            Rectangles.Controls.Add(DeleteButton);
            Rectangles.Controls.Add(AddButton);
            Rectangles.Controls.Add(HeightTextBox);
            Rectangles.Controls.Add(WhTextBox);
            Rectangles.Controls.Add(label23);
            Rectangles.Controls.Add(label22);
            Rectangles.Controls.Add(YTextBox);
            Rectangles.Controls.Add(label21);
            Rectangles.Controls.Add(label20);
            Rectangles.Controls.Add(XTextBox);
            Rectangles.Controls.Add(IddTextBox);
            Rectangles.Controls.Add(label19);
            Rectangles.Controls.Add(SelectedRectangleLabel);
            Rectangles.Controls.Add(RectanglesListBox);
            Rectangles.Controls.Add(label17);
            Rectangles.Controls.Add(RectanglesPanel);
            Rectangles.Location = new Point(4, 29);
            Rectangles.Name = "Rectangles";
            Rectangles.Padding = new Padding(3);
            Rectangles.Size = new Size(962, 537);
            Rectangles.TabIndex = 2;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            Rectangles.Resize += MainForm_Load;
            // 
            // DeleteButton
            // 
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(209, 229);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(79, 55);
            DeleteButton.TabIndex = 15;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.Location = new Point(80, 229);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(76, 55);
            AddButton.TabIndex = 14;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(80, 470);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(138, 27);
            HeightTextBox.TabIndex = 13;
            HeightTextBox.TextChanged += HeightTextBox_TextChanged;
            // 
            // WhTextBox
            // 
            WhTextBox.Location = new Point(80, 435);
            WhTextBox.Name = "WhTextBox";
            WhTextBox.Size = new Size(138, 27);
            WhTextBox.TabIndex = 12;
            WhTextBox.TextChanged += WhTextBox_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(17, 470);
            label23.Name = "label23";
            label23.Size = new Size(57, 20);
            label23.TabIndex = 11;
            label23.Text = "Height:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(22, 434);
            label22.Name = "label22";
            label22.Size = new Size(52, 20);
            label22.TabIndex = 10;
            label22.Text = "Width:";
            // 
            // YTextBox
            // 
            YTextBox.Location = new Point(80, 402);
            YTextBox.Name = "YTextBox";
            YTextBox.Size = new Size(138, 27);
            YTextBox.TabIndex = 9;
            YTextBox.TextChanged += YTextBox_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(49, 402);
            label21.Name = "label21";
            label21.Size = new Size(20, 20);
            label21.TabIndex = 8;
            label21.Text = "Y:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(49, 373);
            label20.Name = "label20";
            label20.Size = new Size(21, 20);
            label20.TabIndex = 7;
            label20.Text = "X:";
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(80, 366);
            XTextBox.Name = "XTextBox";
            XTextBox.Size = new Size(138, 27);
            XTextBox.TabIndex = 6;
            XTextBox.TextChanged += XTextBox_TextChanged;
            // 
            // IddTextBox
            // 
            IddTextBox.Location = new Point(80, 333);
            IddTextBox.Name = "IddTextBox";
            IddTextBox.ReadOnly = true;
            IddTextBox.Size = new Size(138, 27);
            IddTextBox.TabIndex = 5;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(49, 336);
            label19.Name = "label19";
            label19.Size = new Size(25, 20);
            label19.TabIndex = 4;
            label19.Text = "Id:";
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(17, 298);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(139, 20);
            SelectedRectangleLabel.TabIndex = 3;
            SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 20;
            RectanglesListBox.Location = new Point(17, 39);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(374, 184);
            RectanglesListBox.TabIndex = 2;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(17, 16);
            label17.Name = "label17";
            label17.Size = new Size(84, 20);
            label17.TabIndex = 1;
            label17.Text = "Rectangles:";
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectanglesPanel.AutoSize = true;
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(425, 16);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(466, 481);
            RectanglesPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 553);
            Controls.Add(TabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1100, 600);
            MinimumSize = new Size(940, 600);
            Name = "MainForm";
            Text = "Programming Demo";
            Load += MainForm_Load;
            ClassTabPage.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TabControl.ResumeLayout(false);
            Rectangles.ResumeLayout(false);
            Rectangles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage ClassTabPage;
        private GroupBox groupBox4;
        private Button FindMovieButton;
        private Label label13;
        private Label label12;
        private TextBox RatingTextBox;
        private TextBox GenreTextBox;
        private TextBox YearTextBox;
        private TextBox DurationTextBox;
        private Label label11;
        private Label label10;
        private TextBox TitleTextBox;
        private Label label9;
        private ListBox MovieListBox;
        private GroupBox groupBox2;
        private Button FindButton;
        private TextBox ColorTextBox;
        private Label label8;
        private TextBox WidthTextBox;
        private Label label7;
        private TextBox LenghtTextBox;
        private Label label6;
        private ListBox RectListBox;
        private TabPage tabPage1;
        private GroupBox groupBox3;
        private Label ParseLabel;
        private Button ParseButton;
        private TextBox ParseTextBox;
        private Label label5;
        private GroupBox GroupBox;
        private Button GoButton;
        private ComboBox SeasonComboBox;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox IntTextBox;
        private Label label3;
        private ListBox ValueListBox;
        private Label label2;
        private ListBox EnumsListBox;
        private Label label1;
        private TabControl TabControl;
        private TextBox IdTextBox;
        private Label label16;
        private Label label15;
        private TextBox YCoordinateTextBox;
        private TextBox XCoordinateTextBox;
        private Label label14;
        private TabPage Rectangles;
        private Panel RectanglesPanel;
        private TextBox HeightTextBox;
        private TextBox WhTextBox;
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
        private Button DeleteButton;
        private Button AddButton;
    }
}