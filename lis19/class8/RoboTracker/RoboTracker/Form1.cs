using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboTracker
{
    public partial class Form1 : Form
    {
       
        //field
        private Path path;
        private Robot robot;
        private Graphics graphics;
        private Pen pen;
        
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();//to use creat to instead of 'new '
            pen = new Pen(Color.Black, 2.0F);
            path = new Path();
            robot = new Robot(pictureBox1);
        }

    

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
                path.DrawPath(graphics, pen, new Point(e.Location.X, e.Location.Y));
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            path.StartDrawing();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            path.StoptDrawing();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            robot.MoveRobot(path);
            path.Points.Clear();
        }
    }
}
