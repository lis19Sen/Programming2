using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public class Light
    {
        //constant
        private const int LIHHTSIZE = 75;
        //field
        private Graphics graphics;
        private Color color;
        private Point point;
        //private Brush brush;
        private int sleepInterval;
        public Light(Graphics graphics, Color color, Point point, int sleepInterval )
        {
            this.graphics = graphics;
            this.color = color;
            this.point = point;
            this.sleepInterval = sleepInterval;
            //this.brush = brush;
        }

        //method
        public void Draw(Color newColour)
        {
            Brush brush = new SolidBrush(newColour);
            graphics.FillEllipse(brush, point.X, point.Y, 75, 75);
        }

        public void Flash()
        {
            Draw(color);
            Application.DoEvents();
            Thread.Sleep(sleepInterval);
            Draw(Color.Black);
        }
    }
}
