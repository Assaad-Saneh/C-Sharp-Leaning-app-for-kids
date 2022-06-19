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
    public partial class AssignmentMakerTaker : UserControl
    {
        string math = Application.StartupPath + "\\math";
        string lang = Application.StartupPath + "\\language";
        string science = Application.StartupPath + "\\science";
        public AssignmentMakerTaker()
        {
            InitializeComponent();
        }

        private void Math_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CornflowerBlue;
        }

        private void Lang_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Name = (textBox1.Text).Trim();

            if(this.BackColor == Color.CornflowerBlue)
            {
                StreamWriter sw = new StreamWriter("mathassignment.txt");
                sw.Write(textBox2.Text);
                sw.Close();
            }
            else
            {
                if (this.BackColor == Color.FromArgb(255, 128, 128))
                {
                    StreamWriter sw = new StreamWriter("langassignment.txt");
                    sw.Write(textBox2.Text);
                    sw.Close();
                }
                else
                {
                    if (this.BackColor == Color.FromArgb(128, 255, 128))
                    {
                        StreamWriter sw = new StreamWriter("scsassignment.txt");
                        sw.Write(textBox2.Text);
                        sw.Close();
                    }
                }
            }

            if (!Directory.Exists(math))
            {
                Directory.CreateDirectory(math + "\\assignment");
                Directory.CreateDirectory(math + "\\submissions");
            }
            if (!Directory.Exists(lang))
            {
                Directory.CreateDirectory(lang + "\\assignment");
                Directory.CreateDirectory(lang + "\\submissions");
            }
            if (!Directory.Exists(science))
            {
                Directory.CreateDirectory(science + "\\assignment");
                Directory.CreateDirectory(science + "\\submissions");
            }

            if (!(this.BackColor == Color.LemonChiffon))
            {
                if (comboBox1.Text.Length != 0)
                {                    
                    if (this.BackColor == Color.CornflowerBlue)
                    {
                        if (!File.Exists(math + "\\assignmnet\\" + Name + ".txt"))
                        {
                            StreamWriter sr = new StreamWriter(math + "\\assignment\\" + Name + ".txt");
                            sr.Write(textBox2.Text);
                            sr.Close();
                        }
                        else
                        {
                            MessageBox.Show("You should change the name");
                        }
                    }
                    if(this.BackColor == Color.FromArgb(255, 128, 128))
                    {
                        if (!File.Exists(lang + "\\assignmnet\\" + Name + ".txt"))
                        {
                            StreamWriter sr = new StreamWriter(lang + "\\assignment\\" + Name + ".txt");
                            sr.Write(textBox2.Text);
                            sr.Close();
                        }
                        else
                        {
                            MessageBox.Show("You should change the name");
                        }
                    }
                    if (this.BackColor == Color.FromArgb(128, 255, 128))
                    {
                        if (!File.Exists(math + "\\assignmnet\\" + Name + ".txt"))
                        {
                            StreamWriter sr = new StreamWriter(science + "\\assignment\\" + Name + ".txt");
                            sr.Write(textBox2.Text);
                            sr.Close();   
                        }
                        else 
                        {
                            MessageBox.Show("You should change the name");   
                        }   
                    }   
                }
                else
                {
                    MessageBox.Show("You should enter your name Professor");   
                } 
            }
            else
            {
                MessageBox.Show("You should pick a subject");  
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LemonChiffon;
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            this.Hide();
        }
    }
}
