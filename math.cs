using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class math : UserControl
    {
        public math()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;

            progressBar2.Minimum = 0;
            progressBar2.Maximum = 10;

            progressBar3.Minimum = 0;
            progressBar3.Maximum = 10;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        // ===================================================================================== //

        private void math_Load(object sender, EventArgs e)
        {
            
        }
        //======================================================================================
        private void lvl1mathpic_Click(object sender, EventArgs e)
        {

        }
        private void lvl2mathpic_Click(object sender, EventArgs e)
        {
            lvl2math1.Show();
            lvl2math1.BringToFront();
        }

        private void lvl3mathpic_Click(object sender, EventArgs e)
        {
            shapes_lvl3math_1.Show();
            shapes_lvl3math_1.BringToFront();
        }

        private void lvl1math1_Load(object sender, EventArgs e)
        {

        }
        //=========================================================================================
        private void lvl1mathpic_Click_1(object sender, EventArgs e)
        {
            lvl1math1.Show();
            lvl1math1.BringToFront();
        }

        private void math_Load_1(object sender, EventArgs e)
        {
            lvl1math1.Hide();
            lvl2math1.Hide();
            shapes_lvl3math_1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = SaveLoad.m1;
            progressBar2.Value = SaveLoad.m2;
            progressBar3.Value = SaveLoad.m3;
        }
    }
}
