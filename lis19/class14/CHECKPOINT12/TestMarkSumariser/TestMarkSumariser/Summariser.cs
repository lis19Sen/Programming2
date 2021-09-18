using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMarkSumariser
{
   public class Summariser
    {
        private const int MAXSCORE = 100;

        public Summariser()
        {

        }

        public int CalculateMimimum(List<int> scores)
        {
            int minimum = MAXSCORE;
            foreach (int score in scores)
            {
                if (score < minimum)
                {
                    minimum = score;
                }
            }
            return (minimum);
        }
        public int CaculateMaximum(List<int> scores)
        {
            int maximum = 0;
            foreach (int score in scores)
            {
                if (score > maximum)
                {
                    maximum = score;
                }
            }
            return (maximum);
        }
        public double Average(List<int> scores)
        {
            double total = 0;
            foreach (int score in scores)
            {
                total = total + score;
            }

            double average = total / scores.Count;
            return average;
        }
    }
}
