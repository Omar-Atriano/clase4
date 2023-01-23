using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase4
{

    public partial class Form1 : Form
    {
        static Bitmap bmp;
        static Graphics g;
        private Point  ancho1, ancho2 , alto1, alto2;




        private void button1_Click(object sender, EventArgs e)
        {
            Point a, b, c, d;
            a = new Point(0, 0);
            b = new Point(0, 100);
            c = new Point(100, 100);
            d = new Point(100, 0);

            pictureBox1.Image = null;
            double angle = double.Parse(textBox1.Text);
            int Sx = (bmp.Width / 2);
            int Sy = (bmp.Height / 2);
            Render( a, b, c,d, angle, Sx,Sy);
            Refresh();
          

        }
        private void Render(Point a, Point b, Point c, Point d, double angle, int Sx, int Sy)
        {
            setLines();

            PointF a2, b2,c2,d2;
            
            a2 = new PointF(Sx + a.X, Sy - a.Y);
            b2 = new PointF(Sx + b.X, Sy - b.Y);
            c2 = new PointF(Sx + c.X, Sy - c.Y);
            d2 = new PointF(Sx + d.X, Sy - d.Y);
            angle = angle * 3.1416 / 180;

            a2.X = Sx + (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            a2.Y = Sy - (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));
            b2.X = Sx + (float)((b.X * Math.Cos(angle)) - (b.Y * Math.Sin(angle)));
            b2.Y = Sy - (float)((b.X * Math.Sin(angle)) + (b.Y * Math.Cos(angle)));

            c2.X = Sx + (float)((c.X * Math.Cos(angle)) - (c.Y * Math.Sin(angle)));
            c2.Y = Sy - (float)((c.X * Math.Sin(angle)) + (c.Y * Math.Cos(angle)));
            d2.X = Sx + (float)((d.X * Math.Cos(angle)) - (d.Y * Math.Sin(angle)));
            d2.Y = Sy - (float)((d.X * Math.Sin(angle)) + (d.Y * Math.Cos(angle)));

            g.DrawLine(Pens.Red, a2, b2);
            g.DrawLine(Pens.Red, b2, c2);
            g.DrawLine(Pens.Red, c2, d2);
            g.DrawLine(Pens.Red, d2, a2);

        }



        private void button2_Click(object sender, EventArgs e)
        {

            Point a, b, c, d;
            a = new Point(-50, -50);
            b = new Point(-50, 50);
            c = new Point(50, 50);
            d = new Point(50, -50);

            pictureBox1.Image = null;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            int Sx = (bmp.Width / 2);
            int Sy = (bmp.Height / 2);

            double angle = double.Parse(textBox1.Text);
            Render(a, b, c, d, angle, Sx, Sy);
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point a, b, c, d;
            a = new Point(-50, -50);
            b = new Point(-50, 50);
            c = new Point(50, 50);
            d = new Point(50, -50);

            pictureBox1.Image = null;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            double angle = double.Parse(textBox1.Text);
            int Sx = (bmp.Width / 2 +50);
            int Sy = (bmp.Height / 2)-50;
            Render(a, b, c, d, angle, Sx, Sy);
            Refresh();
        }

        public void setLines()
        {
            ancho1 = new Point(0, pictureBox1.Height / 2);
            ancho2 = new Point(pictureBox1.Width, pictureBox1.Height / 2);
            alto1 = new Point(pictureBox1.Width / 2, 0);
            alto2 = new Point(pictureBox1.Width / 2, pictureBox1.Height);

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            g.DrawLine(Pens.Yellow, ancho1, ancho2);
            g.DrawLine(Pens.Yellow, alto1, alto2);
        }

        public Form1()
        {
            InitializeComponent();
           // setLines();

            int Sx = pictureBox1.Width / 2;
            int Sy = pictureBox1.Height / 2;

             Point a, b, c, d;

            a = new Point(0, 0);
            b = new Point(0, 100);
            c = new Point(100 , 100);
            d = new Point(100, 0);
            

            Render(a, b, c, d, 0,Sx,Sy);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
