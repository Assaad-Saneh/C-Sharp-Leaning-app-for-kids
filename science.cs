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
    public partial class science : UserControl
    {
        public science()
        {
            InitializeComponent();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;

            progressBar2.Minimum = 0;
            progressBar2.Maximum = 10;

            progressBar3.Minimum = 0;
            progressBar3.Maximum = 10;
        }

        private void science_Load(object sender, EventArgs e)
        {
            biology1.Hide();
            chemistry1.Hide();
            userControl11.Hide();
        }

        private void Chemistry_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            biology1.Show();
            biology1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            chemistry1.Show();
            chemistry1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = SaveLoad.s3;
            progressBar2.Value = SaveLoad.s2;
            progressBar3.Value = SaveLoad.s1;
        }
    }
}
