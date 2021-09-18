using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conways
{
    public class World
    {
        private const int NCELLS = 2500;
        private const int NCOLS = 50; 
        private const int NROWS = 50;
        private const int RANDFILL = 40;

        private Random random;
        private Grid grid;
        private List <Cell> worldCells;
            
        //constructor
        public World(Random random, Grid grid)
        {
            this.random = random;
            this.grid = grid;

            worldCells = new List <Cell>();

            for (int i = 0; i < NCELLS; i++)
            {
                // fill the worldCells with cells    
                worldCells.Add(new Cell());
            }         

            //assign neighbours 
            int LeftColumn, RightColumn, TopRow, BottomRow;

            for (int i = 0; i < NCELLS; i++)
            {     
                int column = i % NCOLS;
                int row = i / NROWS;
              
                if (column == 0)
                {
                    LeftColumn = (NCOLS-1); 
                }
                else
                {
                    LeftColumn = column - 1;
                }

                if (column == (NCOLS -1))
                {
                    RightColumn = 0;
                }
                else
                {
                    RightColumn = column + 1;
                }

                if (row == 0)
                {
                    TopRow = (NROWS-1);
                }
                else
                {
                    TopRow = row - 1;
                }

                if (row == (NROWS  - 1))
                {
                    BottomRow = 0;
                }
                else
                {
                    BottomRow = row + 1;
                }

                worldCells[column * NCOLS + row].Neighbour(worldCells[LeftColumn * NCOLS + TopRow]);

                worldCells[column * NCOLS + row].Neighbour(worldCells[LeftColumn * NCOLS + row]);

                worldCells[column * NCOLS + row].Neighbour(worldCells[LeftColumn * NCOLS + BottomRow]);

                worldCells[column * NCOLS + row].Neighbour(worldCells[RightColumn * NCOLS + TopRow]);

                worldCells[column * NCOLS + row].Neighbour(worldCells[RightColumn * NCOLS + row]);

                worldCells[column * NCOLS + row].Neighbour(worldCells[RightColumn * NCOLS + BottomRow]);

                worldCells[column * NCOLS + row].Neighbour(worldCells[column * NCOLS + TopRow]);

                worldCells[column * NCOLS + row].Neighbour(worldCells[column * NCOLS + BottomRow]);
            }
        }

        public void Clear()
        {
            foreach (Cell worldCell in worldCells)      
            {
                // set all cells to dead 
                worldCell.CurrentState = false;
                // set all cells to be generation 0
                worldCell.Generation = 0;

            }
        }

        public void Fill()
        {
            // set 40% of cells to be alive
            foreach (Cell worldcell in worldCells)
            {
                if (random.Next(100) <= RANDFILL)
                {
                    worldcell.CurrentState = true;
                    worldcell.Generation = 0;
                }
            }
        }

        public void Draw()
        {
            foreach (Cell worldCell in worldCells)
            {
                //grid.SetCellColour(worldCells.IndexOf(worldCell), Color.White); 
                
                if (worldCell.CurrentState)
                {
                    switch (worldCell.Generation)
                    {
                        case 0:
                            grid.SetCellColour(worldCells.IndexOf(worldCell), Color.Aqua);
                            break;
                        case 1:
                            grid.SetCellColour(worldCells.IndexOf(worldCell), Color.Aqua);
                            break;
                        case 2:
                            grid.SetCellColour(worldCells.IndexOf(worldCell), Color.Teal);
                            break;
                        case 3:
                            grid.SetCellColour(worldCells.IndexOf(worldCell), Color.Blue);
                            break;
                        case 4:
                            grid.SetCellColour(worldCells.IndexOf(worldCell), Color.Navy);
                            break;
                        default:
                            grid.SetCellColour(worldCells.IndexOf(worldCell), Color.Purple);
                            break;
                    }
                }
                else
                {
                    grid.SetCellColour(worldCells.IndexOf(worldCell), Color.White);
                }
            }
        }

        public void UpdateWorld()
        {
            // tell each cell to calculate whether it will be alive in the next generation
            // tell each cell to update its state
            foreach (Cell worldcell in worldCells)
            {
                
                worldcell.CalculateNextState();
               
            }
            foreach (Cell worldcell in worldCells)
            {
                worldcell.UpdateToNextState();
               

            }
        }
    }
}
