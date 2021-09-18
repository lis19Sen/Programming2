using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Conways
{
     public class Cell
    {
        //constants 
        

        //fields
        private List<Cell> neighbours;
        private Boolean currentState;
        private Boolean nextState;
        private int generation;


        public Cell()
        {
            neighbours = new List <Cell>(); 
            currentState = false;
            nextState = false;
            generation = 0;
        }

        public void CalculateNextState()
        {
            //count number of live neighbours
            int nAlive = 0;
            foreach (Cell neighbour in neighbours)
            {
                if (neighbour.currentState == true)
                {
                    nAlive++;
                }
            }
            //implement the rules    
            
            if (currentState == true) //if the cell is alive
            {
                if ((nAlive == 2) || (nAlive == 3))
                {
                    nextState = true;
                    generation++;
                }

            }
            else                     //if the cell is dead
            {
                if (nAlive == 3)
                {
                    nextState = true;
                    generation = 0;
                }
            }
        }

        public void UpdateToNextState()
        {
            // update currState from nextState;  
            currentState = nextState;

            if (nextState == false)
            {
                generation = 0;
            }

            // reset generation to 0
            
        }

        public void Neighbour(Cell neighbour)
        {
            neighbours.Add(neighbour);
        }

        public int Generation { get => generation; set => generation = value; }

        public bool CurrentState { get => currentState; set => currentState = value; }

    }
}
