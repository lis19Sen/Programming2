using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughsAndCrosses
{
    public class Square
    {
        private Image image;
        private Graphics graphics;
        private Rectangle bounds;
        private Boolean filled;

        //fields
        public Square(Graphics graphics, Rectangle bounds)
        {
            this.bounds = bounds;
            this.graphics = graphics;
            Setup();
        }

        //method
        public void Setup()
        {
            image = Properties.Resources.solid;
            filled = false;
        }

        public void DisplayImage()
        {
            graphics.DrawImage(image, bounds.Left, bounds.Top);
        }

        public bool FindActiveSquare(Point MousePoint)
        {
            bool foundSquare = false;
            if (bounds.Contains(MousePoint) == true)
            {
                foundSquare = true;
            }
            return (foundSquare);
        }

        public void Play(bool playerX)
        {
            if (filled == false)
            {
                if (playerX)
                {
                    image = Properties.Resources.X;
                }
                else
                {
                    image = Properties.Resources.O;
                }
                DisplayImage();
                filled = true;
            }
        }
    }
}
