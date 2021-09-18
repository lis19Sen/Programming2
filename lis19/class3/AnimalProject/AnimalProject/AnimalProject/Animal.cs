/*The animal class contains the fields and methods about each animal objects
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class Animal
    {
        //fields, used to store data
        private string type;
        private string name;
        private int legs;

        //constructor, used to iniialise the fields
        public Animal(string type, string name, int legs)
        {
            this.type = type;
            this.name = name;
            this.legs = legs;
        }

        //method, acts on the data stored in the fields
        public string ListDetails()
        {
            return ("I am a " + type + ", and my name is " +  name + ", and I have " + legs + " legs.");
        }
    }
}
//