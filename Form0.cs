using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormProject
{
    public partial class Form0 : Form
    {
        bool userexist = false;
        public Form0()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            math1.Hide();
            languages1.Hide();
            science1.Hide();
            brainGames1.Hide();
            Exit.Hide();
            Exit.SendToBack();
            startingScreen1.Show();
            startingScreen1.BringToFront();

        }

        private void Math_Click(object sender, EventArgs e)
        {
            languages1.Hide();
            science1.Hide();
            brainGames1.Hide();
            math1.Show();
            math1.BringToFront();
            Exit.Show();
            Exit.BringToFront();
            button1.Show();
            button1.BringToFront();
        }

        private void language_Click(object sender, EventArgs e)
        {
            math1.Hide();
            science1.Hide();
            brainGames1.Hide();

            languages1.Show();
            languages1.BringToFront();
            Exit.Show();
            Exit.BringToFront();
            button1.Show();
            button1.BringToFront();
        }

        private void science_Click(object sender, EventArgs e)
        {
            math1.Hide();
            languages1.Hide();
            brainGames1.Hide();

            science1.Show();
            science1.BringToFront();
            Exit.Show();
            Exit.BringToFront();
            button1.Show();
            button1.BringToFront();
        }

        private void braingames_Click(object sender, EventArgs e)
        {
            math1.Hide();
            languages1.Hide();
            science1.Hide();

            brainGames1.Show();
            brainGames1.BringToFront();
            Exit.Show();
            Exit.BringToFront();
            button1.Show();
            button1.BringToFront();
        }

        private void startingScreen1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //lvl1math1.Show();
            //lvl1math1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void timer(object sender, EventArgs e)
        {
            if (math1.Visible == false && languages1.Visible == false && science1.Visible == false && brainGames1.Visible == false)
            {
                startingScreen1.Show();
                startingScreen1.BringToFront();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (!File.Exists("scores.txt"))
            {
                StreamWriter sw = new StreamWriter("scores.txt");
                sw.WriteLine($"{ SaveLoad.StudentName}\t{ SaveLoad.m1}\t{ SaveLoad.m2}\t{ SaveLoad.m3}\t{ SaveLoad.l1}\t{ SaveLoad.l2}\t{ SaveLoad.s1}\t{ SaveLoad.s2}\t{ SaveLoad.s3}\t{ SaveLoad.b1}\t{ SaveLoad.b2}\t");
                sw.Close();
            }
            else
            {
                StreamReader sr = new StreamReader("scores.txt");
                StreamWriter sw = File.CreateText("clone.txt");
                while (sr.Peek() != -1)
                {
                    string s = sr.ReadLine();
                    string[] line = s.Split('\t');
                    if (line[0] != SaveLoad.StudentName)
                    {
                        sw.WriteLine(s);
                    }
                    else
                    {
                        sw.WriteLine($"{SaveLoad.StudentName}\t{SaveLoad.m1}\t{SaveLoad.m2}\t{SaveLoad.m3}\t{SaveLoad.l1}\t{SaveLoad.l2}\t{SaveLoad.s1}\t{SaveLoad.s2}\t{SaveLoad.s3}\t{SaveLoad.b1}\t{SaveLoad.b2}\t");
                        userexist = true;
                    }
                }
                sr.Close();
                sw.Close();

                File.Delete("scores.txt");
                File.Move("clone.txt", "scores.txt");
            }

            if (!userexist)
            {
                StreamWriter sw = File.AppendText("scores.txt");
                sw.WriteLine($"{SaveLoad.StudentName}\t{SaveLoad.m1}\t{SaveLoad.m2}\t{SaveLoad.m3}\t{SaveLoad.l1}\t{SaveLoad.l2}\t{SaveLoad.s1}\t{SaveLoad.s2}\t{SaveLoad.s3}\t{SaveLoad.b1}\t{SaveLoad.b2}\t");
                sw.Close();
            }

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("scores.txt"))
            {
                StreamWriter sw = new StreamWriter("scores.txt");
                sw.WriteLine($"{ SaveLoad.StudentName}\t{ SaveLoad.m1}\t{ SaveLoad.m2}\t{ SaveLoad.m3}\t{ SaveLoad.l1}\t{ SaveLoad.l2}\t{ SaveLoad.s1}\t{ SaveLoad.s2}\t{ SaveLoad.s3}\t{ SaveLoad.b1}\t{ SaveLoad.b2}\t");
                sw.Close();
            }
            else
            {
                StreamReader sr = new StreamReader("scores.txt");
                StreamWriter sw = File.CreateText("clone.txt");
                while (sr.Peek() != -1)
                {
                    string s = sr.ReadLine();
                    string[] line = s.Split('\t');
                    if (line[0] != SaveLoad.StudentName)
                    {
                        sw.WriteLine(s);
                    }
                    else
                    {
                        sw.WriteLine($"{SaveLoad.StudentName}\t{SaveLoad.m1}\t{SaveLoad.m2}\t{SaveLoad.m3}\t{SaveLoad.l1}\t{SaveLoad.l2}\t{SaveLoad.s1}\t{SaveLoad.s2}\t{SaveLoad.s3}\t{SaveLoad.b1}\t{SaveLoad.b2}\t");
                        userexist = true;
                    }
                }
                sr.Close();
                sw.Close();

                File.Delete("scores.txt");
                File.Move("clone.txt", "scores.txt");
            }

            if (!userexist)
            {
                StreamWriter sw = File.AppendText("scores.txt");
                sw.WriteLine($"{SaveLoad.StudentName}\t{SaveLoad.m1}\t{SaveLoad.m2}\t{SaveLoad.m3}\t{SaveLoad.l1}\t{SaveLoad.l2}\t{SaveLoad.s1}\t{SaveLoad.s2}\t{SaveLoad.s3}\t{SaveLoad.b1}\t{SaveLoad.b2}\t");
                sw.Close();
            }

            startingScreen1.Show();
            startingScreen1.BringToFront();
        }
    }
}
