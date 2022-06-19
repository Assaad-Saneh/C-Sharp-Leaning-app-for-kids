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
    public partial class Biology : UserControl
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        Random random = new Random();
        List<Image> animal = new List<Image>();
        bool sun = false, wind = false, grown = false;
        int l1x, l1y, l2x, l2y, l3x, l3y, l4x, l4y, ax,ay;
        public Biology()
        {
            InitializeComponent();
            animal.Add(Properties.Resources.wolf);
            animal.Add(Properties.Resources.asaad_aam_yetsabah);
            animal.Add(Properties.Resources.asaad_bel_mina);
            animal.Add(Properties.Resources.asaad_el_asle);
            animal.Add(Properties.Resources.asaad_fi_lsahra);
            animal.Add(Properties.Resources.asaad_lness);
            animal.Add(Properties.Resources.octopus);
            animal.Add(Properties.Resources.etoile_de_mer);
            animal.Add(Properties.Resources.crab);
            animal.Add(Properties.Resources.buuterfly);

            l1x = pictureBox4.Location.X; l1y = pictureBox4.Location.Y;
            l2x = pictureBox3.Location.X; l2y = pictureBox3.Location.Y;
            l3x = pictureBox7.Location.X; l3y = pictureBox7.Location.Y;
            l4x = pictureBox6.Location.X; l4y = pictureBox6.Location.Y;

            ax = arrosoire.Location.X; ay = arrosoire.Location.Y;
        }

        private void Biology_Load(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            Previous.Hide();
            Finish.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync ("Animals are classified into two groups vertebrates and invertrevrates, ,Vertebrates are animals that have a backbone or spinal column, also called vertebrae. These animals include fish, birds, mammals, amphibians, and reptiles, ,Invertebrates are animals that neither possess nor develop a vertebral column, ,These animals include, insects arachnids crustaceans mollusk wroms sponges");

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if(panel2.Visible)
            {
                Previous.Hide();
                panel2.Hide();
                panel1.Show();

            }
            else
            {
                if (panel3.Visible)
                {
                    panel3.Hide();
                    panel2.Show();
                    
                }
                else
                {
                    if (panel4.Visible)
                    {
                        panel4.Hide();
                        panel3.Show();
                        Next.Show();
                        Finish.Hide();
                        
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vertebrate_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = animal[random.Next(0, 10)];
            pictureBox7.BackgroundImage= animal[random.Next(0, 10)];
            pictureBox6.BackgroundImage = animal[random.Next(0, 10)];
            pictureBox4.BackgroundImage = animal[random.Next(0, 10)];
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlExtension.Draggable(pictureBox3, true);
            ControlExtension.Draggable(pictureBox7, true);
            ControlExtension.Draggable(pictureBox6, true);
            ControlExtension.Draggable(pictureBox4, true);

        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (animal.IndexOf(pictureBox3.BackgroundImage) < 5)
                {
                    if (pictureBox3.Right < button2.Left)
                    {
                        label1.Text = "picture 1 is correct ";
                    }
                    else
                    {
                        label1.Text = "picture 1 is incorrect";
                    }

                }
                else
                {
                    if (pictureBox3.Left > button3.Right)
                    {
                        label1.Text = "picture 1 is correct ";
                    }
                    else
                    {
                        label1.Text = "picture 1 is incorrect";
                    }
                }
                if (animal.IndexOf(pictureBox7.BackgroundImage) < 5)
                {
                    if (pictureBox7.Right < button2.Left)
                    {
                        label2.Text = "picture 2 is correct ";
                    }
                    else
                    {
                        label2.Text = "picture 2 is incorrect";
                    }

                }
                else
                {
                    if (pictureBox7.Left > button3.Right)
                    {
                        label2.Text = "picture 2 is correct ";
                    }
                    else
                    {
                        label2.Text = "picture 2 is incorrect";
                    }
                }
                if (animal.IndexOf(pictureBox6.BackgroundImage) < 5)
                {
                    if (pictureBox6.Right < button2.Left)
                    {
                        label3.Text = "picture 3 is correct ";
                    }

                    else
                    {
                        label3.Text = "picture 3 is incorrect";
                    }

                }
                else
                {
                    if (pictureBox6.Left > button3.Right)
                    {
                        label3.Text = "picture 3 is correct ";
                    }
                    else
                    {
                        label3.Text = "picture 3 is incorrect";
                    }
                }
                if (animal.IndexOf(pictureBox4.BackgroundImage) < 5)
                {
                    if (pictureBox4.Right < button2.Left)
                    {
                        label4.Text = "picture 4 is correct ";
                    }
                    else
                    {
                        label4.Text = "picture 4 is incorrect";
                    }

                }
                else
                {
                    if (pictureBox4.Left > button3.Right)
                    {
                        label4.Text = "picture 4 is correct ";
                    }
                    else
                    {
                        label4.Text = "picture 4 is incorrect";
                    }
                }
            }
            catch { }

            if(label1.Text == "picture 1 is correct " && label2.Text == "picture 2 is correct " && label3.Text == "picture 3 is correct " && label4.Text == "picture 4 is correct ")
            {
                if (!(SaveLoad.s1 > 5))
                {
                    SaveLoad.s1 = 5;
                }
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("for a plant to grow it need , , water , , carbon dioxide from the air , , minerals from the soil , , sunlight ");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            window.BackgroundImage = Properties.Resources.open_window;
            wind = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            sunpic.BackgroundImage = Properties.Resources.sahebto_la_asaaad;
            sun = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlExtension.Draggable(arrosoire, true);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((wind) && (sun) && (arrosoire.Bottom < plant.Top) &&(arrosoire.Left >= plant.Left) && (arrosoire.Left <= plant.Right))
            {
                plant.BackgroundImage = Properties.Resources.closed_one;
                grown = true;
            }
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            if (grown || SaveLoad.s1 >= 10)
            {
                pictureBox4.Location = new Point(l1x, l1y); ;
                pictureBox4.BackgroundImage = Properties.Resources._null;
                pictureBox3.Location = new Point(l2x, l2y);
                pictureBox3.BackgroundImage = Properties.Resources._null;
                pictureBox6.Location = new Point(l3x, l3y);
                pictureBox6.BackgroundImage = Properties.Resources._null;
                pictureBox7.Location = new Point(l4x, l4y);
                pictureBox7.BackgroundImage = Properties.Resources._null;
                label1.Text = string.Empty; label2.Text = string.Empty; label3.Text = string.Empty; label4.Text = string.Empty;

                arrosoire.Location = new Point(ax, ay);
                sunpic.BackgroundImage = Properties.Resources.barade_hendiye;
                window.BackgroundImage = Properties.Resources.closed_window2;
                plant.BackgroundImage = Properties.Resources.far_window;

                Previous.Hide();
                Finish.Hide();
                Next.Show();
                panel4.Hide();
                panel1.Show();
            
                SaveLoad.s1 = 10;

                this.Hide();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Hide();
                panel2.Show();
                Previous.Show();
            }
            else
            {
                if (panel2.Visible && ((label1.Text == "picture 1 is correct " && label2.Text == "picture 2 is correct " && label3.Text == "picture 3 is correct "&& label4.Text == "picture 4 is correct ") || SaveLoad.s1 >= 5))
                {
                    panel2.Hide();
                    panel3.Show();
                }
                else
                {
                    if (panel3.Visible)
                    {
                        panel3.Hide();
                        panel4.Show();
                        Finish.Show();
                        Next.Hide();
                    }

                }
            }

        }
    }
}
