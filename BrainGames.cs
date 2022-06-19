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
    public partial class BrainGames : UserControl
    {
        bool memogame = false;
        public BrainGames()
        {
            InitializeComponent();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;

            progressBar2.Minimum = 0;
            progressBar2.Maximum = 10;
        }

        private void BrainGames_Load(object sender, EventArgs e)
        {
            memorygame1.Hide();
            puzzlegame1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            memorygame1.Show();
            memorygame1.BringToFront();
            memogame = true;
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            memorygame1.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (memogame)
            {
                memorygame1.Hide();
                memogame = false;
                return; 
            }

            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            puzzlegame1.Show();
            puzzlegame1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = SaveLoad.b1;
            progressBar2.Value = SaveLoad.b2;
        }
    }
}
