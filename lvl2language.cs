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
    public partial class lvl2language : UserControl
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        List<Image> images = new List<Image>();
        Random rand = new Random();
        Color col;
        int nb, n, nb1;
        string[] pronouns = new string[8];
        List<string> pron2 = new List<string>()
        {
           "I", "You","He","She","It","We","You(Plural)","They"
        };
        List<string> verbs = new List<string>
        {
           "to school (go)" , " early (sleep)" , " up late (wake)", "football (play)" , "pizza (eat) " , "the car (crash)" , "the doctor(visit)","(be)"
        };
        List<string> solutions = new List<string>
        {
            "went", "slept", "woke", "played", "ate", "crashed", "visited"
        };
        
        public lvl2language()
        {
            InitializeComponent();
            col = textBox1.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("i, you, ,he , ,she , ,it , ,we , ,you , ,they");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void anw2_Click(object sender, EventArgs e)
        {
            if (pron2.IndexOf(anw2.Text) == images.IndexOf(pictureBox2.BackgroundImage))
            {
                feedback.Text = "correct";
                anw1.Enabled = false;
                anw2.Enabled = false;
                anw3.Enabled = false;
                anw4.Enabled = false;
            }
            else
                feedback.Text = "incorrect"; ;
        }

        private void anw1_Click(object sender, EventArgs e)
        {
            if(pron2.IndexOf(anw1.Text)== images.IndexOf(pictureBox2.BackgroundImage))
            {
                feedback.Text = "correct";
                anw1.Enabled = false;
                anw2.Enabled = false;
                anw3.Enabled = false;
                anw4.Enabled = false;
            }
            else
                feedback.Text = "incorrect";
            //if (n == 0)
            //{
            //    feedback.Text = "correct";
            //    anw1.Enabled = false;
            //    anw2.Enabled = false;
            //    anw3.Enabled = false;
            //    anw4.Enabled = false;
            //}
            //else
            //    feedback.Text = "incorrect";
        }

        private void anw3_Click(object sender, EventArgs e)
        {
            if (pron2.IndexOf(anw3.Text) == images.IndexOf(pictureBox2.BackgroundImage))
            {
                feedback.Text = "correct";
                anw1.Enabled = false;
                anw2.Enabled = false;
                anw3.Enabled = false;
                anw4.Enabled = false;
            }
            else
                feedback.Text = "incorrect";
        }

        private void anw4_Click(object sender, EventArgs e)
        {
            if (pron2.IndexOf(anw4.Text) == images.IndexOf(pictureBox2.BackgroundImage))
            {
                feedback.Text = "correct";
                anw1.Enabled = false;
                anw2.Enabled = false;
                anw3.Enabled = false;
                anw4.Enabled = false;
            }
            else
                feedback.Text = "incorrect";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("for most verbs we add e , d  , , for example , mix becomes mixed , , , some verbs are irregular , , for example , do becomes did, , , some verbs stays the same , , cost stays cost  ");
        }

        private void enter(object sender, KeyPressEventArgs e)
        {
            if (panel4.Visible)
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    // Checking for ==textbox1==
                    if (verbs.IndexOf(label4.Text) < 7)
                    {
                        if (textBox1.Text.Trim().ToLower() == solutions[verbs.IndexOf(label4.Text)])
                        {
                            textBox1.BackColor = Color.LightGreen;
                            textBox1.Enabled = false;
                        }
                        else
                            textBox1.BackColor = Color.Red;
                    }
                    else
                    {
                        if (label1.Text == "I" | label1.Text == "he" || label1.Text == "she" || label1.Text == "it")
                        {
                            if (textBox1.Text.Trim().ToLower() == "was")
                            {
                                textBox1.BackColor = Color.LightGreen; textBox1.Enabled = false;
                            }
                            else
                                textBox1.BackColor = Color.Red;
                        }
                        else
                        {
                            if (textBox1.Text.Trim().ToLower() == "were")
                            {
                                textBox1.BackColor = Color.LightGreen; textBox1.Enabled = false;
                            }
                            else
                                textBox1.BackColor = Color.Red;
                        }

                    }


                    // Checking for ==textbox2==
                    if (verbs.IndexOf(label5.Text) < 7)
                    {
                        if (textBox2.Text.Trim().ToLower() == solutions[verbs.IndexOf(label5.Text)])
                        {
                            textBox2.BackColor = Color.LightGreen;
                            textBox2.Enabled = false;
                        }
                        else
                            textBox2.BackColor = Color.Red;
                    }
                    else
                    {
                        if (label2.Text == "I" | label2.Text == "he" || label2.Text == "she" || label2.Text == "it")
                        {
                            if (textBox2.Text.Trim().ToLower() == "was")
                            {
                                textBox2.BackColor = Color.LightGreen; textBox2.Enabled = false;
                            }
                            else
                                textBox2.BackColor = Color.Red;
                        }
                        else
                        {
                            if (textBox2.Text.Trim().ToLower() == "were")
                            {
                                textBox2.BackColor = Color.LightGreen; textBox2.Enabled = false;
                            }
                            else
                                textBox2.BackColor = Color.Red;
                        }

                    }


                    // Checking for ==textbox3==
                    if (verbs.IndexOf(label6.Text) < 7)
                    {
                        if (textBox3.Text.Trim().ToLower() == solutions[verbs.IndexOf(label6.Text)])
                        {
                            textBox3.BackColor = Color.LightGreen;
                            textBox3.Enabled = false;
                        }
                        else
                            textBox3.BackColor = Color.Red;
                    }
                    else
                    {
                        if (label3.Text == "I" | label3.Text == "he" || label3.Text == "she" || label3.Text == "it")
                        {
                            if (textBox3.Text.Trim().ToLower() == "was")
                            {
                                textBox3.BackColor = Color.LightGreen; textBox3.Enabled = false;
                            }
                            else
                                textBox3.BackColor = Color.Red;
                        }
                        else
                        {
                            if (textBox3.Text.Trim().ToLower() == "were")
                            {
                                textBox3.BackColor = Color.LightGreen; textBox3.Enabled = false;
                            }
                            else
                                textBox3.BackColor = Color.Red;
                        }

                    }
                }
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Hide();
                panel2.Show();
                previous.Show();
            }
            else
            {
                if (panel2.Visible && (feedback.Text == "correct"  || SaveLoad.l2 >= 5))
                {
                    panel2.Hide();
                    panel3.Show();
                    if (!(SaveLoad.l2 > 5))
                    {
                        SaveLoad.l2 = 5;
                    }
                }
                else
                {
                    if (panel3.Visible)
                    {
                        panel3.Hide();
                        panel4.Show();
                        next.Hide();
                        Finish.Show();
                    }
                }
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (panel4.Visible)
            {
                panel4.Hide();
                panel3.Show();
                Finish.Hide();
                next.Show();
            }
            else
            {
                if (panel3.Visible)
                {
                    panel2.Show();
                    panel3.Hide();
                }
                else
                {
                    if (panel2.Visible)
                    {
                        panel2.Hide();
                        panel1.Show();
                        previous.Hide();
                    }
                }
            }
        }

        private void Finish_Click(object sender, EventArgs e)
        {

            if ((textBox1.BackColor == Color.LightGreen && textBox2.BackColor == Color.LightGreen && textBox3.BackColor == Color.LightGreen) || SaveLoad.l2 >= 10)
            {
                textBox1.BackColor = col; textBox2.BackColor = col; textBox3.BackColor = col;
                textBox1.Text = "";textBox2.Text = "";textBox3.Text = "";
                textBox1.Enabled = true; textBox3.Enabled = true; textBox2.Enabled = true; 
                label1.Text = ""; label2.Text = ""; label3.Text = ""; label4.Text = "";label5.Text = ""; label6.Text = "";
                pictureBox2.BackgroundImage = Properties.Resources._null;
                anw1.Text = string.Empty; anw2.Text = string.Empty; anw3.Text = string.Empty; anw4.Text = string.Empty;
                anw1.Enabled = true;anw2.Enabled = true; anw3.Enabled = true;anw4.Enabled = true;
                feedback.Text = "";
                
                panel1.Show();
                panel2.Hide();
                panel3.Hide();
                panel4.Hide();
                
                previous.Hide();
                Finish.Hide();
                next.Show();
                
                label1.Text = pronouns[rand.Next(0, 8)];
                label2.Text = pronouns[rand.Next(0, 8)];
                label3.Text = pronouns[rand.Next(0, 8)];
                label4.Text = verbs[rand.Next(0, 8)];
                label5.Text = verbs[rand.Next(0, 8)];
                label6.Text = verbs[rand.Next(0, 8)];

                SaveLoad.l2 = 10;

                this.Hide(); 
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (panel4.Visible)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    if (verbs.IndexOf(label4.Text) < 7)
                    {
                        if (textBox1.Text.Trim().ToLower() == solutions[verbs.IndexOf(label4.Text)])
                        {
                            textBox1.BackColor = Color.LightGreen;
                            textBox1.Enabled = false;
                        }
                        else
                            textBox1.BackColor = Color.Red;textBox1.Enabled = true;
                    }
                    else
                    {
                        if (label1.Text == "I" || label1.Text == "he" || label1.Text == "she" || label1.Text == "it")
                        {
                            if (textBox1.Text.Trim().ToLower() == "was")
                            {
                                textBox1.BackColor = Color.LightGreen; textBox1.Enabled = false;
                            }
                            else
                                textBox1.BackColor = Color.Red; textBox1.Enabled = true;
                        }
                        else
                        {
                            if (textBox1.Text.Trim().ToLower() == "were")
                            {
                                textBox1.BackColor = Color.LightGreen; textBox1.Enabled = false;
                            }
                            else
                                textBox1.BackColor = Color.Red; textBox1.Enabled = true;
                        }

                    }



                    if (verbs.IndexOf(label5.Text) < 7)
                    {
                        if (textBox2.Text.Trim().ToLower() == solutions[verbs.IndexOf(label5.Text)])
                        {
                            textBox2.BackColor = Color.LightGreen;
                            textBox2.Enabled = false;
                        }
                        else
                            textBox2.BackColor = Color.Red; textBox2.Enabled = true;
                    }
                    else
                    {
                        if (label2.Text == "I" || label2.Text == "he" || label2.Text == "she" || label2.Text == "it")
                        {
                            if (textBox2.Text.Trim().ToLower() == "was")
                            {
                                textBox2.BackColor = Color.LightGreen; textBox2.Enabled = false;
                            }
                            else
                                textBox2.BackColor = Color.Red; textBox2.Enabled = true;
                        }
                        else
                        {
                            if (textBox2.Text.Trim().ToLower() == "were")
                            {
                                textBox2.BackColor = Color.LightGreen; textBox2.Enabled = false;
                            }
                            else
                                textBox2.BackColor = Color.Red;textBox2.Enabled = true;
                        }

                    }



                    if (verbs.IndexOf(label6.Text) < 7)
                    {
                        if (textBox3.Text.Trim().ToLower() == solutions[verbs.IndexOf(label6.Text)])
                        {
                            textBox3.BackColor = Color.LightGreen;
                            textBox3.Enabled = false;
                        }
                        else
                            textBox3.BackColor = Color.Red;textBox3.Enabled = true;
                    }
                    else
                    {
                        if (label3.Text == "I" || label3.Text == "he" || label3.Text == "she" || label3.Text == "it")
                        {
                            if (textBox3.Text.Trim().ToLower() == "was")
                            {
                                textBox3.BackColor = Color.LightGreen; textBox3.Enabled = false;
                            }
                            else
                                textBox3.BackColor = Color.Red; textBox3.Enabled = true;
                        }
                        else
                        {
                            if (textBox3.Text.Trim().ToLower() == "were")
                            {
                                textBox3.BackColor = Color.LightGreen; textBox3.Enabled = false;
                            }
                            else
                                textBox3.BackColor = Color.Red; textBox3.Enabled = true;
                        }

                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (panel4.Visible)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    if (verbs.IndexOf(label4.Text) < 7)
                    {
                        if (textBox1.Text.Trim().ToLower() == solutions[verbs.IndexOf(label4.Text)])
                        {
                            textBox1.BackColor = Color.LightGreen;
                            textBox1.Enabled = false;
                        }
                        else
                            textBox1.BackColor = Color.Red; textBox1.Enabled = true;
                    }
                    else
                    {
                        if (label1.Text == "I" || label1.Text == "he" || label1.Text == "she" || label1.Text == "it")
                        {
                            if (textBox1.Text.Trim().ToLower() == "was")
                            {
                                textBox1.BackColor = Color.LightGreen; textBox1.Enabled = false;
                            }
                            else
                                textBox1.BackColor = Color.Red; textBox1.Enabled = true;
                        }
                        else
                        {
                            if (textBox1.Text.Trim().ToLower() == "were")
                            {
                                textBox1.BackColor = Color.LightGreen; textBox1.Enabled = false;
                            }
                            else
                                textBox1.BackColor = Color.Red;textBox1.Enabled = true;
                        }

                    }



                    if (verbs.IndexOf(label5.Text) < 7)
                    {
                        if (textBox2.Text.Trim().ToLower() == solutions[verbs.IndexOf(label5.Text)])
                        {
                            textBox2.BackColor = Color.LightGreen;
                            textBox2.Enabled = false;
                        }
                        else
                            textBox2.BackColor = Color.Red; textBox2.Enabled = true;
                    }
                    else
                    {
                        if (label2.Text == "I" || label2.Text == "he" || label2.Text == "she" || label2.Text == "it")
                        {
                            if (textBox2.Text.Trim().ToLower() == "was")
                            {
                                textBox2.BackColor = Color.LightGreen; textBox2.Enabled = false;
                            }
                            else
                                textBox2.BackColor = Color.Red; textBox2.Enabled = true;
                        }
                        else
                        {
                            if (textBox2.Text.Trim().ToLower() == "were")
                            {
                                textBox2.BackColor = Color.LightGreen; textBox2.Enabled = false;
                            }
                            else
                                textBox2.BackColor = Color.Red;textBox2.Enabled = true;
                        }

                    }



                    if (verbs.IndexOf(label6.Text) < 7)
                    {
                        if (textBox3.Text.Trim().ToLower() == solutions[verbs.IndexOf(label6.Text)])
                        {
                            textBox3.BackColor = Color.LightGreen;
                            textBox3.Enabled = false;
                        }
                        else
                            textBox3.BackColor = Color.Red; textBox3.Enabled = true;
                    }
                    else
                    {
                        if (label3.Text == "I" || label3.Text == "he" || label3.Text == "she" || label3.Text == "it")
                        {
                            if (textBox3.Text.Trim().ToLower() == "was")
                            {
                                textBox3.BackColor = Color.LightGreen; textBox3.Enabled = false;
                            }
                            else
                                textBox3.BackColor = Color.Red; textBox3.Enabled = true;
                        }
                        else
                        {
                            if (textBox3.Text.Trim().ToLower() == "were")
                            {
                                textBox3.BackColor = Color.LightGreen; textBox3.Enabled = false;
                            }
                            else
                                textBox3.BackColor = Color.Red;textBox3.Enabled = true;
                        }

                    }
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (panel4.Visible)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {

                    if (verbs.IndexOf(label4.Text) < 7)
                    {
                        if (textBox1.Text.Trim().ToLower() == solutions[verbs.IndexOf(label4.Text)])
                        {
                            textBox1.BackColor = Color.LightGreen;
                            textBox1.Enabled = false;
                        }
                        else
                            textBox1.BackColor = Color.Red; textBox1.Enabled = true;
                    }
                    else
                    {
                        if (label1.Text == "I" || label1.Text == "he" || label1.Text == "she" || label1.Text == "it")
                        {
                            if (textBox1.Text.Trim().ToLower() == "was")
                            {
                                textBox1.BackColor = Color.LightGreen; textBox1.Enabled = false;
                            }
                            else
                                textBox1.BackColor = Color.Red; textBox1.Enabled = true;
                        }
                        else
                        {
                            if (textBox1.Text.Trim().ToLower() == "were")
                            {
                                textBox1.BackColor = Color.LightGreen; textBox1.Enabled = false;
                            }
                            else
                                textBox1.BackColor = Color.Red;textBox1.Enabled = true;
                        }

                    }



                    if (verbs.IndexOf(label5.Text) < 7)
                    {
                        if (textBox2.Text.Trim().ToLower() == solutions[verbs.IndexOf(label5.Text)])
                        {
                            textBox2.BackColor = Color.LightGreen;
                            textBox2.Enabled = false;
                        }
                        else
                            textBox2.BackColor = Color.Red; textBox2.Enabled = true;
                    }
                    else
                    {
                        if (label2.Text == "I" || label2.Text == "he" || label2.Text == "she" || label2.Text == "it")
                        {
                            if (textBox2.Text.Trim().ToLower() == "was")
                            {
                                textBox2.BackColor = Color.LightGreen; textBox2.Enabled = false;
                            }
                            else
                                textBox2.BackColor = Color.Red; textBox2.Enabled = true;
                        }
                        else
                        {
                            if (textBox2.Text.Trim().ToLower() == "were")
                            {
                                textBox2.BackColor = Color.LightGreen; textBox2.Enabled = false;
                            }
                            else
                                textBox2.BackColor = Color.Red;textBox2.Enabled = true;
                        }

                    }



                    if (verbs.IndexOf(label6.Text) < 7)
                    {
                        if (textBox3.Text.Trim().ToLower() == solutions[verbs.IndexOf(label6.Text)])
                        {
                            textBox3.BackColor = Color.LightGreen;
                            textBox3.Enabled = false;
                        }
                        else
                            textBox3.BackColor = Color.Red; textBox3.Enabled = true;
                    }
                    else
                    {
                        if (label3.Text == "I" || label3.Text == "he" || label3.Text == "she" || label3.Text == "it")
                        {
                            if (textBox3.Text.Trim().ToLower() == "was")
                            {
                                textBox3.BackColor = Color.LightGreen; textBox3.Enabled = false;
                            }
                            else
                                textBox3.BackColor = Color.Red;textBox3.Enabled = true;
                        }
                        else
                        {
                            if (textBox3.Text.Trim().ToLower() == "were")
                            {
                                textBox3.BackColor = Color.LightGreen; textBox3.Enabled = false;
                            }
                            else
                                textBox3.BackColor = Color.Red; textBox3.Enabled = true;
                        }

                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lvl2language_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            previous.Hide();
            Finish.Hide();

            images.Add(Properties.Resources.I);
            images.Add(Properties.Resources.you);
            images.Add(Properties.Resources.he);
            images.Add(Properties.Resources.she); 
            images.Add(Properties.Resources.it);
            images.Add(Properties.Resources.we);
            images.Add(Properties.Resources.you_p);
            images.Add(Properties.Resources.they);

            pronouns[0] = "I";
            pronouns[1] = "you";
            pronouns[2] = "he";
            pronouns[3] = "she";
            pronouns[4] = "it";
            pronouns[5] = "we";
            pronouns[6] = "you(plural)";
            pronouns[7] = "they";

            label1.Text = pronouns[rand.Next(0, 8)];
            label2.Text = pronouns[rand.Next(0, 8)];
            label3.Text = pronouns[rand.Next(0, 8)];
            label4.Text = verbs[rand.Next(0, 8)];
            label5.Text = verbs[rand.Next(0, 8)];
            label6.Text = verbs[rand.Next(0, 8)];
        }

        private void start_Click(object sender, EventArgs e)
        {
            nb = rand.Next(0, 8);
            pictureBox2.BackgroundImage = images[nb];
            nb1 = rand.Next(0, 4);
            List<string> pron = new List<string>()
            {
                "I", "You","He","She","It","We","You(Plural)","They"
            };

            switch (nb1)
            {
                case 0:
                    n = rand.Next(0, pron.Count);
                    anw1.Text = pron[nb];
                    pron.RemoveAt(nb);


                    n = rand.Next(0, pron.Count);
                    anw2.Text = pron[n];
                    pron.RemoveAt(n);


                    n = rand.Next(0, pron.Count);
                    anw3.Text = pron[n];
                    pron.RemoveAt(n);


                    n = rand.Next(0, pron.Count);
                    anw4.Text = pron[n];
                    pron.RemoveAt(n);
                    break;
                case 1:
                    n = rand.Next(0, pron.Count);
                    anw2.Text = pron[nb];
                    pron.RemoveAt(nb);

                    n = rand.Next(0, pron.Count);
                    anw1.Text = pron[n];
                    pron.RemoveAt(n);


                    n = rand.Next(0, pron.Count);
                    anw3.Text = pron[n];
                    pron.RemoveAt(n);


                    n = rand.Next(0, pron.Count);
                    anw4.Text = pron[n];
                    pron.RemoveAt(n);
                    break;
                case 2:
                    n = rand.Next(0, pron.Count);
                    anw3.Text = pron[nb];
                    pron.RemoveAt(nb);

                    n = rand.Next(0, pron.Count);
                    anw1.Text = pron[n];
                    pron.RemoveAt(n);


                    n = rand.Next(0, pron.Count);
                    anw2.Text = pron[n];
                    pron.RemoveAt(n);

                    n = rand.Next(0, pron.Count);
                    anw4.Text = pron[n];
                    pron.RemoveAt(n);
                    break;
                case 3:
                    n = rand.Next(0, pron.Count);
                    anw4.Text = pron[nb];
                    pron.RemoveAt(nb);

                    n = rand.Next(0, pron.Count);
                    anw1.Text = pron[n];
                    pron.RemoveAt(n);


                    n = rand.Next(0, pron.Count);
                    anw2.Text = pron[n];
                    pron.RemoveAt(n);


                    n = rand.Next(0, pron.Count);
                    anw3.Text = pron[n];
                    pron.RemoveAt(n);
                    break;
            }
            pron.Add("I"); pron.Add("You"); pron.Add("He"); pron.Add("She"); pron.Add("It"); pron.Add("We"); pron.Add("You(Plural)"); pron.Add("They");
        }
    }
}
