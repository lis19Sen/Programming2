using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        private int strength;
        private int health;
        private string name;
        private Random random;

        public Player(int strength, int health, string name, Random random)
        {
            this.strength = strength;
            this.health = health;
            this.name = name;
            this.random = random;
        }

        

        public int Attack()
        {
            return (random.Next(1, strength + 1));
        }

        public int Strength { get => strength; set => strength = value; }
        public string Name { get => name; set => name = value; }
        protected int Health { get => health; set => health = value; }
    }
}
