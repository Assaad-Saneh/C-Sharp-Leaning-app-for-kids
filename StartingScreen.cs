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
using System.Xml;

namespace WinFormProject
{
    public partial class StartingScreen : UserControl
    {

        DataRow dr;
        string sname;
        bool stuexist = false;
        public StartingScreen()
        {
            InitializeComponent();
        }

        //===========================================================================================================================================

        private void button1_Click(object sender, EventArgs e)
        {
            SaveLoad.m1 = 0;
            SaveLoad.m2 = 0;
            SaveLoad.m3 = 0; 
            SaveLoad.l1 = 0;
            SaveLoad.l2 = 0;
            SaveLoad.s1 = 0;
            SaveLoad.s2 = 0;
            SaveLoad.s3 = 0;
            SaveLoad.b1 = 0;
            SaveLoad.b2 = 0;


            if (comboBox1.Text != "1234")
            {
                SaveLoad.StudentName = comboBox1.Text;

                setup();
                search();
                if (SaveLoad.StudentName.Length != 0)
                {
                    if (!stuexist)
                    {
                        dr = SaveLoad.student.NewRow();
                        dr["user"] = SaveLoad.StudentName;
                        dr["m1"] = 0;
                        dr["m2"] = 0;
                        dr["m3"] = 0;
                        dr["l1"] = 0;
                        dr["l2"] = 0;
                        dr["s1"] = 0;
                        dr["s2"] = 0;
                        dr["s3"] = 0;
                        dr["b1"] = 0;
                        dr["b2"] = 0;
                        SaveLoad.student.Rows.Add(dr);
                        comboBox1.Items.Add(SaveLoad.StudentName);
                    }
                    dataGridView1.DataSource = SaveLoad.student;
                    SaveLoad.ds.WriteXml(Application.StartupPath + "\\student.xml");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("combobox is emty please enter user name");
                }
            }
            else
            {
                if (File.Exists("mgrades.txt"))
                {
                    File.Delete("mgrades.txt");
                }

                if (File.Exists("lgrades.txt"))
                {
                    File.Delete("lgrades.txt");
                }

                if (File.Exists("sgrades.txt"))
                {
                    File.Delete("sgrades.txt");
                }

                string[] files = Directory.GetFiles(Application.StartupPath, "*submission*.txt");

                foreach(string s in files)
                {
                    File.Delete(s);
                }
            }

            if (File.Exists("scores.txt"))
            {
                bool userexist = false;
                StreamReader sr = new StreamReader("scores.txt");
                while (sr.Peek() != -1 && !userexist)
                {
                    string[] line = sr.ReadLine().Split('\t');
                    if(line[0] == comboBox1.Text)
                    {
                        userexist = true;
                        SaveLoad.m1 = int.Parse(line[1]);
                        SaveLoad.m2 = int.Parse(line[2]);
                        SaveLoad.m3 = int.Parse(line[3]);
                        SaveLoad.l1 = int.Parse(line[4]);
                        SaveLoad.l2 = int.Parse(line[5]);
                        SaveLoad.s1 = int.Parse(line[6]);
                        SaveLoad.s2 = int.Parse(line[7]);
                        SaveLoad.s3 = int.Parse(line[8]);
                        SaveLoad.b1 = int.Parse(line[9]);
                        SaveLoad.b2 = int.Parse(line[10]);
                    }
                }

                sr.Close();
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //======================================================================================================================================

        public void setup()
        {
            SaveLoad.ds = new DataSet();
            if (!File.Exists(Application.StartupPath + "\\student.xml") && (!File.Exists("student.xml")))
            {
                SaveLoad.ds.DataSetName = "students";
                SaveLoad.student = new DataTable();
                SaveLoad.student.TableName = "student";
                SaveLoad.ds.Tables.Add(SaveLoad.student);
                DataColumn dc = new DataColumn("user", typeof(string));
                SaveLoad.student.Columns.Add(dc);
                dc = new DataColumn("m1", typeof(int));
                SaveLoad.student.Columns.Add(dc);
                dc = new DataColumn("m2", typeof(int));
                SaveLoad.student.Columns.Add(dc);
                dc = new DataColumn("m3", typeof(int));
                SaveLoad.student.Columns.Add(dc);
                dc = new DataColumn("l1", typeof(int));
                SaveLoad.student.Columns.Add(dc);
                dc = new DataColumn("l2", typeof(int));
                SaveLoad.student.Columns.Add(dc);
                dc = new DataColumn("s1", typeof(int));
                SaveLoad.student.Columns.Add(dc);
                dc = new DataColumn("s2", typeof(int));
                SaveLoad.student.Columns.Add(dc);
                dc = new DataColumn("s3", typeof(int));
                SaveLoad.student.Columns.Add(dc);
                dc = new DataColumn("b1", typeof(int));
                SaveLoad.student.Columns.Add(dc);
                dc = new DataColumn("b2", typeof(int));
                SaveLoad.student.Columns.Add(dc);
            }
            else
            {
                SaveLoad.student = new DataTable();
                SaveLoad.ds.ReadXml(Application.StartupPath + "\\student.xml");
                SaveLoad.student = SaveLoad.ds.Tables["student"];
            }
            dataGridView1.DataSource = SaveLoad.student;
        }

        //======================================================================================================================================
        public void search()
        {
            if(File.Exists("student.xml"))
            {
                XmlTextReader xtr = new XmlTextReader("student.xml");

                while (xtr.Read())
                {
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "user")
                    {
                        sname = xtr.ReadElementContentAsString();
                        if(SaveLoad.StudentName == sname)
                        {
                            stuexist = true;
                        }
                    }
                }
                xtr.Close();
            }
        }
        string sd = string.Empty;

        //======================================================================================================================================
        private void StartingScreen_Load(object sender, EventArgs e)
        {
                if (File.Exists("student.xml"))
                {
                    XmlTextReader xtr = new XmlTextReader("student.xml");
                    while (xtr.Read())
                    {


                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "user")
                        {
                            sd = xtr.ReadElementContentAsString();
                            comboBox1.Items.Add(sd);
                           

                        }
                    }
                    xtr.Close();
                    
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Length == 0 && comboBox1.Text != "1234")
            {
                MessageBox.Show("Enter your name before taking the assignment");
            }
            else
            {
                SaveLoad.StudentName = comboBox1.Text;
                assignmentTaker1.Show();
                assignmentTaker1.BringToFront();
            }
        }

