using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus
{
    class Clown
    {
        //fields, or private data members
        public string name;
        public int height;
        public int age;
        public int order;

        //contructor, has the same name with class or project,
        //used to assign initial value to the field
        public Clown(string name, int height, int age, int order)
        {
            this.name = name;
            this.height = height;
            this.age = age;
            this.order = order;
        }

        //method, user define. For this one, talk about yourself
        public string TalkAboutYourself()
        {
            return ("I am clown" + order + ". My name is " + name + ", I am " + age + " years old. And I am "
                + height + " centimeters tall.");
        }
    }
}
