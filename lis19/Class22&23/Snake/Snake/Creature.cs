using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public abstract class Creature
    {
        //fields
        protected Bitmap head;
        protected Grid grid;

        //constructer
        public Creature(Bitmap head, Grid grid)
        {
            this.grid = grid;
            this.head = head;
        }

        //mehtod
        public abstract void Draw();
    }
}
