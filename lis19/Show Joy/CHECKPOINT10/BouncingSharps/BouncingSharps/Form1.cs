using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingSharps
{
   
    public partial class Form1 : Form
    {

        private Controller controller;
        private Bitmap bufferImage;
        private Graphics bufferGraphics;
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            bufferImage = new Bitmap(Width, Height);
            bufferGraphics = Graphics.FromImage(bufferImage);
            graphics = CreateGraphics();
            controller = new Controller(bufferGraphics, ClientSize);
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bufferGraphics.FillRectangle(Brushes.Black, 0, 0, Width, Height);
            controller.Run();
            graphics.DrawImage(bufferImage,0,0);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            controller.Velocity(0, new Point(trackBar1.Value, trackBar1.Value));
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            controller.Velocity(0, new Point(trackBar2.Value, trackBar2.Value));
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            controller.Velocity(0, new Point(trackBar3.Value, trackBar3.Value));
        }
    }
}
