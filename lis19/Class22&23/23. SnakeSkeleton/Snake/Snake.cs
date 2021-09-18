using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SnakeGame
{
    public class Snake : Creature
    {
        private const int SANKESTART = 15;
        private const int LENGTH = 8;
        private const int CELLS = 30;

        private Bitmap body;
        private List<Point> position;
        private Direction direction;
        private Boolean hitwall;
        private Boolean hitself;
        private Boolean frogeaten;
       

        public Snake(Bitmap head, Bitmap body, Grid grid)
            : base(head, grid)
        {
            this.body = body;
            direction = Direction.Right;
            position = new List<Point>();
            for (int i = 0; i < LENGTH; i++)
            {
                position.Add(new Point(SANKESTART - i, SANKESTART));
            }

        }
          
        public override void Draw()
        {
            foreach (Point position in position)
            {
                grid.Rows[position.Y].Cells[position.X].Value = body;
            }

            grid.Rows[position[0].Y].Cells[position[0].X].Value = head;
        }

        public void Move()
        {
            for (int i = (position.Count - 1); i > 0; i--)
            {
                position[i] = position[i - 1];
            }
            switch(direction)
            { 
            
                case Direction.Left:
                    {
                        position[0] = new Point(position[0].X - 1, position[0].Y);
                        break;
                    }
                case Direction.Right:
                    {
                        position[0] = new Point(position[0].X + 1, position[0].Y);
                        break;
                    }
                case Direction.Up:
                    {
                        position[0] = new Point(position[0].X, position[0].Y - 1);
                        break;
                    }
                case Direction.Down:
                    {
                        position[0] = new Point(position[0].X, position[0].Y + 1);
                        break;
                    }
            }
        }
        public Boolean HitWall()
        {
            hitwall = false;
            if ((position[0].X <= 0) || (position[0].X >= (CELLS - 1)) || (position[0].Y <= 0) || (position[0].Y >= (CELLS - 1)))
            {
                hitwall = true;
            }
            return (hitwall);
        }

        public Boolean Hitself()
        {
            hitself = false;
            for (int i = 1; i < position.Count; i++)
            {
                if (position[i] == position[0])
                {
                    hitself = true;
                }
            }

          
            return (hitself);
        }

        public Boolean SnakeEat(Point point)
        {
            frogeaten = false;
            if (position[0] == point)
            {
                frogeaten = true;
            }
            return (frogeaten);
        }

        public Direction Direction { get => direction; set => direction = value; }
        public bool Hitwall { get => hitwall; set => hitwall = value; }
        public bool Hitself1 { get => hitself; set => hitself = value; }
    }
}
