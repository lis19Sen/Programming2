using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Block
    {
        //constant
        private const int BLOCK_WIDTH = 80;
        private const int BLOCK_HIGHT = 20;
        //field
        private Graphics graphics;
        private Point blockpoint;
        private Color color;
        private Brush bursh;
        private Rectangle rectangle;


        public Block( Graphics graphics, Point blockpoint, Color color)
        {
            
            this.blockpoint = blockpoint;
            this.color = color;
            this.graphics = graphics;
            bursh = new SolidBrush(Color.Pink);
            this.rectangle = new Rectangle(blockpoint.X, blockpoint.Y, BLOCK_WIDTH, BLOCK_HIGHT);
        }

        public void Draw()
        {
            graphics.FillRectangle(bursh, this.rectangle);
            //rectangle.IntersectsWith(ball)=true / false
        }

    }
}
