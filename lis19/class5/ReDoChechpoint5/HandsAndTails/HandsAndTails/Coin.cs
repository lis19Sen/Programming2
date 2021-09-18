using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsAndTails
{
    public class Coin
    {
        //constant, use captal words
        private const int NUMBEROFSIDE = 2;
        //fields, also called private data members
        private string sideUp;
        private Random random;
        private int headCount;
        private int tailCount;

        //constructor, used to asign initial values to the field
        public Coin(Random random1)
        {
            random = random1;
        }

        public string SideUp { get => sideUp; set => sideUp = value; }
        public int HeadCount { get => headCount; set => headCount = value; }
        public int TailCount { get => tailCount; set => tailCount = value; }

        //methods, user define
        public string Throw()
        {
            int temp = random.Next(NUMBEROFSIDE);
            if (temp == 0)
            {
                SideUp = "Head";
                HeadCount++;
                
            }
            else
            {
                SideUp = "Tail";
                TailCount++;
            }
            return (SideUp);
        }


    }
}
