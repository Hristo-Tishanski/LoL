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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            gameTitle = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(53, 177);
            button1.Name = "button1";
            button1.Size = new Size(117, 97);
            button1.TabIndex = 0;
            button1.Text = "Roles";
            button1.UseVisualStyleBackColor = true;
            button1.Click += roles_Click;
            // 
            // button2
            // 
            button2.Location = new Point(190, 179);
            button2.Name = "button2";
            button2.Size = new Size(114, 93);
            button2.TabIndex = 1;
            button2.Text = "Regions";
            button2.UseVisualStyleBackColor = true;
            button2.Click += region_Click;
            // 
            // button3
            // 
            button3.Location = new Point(320, 177);
            button3.Name = "button3";
            button3.Size = new Size(116, 97);
            button3.TabIndex = 2;
            button3.Text = "Release Date";
            button3.UseVisualStyleBackColor = true;
            button3.Click += releaseDate_Click;
            // 
            // button4
            // 
            button4.Location = new Point(463, 181);
            button4.Name = "button4";
            button4.Size = new Size(104, 93);
            button4.TabIndex = 3;
            button4.Text = "Champion Class";
            button4.UseVisualStyleBackColor = true;
            button4.Click += championClass_Click;
            // 
            // button5
            // 
            button5.Location = new Point(604, 179);
            button5.Name = "button5";
            button5.Size = new Size(101, 93);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}