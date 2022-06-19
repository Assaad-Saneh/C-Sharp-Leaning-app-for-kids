namespace WinFormProject
{
    partial class science
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
            this.components = new System.ComponentModel.Container();
            this.Biology = new System.Windows.Forms.Label();
            this.Chemistry = new System.Windows.Forms.Label();
            this.Physics = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.biology1 = new WinFormProject.Biology();
            this.chemistry1 = new WinFormProject.chemistry();
            this.userControl11 = new WinFormProject.UserControl1();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Biology
            // 
            this.Biology.Font = new System.Drawing.Font("Swis721 BlkEx BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biology.Location = new System.Drawing.Point(40, 50);
            this.Biology.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Biology.Name = "Biology";
            this.Biology.Size = new System.Drawing.Size(280, 50);
            this.Biology.TabIndex = 3;
            this.Biology.Text = "Biology";
            this.Biology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chemistry
            // 
            this.Chemistry.Font = new System.Drawing.Font("Swis721 BlkEx BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chemistry.Location = new System.Drawing.Point(413, 50);
            this.Chemistry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Chemistry.Name = "Chemistry";
            this.Chemistry.Size = new System.Drawing.Size(280, 50);
            this.Chemistry.TabIndex = 4;
            this.Chemistry.Text = "Chemistry";
            this.Chemistry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Chemistry.Click += new System.EventHandler(this.Chemistry_Click);
            // 
            // Physics
            // 
            this.Physics.Font = new System.Drawing.Font("Swis721 BlkEx BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Physics.Location = new System.Drawing.Point(785, 50);
            this.Physics.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Physics.Name = "Physics";
            this.Physics.Size = new System.Drawing.Size(280, 50);
            this.Physics.TabIndex = 5;
            this.Physics.Text = "Physics";
            this.Physics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WinFormProject.Properties.Resources.chemistry2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(40, 140);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(280, 273);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WinFormProject.Properties.Resources.chemistry1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(785, 140);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 273);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinFormProject.Properties.Resources.chemistry3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(413, 140);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 273);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(785, 470);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(280, 30);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 6;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(413, 470);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(280, 30);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 7;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(40, 470);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(280, 30);
            this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar3.TabIndex = 8;
            // 
            // biology1
            // 
            this.biology1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.biology1.Location = new System.Drawing.Point(0, 0);
            this.biology1.Margin = new System.Windows.Forms.Padding(1);
            this.biology1.Name = "biology1";
            this.biology1.Size = new System.Drawing.Size(1100, 550);
            this.biology1.TabIndex = 9;
            // 
            // chemistry1
            // 
            this.chemistry1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chemistry1.Location = new System.Drawing.Point(0, 0);
            this.chemistry1.Margin = new System.Windows.Forms.Padding(2);
            this.chemistry1.Name = "chemistry1";
            this.chemistry1.Size = new System.Drawing.Size(1100, 550);
            this.chemistry1.TabIndex = 10;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.userControl11.ForeColor = System.Drawing.Color.White;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1100, 550);
            this.userControl11.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // science
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Physics);
            this.Controls.Add(this.Chemistry);
            this.Controls.Add(this.Biology);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.biology1);
            this.Controls.Add(this.chemistry1);
            this.Controls.Add(this.userControl11);
            this.Name = "science";
            this.Size = new System.Drawing.Size(1100, 550);
            this.Load += new System.EventHandler(this.science_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Biology;
        private System.Windows.Forms.Label Chemistry;
        private System.Windows.Forms.Label Physics;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private Biology biology1;
        private chemistry chemistry1;
        private UserControl1 userControl11;
        private System.Windows.Forms.Timer timer1;
    }
}
