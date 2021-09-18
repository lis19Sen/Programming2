using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTracker
{

    public class Path
    {
        //fields
        private List<Point> points;
        private Boolean isDrawing;

        //constructor
        public Path()
        {
            points = new List<Point>();
        }

       

        public void DrawPath(Graphics graphics, Pen pen, Point mousePoint)
        {
            if (isDrawing == true)
            {
                points.Add(mousePoint);
                for (int i = 0; i < Points.Count - 1; i++)
                {
                    graphics.DrawLine(pen, points[i], points[i + 1]);
                }
            }
        }

        //method
        public void StartDrawing()
        {
            points.Clear();
            //points.Add(mousePoint);
            isDrawing = true;

        }

        public void StoptDrawing()
        {
            
            isDrawing = false;

        }

        public List<Point> Points { get => points; set => points = value; }
    }
}
