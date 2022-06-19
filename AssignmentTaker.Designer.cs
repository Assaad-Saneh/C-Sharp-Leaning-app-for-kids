namespace WinFormProject
{
    partial class AssignmentTaker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lang = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Math = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Given = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lang
            // 
            this.Lang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lang.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lang.Location = new System.Drawing.Point(3, 285);
            this.Lang.Name = "Lang";
            this.Lang.Size = new System.Drawing.Size(220, 100);
            this.Lang.TabIndex = 5;
            this.Lang.Text = "language";
            this.Lang.UseVisualStyleBackColor = false;
            this.Lang.Click += new System.EventHandler(this.Lang_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 100);
            this.button1.TabIndex = 4;
            this.button1.Text = "science";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Math
            // 
            this.Math.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Math.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Math.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Math.Location = new System.Drawing.Point(3, 140);
            this.Math.Name = "Math";
            this.Math.Size = new System.Drawing.Size(220, 100);
            this.Math.TabIndex = 3;
            this.Math.Text = "math";
            this.Math.UseVisualStyleBackColor = false;
            this.Math.Click += new System.EventHandler(this.Math_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 76);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pick The Subject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.White;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(3, 558);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(220, 39);
            this.submit.TabIndex = 9;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Submition :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(256, 262);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(841, 335);
            this.textBox2.TabIndex = 10;
            // 
            // Given
            // 
            this.Given.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Given.Location = new System.Drawing.Point(253, 10);
            this.Given.Name = "Given";
            this.Given.Size = new System.Drawing.Size(100, 19);
            this.Given.TabIndex = 12;
            this.Given.Text = "Assignment :";
            this.Given.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(844, 198);
            this.label2.TabIndex = 13;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::WinFormProject.Properties.Resources.backbutton100_2_;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(40, 40);
            this.BackButton.TabIndex = 14;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AssignmentTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Given);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Math);
            this.Name = "AssignmentTaker";
            this.Size = new System.Drawing.Size(1100, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Math;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Given;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackButton;
    }
}
