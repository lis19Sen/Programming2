using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Square : Polygon
    {
        public Square(Point position, Color color, int size, Graphics graphics)
            : base(position, color, size, graphics)
        {
        }

        public override void Draw()
        {
            SolidBrush brush = new SolidBrush(color);
            graphics.FillRectangle(brush, position.X, position.Y, size, size);
        }

        public override double CalculateArea()
        {
            return (size * size);
        }
    }
}
