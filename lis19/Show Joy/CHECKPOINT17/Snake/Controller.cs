using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SnakeGame
{
    public class Controller
    {
        private Snake snake;
        private Grid grid;
        private Random random;
        private Frog frog;

        public Controller(Grid grid, Random random)
        {
            this.grid = grid;
            this.random = random;
            snake = new Snake(Properties.Resources.snakeEyes, Properties.Resources.snakeSkin, grid);
            frog = new Frog(Properties.Resources.frog, grid);
        }

        public void StartNewGame()
        {
            grid.Draw();
            snake.Draw();
            snake.Move();
            
            snake.Hitself();
            snake.Hitself();
            frog.Draw();
            snake.SnakeEat(frog.Position);

        }

        public ErrorMessage PlayGame()
        {
            if (frog.Life == false)
            {
                frog.Position = FindFreeCell();
                frog.Life = true;
            }

            ErrorMessage message = ErrorMessage.noError;
            if (snake.SnakeEat(frog.Position))
            {
                message = ErrorMessage.snakeEatenFrog;
                frog.Life = false;
            }

            if (snake.HitWall() == true)
            {
                message = ErrorMessage.snakeHitWall;
            }

            if (snake.Hitself() == true)
            {
                message = ErrorMessage.snakeHitSelf;
            }
            return message;
        }

        private Point FindFreeCell()
        {
            Point target = Point.Empty;

            while (target == Point.Empty)
            {
                int i = random.Next(30);
                int j = random.Next(30);

                if (grid.Rows[i].Cells[j].Value == grid.Blank)
                {
                    target = new Point(i, j);
                }
            }

            return target;
        }

        public void SetSnakeDirection(Direction direction)
        {
            snake.Direction = direction;
        }
        
  }
}
