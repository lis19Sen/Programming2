using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint9
{
    class controllor
    {
        //field
        private List<Molecular> moleculars;
        private Graphics graphics;
        private Random random;

        //constructor
        public controllor(Graphics graphics, Random random)
        {
            this.graphics = graphics;
            this.random = random;
            moleculars = new List<Molecular>();
            for (int i = 0; i < 100; i++)
            {
                moleculars.Add(new Molecular(graphics, new Point(100, 100), random, Color.Pink));
                moleculars.Add(new Molecular(graphics, new Point(300, 300), random, Color.Blue));
                moleculars.Add(new Molecular(graphics, new Point(500, 450), random, Color.Black));
            }
        }

        //method
        public void DrawAndMove()
        {
            foreach (Molecular molecular in moleculars)
            {
                molecular.Draw();
                molecular.Move();
            }
        }
    }
}
