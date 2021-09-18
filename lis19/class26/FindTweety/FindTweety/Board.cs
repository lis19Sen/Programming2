using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTweety
{
    public class Board
    {
        //constant
        private const int NCOLS = 4;
        private const int NROWS = 2;
        private const int SQUARESIZE = 100;

        //fields
        private List<Square> squares;

        public Board(Graphics graphics)
        {
            squares = new List<Square>();
            for (int i = 0; i < NCOLS; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    int left = i * SQUARESIZE;
                    int top = j * SQUARESIZE;
                    Rectangle bounds = new Rectangle(left, top, SQUARESIZE, SQUARESIZE);
                    Square square = new Square(graphics, bounds);
                    squares.Add(square);
                }
            }
        }

        public void SetUpNewGame()
        {
            foreach (Square square in squares)
            {
                square.SetUp();
                 
            }
        }

       

        public void PlayThisSquare(Point MousePoistion)
        {

        }
    }
}
