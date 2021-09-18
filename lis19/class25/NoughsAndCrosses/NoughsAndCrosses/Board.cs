using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughsAndCrosses
{
    public class Board
    {
        //constant
        private const int NCOLS = 3;
        private const int NROWS = 3;
        private const int SQUARESIZE = 100;

        //fields
        private List<Square> squares;
        private Boolean playerX;

        //constructer
        public Board(Graphics graphics)
        {
            squares = new List<Square>();
            for (int i = 0; i < NCOLS; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    int left = i * SQUARESIZE;
                    int top = j * SQUARESIZE;
                    Rectangle bounds = new Rectangle(left + 10, top + 10, SQUARESIZE, SQUARESIZE);
                    Square square = new Square(graphics,bounds);
                    squares.Add(square);
                }
            }
        }
        public void SetUpNewGame()
        {
            foreach (Square square in squares)
            {
                square.Setup();
                square.DisplayImage();

            }
        }

        public void PlayThisSquare(Point mousePosition)
        {

        }
    }
}
