using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingSharps
{
    public class Controller
    {
        private List<Ball> balls;

        public Controller(Graphics graphics, Size clientSize)
        {
            balls = new List<Ball>();
            balls.Add(new Ball(graphics, new Point(100,100), Color.Red, new Point(30, 30), clientSize));
            balls.Add(new Ball(graphics, new Point(200, 50), Color.Pink, new Point(30, 30), clientSize));
            balls.Add(new Ball(graphics, new Point(300, 150), Color.Blue, new Point(30, 30), clientSize));
        }

        public void Run()
        {
            foreach (Ball ball in balls)
            {

                ball.Draw();
                ball.Move();
                ball.HitWall();
                
            }
        }

        public void Velocity(int i, Point value)
        {
            balls[i].Velocity = value;
        }
    }
}
