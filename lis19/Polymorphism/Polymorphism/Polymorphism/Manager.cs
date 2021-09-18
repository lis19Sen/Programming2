using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Manager
    {
        private Random random;
        private Graphics graphics;
        private Polygon polygon;

        public Manager(Random random, Graphics graphics)
        {
            this.random = random;
            this.graphics = graphics;
            polygon = null;
        }
        public void CreatePolygon()
        {
            int randomNumber = random.Next(3);
            switch (randomNumber)
            {
                case 0:
                    polygon = new Circle(new Point(random.Next(1980), random.Next(1080)), Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)), random.Next(100,200), graphics);
                    break;
                case 1:
                    polygon = new Square(new Point(random.Next(1980), random.Next(1080)), Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)), random.Next(100, 200), graphics);
                    break;
                case 2:
                    polygon = new Trangle(new Point(random.Next(1980), random.Next(1080)), Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)), random.Next(100, 200), graphics);
                    break;
            }
        }

        public void DrawPolygon()
        {
            polygon.Draw();
        }

        public string CalculatePolygonArea()
        {
            double area = polygon.CalculateArea();
            return (Convert.ToString(area));
        }
    }
}
