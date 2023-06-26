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
            rectanglesControl1 = new Models.View.Panels.RectanglesControl();
            moviesControl1 = new Models.View.Panels.MoviesControl();
            tabPage1 = new TabPage();
            seasonHandleControl1 = new Models.View.Panels.SeasonHandleControl();
            weekdayParsingControl1 = new Models.View.Panels.WeekdayParsingControl();
            enumerationsControl1 = new Models.View.Panels.EnumerationsControl();
            TabControl = new TabControl();
            Rectangles = new TabPage();
            rectanglesCollisionControl1 = new Models.View.Panels.RectanglesCollisionControl();
            ClassTabPage.SuspendLayout();
            tabPage1.SuspendLayout();
            TabControl.SuspendLayout();
            Rectangles.SuspendLayout();
            SuspendLayout();
            // 
            // ClassTabPage
            // 
            ClassTabPage.Controls.Add(rectanglesControl1);
            ClassTabPage.Controls.Add(moviesControl1);
            ClassTabPage.Location = new Point(4, 29);
            ClassTabPage.Name = "ClassTabPage";
            ClassTabPage.Padding = new Padding(3);
            ClassTabPage.Size = new Size(962, 537);
            ClassTabPage.TabIndex = 1;
            ClassTabPage.Text = "Classes";
            ClassTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Location = new Point(4, 0);
            rectanglesControl1.MinimumSize = new Size(448, 488);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(448, 631);
            rectanglesControl1.TabIndex = 1;
            // 
            // moviesControl1
            // 
            moviesControl1.Location = new Point(443, 0);
            moviesControl1.Name = "moviesControl1";
            moviesControl1.Size = new Size(672, 756);
            moviesControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(seasonHandleControl1);
            tabPage1.Controls.Add(weekdayParsingControl1);
            tabPage1.Controls.Add(enumerationsControl1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(962, 537);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // seasonHandleControl1
            // 
            seasonHandleControl1.Location = new Point(396, 319);
            seasonHandleControl1.Name = "seasonHandleControl1";
            seasonHandleControl1.Size = new Size(501, 212);
            seasonHandleControl1.TabIndex = 2;
            // 
            // weekdayParsingControl1
            // 
            weekdayParsingControl1.Location = new Point(-4, 319);
            weekdayParsingControl1.Name = "weekdayParsingControl1";
            weekdayParsingControl1.Size = new Size(495, 212);
            weekdayParsingControl1.TabIndex = 1;
            // 
            // enumerationsControl1
            // 
            enumerationsControl1.Dock = DockStyle.Fill;
            enumerationsControl1.Location = new Point(3, 3);
            enumerationsControl1.Name = "enumerationsControl1";
            enumerationsControl1.Size = new Size(956, 531);
            enumerationsControl1.TabIndex = 0;
            // 
            // TabControl
            // 
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
            Rectangles.Controls.Add(rectanglesCollisionControl1);
            Rectangles.Location = new Point(4, 29);
            Rectangles.Name = "Rectangles";
            Rectangles.Padding = new Padding(3);
            Rectangles.Size = new Size(962, 537);
            Rectangles.TabIndex = 2;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Location = new Point(-9, -29);
            rectanglesCollisionControl1.MinimumSize = new Size(920, 540);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(920, 572);
            rectanglesCollisionControl1.TabIndex = 0;
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
            ClassTabPage.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            Rectangles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage ClassTabPage;
        private TabPage tabPage1;
        private TabControl TabControl;
        private TabPage Rectangles;
        private Models.View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Models.View.Panels.RectanglesControl rectanglesControl1;
        private Models.View.Panels.MoviesControl moviesControl1;
        private Models.View.Panels.EnumerationsControl enumerationsControl1;
        private Models.View.Panels.SeasonHandleControl seasonHandleControl1;
        private Models.View.Panels.WeekdayParsingControl weekdayParsingControl1;
    }
}