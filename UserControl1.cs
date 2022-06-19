using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace WinFormProject
{
    public partial class UserControl1 : UserControl
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        int gravity = 10, f = 10, neg =1, h=10 , d=30, px,py ;
        public UserControl1()
        {
            InitializeComponent();
            panel1.Show();
            panel2.Hide();
            previous.Hide();
            Finish.Hide();

            timer1.Enabled = true;

            px = appleshell.Location.X;
            py = appleshell.Location.Y;
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel1.Show();
                panel1.BringToFront();
                panel2.Hide();
                next.Show();
                previous.Hide();
                Finish.Hide();
            }
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
            panel2.Hide();
            timer1.Enabled = true;
            timer2.Enabled = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            next.Show();
            previous.Hide();
            Finish.Hide();
            appleshell.Location = new Point(px, py);
            SaveLoad.s3 = 10;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("Gravity is the force of attraction that pulls together all  matter, that means really big objects like planets and stars have a stronger gravitational pull. The gravitational pull of an object depend on how massive it is.");
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Hide();
                panel2.Show();
                panel2.BringToFront();
                //next.Hide();
                previous.Show();
                Finish.Show();

                SaveLoad.s3 = 5;
            }
            else
            {
                EarthSunMoon esm = new EarthSunMoon();
                esm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            apple.Top += gravity;
            if(apple.Top >= 480)
            {
                apple.Top = 0;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            if (numericUpDown1.Value < 5 || numericUpDown1.Value > 15)
            {
                h = 10;
            }
            else
            {
                h = (Convert.ToInt32(numericUpDown1.Value));
            }

            if (numericUpDown2.Value < 10 || numericUpDown2.Value > 80)
            {
                d= 30;
            }
            else
            {
                d = Convert.ToInt32(numericUpDown2.Value);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 5 || numericUpDown1.Value > 15)
            {
                h = 10;
            }
            else
            {
                h = (Convert.ToInt32(numericUpDown1.Value));
            }

            if (numericUpDown2.Value < 10 || numericUpDown2.Value > 80)
            {
                d = 30;
            }
            else
            {
                d = Convert.ToInt32(numericUpDown2.Value);
            }
            // =================================================================================================================================
            if (f >= -h)
            {
                if (f < 0)
                {
                    neg = -1;
                }
                appleshell.Top -= Convert.ToInt32(neg * ((f * f) * 0.5));
                appleshell.Left += d;
                f -= 1;
            }
            else
            {
                appleshell.Location = new Point(px, py);
                neg = 1;
                f = h;
            }
        }
    }
}
