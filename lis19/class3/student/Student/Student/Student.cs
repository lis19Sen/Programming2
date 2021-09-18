using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{ 
    class Student
    {
        //field, also called private data members
        private string FamilyName;
        private string GivenName;
        private int Age;
        private int StudentNumber;

        //constructor, has the same name with class,
        //used to asign initial values to the fields
        public Student(string FamilyName, string GivenName, int Age, int StudentNumber)
        {
            this.FamilyName = FamilyName;
            this.GivenName = GivenName;
            this.Age = Age;
            this.StudentNumber = StudentNumber;

        }

        //methoed, user define
        public string Enrol()
        {
            return (FamilyName +"\r\n"+ GivenName + Convert.ToString(Age) + Convert.ToString(StudentNumber));
        }

        //method, user define
        public string Withdraw()
        {
            return (FamilyName + GivenName + Convert.ToString(StudentNumber));
        }
    }
}
