using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Paddle
    {
        //constant
        private const int PADDLE_WIDTH = 80;
        private const int PADDLE_HIGHT = 20;
        
        //field
        private Graphics graphics;
        private Point position;
        private Color color;
        private Brush bursh;
        //private Rectangle rectangle;


        public Paddle(Graphics graphics, Point paddleposition, Color color)
        {

            this.position = paddleposition;
            this.color = color;
            this.graphics = graphics;
            bursh = new SolidBrush(Color.Pink);
            //this.rectangle = new Rectangle(position.X, position.Y, PADDLE_WIDTH, PADDLE_HIGHT);
        }

        public void Draw()
        {
            graphics.FillRectangle(bursh, new Rectangle(position.X, position.Y, PADDLE_WIDTH, PADDLE_HIGHT));
        }
        public void Move(int mouseX)
        {
            this.position.X = mouseX;
        }
    }
}
