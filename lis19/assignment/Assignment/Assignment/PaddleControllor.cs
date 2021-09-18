using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class PaddleControllor
    {
        private Paddle paddle;
        private Graphics graphics;

        public PaddleControllor(Graphics graphics)
        {
            this.graphics = graphics;
            paddle = new Paddle(graphics, new Point(500, 500), Color.White);
        }

        public void DrawPaddle()
        {
            paddle.Draw();
        }
        public void MovePaddle(int mouseX)
        {
            paddle.Move(mouseX);
        }

    }
}
