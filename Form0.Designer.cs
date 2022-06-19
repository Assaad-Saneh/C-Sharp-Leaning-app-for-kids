namespace WinFormProject
{
    partial class Form0
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            this.panel1 = new System.Windows.Forms.Panel();
            this.braingames = new System.Windows.Forms.Button();
            this.science = new System.Windows.Forms.Button();
            this.language = new System.Windows.Forms.Button();
            this.Math = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.startingScreen1 = new WinFormProject.StartingScreen();
            this.math1 = new WinFormProject.math();
            this.languages1 = new WinFormProject.Languages();
            this.science1 = new WinFormProject.science();
            this.brainGames1 = new WinFormProject.BrainGames();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.braingames);
            this.panel1.Controls.Add(this.science);
            this.panel1.Controls.Add(this.language);
            this.panel1.Controls.Add(this.Math);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 50);
            this.panel1.TabIndex = 0;
            // 
            // braingames
            // 
            this.braingames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.braingames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.braingames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.braingames.FlatAppearance.BorderSize = 0;
            this.braingames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.braingames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.braingames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.braingames.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braingames.Location = new System.Drawing.Point(825, -10);
            this.braingames.Margin = new System.Windows.Forms.Padding(0);
            this.braingames.Name = "braingames";
            this.braingames.Size = new System.Drawing.Size(275, 60);
            this.braingames.TabIndex = 3;
            this.braingames.Text = "Brain Games";
            this.braingames.UseVisualStyleBackColor = false;
            this.braingames.Click += new System.EventHandler(this.braingames_Click);
            // 
            // science
            // 
            this.science.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.science.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.science.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.science.Cursor = System.Windows.Forms.Cursors.Hand;
            this.science.FlatAppearance.BorderSize = 0;
            this.science.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.science.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.science.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.science.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.science.Location = new System.Drawing.Point(550, -10);
            this.science.Margin = new System.Windows.Forms.Padding(0);
            this.science.Name = "science";
            this.science.Size = new System.Drawing.Size(275, 60);
            this.science.TabIndex = 2;
            this.science.Text = "Science";
            this.science.UseVisualStyleBackColor = false;
            this.science.Click += new System.EventHandler(this.science_Click);
            // 
            // language
            // 
            this.language.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.language.Cursor = System.Windows.Forms.Cursors.Hand;
            this.language.FlatAppearance.BorderSize = 0;
            this.language.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.language.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.language.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language.Location = new System.Drawing.Point(275, -10);
            this.language.Margin = new System.Windows.Forms.Padding(0);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(275, 60);
            this.language.TabIndex = 1;
            this.language.Text = "LANGUAGE";
            this.language.UseVisualStyleBackColor = false;
            this.language.Click += new System.EventHandler(this.language_Click);
            // 
            // Math
            // 
            this.Math.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Math.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Math.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Math.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Math.FlatAppearance.BorderSize = 0;
            this.Math.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Math.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Math.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Math.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Math.Location = new System.Drawing.Point(0, -10);
            this.Math.Margin = new System.Windows.Forms.Padding(0);
            this.Math.Name = "Math";
            this.Math.Size = new System.Drawing.Size(275, 60);
            this.Math.TabIndex = 0;
            this.Math.Text = "MATH";
            this.Math.UseVisualStyleBackColor = false;
            this.Math.Click += new System.EventHandler(this.Math_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::WinFormProject.Properties.Resources._100;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(1077, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(23, 23);
            this.Exit.TabIndex = 10;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(980, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "main menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startingScreen1
            // 
            this.startingScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startingScreen1.BackgroundImage")));
            this.startingScreen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startingScreen1.Location = new System.Drawing.Point(0, 0);
            this.startingScreen1.Name = "startingScreen1";
            this.startingScreen1.Size = new System.Drawing.Size(1100, 600);
            this.startingScreen1.TabIndex = 9;
            // 
            // math1
            // 
            this.math1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.math1.Location = new System.Drawing.Point(0, 0);
            this.math1.Name = "math1";
            this.math1.Size = new System.Drawing.Size(1100, 550);
            this.math1.TabIndex = 4;
            // 
            // languages1
            // 
            this.languages1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.languages1.Location = new System.Drawing.Point(0, 0);
            this.languages1.Name = "languages1";
            this.languages1.Size = new System.Drawing.Size(1100, 550);
            this.languages1.TabIndex = 3;
            // 
            // science1
            // 
            this.science1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.science1.Location = new System.Drawing.Point(0, 0);
            this.science1.Name = "science1";
            this.science1.Size = new System.Drawing.Size(1100, 550);
            this.science1.TabIndex = 2;
            // 
            // brainGames1
            // 
            this.brainGames1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.brainGames1.Location = new System.Drawing.Point(0, 0);
            this.brainGames1.Name = "brainGames1";
            this.brainGames1.Size = new System.Drawing.Size(1100, 550);
            this.brainGames1.TabIndex = 1;
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.startingScreen1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.math1);
            this.Controls.Add(this.languages1);
            this.Controls.Add(this.science1);
            this.Controls.Add(this.brainGames1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button language;
        private System.Windows.Forms.Button Math;
        private System.Windows.Forms.Button braingames;
        private System.Windows.Forms.Button science;
        private BrainGames brainGames1;
        private science science1;
        private Languages languages1;
        private math math1;
        private StartingScreen startingScreen1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button1;
    }
}