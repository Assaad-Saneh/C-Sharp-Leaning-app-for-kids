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
    public partial class lvl1 : UserControl
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        Random random = new Random();
        int randchar;
        int nb;
        List<string> dict = new List<string>()
        {
            "the boy wake up early", "the weather was bad yesterday", "the artist painted the posters",
            "education is important", "i like playing football"
        };


        public lvl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("a, , b , , c , , d , ,e , f , ,g , ,h , ,i , ,j , ,k , ,l , ,m , ,n , ,o , ,p , ,q , ,r , ,s , ,t , ,u , ,v , ,w , ,x , ,y , ,z");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) /*next*/
        {
            if (panel1.Visible == true)
            {
                panel1.Hide();
                panel2.Show();
                panel2.BringToFront();
                previous.Show();
                previous.BringToFront();

            }
            else
            {
                if (panel2.Visible == true && (!(textBox1.Enabled || textBox2.Enabled || textBox3.Enabled) || SaveLoad.l1>=3))
                {
                    panel2.Hide();
                    panel3.Show();
                    panel3.BringToFront();
                    if (!(SaveLoad.l1 > 3))
                    {
                        SaveLoad.l1 = 3;
                    }
                }
                else
                {
                    if(panel3.Visible == true)
                    {
                        panel3.Hide();
                        panel4.Show();
                        panel4.BringToFront();
                    }
                    else
                    {
                        if(panel4.Visible == true && (label5.Text == "good job" || SaveLoad.l1 >=7))
                        {
                            panel4.Hide();
                            panel5.Show();
                            panel5.BringToFront();
                            if (!(SaveLoad.l1 > 7))
                            {
                                SaveLoad.l1 = 7;
                            }
                        }
                        else
                        {
                            if(panel5.Visible == true)
                            {
                                panel5.Hide();
                                panel6.Show();
                                panel6.BringToFront();
                                finish.Show();
                                next.Hide();
                            }
                        }
                    }
                }
            }
        }

        private void lvl1_Load(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
            panel2.Hide();
            previous.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel1.Show();
                panel1.BringToFront();
                panel2.Hide();
                previous.Hide();
            }
            else
            {
                if (panel3.Visible == true)
                {
                    panel3.Hide();
                    panel2.Show();
                    panel2.BringToFront();
                }
                else
                {
                    if(panel4.Visible == true)
                    {
                        panel4.Hide();
                        panel3.Show();
                        panel3.BringToFront();
                    }
                    else
                    {
                        if (panel5.Visible == true)
                        {
                            panel5.Hide();
                            panel4.Show();
                            panel4.BringToFront();
                        }
                        else
                        {
                            if(panel6.Visible == true)
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

        private void submit1p2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "a")
            {
                fb1.Text = "BRAVO";
                textBox1.Enabled = false;

            }
            else
                fb1.Text = "INCORRECT";

        }

        private void submit2p2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.ToLower() == "f")
            {
                fb2.Text = "BRAVO";
                textBox2.Enabled = false;

            }
            else
                fb2.Text = "INCORRECT";
        }

        private void submit3p2_Click(object sender, EventArgs e)
        {

            if (textBox3.Text.ToLower() == "m")
            {
                fb3.Text = "BRAVO";
                textBox3.Enabled = false;

            }
            else
                fb3.Text = "INCORRECT";
        }

        private void fb2_Click(object sender, EventArgs e)
        {

        }

        private void fb3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("insect");
        }

        private void x_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("xenops");
        }

        private void a_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("alligator");
        }

        private void b_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("bear");

        }

        private void c_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("cat");
        }

        private void d_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("dog");
        }

        private void e_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("elephant");
        }

        private void f_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("frog");
        }

        private void g_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("goose");
        }

        private void h_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("hoop");
        }

        private void j_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("jaguar");
        }

        private void k_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("kangaroo");
        }

        private void l_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("lizard");
        }

        private void m_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("moose");
        }

        private void n_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("newt");
        }

        private void o_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("octopus");
        }

        private void p_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("penguin");
        }

        private void q_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("quoll");
        }

        private void r_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("rabbit");
        }

        private void s_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("seal");
        }

        private void t_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("tiger");
        }

        private void u_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("unicorn");
        }

        private void v_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("viper");
        }

        private void w_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("whale");
        }

        private void y_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("yak");
        }

        private void z_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("zebra");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'C')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            randchar = random.Next(65, 91);
            questionp4.Text = ((char)randchar).ToString();
        }

        private void questionp4_Click(object sender, EventArgs e)
        {

        }

        private void ap4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'A')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void bp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'B')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void dp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'D')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void ep4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'E')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void fp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'F')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void gp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'G')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void hp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'H')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void ip4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'I')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void jp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'J')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void kp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'K')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void lp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'L')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void mp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'M')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void np4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'N')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void op4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'O')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void pp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'P')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void qp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'Q')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void rp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'R')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void sp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'S')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void tp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'T')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void up4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'U')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void vp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'V')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void wp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'W')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void xp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'X')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void yp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'Y')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void zp4_Click(object sender, EventArgs e)
        {
            if ((int)randchar == (int)'Z')
            {
                label5.Text = "good job";
            }
            else
                label5.Text = "try again";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void father_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("Father");
        }

        private void mother_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("mother");
        }

        private void brother_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("brother");
        }

        private void sister_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("sister");
        }

        private void uncle_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("uncle");
        }

        private void grandpa_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("grandpa");
        }

        private void grandma_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("grandma");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("a, airplane, ,b, bus, ,c, car, ,d, dog, ,e, egg, ,f, flower, ,g, giraffe, ,h, hedgehog, ,i, icecream, ,j, jar, ,k, kettle, ,l, lion, ,m, mustache, ,n, nest, ,o, orange, ,p, pigeon, ,q, queen, ,r, raisins, ,s, skirt, ,t, tights, ,u, umbrella, ,v, vegetables, ,w, watch, ,x, xylophone, ,y, yacht, ,z, zebra ");
        }

        private void dictation_Click(object sender, EventArgs e)
        {
            nb = random.Next(0, 5);
            speech.SpeakAsync(dict[nb]);
        }

        private void submitp6_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim().ToLower() == dict[nb])
            {
                feedback.Text = "great job";
            }
            else
                feedback.Text = "try again";
        }

        private void finish_Click(object sender, EventArgs e)
        {
            if (feedback.Text == "great job" || SaveLoad.l1 >= 10)
            {
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                textBox1.Enabled = true; textBox2.Enabled = true; textBox3.Enabled = true;
                feedback.Text = "";
                textBox4.Text = "";
                label5.Text = "";

                fb1.Text = string.Empty; fb2.Text = string.Empty; fb3.Text = string.Empty;

                questionp4.Text = "";
                //restarting the course to it's initial state.
                panel1.Show();
                panel1.BringToFront();
                panel2.Hide();
                previous.Hide();
                finish.Hide();
                next.Show();
                panel3.Hide();
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();

                SaveLoad.l1 = 10;

                this.Hide();
            }
        }

        private void submitp6_Click_1(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim().ToLower() == dict[nb])
            {
                feedback.Text = "great job";
            }
            else
                feedback.Text = "try again";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
