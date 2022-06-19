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
    public partial class memorygame : UserControl
    {
        int time = 0;
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "C","C","E","E","H","H","I","I",
            "S","S","T","T","Y","Y","Z","Z"
        };
        bool win = false;
        List<string> temp = new List<string>()
        {
            "C","C","E","E","H","H","I","I",
            "S","S","T","T","Y","Y","Z","Z"
        };
        

        Label firstclicked, secondclicked;

        public memorygame()
        {
            InitializeComponent();
            AssignIconToSquares();
            if (File.Exists("MemoHighScore.txt"))
            {
                StreamReader sr = new StreamReader("MemoHighScore.txt");
                int HighScore = int.Parse(sr.ReadLine());
                HighScoreLabel.Text = "High Score : ";
                HighScoreLabel.Text += Convert.ToString(HighScore);
                sr.Close();
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            timer2.Start();
            if (firstclicked != null && secondclicked != null)
                return;

            Label clickedlabel = sender as Label;

            if (clickedlabel == null)
                return;

            if (clickedlabel.ForeColor == Color.Black)
                return;

            if(firstclicked == null)
            {
                firstclicked = clickedlabel;
                firstclicked.ForeColor = Color.Black;
                return;
            }

            secondclicked = clickedlabel;
            secondclicked.ForeColor = Color.Black;

            CheckForWinner();

            if(firstclicked.Text == secondclicked.Text)
            {
                firstclicked = null;
                secondclicked = null;
            }
            else 
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstclicked.ForeColor = firstclicked.BackColor;
            secondclicked.ForeColor = secondclicked.BackColor;

            firstclicked = null;
            secondclicked = null;
        }

        private void CheckForWinner()
        {
            Label label;
            for(int i = 0; i<tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }
            timer2.Stop();
            winmsg.Text = "You did it!!!\n BRAVOO!!!";
            win = true;
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (win)
            {
                if (File.Exists("MemoHighScore.txt"))
                {
                    StreamReader sr = new StreamReader("MemoHighScore.txt");
                    int HighScore = int.Parse(sr.ReadLine());
                    sr.Close();
                    if (time < HighScore)
                    {
                        StreamWriter sw = new StreamWriter("MemoHighScore.txt");
                        sw.WriteLine(time);
                        sw.Close();
                    }

                }
                else
                {
                    StreamWriter sw = new StreamWriter("MemoHighScore.txt");
                    sw.WriteLine(time);
                    sw.Close();
                }

                win = false;
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                {
                    if (tableLayoutPanel1.Controls[i] is Label)
                    {
                        tableLayoutPanel1.Controls[i].Text = "";
                        tableLayoutPanel1.Controls[i].ForeColor = Color.Yellow;
                        foreach(string s in temp)
                        {
                            icons.Add(s);
                        }
                    
                        AssignIconToSquares();
                    }
                    else
                        continue;
                }
                SaveLoad.b1 = 10;
            }
            
            winmsg.Text = "";
            timelabel.Text = "";
            foreach (Label l in tableLayoutPanel1.Controls)
            {
                l.ForeColor = Color.Yellow;
            }

            if (File.Exists("MemoHighScore.txt"))
            {
                StreamReader sr = new StreamReader("MemoHighScore.txt");
                int HighScore = int.Parse(sr.ReadLine());
                HighScoreLabel.Text = "High Score : ";
                HighScoreLabel.Text += Convert.ToString(HighScore);
                sr.Close();
            }

            time = 0;

            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time++;
            timelabel.Text = "";
            timelabel.Text = Convert.ToString(time) + " sec";
        }

        private void AssignIconToSquares()
        {
            Label label;
            int randomNumber;

            for(int i =0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;

                randomNumber = random.Next(0, icons.Count);
                label.Text = icons[randomNumber];

                icons.RemoveAt(randomNumber);
            }
        }
    }
}
