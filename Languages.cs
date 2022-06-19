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
    public partial class Languages : UserControl
    {
        public Languages()
        {
            InitializeComponent();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;

            progressBar2.Minimum = 0;
            progressBar2.Maximum = 10;
        }

        private void lvl11_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lvl11.Show();
            lvl11.BringToFront();

        }

        private void Languages_Load(object sender, EventArgs e)
        {
            lvl11.Hide();
            lvl2language1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lvl2language1.Show();
            lvl2language1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = SaveLoad.l1;
            progressBar2.Value = SaveLoad.l2;
        }
    }
}
