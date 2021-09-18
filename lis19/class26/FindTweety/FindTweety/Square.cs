using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTweety
{
    public class Square
    {
        private Bitmap image;
        private Graphics graphics;
        private Rectangle bounds;
        private Boolean filled;
        private eType type;

        public Square(Graphics graphics, Rectangle bounds)
        {
            this.graphics = graphics;
            this.bounds = bounds;
        }

        public void SetUp()
        {
            image = Properties.Resources.start;
            filled = false;
        }

        public void SetImage()
        {
            switch (type)
            {
                case eType.BLANK:
                    {
                        image = Properties.Resources.blue;
                        break;
                    }
                case eType.WIN:
                    {
                        image = Properties.Resources.tweety;
                        break;
                    }
                case eType.LOSSE:
                    {
                        image = Properties.Resources.sylvester;
                        break;
                    }
            }
        }

        public bool FindActiveSquare(Point MousePosition)
        {
            bool foundSquare = false;
            if (bounds.Contains(MousePosition) == true)
            {
                foundSquare = true;
            }
            return (foundSquare);
        }

        public void DisplayImage()
        {
            graphics.DrawImage(image, bounds.Left, bounds.Top);
        }
    }
}
