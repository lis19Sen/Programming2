using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsAndTails
{
    class Coin
    {
        //cosntant
        private const int NUMBEROFSIDE = 2;
        //fields, used to
        
        private string coinSide; //private name use lowercase word
        private Random random;
        private int headCount;
        private int tailCount;

        public Coin(Random random)
        {
            this.random = random; 
        }

        public string Throw()
        {
            int temp = random.Next(NUMBEROFSIDE);
            
            if ( temp == 0)
            {
                coinSide = "Head";
                headCount++;
            }
            else
            {
                coinSide = "Tail";
                tailCount++;
            }

            return coinSide;
        }

        public int HeadCount { get => headCount; set => headCount = value; }
        public int TailCount { get => tailCount; set => tailCount = value; }
      
    }
}
