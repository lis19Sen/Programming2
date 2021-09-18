using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Circle : Polygon
    {
        public Circle(Point position, Color color, int size, Graphics graphics)
            :base(position, color, size, graphics)
        {

        }

        public override void Draw()
        {
            SolidBrush brush = new SolidBrush(color);
            graphics.FillEllipse(brush, position.X, position.Y, size, size);
        }

        public override double CalculateArea()
        {
            return (Math.PI * (size/2) * (size/2));
        }
    }
}
