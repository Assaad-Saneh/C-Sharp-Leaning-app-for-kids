using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WinFormProject
{
    public partial class EarthSunMoon : Form
    {
        float angle = 0, Earth_velocity = 1;

        int px = 230, py = 230, dst = 100;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void EarthSunMoon_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            StringFormat str = new StringFormat();

            Random r = new Random();
                     
            g.DrawEllipse(Pens.Yellow, r.Next(0, 500), r.Next(0, 500), 2, 2);
            g.FillEllipse(Brushes.Yellow, r.Next(0, 500), r.Next(0, 500), 3, 3);
            g.DrawEllipse(Pens.Orange, r.Next(0, 500), r.Next(0, 500), 2, 2);
            g.FillEllipse(Brushes.Orange, r.Next(0, 500), r.Next(0, 500), 3, 3);
            g.DrawEllipse(Pens.Azure, r.Next(0, 500), r.Next(0, 500), 2, 2);
            g.FillEllipse(Brushes.Azure, r.Next(0, 500), r.Next(0, 500), 3, 3);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TranslateTransform(px, py, MatrixOrder.Append);
            g.DrawEllipse(Pens.White, -dst + 6, -dst + 6, 200, 200);
            g.ResetTransform();

            g.FillEllipse(Brushes.Gold, px + 10, py - 20, 40, 40);
            g.DrawString("Sun", Font, new SolidBrush(Color.Gold), (int)(px - dst + 120), (int)(py - dst + 50), str);

            int x = (int)(px + dst * Math.Sin(angle * Math.PI / (2*182.5f)));
            int y = (int)(py + dst * Math.Cos(angle * Math.PI / (2*182.5f)));
            g.FillEllipse(Brushes.Blue, (int)x, (int)y, 20, 20);
            angle -= Earth_velocity;

            g.DrawEllipse(Pens.White, (int)x - 20, (int)y - 20, 60, 60);

            int x1 = (int)(x + 30 * Math.Sin(angle * Math.PI / 60f));
            int y1 = (int)(y + 30 * Math.Cos(angle * Math.PI / 60f));

            g.FillEllipse(Brushes.Wheat, (int)x1, (int)y1, 16, 16);

            g.DrawString("Earth-Moon", Font, new SolidBrush(Color.Blue), (int)(x - dst + 70), (int)(y - dst + 50), str);

            g.ResetTransform();
        }

        public EarthSunMoon()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value + 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
