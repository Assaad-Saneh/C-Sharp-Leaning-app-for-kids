namespace WinFormProject
{
    partial class StartingScreen
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
            this.Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.give = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Grade = new System.Windows.Forms.Button();
            this.assignmentMakerTaker1 = new WinFormProject.AssignmentMakerTaker();
            this.assignmentTaker1 = new WinFormProject.AssignmentTaker();
            this.grading1 = new WinFormProject.grading();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Exit.Location = new System.Drawing.Point(530, 15);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(40, 40);
            this.Exit.TabIndex = 0;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WinFormProject.Properties.Resources.button_design_1610564625456;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(475, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 80);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(475, 265);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 25);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(432, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // give
            // 
            this.give.BackColor = System.Drawing.Color.Yellow;
            this.give.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.give.Cursor = System.Windows.Forms.Cursors.Hand;
            this.give.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.give.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.give.ForeColor = System.Drawing.Color.Blue;
            this.give.Location = new System.Drawing.Point(475, 296);
            this.give.Name = "give";
            this.give.Size = new System.Drawing.Size(72, 27);
            this.give.TabIndex = 4;
            this.give.Text = "Give";
            this.give.UseVisualStyleBackColor = false;
            this.give.Click += new System.EventHandler(this.give_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(475, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Solve Assignments";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grade
            // 
            this.Grade.BackColor = System.Drawing.Color.Yellow;
            this.Grade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Grade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grade.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade.ForeColor = System.Drawing.Color.Blue;
            this.Grade.Location = new System.Drawing.Point(553, 296);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(72, 27);
            this.Grade.TabIndex = 6;
            this.Grade.Text = "Grade";
            this.Grade.UseVisualStyleBackColor = false;
            this.Grade.Click += new System.EventHandler(this.Grade_Click);
            // 
            // assignmentMakerTaker1
            // 
            this.assignmentMakerTaker1.BackColor = System.Drawing.Color.LemonChiffon;
            this.assignmentMakerTaker1.Location = new System.Drawing.Point(0, 0);
            this.assignmentMakerTaker1.Name = "assignmentMakerTaker1";
            this.assignmentMakerTaker1.Size = new System.Drawing.Size(1100, 600);
            this.assignmentMakerTaker1.TabIndex = 7;
            this.assignmentMakerTaker1.Visible = false;
            // 
            // assignmentTaker1
            // 
            this.assignmentTaker1.BackColor = System.Drawing.Color.LemonChiffon;
            this.assignmentTaker1.Location = new System.Drawing.Point(0, 0);
            this.assignmentTaker1.Name = "assignmentTaker1";
            this.assignmentTaker1.Size = new System.Drawing.Size(1100, 600);
            this.assignmentTaker1.TabIndex = 8;
            this.assignmentTaker1.Visible = false;
            // 
            // grading1
            // 
            this.grading1.BackColor = System.Drawing.Color.LemonChiffon;
            this.grading1.Location = new System.Drawing.Point(0, 0);
            this.grading1.Name = "grading1";
            this.grading1.Size = new System.Drawing.Size(1100, 600);
            this.grading1.TabIndex = 10;
            this.grading1.Visible = false;
            // 
            // StartingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormProject.Properties.Resources.kidswp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.give);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.assignmentMakerTaker1);
            this.Controls.Add(this.assignmentTaker1);
            this.Controls.Add(this.grading1);
            this.Name = "StartingScreen";
            this.Size = new System.Drawing.Size(1100, 600);
            this.Load += new System.EventHandler(this.StartingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button give;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Grade;
        private AssignmentMakerTaker assignmentMakerTaker1;
        private AssignmentTaker assignmentTaker1;
        private grading grading1;
    }
}
