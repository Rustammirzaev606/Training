using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructorApp
{
    class Professor
    {

        string fName;
        string lName;

        int important1;
        int important2;


        public Professor(string FirstName, string LastName)  //FirstName and LastName are properties
        {
            fName = FirstName;
            lName = LastName;


        }

        public void Display()
        {
            Console.WriteLine(fName + lName);

        }
    }
}
