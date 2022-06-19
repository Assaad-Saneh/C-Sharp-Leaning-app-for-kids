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
    public partial class chemistry : UserControl
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        Random random = new Random();
        List<string> product = new List<string>
        {
            "NaH"  , "HCl", "BrH" , "LiF" , "NaF" , "ClF" , "NaCl" , "LiCl" ,  "LiBr",  "BrF", "CO", "NO"
        };
        bool c1 = false, c2 = false;
        public chemistry()
        {
            InitializeComponent();
        }

        private void chemistry_Load(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
            panel2.Hide();
            panel3.Hide();
            panel6.Hide();
            Previous.Hide();
            Finish.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("The constituents of the atom are protons, , neutrons, , and electrons, ,  The protons and neutrons (nucleons) are found in the nucleus of atoms, , The nucleus of an atom is surrounded by empty space , , in which there are electrons.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Hide();
                panel1.Show();
                Previous.Hide();
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
                    if (panel6.Visible)
                    {
                        panel6.Hide();
                        Finish.Hide();
                        Next.Show();
                        panel3.Show();
                    }
                }
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().ToLower() == "proton")
            {
                textBox1.BackColor = Color.LimeGreen;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (textBox2.Text.Trim().ToLower() == "electron")
            {
                textBox2.BackColor = Color.LimeGreen;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (textBox3.Text.Trim().ToLower() == "neutron")
            {
                textBox3.BackColor = Color.LimeGreen;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if(textBox1.BackColor == Color.LimeGreen && textBox2.BackColor == Color.LimeGreen && textBox3.BackColor == Color.LimeGreen)
            {
                if (!(SaveLoad.s2 > 5))
                {
                    SaveLoad.s2 = 5;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speech.SpeakAsync("a table of the chemical elements arranged in order of atomic number, usually in rows, so that elements with similar atomic structure appear in vertical columns");
        }

        private void F_Click(object sender, EventArgs e)
        {
            if (!c1 )
            {
                F.FlatAppearance.BorderColor = Color.Yellow;
                F.ForeColor = Color.Yellow;
                c1 = true;
            }
            else
            {
                if (!c2)
                {
                    F.FlatAppearance.BorderColor = Color.Yellow;
                    F.ForeColor = Color.Yellow;
                    c2 = true; 
                }
            }
        }

        private void Li_Click(object sender, EventArgs e)
        {
            if (!c1)
            {
                Li.FlatAppearance.BorderColor = Color.Yellow;
                Li.ForeColor = Color.Yellow;
                c1 = true;
            }
            else
            {
                if (!c2)
                {
                    Li.FlatAppearance.BorderColor = Color.Yellow;
                    Li.ForeColor = Color.Yellow;
                    c2 = true;
                }
            }
        }

        private void H_Click(object sender, EventArgs e)
        {
            if (!c1)
            {
                H.FlatAppearance.BorderColor = Color.Yellow;
                H.ForeColor = Color.Yellow;
                c1 = true;
            }
            else
            {
                if (!c2)
                {
                    H.FlatAppearance.BorderColor = Color.Yellow;
                    H.ForeColor = Color.Yellow;
                    c2 = true;
                }
            }
        }

        private void Na_Click(object sender, EventArgs e)
        {
            if (!c1)
            {
                Na.FlatAppearance.BorderColor = Color.Yellow;
                Na.ForeColor = Color.Yellow;
                c1 = true;
            }
            else
            {
                if (!c2)
                {
                    Na.FlatAppearance.BorderColor = Color.Yellow;
                    Na.ForeColor = Color.Yellow;
                    c2 = true;
                }
            }
        }

        private void Cl_Click(object sender, EventArgs e)
        {
            if (!c1)
            {
                Cl.FlatAppearance.BorderColor = Color.Yellow;
                Cl.ForeColor = Color.Yellow;
                c1 = true;
            }
            else
            {
                if (!c2)
                {
                   Cl.FlatAppearance.BorderColor = Color.Yellow;
                    Cl.ForeColor = Color.Yellow;
                    c2 = true;
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            label3.Text = product[random.Next(0, product.Count)];
        }

        private void submitp4_Click(object sender, EventArgs e)
        {
            try
            {
                switch (product.IndexOf(label3.Text))
                {
                    case 0:
                        if (Na.ForeColor == Color.Yellow && H.ForeColor == Color.Yellow)
                            label4.Text = "You did it!!";
                        else
                            label4.Text = "wrong, retry";
                        break;
                    case 1:
                        if (Cl.ForeColor == Color.Yellow && H.ForeColor == Color.Yellow)
                            label4.Text = "You did it!!";
                        else
                            label4.Text = "wrong, retry";
                        break;
                    case 2:
                        if (Br.ForeColor == Color.Yellow && H.ForeColor == Color.Yellow)
                            label4.Text = "You did it!!";
                        else
                            label4.Text = "wrong, retry";
                        break;
                    case 3:
                        if (Li.ForeColor == Color.Yellow && F.ForeColor == Color.Yellow)
                            label4.Text = "You did it!!";
                        else
                            label4.Text = "wrong, retry";
                        break;
                    case 4:
                        if (Na.ForeColor == Color.Yellow && F.ForeColor == Color.Yellow)
                            label4.Text = "You did it!!";
                        else
                            label4.Text = "wrong, retry";
                        break;
                    case 5:
                        if (Cl.ForeColor == Color.Yellow && F.ForeColor == Color.Yellow)
                            label4.Text = "You did it!!";
                        else
                            label4.Text = "wrong, retry";
                        break;
                    case 6:
                        if (Cl.ForeColor == Color.Yellow && Na.ForeColor == Color.Yellow)
                            label4.Text = "You did it!!";
                        else
                            label4.Text = "wrong, retry";
                        break;
                    case 7:
                        if (Cl.ForeColor == Color.Yellow && Li.ForeColor == Color.Yellow)
                            label4.Text = "You did it!!";
                        else
                            label4.Text = "wrong, retry";
                        break;
                    case 8:
                        if (Br.ForeColor == Color.Yellow && Li.ForeColor == Color.Yellow)
                            label4.Text = "You did it!!";
                        else
                            label4.Text = "wrong, retry";
                        break;
                    case 9:
                        if (Br.ForeColor == Color.Yellow && F.ForeColor == Color.Yellow)
                            label4.Text = "You did it!!";
                        else
                            label4.Text = "wrong, retry";
                        break;
                    case 10:
                        if (C.ForeColor == Color.Yellow && O.ForeColor == Color.Yellow)
                            label4.Text = "You did it!!";
                        else
                            label4.Text = "wrong, retry";
                        break;
                    case 11:
                        if (N.ForeColor == Color.Yellow && O.ForeColor == Color.Yellow)
                            label4.Text = "You did it!!";
                        else
                            label4.Text = "wrong, retry";
                        break;
                }
            }
            catch { }
            Na.ForeColor = Color.Red;Na.FlatAppearance.BorderColor = Color.Red;
            Cl.ForeColor = Color.Red; Cl.FlatAppearance.BorderColor = Color.Red;
            Br.ForeColor = Color.Red; Br.FlatAppearance.BorderColor = Color.Red;
            H.ForeColor = Color.Red; H.FlatAppearance.BorderColor = Color.Red;
            F.ForeColor = Color.Red; F.FlatAppearance.BorderColor = Color.Red;
            Li.ForeColor = Color.Red; Li.FlatAppearance.BorderColor = Color.Red;
            C.ForeColor = Color.Red; C.FlatAppearance.BorderColor = Color.Red;
            O.ForeColor = Color.Red; O.FlatAppearance.BorderColor = Color.Red;
            N.ForeColor = Color.Red; N.FlatAppearance.BorderColor = Color.Red;
            c1 = false;
            c2 = false;
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
                if (panel2.Visible && ((textBox1.BackColor == Color.LimeGreen && textBox2.BackColor == Color.LimeGreen && textBox3.BackColor == Color.LimeGreen)||SaveLoad.s2 >= 5))
                {
                    panel2.Hide();
                    panel3.Show();
                }
                else
                {
                    if (panel3.Visible)
                    {
                        panel3.Hide();
                        panel6.Show();
                        Next.Hide();
                        Finish.Show();
                    }
                }
            }
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            if (label4.Text == "You did it!!" || SaveLoad.s2 >= 10)
            {
                label4.Text = string.Empty; label3.Text = string.Empty;
                textBox1.Text = string.Empty; textBox2.Text = string.Empty; textBox3.Text = string.Empty;
                textBox1.BackColor = Color.White; textBox2.BackColor = Color.White; textBox3.BackColor = Color.White;
                textBox1.Enabled = true; textBox2.Enabled = true; textBox3.Enabled = true;
                F.ForeColor = Color.Red; Li.ForeColor = Color.Red; H.ForeColor = Color.Red; Na.ForeColor = Color.Red; Cl.ForeColor = Color.Red; Br.ForeColor = Color.Red;
                Previous.Hide();
                Finish.Hide();
                Next.Show();
                panel1.Show();
                panel1.BringToFront();
                panel6.Hide();
                SaveLoad.s2 = 10;

                this.Hide();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (!c1)
            {
                C.FlatAppearance.BorderColor = Color.Yellow;
                C.ForeColor = Color.Yellow;
                c1 = true;
            }
            else
            {
                if (!c2)
                {
                    C.FlatAppearance.BorderColor = Color.Yellow;
                    C.ForeColor = Color.Yellow;
                    c2 = true;
                }
            }
        }

        private void O_Click(object sender, EventArgs e)
        {
            if (!c1)
            {
                O.FlatAppearance.BorderColor = Color.Yellow;
                O.ForeColor = Color.Yellow;
                c1 = true;
            }
            else
            {
                if (!c2)
                {
                    O.FlatAppearance.BorderColor = Color.Yellow;
                    O.ForeColor = Color.Yellow;
                    c2 = true;
                }
            }
        }

        private void N_Click(object sender, EventArgs e)
        {
            if (!c1)
            {
                N.FlatAppearance.BorderColor = Color.Yellow;
                N.ForeColor = Color.Yellow;
                c1 = true;
            }
            else
            {
                if (!c2)
                {
                    N.FlatAppearance.BorderColor = Color.Yellow;
                    N.ForeColor = Color.Yellow;
                    c2 = true;
                }
            }
        }

        private void Br_Click(object sender, EventArgs e)
        {
            if (!c1)
            {
                Br.FlatAppearance.BorderColor = Color.Yellow;
                Br.ForeColor = Color.Yellow;
                c1 = true;
            }
            else
            {
                if (!c2)
                {
                    Br.FlatAppearance.BorderColor = Color.Yellow;
                    Br.ForeColor = Color.Yellow;
                    c2 = true;
                }
            }
        }
    }
}
