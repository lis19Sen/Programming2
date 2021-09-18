using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint9
{
    class Molecular
    {
        //field
        private Graphics graphics;
        private Point pointPosition;
        private Random random;
        private Color color;
        private Brush brush;

        //constructor
        public Molecular(Graphics graphics, Point point, Random random, Color color)
        {
            this.graphics = graphics;
            this.pointPosition = point;
            this.random = random;
            this.color = color;
            brush = new SolidBrush(color);
        }

        //method
        public void Draw()
        {
            graphics.FillEllipse(brush, pointPosition.X, pointPosition.Y, 5, 5);
        }
        public void Move()
        {
            int moveRangeX = random.Next(-10, 10);
            int moveRangeY = random.Next(-10, 10);
            int moveBack = 20; // when it go out, ask it to come back

            if (pointPosition.Y >= 506 || pointPosition.X >= 795)
            {
                pointPosition.Y += (-20);
                pointPosition.X += (-20);
            }
            else if (pointPosition.Y <= 0 || pointPosition.X <= 0)
            {
                pointPosition.X += moveBack;
                pointPosition.Y += moveBack;
            }
            else
            {
                pointPosition.X += moveRangeX;
                pointPosition.Y += moveRangeY;
            }
        }
    }
}
