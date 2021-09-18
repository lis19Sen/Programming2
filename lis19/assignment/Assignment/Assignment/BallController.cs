using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class BallController
    {

        private Ball ball;
        private Graphics graphics;
        private Size cilentSize;

        public BallController(Graphics graphics, Size clientSize)
        {
            this.graphics = graphics;
            this.cilentSize = clientSize;
            ball = new Ball(graphics, new Point(500,500), Color.White, new Point(10, 10), clientSize);
        }

        public void Run()
        {
            ball.Draw();
            ball.Move();
            ball.BallBehavior();
        }
      

        
    }
}
