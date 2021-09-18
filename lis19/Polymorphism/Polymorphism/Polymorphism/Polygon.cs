using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Polygon
    {
        //parent fields
        protected Point position;
        protected Color color;
        protected int size;
        protected Graphics graphics;

        //constructer
        public Polygon(Point position, Color color, int size, Graphics graphics)
        {
            this.position = position;
            this.color = color;
            this.size = size;
            this.graphics = graphics;
        }

        //method
        public abstract void Draw();
        public abstract double CalculateArea();
    }
}
