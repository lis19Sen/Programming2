using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_class
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(Pens.Green, new Point(10, 10), new Point(100, 100));
            graphics.DrawLine(Pens.Green, new Point(10, 100), new Point(100, 10));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.DrawRectangle(Pens.Red, new Rectangle(150,150,100,50));
            graphics.FillRectangle(Brushes.Blue, new Rectangle(150, 150, 100, 50));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphics.FillRectangle(Brushes.Blue, new Rectangle(150,250,100,50));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphics.DrawEllipse(Pens.Yellow, new RectangleF(200,200,400,120));
            Font font = new Font("Consolas", 55, FontStyle.Italic);
            graphics.DrawString("Hi there", font, Brushes.SkyBlue, 200, 200);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int width = 500;
            Font font = new Font("Tahoma", 6, FontStyle.Regular);
            for (int x = 0; x < width; x += 20)
            {
                graphics.DrawLine(Pens.Black,new Point(x, 0), new Point(x, 480) );
            }
            for (int y = 0; y < 500; y += 20)
            {
                graphics.DrawLine(Pens.Black, new Point(0, y), new Point(480, y));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Brushes.Black, 3.0F);
            graphics.DrawCurve(pen, new Point[] { new Point(80, 60), new Point(200, 40), new Point(180, 60), new Point(300, 40) });
            graphics.DrawCurve(pen, new Point[] { new Point(300, 180), new Point(180, 200), new Point(200, 180), new Point(80, 200) });
            graphics.DrawLine(pen, new Point(300, 40), new Point(300, 180));
            graphics.DrawLine(pen, new Point(80, 60), new Point(80, 200));
            graphics.DrawEllipse(pen, 40, 40, 40, 40);
            graphics.DrawRectangle(pen, 40, 60, 20, 300);
            graphics.DrawLine(pen, new Point(60, 60), new Point(80, 60));
            graphics.DrawLine(pen, new Point(60, 200), new Point(80, 200));
            int width = 500;
            Font font = new Font("Tahoma", 6, FontStyle.Regular);
            for (int x = 0; x < width; x += 20)
            {
                graphics.DrawLine(Pens.Black, new Point(x, 0), new Point(x, 480));
            }
            for (int y = 0; y < 500; y += 20)
            {
                graphics.DrawLine(Pens.Black, new Point(0, y), new Point(480, y));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            graphics.FillPolygon(Brushes.Black, new Point[] { new Point (60,40), new Point(140, 80), new Point(200, 40), new Point(300, 80),
            new Point (380,60),new Point (340,140),new Point (320, 180),new Point (380, 240),new Point (320, 300),new Point (340, 340), new Point (240,320),
            new Point (180,340),new Point (20, 320),new Point (60,280),new Point (100, 240),new Point (40, 220),new Point (80, 160),});
            Font font = new Font("Times New Roman", 24, FontStyle.Italic );
            graphics.DrawString("Pow!", font, Brushes.White, new Point(80, 80));
            graphics.DrawString("Pow!", font, Brushes.White, new Point(120, 120));
            graphics.DrawString("Pow!", font, Brushes.White, new Point(160, 160));
            graphics.DrawString("Pow!", font, Brushes.White, new Point(200, 200));
            graphics.DrawString("Pow!", font, Brushes.White, new Point(240, 240));



        }
    }
}
