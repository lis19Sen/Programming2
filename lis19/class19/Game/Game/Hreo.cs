using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Hero : Player
       
    {
        public Hero(int strength, int health, string name, Random random)
            : base(strength, health, name, random)
        {
        }

        public void Recover()
        {
            Health += 2;
        }
    }
}
