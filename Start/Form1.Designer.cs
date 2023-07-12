namespace Start
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            gameTitle = new TextBox();
            ROLES = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 10;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(-11, 228);
            button1.Name = "button1";
            button1.Size = new Size(195, 190);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += roles_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(190, 222);
            button2.Name = "button2";
            button2.Size = new Size(181, 196);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += region_Click;
            // 
            // button3
            // 
            button3.Location = new Point(340, 219);
            button3.Name = "button3";
            button3.Size = new Size(117, 112);
            button3.TabIndex = 2;
            button3.Text = "Release Date";
            button3.UseVisualStyleBackColor = true;
            button3.Click += releaseDate_Click;
            // 
            // button4
            // 
            button4.Location = new Point(481, 219);
            button4.Name = "button4";
            button4.Size = new Size(117, 112);
            button4.TabIndex = 3;
            button4.Text = "Champion Class";
            button4.UseVisualStyleBackColor = true;
            button4.Click += championClass_Click;
            // 
            // button5
            // 
            button5.Location = new Point(637, 219);
            button5.Name = "button5";
            button5.Size = new Size(117, 112);
            button5.TabIndex = 4;
            button5.Text = "Alphabetically";
            button5.UseVisualStyleBackColor = true;
            button5.Click += alphabetically_Click;
            // 
            // gameTitle
            // 
            gameTitle.Location = new Point(190, 41);
            gameTitle.Multiline = true;
            gameTitle.Name = "gameTitle";
            gameTitle.ReadOnly = true;
            gameTitle.Size = new Size(377, 60);
            gameTitle.TabIndex = 5;
            // 
            // ROLES
            // 
            ROLES.AutoSize = true;
            ROLES.Location = new Point(89, 201);
            ROLES.Name = "ROLES";
            ROLES.Size = new Size(35, 15);
            ROLES.TabIndex = 6;
            ROLES.Text = "ROLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 201);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 7;
            label2.Text = "REGION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 201);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 8;
            label3.Text = "RELEASE DATE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(517, 201);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 9;
            label4.Text = "CLASS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(646, 201);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 10;
            label5.Text = "ALPHABETICALLY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ROLES);
            Controls.Add(gameTitle);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox gameTitle;
        private Label ROLES;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}