        private void give_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1234")
            {
                assignmentMakerTaker1.Visible = true;
                assignmentMakerTaker1.BringToFront();
            }
        }

        private void Grade_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1234")
            {
                grading1.Show();
                grading1.BringToFront();
            }
            else
            {
                if (comboBox1.Text != "")
                {
                    string message = "";
                    if (File.Exists("mgrades.txt"))
                    {
                        bool gexist = false;
                        StreamReader sr = new StreamReader("mgrades.txt");
                        while (sr.Peek() != -1 && !gexist)
                        {
                            string[] line = sr.ReadLine().Split('\t');
                            if (line[0] == comboBox1.Text)
                            {
                                gexist = true;
                                message += "Math :\t";
                                foreach (string s in line)
                                {
                                    message += s + "\t";
                                }
                                message += "\n";
                            }
                        }
                        sr.Close();
                    }
                    else
                    {
                        message += "No grades in math\n";
                    }

                    if (File.Exists("lgrades.txt"))
                    {
                        bool gexist = false;
                        StreamReader sr = new StreamReader("lgrades.txt");
                        while (sr.Peek() != -1 && !gexist)
                        {
                            string[] line = sr.ReadLine().Split('\t');
                            if (line[0] == comboBox1.Text)
                            {
                                gexist = true;
                                message += "Language :\t";
                                foreach (string s in line)
                                {
                                    message += s + "\t";
                                }
                                message += "\n";
                            }
                        }
                        sr.Close();
                    }
                    else
                    {
                        message += "No grade in language\n";
                    }

                    if (File.Exists("sgrades.txt"))
                    {
                        bool gexist = false;
                        StreamReader sr = new StreamReader("sgrades.txt");
                        while (sr.Peek() != -1 && !gexist)
                        {
                            string[] line = sr.ReadLine().Split('\t');
                            if (line[0] == comboBox1.Text)
                            {
                                gexist = true;
                                message += "Science : \t";
                                foreach (string s in line)
                                {
                                    message += s + "\t";
                                }
                                message += "\n";
                            }
                        }
                        sr.Close();
                    }
                    else
                    {
                        message += "no grade in scince\n";
                    }

                    MessageBox.Show(message);
                }

            }
        }
    }
}
