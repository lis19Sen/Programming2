using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Trangle : Polygon
    {
        public Trangle(Point position, Color color, int size, Graphics graphics)
            : base(position, color, size, graphics)
        { }

        public override void Draw()
        {
            SolidBrush brush = new SolidBrush(color);
            graphics.FillPolygon(brush, new Point[] 
            { position, new Point(position.X + size, position.Y + size), new Point(position.X - size, position.Y + size)});
        }
        public override double CalculateArea()
        {
            return ( size * size);
        }
    }
}
