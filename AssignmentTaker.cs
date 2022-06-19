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
    public partial class AssignmentTaker : UserControl
    {
        string math = Application.StartupPath + "\\math\\" + "\\assignment\\";
        string language = Application.StartupPath + "\\language\\" + "\\assignment\\";
        string science = Application.StartupPath + "\\science\\" + "\\assignment\\";

        public AssignmentTaker()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            label2.Text = "";
            this.BackColor = Color.LemonChiffon;
            this.Hide();
        }

        private void Math_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CornflowerBlue;
            //string[] assignmnets = Directory.GetFiles(Application.StartupPath + "\\math");
            if (File.Exists("mathassignment.txt")) 
            {
                StreamReader sr = new StreamReader("mathassignment.txt");
                label2.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                label2.Text = "There is no assignments in math";
            }
        }

        private void Lang_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 128, 128);
            //string[] assignmnets = Directory.GetFiles(Application.StartupPath + "\\language\\" + "\\assignment\\");
            if (File.Exists("langassignment.txt"))
            {
                StreamReader sr = new StreamReader("langassignment.txt");
                label2.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                label2.Text = "There is no assignments in language";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(128, 255, 128);
            //string[] assignmnets = Directory.GetFiles(Application.StartupPath + "\\science\\" + "\\assignment\\");
            if (File.Exists("scsassignment.txt"))
            {
                StreamReader sr = new StreamReader("scsassignment.txt");
                label2.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                label2.Text = "There is no assignments in science";
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //string[] assignmnets = Directory.GetFiles(Application.StartupPath + "\\science\\" + "\\assignment\\");

            if (SaveLoad.StudentName.Length != 0)
            {
                string sname = SaveLoad.StudentName;
                if(textBox2.Text != string.Empty)
                {
                    if (this.BackColor == Color.CornflowerBlue)
                    {
                        StreamWriter sw = new StreamWriter("msubmission" + sname + ".txt");
                        sw.Write(textBox2.Text);
                        sw.Close();
                    }
                    else
                    {
                        if (this.BackColor == Color.FromArgb(255, 128, 128))
                        {
                            StreamWriter sw = new StreamWriter("lsubmission" + sname + ".txt");
                            sw.Write(textBox2.Text);
                            sw.Close();
                        }
                        else
                        {
                            if (this.BackColor == Color.FromArgb(128, 255, 128))
                            {
                                StreamWriter sw = new StreamWriter("ssubmission" + sname + ".txt");
                                sw.Write(textBox2.Text);
                                sw.Close();
                            }
                            else
                            {
                                MessageBox.Show("You should pick the subject assignment first");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You can't give empty submission");
                }
            }
            else
            {
                MessageBox.Show("Name not found");
            }
        }
    }
}
