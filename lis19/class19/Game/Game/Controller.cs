using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Controller
    {
        //constant
        private const int HEROHEALTH = 10;
        private const int HEROSTRENGTH = 10;
        private const int WILD = 50;

        //fields
        private Player monster;
        private Hero hero;
        private Random random;

        public Controller(Random random)
        {
            monster = new Player(HEROSTRENGTH + random.Next(WILD), HEROHEALTH + random.Next(WILD), "Sam", random);
            hero = new Hero(HEROSTRENGTH, HEROHEALTH, "Bing", random);
        }

        public void HeroAttack()
        {

        }
    }
}
