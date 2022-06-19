namespace WinFormProject
{
    partial class math
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.lvl3mathpic = new System.Windows.Forms.PictureBox();
            this.lvl2mathpic = new System.Windows.Forms.PictureBox();
            this.lvl1mathpic = new System.Windows.Forms.PictureBox();
            this.lvl1math1 = new WinFormProject.lvl1math();
            this.shapes_lvl3math_1 = new WinFormProject.shapes_lvl3math_();
            this.lvl2math1 = new WinFormProject.lvl2math();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lvl3mathpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl2mathpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl1mathpic)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 470);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(275, 30);
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "1st step math";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Swis721 BlkEx BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "2nd step math";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Swis721 BlkEx BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(785, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shapes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(413, 470);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(275, 30);
            this.progressBar2.TabIndex = 7;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(785, 470);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(275, 30);
            this.progressBar3.TabIndex = 8;
            // 
            // lvl3mathpic
            // 
            this.lvl3mathpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lvl3mathpic.BackgroundImage = global::WinFormProject.Properties.Resources._20210114_143125;
            this.lvl3mathpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lvl3mathpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvl3mathpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvl3mathpic.Location = new System.Drawing.Point(785, 140);
            this.lvl3mathpic.Name = "lvl3mathpic";
            this.lvl3mathpic.Size = new System.Drawing.Size(275, 275);
            this.lvl3mathpic.TabIndex = 4;
            this.lvl3mathpic.TabStop = false;
            this.lvl3mathpic.Click += new System.EventHandler(this.lvl3mathpic_Click);
            // 
            // lvl2mathpic
            // 
            this.lvl2mathpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lvl2mathpic.BackgroundImage = global::WinFormProject.Properties.Resources._20210114_185229;
            this.lvl2mathpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lvl2mathpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvl2mathpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvl2mathpic.Location = new System.Drawing.Point(413, 140);
            this.lvl2mathpic.Name = "lvl2mathpic";
            this.lvl2mathpic.Size = new System.Drawing.Size(275, 275);
            this.lvl2mathpic.TabIndex = 3;
            this.lvl2mathpic.TabStop = false;
            this.lvl2mathpic.Click += new System.EventHandler(this.lvl2mathpic_Click);
            // 
            // lvl1mathpic
            // 
            this.lvl1mathpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lvl1mathpic.BackgroundImage = global::WinFormProject.Properties.Resources._20210113_210639;
            this.lvl1mathpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lvl1mathpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvl1mathpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvl1mathpic.Location = new System.Drawing.Point(40, 140);
            this.lvl1mathpic.Name = "lvl1mathpic";
            this.lvl1mathpic.Size = new System.Drawing.Size(275, 275);
            this.lvl1mathpic.TabIndex = 0;
            this.lvl1mathpic.TabStop = false;
            this.lvl1mathpic.Click += new System.EventHandler(this.lvl1mathpic_Click_1);
            // 
            // lvl1math1
            // 
            this.lvl1math1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lvl1math1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvl1math1.Location = new System.Drawing.Point(0, 3);
            this.lvl1math1.Name = "lvl1math1";
            this.lvl1math1.Size = new System.Drawing.Size(1100, 550);
            this.lvl1math1.TabIndex = 9;
            // 
            // shapes_lvl3math_1
            // 
            this.shapes_lvl3math_1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.shapes_lvl3math_1.Location = new System.Drawing.Point(0, 0);
            this.shapes_lvl3math_1.Name = "shapes_lvl3math_1";
            this.shapes_lvl3math_1.Size = new System.Drawing.Size(1100, 550);
            this.shapes_lvl3math_1.TabIndex = 10;
            // 
            // lvl2math1
            // 
            this.lvl2math1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lvl2math1.Location = new System.Drawing.Point(0, 0);
            this.lvl2math1.Name = "lvl2math1";
            this.lvl2math1.Size = new System.Drawing.Size(1100, 550);
            this.lvl2math1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // math
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvl3mathpic);
            this.Controls.Add(this.lvl2mathpic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lvl1mathpic);
            this.Controls.Add(this.lvl1math1);
            this.Controls.Add(this.shapes_lvl3math_1);
            this.Controls.Add(this.lvl2math1);
            this.Name = "math";
            this.Size = new System.Drawing.Size(1100, 550);
            this.Load += new System.EventHandler(this.math_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.lvl3mathpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl2mathpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl1mathpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lvl1mathpic;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox lvl2mathpic;
        private System.Windows.Forms.PictureBox lvl3mathpic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private lvl1math lvl1math1;
        private shapes_lvl3math_ shapes_lvl3math_1;
        private lvl2math lvl2math1;
        private System.Windows.Forms.Timer timer1;
    }
}
