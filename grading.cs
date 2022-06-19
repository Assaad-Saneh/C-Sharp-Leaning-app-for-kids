using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormProject
{
    public partial class grading : UserControl
    {
        string[] subs;
        int index = 0;

        public grading()
        {
            InitializeComponent();
        }

        private void Math_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            button2.Enabled = true;
            index = 0;
            this.BackColor = Color.CornflowerBlue;
            subs = Directory.GetFiles(Application.StartupPath, "*msubmission*.txt");
            if (!(subs.Length == 0))
            {
                foreach (string s in subs)
                {
                    label4.Text += Path.GetFileName(s) + "\n";
                }

                StreamReader sr = new StreamReader(subs[0]);
                label2.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                label2.Text = "No submissons";
            }
        }

        private void Lang_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            button2.Enabled = true;
            index = 0;
            this.BackColor = Color.FromArgb(255, 128, 128);
            subs = Directory.GetFiles(Application.StartupPath, "*lsubmission*.txt");
            if (!(subs.Length == 0))
            {
                foreach (string s in subs)
                {
                    label4.Text += Path.GetFileName(s) + "\n";
                }

                StreamReader sr = new StreamReader(subs[0]);
                label2.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                label2.Text = "No submissons";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            button2.Enabled = true;
            index = 0;
            this.BackColor = Color.FromArgb(128, 255, 128);
            subs = Directory.GetFiles(Application.StartupPath, "*ssubmission*.txt");
            if (!(subs.Length == 0))
            {
                foreach (string s in subs)
                {
                    label4.Text += Path.GetFileName(s) + "\n";
                }

                StreamReader sr = new StreamReader(subs[0]);
                label2.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                label2.Text = "No submissons";
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value == -1)
            {
                MessageBox.Show("You must grade the submission first");
            }
            else
            {
                label2.Text = "";
                index++;
                if (index < subs.Length)
                {
                    StreamReader sr = new StreamReader(subs[index]);
                    label2.Text = sr.ReadToEnd();
                    sr.Close();
                }
                else
                {
                    label2.Text = "no more submissions";
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.CornflowerBlue)
            {
                if (!File.Exists("mgrades.txt"))
                {
                    StreamWriter sc =  File.CreateText("mgrades.txt");
                    sc.Close();
                }

                string fname = Path.GetFileName(subs[index]);
                int len = fname.IndexOf(".") - 11;
                string name = fname.Substring(11, len);

                StreamReader sr = new StreamReader("mgrades.txt");
                bool nexist = false;
                while (sr.Peek() != -1 && !nexist)
                {
                    string[] line = sr.ReadLine().Split('\t');
                    if (line[0] == name)
                    {
                        nexist = true;
                    }
                }
                sr.Close();

                StreamWriter sw = File.AppendText("mgrades.txt");
                if (!nexist)
                {
                    sw.WriteLine($"{name}\t{numericUpDown1.Value}\t{textBox1.Text}");
                }
                sw.Close();
            }
            else
            {
                if(this.BackColor == Color.FromArgb(255, 128, 128))
                {
                    if (!File.Exists("lgrades.txt"))
                    {
                        StreamWriter sc = File.CreateText("lgrades.txt");
                        sc.Close();
                    }

                    string fname = Path.GetFileName(subs[index]);
                    int len = fname.IndexOf(".") - 11;
                    string name = fname.Substring(11, len);

                    StreamReader sr = new StreamReader("lgrades.txt");
                    bool nexist = false;
                    while (sr.Peek() != -1 && !nexist)
                    {
                        string[] line = sr.ReadLine().Split('\t');
                        if (line[0] == name)
                        {
                            nexist = true;
                        }
                    }
                    sr.Close();

                    StreamWriter sw = File.AppendText("lgrades.txt");
                    if (!nexist)
                    {
                        sw.WriteLine($"{name}\t{numericUpDown1.Value}\t{textBox1.Text}");
                    }
                    sw.Close();
                }
                else
                {
                    if (this.BackColor == Color.FromArgb(128, 255, 128))
                    {
                        if (!File.Exists("sgrades.txt"))
                        {
                            StreamWriter sc = File.CreateText("sgrades.txt");
                            sc.Close();
                        }

                        string fname = Path.GetFileName(subs[index]);
                        int len = fname.IndexOf(".") - 11;
                        string name = fname.Substring(11, len);

                        StreamReader sr = new StreamReader("sgrades.txt");
                        bool nexist = false;
                        while (sr.Peek() != -1 && !nexist)
                        {
                            string[] line = sr.ReadLine().Split('\t');
                            if (line[0] == name)
                            {
                                nexist = true;
                            }
                        }
                        sr.Close();

                        StreamWriter sw = File.AppendText("sgrades.txt");
                        if (!nexist)
                        {
                            sw.WriteLine($"{name}\t{numericUpDown1.Value}\t{textBox1.Text}");
                        }
                        sw.Close();
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LemonChiffon;
            numericUpDown1.Value = -1;
            label2.Text = "";
            label4.Text = "";
            textBox1.Text = "";
            button2.Enabled = false;
            this.Hide();
        }
    }
}
