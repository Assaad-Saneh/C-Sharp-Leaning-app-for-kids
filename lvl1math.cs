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
    public partial class lvl1math : UserControl
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        Random random = new Random();
        int n1, n2;

        public lvl1math()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("This is how you count numbers from ,one, to ,ten," +
                ", try repeating after me, ," +
                "one, , two, , three, , four, , five, , six, , seven, , eight, , nine, , ten.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("you can use your fingers to count, ,one, , two, , three, , four, , five, , six, , seven, , eight, , nine, , ten.");
        }

        private void lvl1math_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {

        }

        private void prevbtn_Click(object sender, EventArgs e)
        {

        }

        private void sub1_Click(object sender, EventArgs e)
        {
            if (q1_5.Checked)
            {
                feedback1.Text = "Good job !";
                q1_1.Enabled = false;
                q1_5.Enabled = false;
                q1_8.Enabled = false;
            }
            else
                feedback1.Text = "Try again";
        }

        private void sub2_Click(object sender, EventArgs e)
        {
            if (q2_2.Checked)
            {
                feedback2.Text = "Good job !";
                q2_2.Enabled = false;
                q2_6.Enabled = false;
                q2_10.Enabled = false;
            }
            else
                feedback2.Text = "Try again";
        }

        private void sound11_20_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("Those are the numbers that comes after ten, try repeating after me, , " +
                "eleven, , twelve, , thirteen, , fourteen, , fifteen, , sixteen, , seventeen, , eighteen, , niynteen, , twenty, , ," +
                ",you can't count those numbers on your hands.");
        }

        private void sub1_p4_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 3)
            {
                fb1p4.Text = "Great!!";
                numericUpDown1.Enabled = false;
            }
            else
                fb1p4.Text = "Incorrect";
        }

        private void sub2_p4_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 18)
            {
                fb2p4.Text = "Great!!";
                numericUpDown2.Enabled = false;
            }
            else
                fb2p4.Text = "Incorrect";
        }

        private void sub3_p4_Click(object sender, EventArgs e)
        {
            if (numericUpDown3.Value == 15)
            {
                fb3p4.Text = "Great!!";
                numericUpDown3.Enabled = false;
            }
            else
                fb3p4.Text = "Incorrect";
        }

        private void next1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            panel2.BringToFront();
        }

        private void next2_Click(object sender, EventArgs e)
        {
            if ((q1_5.Enabled == false && q2_2.Enabled == false)||SaveLoad.m1 >= 2)
            {
                panel2.Hide();
                panel3.Show();
                panel3.BringToFront();
                if (!(SaveLoad.m1 > 2))
                {
                    SaveLoad.m1 = 2;
                }
            }
        }

        private void previous2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
            panel1.BringToFront();
        }

        private void next3_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel4.Show();
            panel4.BringToFront();
        }

        private void previous3_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel2.Show();
            panel2.BringToFront();
        }

        private void previous4_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            panel3.Show();
            panel3.BringToFront();
        }

        private void next4_Click(object sender, EventArgs e)
        {
            if ((numericUpDown1.Enabled == false && numericUpDown2.Enabled == false && numericUpDown3.Enabled == false) || SaveLoad.m1 >= 4)
            {
                panel4.Hide();
                panel5.Show();
                panel5.BringToFront();
                if (! (SaveLoad.m1 > 4)) 
                {
                    SaveLoad.m1 = 4;

                }
            }
        }

        private void previous5_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel4.Show();
            panel4.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "Seven" || textBox1.Text == "seven")
            {
                p5fb1.Text = "Bravoo!!";
                textBox1.Enabled = false;
            }
            else
                p5fb1.Text = "Try Again";

            if (textBox2.Text.Trim() == "thirteen" || textBox2.Text.Trim() == "Thirteen")
            {
                p5fb2.Text = "Bravo!!";
                textBox2.Enabled = false;
            }
            else
                p5fb2.Text = "Try Again";

            if (textBox3.Text.Trim() == "three" || textBox3.Text.Trim() == "Thee")
            {
                p5fb3.Text = "Bravo!!";
                textBox3.Enabled = false;
            }
            else
                p5fb3.Text = "Try Again";

            if (textBox4.Text.Trim() == "eleven" || textBox4.Text.Trim() == "Eleven")
            {
                p5fb4.Text = "Bravo!!";
                textBox4.Enabled = false;
            }
            else
                p5fb4.Text = "Try Again";

            if (textBox5.Text.Trim() == "sixteen" || textBox5.Text.Trim() == "Sixteen")
            {
                p5fb5.Text = "Bravo!!";
                textBox5.Enabled = false;
            }
            else
                p5fb5.Text = "Try Again";

            if (textBox6.Text.Trim() == "twenty" || textBox6.Text.Trim() == "Twenty")
            {
                p5fb6.Text = "Bravo!!";
                textBox6.Enabled = false;
            }
            else
                p5fb6.Text = "Try Again";
        }

        private void next5_Click(object sender, EventArgs e)
        {
            if((!(textBox1.Enabled && textBox2.Enabled && textBox3.Enabled && textBox4.Enabled && textBox5.Enabled && textBox6.Enabled)) || SaveLoad.m1 >= 8)
            {
                panel6.Show();
                panel6.BringToFront();
                panel5.Hide();

                if (!(SaveLoad.m1 > 8))
                {
                    SaveLoad.m1 = 8;
                }
            }
        }

        private void previous6_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            panel5.Show();
            panel5.BringToFront();
        }

        private void lvl1math_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            n1 = random.Next(0, 10);
            n2 = random.Next(0, 10);
            cq11.Text = Convert.ToString(n1);
            cq12.Text = Convert.ToString(n2);

            n1 = random.Next(0, 10);
            n2 = random.Next(0, 10);
            cq21.Text = Convert.ToString(n1);
            cq22.Text = Convert.ToString(n2);

            n1 = random.Next(0, 10);
            n2 = random.Next(0, 10);
            cq31.Text = Convert.ToString(n1);
            cq32.Text = Convert.ToString(n2);

            n1 = random.Next(0, 10);
            n2 = random.Next(0, 10);
            cq31.Text = Convert.ToString(n1);
            cq32.Text = Convert.ToString(n2);

            n1 = random.Next(0, 10);
            n2 = random.Next(0, 10);
            cq41.Text = Convert.ToString(n1);
            cq42.Text = Convert.ToString(n2);

            n1 = random.Next(0, 10);
            n2 = random.Next(0, 10);
            cq51.Text = Convert.ToString(n1);
            cq52.Text = Convert.ToString(n2);

            n1 = random.Next(0, 10);
            n2 = random.Next(0, 10);
            cq61.Text = Convert.ToString(n1);
            cq62.Text = Convert.ToString(n2);
        }

        private void finish_Click(object sender, EventArgs e)
        {
            if (!(e1.Enabled && e2.Enabled && e3.Enabled && e4.Enabled && e5.Enabled && e6.Enabled) || SaveLoad.m1 >=10)
            {
                l1.Checked = false;l2.Checked = false;l3.Checked = false;l4.Checked = false;l5.Checked = false;l6.Checked = false;
                g1.Checked = false;g2.Checked = false;g3.Checked = false;g4.Checked = false;g5.Checked = false;g6.Checked = false;
                e1.Checked = false;e2.Checked = false ;e3.Checked = false;e4.Checked = false;e5.Checked = false;e6.Checked = false;
                l1.Enabled = true; l2.Enabled = true; l3.Enabled = true; l4.Enabled = true; l5.Enabled = true; l6.Enabled = true;
                g1.Enabled = true; g2.Enabled = true; g3.Enabled = true; g4.Enabled = true; g5.Enabled = true; g6.Enabled = true;
                e1.Enabled = true; e2.Enabled = true; e3.Enabled = true; e4.Enabled = true; e5.Enabled = true; e6.Enabled = true;
                fb1.Text = string.Empty; fb2.Text = string.Empty; fb3.Text = string.Empty; fb4.Text = string.Empty; fb5.Text = string.Empty; fb6.Text = string.Empty;
                cq11.Text = string.Empty; cq12.Text = string.Empty;
                cq21.Text = string.Empty; cq22.Text = string.Empty;
                cq31.Text = string.Empty; cq32.Text = string.Empty;
                cq41.Text = string.Empty; cq42.Text = string.Empty;
                cq51.Text = string.Empty; cq52.Text = string.Empty;
                cq61.Text = string.Empty; cq62.Text = string.Empty;

                p5fb1.Text = string.Empty; p5fb2.Text = string.Empty; p5fb3.Text = string.Empty; p5fb4.Text = string.Empty; p5fb5.Text = string.Empty; p5fb6.Text = string.Empty;
                textBox1.Text = string.Empty; textBox2.Text = string.Empty; textBox3.Text = string.Empty; textBox4.Text = string.Empty; textBox5.Text = string.Empty; textBox6.Text = string.Empty;
                textBox1.Enabled = true; textBox2.Enabled = true; textBox3.Enabled = true; textBox4.Enabled = true; textBox5.Enabled = true; textBox6.Enabled = true;

                numericUpDown1.Value = 0; numericUpDown2.Value = 0;numericUpDown3.Value = 0;
                numericUpDown1.Enabled = true; numericUpDown2.Enabled = true; numericUpDown3.Enabled = true;
                fb1p4.Text = string.Empty; fb2p4.Text = string.Empty; fb3p4.Text = string.Empty;

                q1_1.Checked = false;q1_5.Checked = false; q1_8.Checked = false;q2_10.Checked = false;q2_2.Checked = false;q2_6.Checked = false;
                q1_1.Enabled =true; q1_5.Enabled = true; q1_8.Enabled = true; q2_10.Enabled = true; q2_2.Enabled = true; q2_6.Enabled = true;
                feedback1.Text = string.Empty;feedback2.Text = string.Empty;

                panel1.Show();
                panel1.BringToFront();

                SaveLoad.m1 = 10;

                this.Hide();
            }
        }

        private void previous7_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            panel6.Show();
            panel6.BringToFront();
        }

        private void next6_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            panel7.Show();
            panel7.BringToFront();
        }

        private void lvl1math_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {

                //===========================q1================================================================
                if (Convert.ToInt32(cq11.Text) > Convert.ToInt32(cq12.Text))
                {
                    if (g1.Checked)
                    {
                        l1.Enabled = false; g1.Enabled = false; e1.Enabled = false; fb1.Text = "True";
                    }
                    else
                        fb1.Text = "False";
                }
                else
                {
                    if (Convert.ToInt32(cq11.Text) < Convert.ToInt32(cq12.Text))
                    {
                        if (l1.Checked)
                        {
                            l1.Enabled = false; g1.Enabled = false; e1.Enabled = false; fb1.Text = "True";
                        }
                        else
                            fb1.Text = "False";
                    }
                    else
                    {
                        if (Convert.ToInt32(cq11.Text) == Convert.ToInt32(cq12.Text))
                        {
                            if (e1.Checked)
                            {
                                l1.Enabled = false; g1.Enabled = false; e1.Enabled = false; fb1.Text = "True";
                            }
                            else
                                fb1.Text = "False";
                        }
                    }
                }
                //==============================q2===================================================================
                if (Convert.ToInt32(cq21.Text) > Convert.ToInt32(cq22.Text))
                {
                    if (g2.Checked)
                    {
                        l2.Enabled = false; g2.Enabled = false; e2.Enabled = false; fb2.Text = "True";
                    }
                    else
                        fb2.Text = "False";
                }
                else
                {
                    if (Convert.ToInt32(cq21.Text) < Convert.ToInt32(cq22.Text))
                    {
                        if (l2.Checked)
                        {
                            l2.Enabled = false; g2.Enabled = false; e2.Enabled = false; fb2.Text = "True";
                        }
                        else
                            fb2.Text = "False";
                    }
                    else
                    {
                        if (Convert.ToInt32(cq21.Text) == Convert.ToInt32(cq22.Text))
                        {
                            if (e2.Checked)
                            {
                                l2.Enabled = false; g2.Enabled = false; e2.Enabled = false; fb2.Text = "True";
                            }
                            else
                                fb2.Text = "False";
                        }
                    }
                }
                //=======================================q3====================================================================
                if (Convert.ToInt32(cq31.Text) > Convert.ToInt32(cq32.Text))
                {
                    if (g3.Checked)
                    {
                        l3.Enabled = false; g3.Enabled = false; e3.Enabled = false; fb3.Text = "True";
                    }
                    else
                        fb3.Text = "False";
                }
                else
                {
                    if (Convert.ToInt32(cq31.Text) < Convert.ToInt32(cq32.Text))
                    {
                        if (l3.Checked)
                        {
                            l3.Enabled = false; g3.Enabled = false; e3.Enabled = false; fb3.Text = "True";
                        }
                        else
                            fb3.Text = "False";
                    }
                    else
                    {
                        if (Convert.ToInt32(cq31.Text) == Convert.ToInt32(cq32.Text))
                        {
                            if (e3.Checked)
                            {
                                l3.Enabled = false; g3.Enabled = false; e3.Enabled = false; fb3.Text = "True";
                            }
                            else
                                fb3.Text = "False";
                        }
                    }
                }
                // =====================================================q4=======================================================
                if (Convert.ToInt32(cq41.Text) > Convert.ToInt32(cq42.Text))
                {
                    if (g4.Checked)
                    {
                        l4.Enabled = false; g4.Enabled = false; e4.Enabled = false; fb4.Text = "True";
                    }
                    else
                        fb4.Text = "False";
                }
                else
                {
                    if (Convert.ToInt32(cq41.Text) < Convert.ToInt32(cq42.Text))
                    {
                        if (l4.Checked)
                        {
                            l4.Enabled = false; g4.Enabled = false; e4.Enabled = false; fb4.Text = "True";
                        }
                        else
                            fb4.Text = "False";
                    }
                    else
                    {
                        if (Convert.ToInt32(cq41.Text) == Convert.ToInt32(cq42.Text))
                        {
                            if (e4.Checked)
                            {
                                l4.Enabled = false; g4.Enabled = false; e4.Enabled = false; fb4.Text = "True";
                            }
                            else
                                fb4.Text = "False";
                        }
                    }
                }
                //===============================================q5=======================================================
                if (Convert.ToInt32(cq51.Text) > Convert.ToInt32(cq52.Text))
                {
                    if (g5.Checked)
                    {
                        l5.Enabled = false; g5.Enabled = false; e5.Enabled = false; fb5.Text = "True";
                    }
                    else
                        fb5.Text = "False";
                }
                else
                {
                    if (Convert.ToInt32(cq51.Text) < Convert.ToInt32(cq52.Text))
                    {
                        if (l5.Checked)
                        {
                            l5.Enabled = false; g5.Enabled = false; e5.Enabled = false; fb5.Text = "True";
                        }
                        else
                            fb5.Text = "False";
                    }
                    else
                    {
                        if (Convert.ToInt32(cq51.Text) == Convert.ToInt32(cq52.Text))
                        {
                            if (e5.Checked)
                            {
                                l5.Enabled = false; g5.Enabled = false; e5.Enabled = false; fb5.Text = "True";
                            }
                            else
                                fb5.Text = "False";
                        }
                    }
                }
                //===============================================q6=============================================================
                if (Convert.ToInt32(cq61.Text) > Convert.ToInt32(cq62.Text))
                {
                    if (g6.Checked)
                    {
                        l6.Enabled = false; g6.Enabled = false; e6.Enabled = false; fb6.Text = "True";
                    }
                    else
                        fb6.Text = "False";
                }
                else
                {
                    if (Convert.ToInt32(cq61.Text) < Convert.ToInt32(cq62.Text))
                    {
                        if (l6.Checked)
                        {
                            l6.Enabled = false; g6.Enabled = false; e6.Enabled = false; fb6.Text = "True";
                        }
                        else
                            fb6.Text = "False";
                    }
                    else
                    {
                        if (Convert.ToInt32(cq61.Text) == Convert.ToInt32(cq62.Text))
                        {
                            if (e6.Checked)
                            {
                                l6.Enabled = false; g6.Enabled = false; e6.Enabled = false; fb6.Text = "True";
                            }
                            else
                                fb6.Text = "False";
                        }
                    }
                }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void speakerp6_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("Here is the concept of comparison, we use less than , , greater than , , and = to compare 2 numbers:, , , " +
                "we use less than symbol to say that the number on left is SMALLER THAN the number on the right:, , 2 less than 7, , ," +
                "we use greater than symbol to say that the number on left is GREATER THAN the number on the right:, , 8 greater than 3, , ," +
                "finally, we use = to say that both numbers are equale:, ,  5 = 5");
        }
    }
}
