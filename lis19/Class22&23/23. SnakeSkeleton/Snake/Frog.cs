using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SnakeGame
{
    public class Frog : Creature
    {
        private Point frogposition;
        private Boolean life;

        public Frog(Bitmap head, Grid grid)
            : base(head, grid)
        {
            frogposition = new Point(0,0);
            life = false;
        }

        public Point Position { get => frogposition; set => frogposition = value; }
        public bool Life { get => life; set => life = value; }

        public override void Draw()
        {
            grid.Rows[frogposition.Y].Cells[frogposition.X].Value = head;
        }
    }
}
