/* Program name: 	   Animal Project
   Project file name:  Animal
   Author:		       Sen Li
   Date:	           09/08/2018
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

namespace Animal
{

    class Animal
    {
        //fields, also called private data members, always begin with
        //lower case letter and are always private so that they are limited 
        //to their class
        private string type;
        private string name;
        private int age;

        //construtor, used to assign initial values to the fields
        public Animal(string type, string name, int age)
        {
            this.type = type;
            this.name = name;
            this.age = age;

        }
        //method, user define
        public string ListDetails()
        {
            return ("I am a " + type + ", my name is " + name + "and I am " +
                age + "years old");
        }
    }
}
