/* Program name: 	    <<Formal program name>>
   Project file name:
   Author:		    <<Your name>>
   Date:	 
   Language:		    C#
   Platform:		    Microsoft Visual Studio 2013
   Purpose:		    <<What does the program do?  One-to-two sentences only>>
   Description:		    <<A detailed description of what the program does>>
   Known Bugs:		    <<Must be commented out, your program MUST compile>>
   Additional Features:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    class Animal
    {
        //fields, or private data members
        public string type;
        public string name;
        public int legs;

        // consturctor, has the same name with project or class,
        // used to asign intial value to the fields
        public Animal(string type, string name, int legs)
        {
            this.type = type;
            this.name = name;
            this.legs = legs;
        }

        // methods, user define
        public string ListDetails()
        {
            return("I am a " + type + ", my name is " + name + ", and I have"
            + legs + " legs");
        }
    }
}
