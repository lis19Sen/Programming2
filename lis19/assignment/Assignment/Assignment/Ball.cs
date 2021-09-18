using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Ball
    {
        //constant
        private const int BALLSIZE = 50;
        private const int GOBACK = -1;
    
        //field
        private Graphics graphics;
        private Point ballPosition;
        private Color color;
        private Brush bursh;
        private Point speed;
        private Size cilentSize;
 
        public Ball(Graphics graphics, Point ballPosition, Color color, Point speed, Size cs)
        {

            this.ballPosition = ballPosition;
            this.color = color;
            this.graphics = graphics;
            bursh = new SolidBrush(color);
            this.speed = speed;
            cilentSize = cs;
        }

        public void Draw()
        {
            graphics.FillEllipse(bursh, ballPosition.X, ballPosition.Y, BALLSIZE, BALLSIZE);
        }
        public void Move()
        {
            ballPosition.X += speed.X;
            ballPosition.Y += speed.Y;
        }

        public void BallBehavior()
        {
            if ((ballPosition.X + BALLSIZE)  >= cilentSize.Width || ballPosition.X <= 0)
            {
                speed.X *= GOBACK;
            }

            if ((ballPosition.Y + BALLSIZE)  >= cilentSize.Height || ballPosition.Y <= 0)
            {
                speed.Y *= GOBACK;
            }
        }
    }
}
