using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingSharps
{
    public class Ball
    {
        //constant
        private const int BALLSIZE = 40;
        private const int CHANGEDIRECTION = -1;

        private Brush brush;
        private Point position;
        private Point velocity;
        private Graphics graphics;
        private Size cilentSize;

        

        public Ball(Graphics graphics, Point position, Color color, Point velocity, Size cilentSize)
        {
            this.graphics = graphics;
            this.position = position;
            this.velocity = velocity;
            this.cilentSize = cilentSize;
            brush = new SolidBrush(color);
        }

        public void Draw()
        {
            graphics.FillEllipse(brush, position.X, position.Y, BALLSIZE, BALLSIZE);
        }
        public void Move()
        {
            position.X += velocity.X;
            position.Y += velocity.Y;
        }

        public void HitWall()
        {
            if ((position.X <= 0) || (position.X + BALLSIZE >= cilentSize.Width))
            {
                velocity.X *= CHANGEDIRECTION;//change X direction
            }

            if ((position.Y <= 0) || (position.Y + BALLSIZE >= cilentSize.Height))
            {
                velocity.Y *= CHANGEDIRECTION;// change Y direction
            }
        }
        public Point Velocity
        {
            get => velocity;
            set
            {
                if (velocity.X < 0)
                {
                    velocity.X = value.X * CHANGEDIRECTION;
                }
                else
                {
                    velocity.X = value.X;
                }
                if (velocity.Y < 0)
                {
                    velocity.Y = value.Y * CHANGEDIRECTION;
                }
                else
                {
                    velocity.Y = value.Y;
                }
            }
        }
    }
}
