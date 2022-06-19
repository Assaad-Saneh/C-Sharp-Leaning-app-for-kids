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
    public partial class lvl2math : UserControl
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        Random random = new Random();
        bool rclicked = false, cclicked = false, clicked = false;

        public lvl2math()
        {
            InitializeComponent();
        }


        private void lvl2math_Load(object sender, EventArgs e)
        {

            panel1.Show();
            previous.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            Finish.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("Now we will learn about basic arthmetics, ,Addition, Substraction, Multiplication and Division");
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                previous.Show();
                panel1.Hide();
                panel2.Show();
                panel2.BringToFront();
            }
            else
            {
                if (panel2.Visible && ((label3.Visible && label6.Visible) || SaveLoad.m2 >=2))
                {
                    panel2.Hide();
                    panel3.Show();
                    panel3.BringToFront();
                    if (!(SaveLoad.m2 > 2))
                    {
                        SaveLoad.m2 = 2;
                    }
                }
                else
                {
                    if (panel3.Visible && (!(numericUpDown1.Enabled && numericUpDown2.Enabled &&numericUpDown3.Enabled && numericUpDown4.Enabled) || SaveLoad.m2 >= 4))
                    {
                        panel3.Hide();
                        panel4.Show();
                        panel4.BringToFront();
                        if (!(SaveLoad.m2 > 4))
                        {
                            SaveLoad.m2 = 4;
                        }
                    }
                    else
                    {
                        if (panel4.Visible)
                        {
                            panel4.Hide();
                            panel5.Show();
                            panel5.BringToFront();
                        }
                        else
                        {
                            if (panel5.Visible && (!(s1p5.Enabled || s2p5.Enabled || s3p5.Enabled || s4p5.Enabled)|| SaveLoad.m2 >= 6))
                            {
                                panel5.Hide();
                                panel6.Show();
                                panel6.BringToFront();
                                if (!(SaveLoad.m2 > 6))
                                {
                                    SaveLoad.m2 = 6;
                                }
                            }
                            else
                            {
                                if (panel6.Visible)
                                {
                                    panel6.Hide();
                                    panel7.Show();
                                    panel7.BringToFront();
                                }
                                else
                                {
                                    if (panel7.Visible && ((!num1.Enabled && !num2.Enabled) || SaveLoad.m2 >= 8))
                                    {
                                        panel7.Hide();
                                        panel8.Show();
                                        panel8.BringToFront();
                                        if (!(SaveLoad.m2 > 8))
                                        {
                                            SaveLoad.m2 = 8;
                                        }
                                    }
                                    else
                                    {
                                        if (panel8.Visible)
                                        {
                                            panel8.Hide();
                                            panel9.Show();
                                            panel9.BringToFront();
                                            Finish.Show();
                                            next.Hide();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void previous_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Hide();
                panel1.Show();panel1.BringToFront();
                previous.Hide();
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
                            }
                            else
                            {
                                if (panel7.Visible)
                                {
                                    panel7.Hide();
                                    panel6.Show();
                                    panel6.BringToFront();
                                }
                                else
                                {
                                    if (panel8.Visible)
                                    {
                                        panel8.Hide();
                                        panel7.Show();
                                        panel7.BringToFront();
                                    }
                                    else
                                    {
                                        if (panel9.Visible)
                                        {
                                            panel9.Hide();
                                            panel8.Show();
                                            panel8.BringToFront();
                                            next.Show();
                                            Finish.Hide();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void spkp2_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("Addition, is, when, you, add, more, than, one, number, in, order, to, get, the, sum, of, them");
        }

        private void q1s2_Click(object sender, EventArgs e)
        {
            label3.Show();
        }

        private void q2s3_Click(object sender, EventArgs e)
        {
            label6.Show();
        }

        private void q1s1_Click(object sender, EventArgs e)
        {
            label5.Show();
        }

        private void q1s3_Click(object sender, EventArgs e)
        {
            label4.Show();
        }

        private void q2s1_Click(object sender, EventArgs e)
        {
            label8.Show();
        }

        private void q2s2_Click(object sender, EventArgs e)
        {
            label7.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown1.Value == (Convert.ToInt32(b1.Text) + Convert.ToInt32(b2.Text)))
                {
                    numericUpDown1.BackColor = Color.Lime;
                    numericUpDown1.Enabled = false;
                }
                else
                    numericUpDown1.BackColor = Color.Red;

                if (numericUpDown2.Value == (Convert.ToInt32(b3.Text) + Convert.ToInt32(b4.Text)))
                {
                    numericUpDown2.BackColor = Color.Lime;
                    numericUpDown2.Enabled = false;
                }
                else
                    numericUpDown2.BackColor = Color.Red;

                if (numericUpDown3.Value == (Convert.ToInt32(b5.Text) + Convert.ToInt32(b6.Text)))
                {
                    numericUpDown3.BackColor = Color.Lime;
                    numericUpDown3.Enabled = false;
                }
                else
                    numericUpDown3.BackColor = Color.Red;

                if (numericUpDown4.Value == (Convert.ToInt32(b7.Text) + Convert.ToInt32(b8.Text) + Convert.ToInt32(b9.Text)))
                {
                    numericUpDown4.BackColor = Color.Lime;
                    numericUpDown4.Enabled = false;
                }
                else
                    numericUpDown4.BackColor = Color.Red;
            }
            catch { }
        }

        private void start_Click(object sender, EventArgs e)
        {
            b1.Text = random.Next(0, 10).ToString();
            b2.Text = random.Next(0, 10).ToString();
            b3.Text = random.Next(0, 10).ToString();
            b4.Text = random.Next(0, 10).ToString();
            b5.Text = random.Next(0, 10).ToString();
            b6.Text = random.Next(0, 10).ToString();
            b7.Text = random.Next(0, 10).ToString();
            b8.Text = random.Next(0, 10).ToString();
            b9.Text = random.Next(0, 10).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("Substraction is when you have a number and you take from it a certain quantity, therefore, substracting from it.");
        }

        private void startp5_Click(object sender, EventArgs e)
        {
            q11p5.Text = Convert.ToString(random.Next(0, 10));
            q12p5.Text = Convert.ToString(random.Next(0, Convert.ToInt32(q11p5.Text)));

            q21p5.Text = Convert.ToString(random.Next(0, 10));
            q22p5.Text = Convert.ToString(random.Next(0, Convert.ToInt32(q21p5.Text)));

            q31p5.Text = Convert.ToString(random.Next(0, 10));
            q32p5.Text = Convert.ToString(random.Next(0, Convert.ToInt32(q31p5.Text)));

            q41p5.Text = Convert.ToString(random.Next(0, 10));
            q42p5.Text = Convert.ToString(random.Next(0, Convert.ToInt32(q41p5.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("Multiplication is when you add the same number to itself multiple times");
        }

        private void startp7_Click(object sender, EventArgs e)
        {
            q11p7.Text = Convert.ToString(random.Next(0, 10));
            q12p7.Text = Convert.ToString(random.Next(0, 10));
            q21p7.Text = Convert.ToString(random.Next(0, 10));
            q22p7.Text = Convert.ToString(random.Next(0, 10));
        }

        private void submitp7_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1.Value == Convert.ToInt32(q11p7.Text) * Convert.ToInt32(q12p7.Text))
                {
                    num1.BackColor = Color.Lime;
                    num1.Enabled = false;
                }
                else
                    num1.BackColor = Color.Red;

                if (num2.Value == Convert.ToInt32(q21p7.Text) * Convert.ToInt32(q22p7.Text))
                {
                    num2.BackColor = Color.Lime;
                    num2.Enabled = false;
                }
                else
                    num2.BackColor = Color.Red;
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("Division is finding the number that, when multiplied by the denomenator, gives the numerator");
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            if ((!num2p9.Enabled && !num2p9.Enabled) || SaveLoad.m2 >= 10)
            {
                num1p9.Value = 0; num1p9.BackColor = Color.White; num2p9.Value = 0; num2p9.BackColor = Color.White;
                num1p9.Enabled = true;num2p9.Enabled = true;
                q11p9.Text = string.Empty;q12p9.Text = string.Empty; q21p9.Text = string.Empty; q22p9.Text = string.Empty;

                num1.Value = 0; num1.BackColor = Color.White; num2.Value = 0; num2.BackColor = Color.White;
                num1.Enabled = true; num2.Enabled = true;
                q11p7.Text = string.Empty; q12p7.Text = string.Empty; q21p7.Text = string.Empty; q22p7.Text = string.Empty;

                q11p5.Text = string.Empty;q12p5.Text = string.Empty; q21p5.Text = string.Empty; q22p5.Text = string.Empty; q31p5.Text = string.Empty; q32p5.Text = string.Empty; q41p5.Text = string.Empty; q42p5.Text = string.Empty;
                s1p5.BackColor = Color.White; s2p5.BackColor = Color.White; s3p5.BackColor = Color.White; s4p5.BackColor = Color.White;
                s1p5.Enabled = true; s2p5.Enabled = true; s3p5.Enabled = true; s4p5.Enabled = true;
                s1p5.Value = 0; s2p5.Value = 0; s3p5.Value = 0; s4p5.Value = 0;

                b1.Text = string.Empty; b2.Text = string.Empty; b3.Text = string.Empty; b4.Text = string.Empty; b5.Text = string.Empty; b6.Text = string.Empty; b7.Text = string.Empty; b8.Text = string.Empty; b9.Text = string.Empty;
                numericUpDown1.Value = 0;numericUpDown1.Enabled = true;numericUpDown1.BackColor = Color.White;
                numericUpDown2.Value = 0; numericUpDown2.Enabled = true; numericUpDown2.BackColor = Color.White;
                numericUpDown3.Value = 0; numericUpDown3.Enabled = true; numericUpDown3.BackColor = Color.White;
                numericUpDown4.Value = 0; numericUpDown4.Enabled = true; numericUpDown4.BackColor = Color.White;

                label3.Hide(); label4.Hide(); label5.Hide(); label6.Hide(); label7.Hide(); label8.Hide();

                panel1.Show();
                panel1.BringToFront();
                panel9.Hide();
                Finish.Hide();
                previous.Hide();
                next.Show();

                SaveLoad.m2 = 10;

                this.Hide();
            }
        }

        private void startp9_Click(object sender, EventArgs e)
        {
            int n1 = random.Next(1, 11);
            int n2 = random.Next(1, 11);
            q11p9.Text = Convert.ToString(n1 * random.Next(1,11));
            q12p9.Text = Convert.ToString(n1);
            q21p9.Text = Convert.ToString(n2 * random.Next(1, 11));
            q22p9.Text = Convert.ToString(n2);
        }

        private void submitp9_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1p9.Value == Convert.ToInt32(q11p9.Text) / Convert.ToInt32(q12p9.Text))
                {
                    num1p9.Enabled = false;
                    num1p9.BackColor = Color.Lime;
                }
                else
                    num1p9.BackColor = Color.Red;

                if (num2p9.Value == Convert.ToInt32(q21p9.Text) / Convert.ToInt32(q22p9.Text))
                {
                    num2p9.Enabled = false;
                    num2p9.BackColor = Color.Lime;
                }
                else
                    num2p9.BackColor = Color.Red;
            }
            catch { }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitp5_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1p5.Value == Convert.ToInt32(q11p5.Text) - Convert.ToInt32(q12p5.Text))
                {
                    s1p5.Enabled = false;
                    s1p5.BackColor = Color.Lime;
                }
                else
                {
                    s1p5.BackColor = Color.Red;
                }

                if (s2p5.Value == Convert.ToInt32(q21p5.Text) - Convert.ToInt32(q22p5.Text))
                {
                    s2p5.Enabled = false;
                    s2p5.BackColor = Color.Lime;
                }
                else
                {
                    s2p5.BackColor = Color.Red;
                }

                if (s3p5.Value == Convert.ToInt32(q31p5.Text) - Convert.ToInt32(q32p5.Text))
                {
                    s3p5.Enabled = false;
                    s3p5.BackColor = Color.Lime;
                }
                else
                {
                    s3p5.BackColor = Color.Red;
                }

                if (s4p5.Value == Convert.ToInt32(q41p5.Text) - Convert.ToInt32(q42p5.Text))
                {
                    s4p5.Enabled = false;
                    s4p5.BackColor = Color.Lime;
                }
                else
                {
                    s4p5.BackColor = Color.Red;
                }
            }
            catch { }
        }
        //==============================================================================================================================================================================
        private void label_Click(object sender, EventArgs e)
        {
            Label clickedlabel = sender as Label;
            if (clickedlabel == null)
            { return; }

            if (clickedlabel.Location.X <= 50)
            {
                var y = clickedlabel.Location.Y;
                if (cclicked == false)
                {
                    for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                    {
                        if (tableLayoutPanel1.Controls[i] is Label && tableLayoutPanel1.Controls[i].Location.Y == y)
                        {
                            tableLayoutPanel1.Controls[i].BackColor = Color.Gold;
                        }
                    }
                    cclicked = true;
                    
                }
                else
                {
                    for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                    {
                        tableLayoutPanel1.Controls[i].BackColor = Color.Blue;
                    }
                    cclicked = false;
                }
            }
            else
            {
                if (clickedlabel.Location.Y <= 45)
                {
                    if (!rclicked)
                    {
                        var x = clickedlabel.Location.X;

                        for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                        {
                            if (tableLayoutPanel1.Controls[i] is Label && tableLayoutPanel1.Controls[i].Location.X == x)
                            {
                                tableLayoutPanel1.Controls[i].BackColor = Color.Gold;
                            }
                        }
                        rclicked = true;
                    }
                    else
                    {
                        for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                        {
                            tableLayoutPanel1.Controls[i].BackColor = Color.Blue;
                        }
                        rclicked = false;
                    }
                }
                else
                {
                    if ((clickedlabel.Location.Y != 1 && clickedlabel.Location.X != 4) && !clicked)
                    {
                        if (rclicked || cclicked)
                        {
                            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                            {
                                if (tableLayoutPanel1.Controls[i] is Label)
                                    tableLayoutPanel1.Controls[i].BackColor = Color.Blue;
                            }
                        }

                        cclicked = false; rclicked = false;
                        clicked = true;

                        var x = clickedlabel.Location.X;
                        var y = clickedlabel.Location.Y;

                        for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                        {
                            if (tableLayoutPanel1.Controls[i] is Label)
                            {
                                if (tableLayoutPanel1.Controls[i].Location.X == x || tableLayoutPanel1.Controls[i].Location.Y == y)
                                {
                                    tableLayoutPanel1.Controls[i].BackColor = Color.Gold;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                        {
                            tableLayoutPanel1.Controls[i].BackColor = Color.Blue;
                        }
                        rclicked = false; cclicked = false;
                        clicked = false;
                    }
                }
            }
            //==========================================================================================================================================================================
        }
    }
}
