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
    public partial class shapes_lvl3math_ : UserControl
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        Random ran = new Random();
        int nb;

        public shapes_lvl3math_()
        {
            InitializeComponent();
        }

        private void shapes_lvl3math__Load(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
            previous.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
        }

        private void speaker1_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("The ,  lesson , will ,be, about , basic , shapes , like, , circle, , triangle, , square, ,rectangle");
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Hide();
                panel2.Show();
                panel2.BringToFront();
                previous.Show();
            }
            else
            {
                if (panel2.Visible && (fb_p2.Text == "Good job!" || SaveLoad.m3 >= 2))
                {
                    panel2.Hide();
                    panel3.Show();
                    panel3.BringToFront();
                    if (!(SaveLoad.m3 > 2))
                    {
                        SaveLoad.m3 = 2;
                    }
                }
                else
                {
                    if (panel3.Visible && (fb3.Text == "Good job!"|| SaveLoad.m3 >= 4))
                    {
                        panel3.Hide();
                        panel4.Show();
                        panel4.BringToFront();
                        if (!(SaveLoad.m3 > 4))
                        {
                            SaveLoad.m3 = 4;
                        }
                    }
                    else
                    {
                        if (panel4.Visible && (fb4.Text == "Good job!" || SaveLoad.m3 >= 4))
                        {
                            panel4.Hide();
                            panel5.Show();
                            panel5.BringToFront();
                            if (!(SaveLoad.m3 > 6))
                            {
                                SaveLoad.m3 = 6;
                            }
                        }
                        else
                        {
                            if (panel5.Visible && (fb5.Text == "Good job!"|| SaveLoad.m3 >= 8))
                            {
                                panel5.Hide();
                                panel6.Show();
                                panel6.BringToFront();
                                finish.Show();
                                if (!(SaveLoad.m3 > 8))
                                {
                                    SaveLoad.m3 = 8;
                                }
                            }
                            else
                            {
                                if(panel6.Visible && (fb6.Text == "You did it!" || SaveLoad.m3 >= 10))
                                {
                                    var paint = new Paint();
                                    paint.Show();
                                    paint.BringToFront();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void speacker2_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("A triangle has 3 sides, It's like a pizza slice, ,Could  you figure out which of the following is a triangle ?");
        }

        private void trianglepic_Click(object sender, EventArgs e)
        {
            fb_p2.Text = "Good job!";
        }

        private void circlepic_Click(object sender, EventArgs e)
        {
            fb_p2.Text = "try again";
        }

        private void squarepic_Click(object sender, EventArgs e)
        {
            fb_p2.Text = "try again";
        }

        private void rectpic_Click(object sender, EventArgs e)
        {
            fb_p2.Text = "try again";
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Hide();
                panel1.Show();
                panel1.BringToFront();
            }
            else
            {
                if (panel3.Visible)
                {
                    panel3.Hide();
                    panel2.Show();
                    panel2.BringToFront();
                }
                else
                {
                    if (panel4.Visible)
                    {
                        panel4.Hide();
                        panel3.Show();
                        panel3.BringToFront();
                    }
                    else
                    {
                        if (panel5.Visible)
                        {
                            panel5.Hide();
                            panel4.Show();
                            panel4.BringToFront();
                        }
                        else
                        {
                            if (panel6.Visible)
                            {
                                panel6.Hide();
                                panel5.Show();
                                panel5.BringToFront();
                                next.Show();
                                finish.Hide();
                            }
                        }
                    }
                }
            }
        }

        private void speacker3_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("A rectangle has 4 sides, and each 2 sides are equal and parallel, ,it's like your laptop screen, ,Could you figure out which of the following is a rectangle?");
        }

        private void rect3_Click(object sender, EventArgs e)
        {
            fb3.Text = "Good job!";
        }

        private void triangle3_Click(object sender, EventArgs e)
        {
            fb3.Text = "try again";
        }

        private void circle3_Click(object sender, EventArgs e)
        {
            fb3.Text = "try again";
        }

        private void square3_Click(object sender, EventArgs e)
        {
            fb3.Text = "try again";
        }

        private void circle4_Click(object sender, EventArgs e)
        {
            fb4.Text = "Good job!";
        }

        private void triangle4_Click(object sender, EventArgs e)
        {
            fb3.Text = "try again";
        }

        private void square4_Click(object sender, EventArgs e)
        {
            fb4.Text = "try again";
        }

        private void rect4_Click(object sender, EventArgs e)
        {
            fb4.Text = "try again";
        }

        private void sq5_Click(object sender, EventArgs e)
        {
            fb5.Text = "Good job!";
        }

        private void cir5_Click(object sender, EventArgs e)
        {
            fb5.Text = "try again";
        }

        private void tri5_Click(object sender, EventArgs e)
        {
            fb5.Text = "try again";
        }

        private void rect5_Click(object sender, EventArgs e)
        {
            fb5.Text = "try again";
        }

        private void speaker5_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("A square is an object with 4 equal and parallel sides, it's like a dice ,Could you figure out which of the following is a square ?");
        }

        private void speaker4_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("A circle is a round object with no sides, it's like a ball, Could you figure out which of the following is a circle ?");
        }

        private void start_Click(object sender, EventArgs e)
        {
            submit.Show();
            nb = ran.Next(0, 5);
            label3.Text = "What is that shape?";

            switch (nb)
            {
                case 0:
                    tri.Show();
                    cir.Hide();
                    rect.Hide();
                    squ.Hide();
                    break;

                case 1:
                    cir.Show();
                    tri.Hide();
                    rect.Hide();
                    squ.Hide();
                    break;

                case 2:
                    squ.Show();
                    cir.Hide();
                    rect.Hide();
                    tri.Hide();
                    break;

                case 3:
                    rect.Show();
                    squ.Hide();
                    cir.Hide();
                    tri.Hide();
                    break;

                default:
                    cir.Show();
                    tri.Hide();
                    rect.Hide();
                    squ.Hide();
                    break;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            switch (nb)
            {
                case 0:
                    if (textBox1.Text.Trim().ToLower() == "triangle")
                    {
                        fb6.Text = "You did it!";
                    }
                    else
                        fb6.Text = "Wrong";
                    break;

                case 1:
                    if (textBox1.Text.Trim().ToLower() == "circle")
                    {
                        fb6.Text = "You did it!";
                    }
                    else
                        fb6.Text = "Wrong"; 
                    break;

                case 2:
                    if (textBox1.Text.Trim().ToLower() == "square")
                    {
                        fb6.Text = "You did it!";
                    }
                    else
                        fb6.Text = "Wrong";
                    break;

                case 3:
                    if (textBox1.Text.Trim().ToLower() == "rectangle")
                    {
                        fb6.Text = "You did it!";
                    }
                    else
                        fb6.Text = "Wrong";
                    break;

                default:
                    if (textBox1.Text.Trim().ToLower() == "circle")
                    {
                        fb6.Text = "You did it!";
                    }
                    else
                        fb6.Text = "Wrong";
                    break;
            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
            if (fb6.Text == "You did it!" ||SaveLoad.m3 >= 10)
            {
                textBox1.Text = string.Empty;
                fb_p2.Text = string.Empty;
                fb3.Text = string.Empty;
                fb4.Text = string.Empty;
                fb5.Text = string.Empty;
                fb6.Text = string.Empty;

                rect.Hide();
                cir.Hide();
                tri.Hide();
                squ.Hide();

                next.Show();
                previous.Hide();
                finish.Hide();

                panel1.Show();
                panel1.BringToFront();
                panel6.Hide();

                SaveLoad.m3 = 10;

                this.Hide();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
