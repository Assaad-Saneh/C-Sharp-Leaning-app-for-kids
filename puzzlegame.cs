using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace WinFormProject
{
    public partial class puzzlegame : UserControl
    {
        Point EmptyPoint;
        ArrayList images = new ArrayList();
        bool win = false;
        int time = 0;
        public puzzlegame()
        {
            EmptyPoint.X = 300;
            EmptyPoint.Y = 300;
            InitializeComponent();

            if (File.Exists("PuzzleHighScore.txt"))
            {
                StreamReader sr = new StreamReader("PuzzleHighScore.txt");
                int HighScore = int.Parse(sr.ReadLine());
                HighScoreLabel.Text = "High Score : ";
                HighScoreLabel.Text += Convert.ToString(HighScore);
                sr.Close();
            }
        }

        private void puzzlegame_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Button b in panel1.Controls)
                b.Enabled = true;
            Image original = Properties.Resources._20210114_101855;

            cropImageToImages(original, 450, 450);
            AddImagesToButtons(images);

            timer1.Start();
        }
        
        private void AddImagesToButtons(ArrayList images)
        {
            int i = 0;
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };
            arr = suffle(arr);

            foreach(Button b in panel1.Controls)
            {
                if (i < arr.Length)
                {
                    b.Image = (Image)images[arr[i]];
                    i++;
                }
            }
        }

        private int[] suffle(int[] arr)
        {
            Random rand = new Random();
            arr = arr.OrderBy(x => rand.Next()).ToArray();
            return arr;
        }

        private void cropImageToImages(Image original ,int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(original, 0, 0, w, h);
            graphic.Dispose();
            int movr = 0, movd = 0;
            for(int x = 0; x < 8; x++)
            {
                Bitmap piece = new Bitmap(150, 150);
                for (int i = 0; i < 150; i++)
                    for (int j = 0; j < 150; j++)
                        piece.SetPixel(i, j, bmp.GetPixel(i + movr, j + movd));
                images.Add(piece);
                movr += 150;
                if(movr == 450)
                {
                    movr = 0;
                    movd += 150;
                }                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MoveButton((Button)sender);
            }
            catch { }
        }

        private void MoveButton(Button btn)
        {
            if(((btn.Location.X==EmptyPoint.X-150||btn.Location.X==EmptyPoint.X+150)&&btn.Location.Y==EmptyPoint.Y)
                ||(btn.Location.Y == EmptyPoint.Y - 150 || btn.Location.Y == EmptyPoint.Y + 150) && btn.Location.X == EmptyPoint.X)
            {
                Point swap = btn.Location;
                btn.Location = EmptyPoint;
                EmptyPoint = swap;
            }

            if (EmptyPoint.X == 300 && EmptyPoint.Y == 300)
                CheckValid();
        }

        private void CheckValid()
        {
            int count = 0, index;
            foreach(Button btn in panel1.Controls)
            {
                index = (btn.Location.Y / 150) * 3 + btn.Location.X / 150;
                if (images[index] == btn.Image)
                    count++;
            }
            if (count == 8)
            {
                winmsg.Text = "You win!!";
                win = true;
                timer1.Stop();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (win)
            {
                if (File.Exists("PuzzleHighScore.txt"))
                {
                    StreamReader sr = new StreamReader("PuzzleHighScore.txt");
                    int HighScore = int.Parse(sr.ReadLine());
                    sr.Close();
                    if (time < HighScore)
                    {
                        StreamWriter sw = new StreamWriter("PuzzleHighScore.txt");
                        sw.WriteLine(time);
                        sw.Close();
                    }

                }
                else
                {
                    StreamWriter sw = new StreamWriter("PuzzleHighScore.txt");
                    sw.WriteLine(time);
                    sw.Close();
                }

                winmsg.Text = "";
                foreach(Button btn in panel1.Controls)
                {
                    btn.Image = Properties.Resources._null;
                    btn.BackColor = Color.Yellow;
                }
                SaveLoad.b2 = 10;
            }
            time = 0;
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            timelabel.Text = "";
            timelabel.Text = Convert.ToString(time) + " sec";
        }
    }
}
