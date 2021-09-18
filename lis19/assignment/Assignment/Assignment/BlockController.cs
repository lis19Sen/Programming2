using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   public class BlockController
    {
        private List<Block> blocks;
        private Graphics graphics;

        public BlockController(Graphics graphics)
        {
            this.graphics = graphics;
            blocks = new List<Block>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    blocks.Add(new Block(graphics, new Point(i * 87, j * 30), Color.Pink));
                    
                }
                
            }
        }

        public void DrawBlocks()
        {
            foreach (Block block in blocks)
            {
                block.Draw();
                // dispear    blocks.Remove(block);
            }
        }
    }
}
