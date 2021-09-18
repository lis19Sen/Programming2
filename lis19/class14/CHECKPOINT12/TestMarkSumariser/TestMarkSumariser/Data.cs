using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMarkSumariser
{
    public class Data
    {
        //constant
        private const int SCORESTOCREATE = 10;
        private const int UPPERBOUND = 101;

        //field
        private List<int> scores;
        private Random random;

        //constructor
        public Data(Random random)
        {
            this.random = random;
            Scores = new List<int>();
        }


        //method
        public void CreatSocres()
        {
            Scores.Clear();
            for (int i = 0; i < SCORESTOCREATE; i++)
            {
                Scores.Add(random.Next(UPPERBOUND));
            }
        }

        
        
        //properties
        public List<int> Scores { get => scores; set => scores = value; }

    }
}
