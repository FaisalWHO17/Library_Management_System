namespace Library_Management_System
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            Books = new Button();
            Journals = new Button();
            Magazines = new Button();
            HomeButton = new Button();
            AboutButton = new Button();
            ContactButton = new Button();
            LoginButton = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Books
            // 
            Books.BackgroundImage = Properties.Resources.Group_51__1_;
            Books.FlatAppearance.BorderSize = 0;
            Books.FlatStyle = FlatStyle.Flat;
            Books.Location = new Point(98, 167);
            Books.Name = "Books";
            Books.Size = new Size(226, 321);
            Books.TabIndex = 0;
            Books.UseVisualStyleBackColor = true;
            Books.Click += button1_Click;
            // 
            // Journals
            // 
            Journals.BackgroundImage = Properties.Resources.Group_50__1_;
            Journals.FlatAppearance.BorderSize = 0;
            Journals.FlatStyle = FlatStyle.Flat;
            Journals.Location = new Point(372, 164);
            Journals.Name = "Journals";
            Journals.Size = new Size(226, 321);
            Journals.TabIndex = 0;
            Journals.UseVisualStyleBackColor = true;
            Journals.Click += button1_Click;
            // 
            // Magazines
            // 
            Magazines.BackgroundImage = Properties.Resources.Group_49__1_;
            Magazines.FlatAppearance.BorderSize = 0;
            Magazines.FlatStyle = FlatStyle.Flat;
            Magazines.Location = new Point(646, 164);
            Magazines.Name = "Magazines";
            Magazines.Size = new Size(226, 321);
            Magazines.TabIndex = 0;
            Magazines.UseVisualStyleBackColor = true;
            Magazines.Click += button1_Click;
            // 
            // HomeButton
            // 
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Image = Properties.Resources.Frame_18;
            HomeButton.Location = new Point(276, 26);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(62, 26);
            HomeButton.TabIndex = 1;
            HomeButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            AboutButton.FlatAppearance.BorderSize = 0;
            AboutButton.FlatStyle = FlatStyle.Flat;
            AboutButton.Image = Properties.Resources.About;
            AboutButton.Location = new Point(330, 23);
            AboutButton.Name = "AboutButton";
            AboutButton.Size = new Size(76, 27);
            AboutButton.TabIndex = 1;
            AboutButton.UseVisualStyleBackColor = true;
            // 
            // ContactButton
            // 
            ContactButton.FlatAppearance.BorderSize = 0;
            ContactButton.FlatStyle = FlatStyle.Flat;
            ContactButton.Image = Properties.Resources.Contact;
            ContactButton.Location = new Point(412, 19);
            ContactButton.Name = "ContactButton";
            ContactButton.Size = new Size(75, 36);
            ContactButton.TabIndex = 1;
            ContactButton.UseVisualStyleBackColor = true;
            ContactButton.Click += ContactButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Image = Properties.Resources.Log_In__1_;
            LoginButton.Location = new Point(493, 23);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(59, 32);
            LoginButton.TabIndex = 1;
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += Login_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(570, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Rectangle_27;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(865, 14);
            button1.Name = "button1";
            button1.Size = new Size(47, 45);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cATEGORY__1_;
            ClientSize = new Size(942, 493);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(LoginButton);
            Controls.Add(ContactButton);
            Controls.Add(AboutButton);
            Controls.Add(HomeButton);
            Controls.Add(Magazines);
            Controls.Add(Journals);
            Controls.Add(Books);
            Name = "Category";
            Text = "Category";
            Load += Category_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Books;
        private Button Journals;
        private Button Magazines;
        private Button HomeButton;
        private Button AboutButton;
        private Button ContactButton;
        private Button LoginButton;
        private TextBox textBox1;
        private Button button1;
    }
}
