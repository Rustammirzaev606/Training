﻿using System;
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

        public Professor()
        {
            Console.WriteLine("BRUH");
        }
        public Professor(string FirstName, string LastName)  //FirstName and LastName are properties
        {
            fName = FirstName;
            lName = LastName;


        }
        public Professor(int Code1, int Code2)
        {
            important1 = Code1;
            important2 = Code2;

        }

        public void Display()
        {
            Console.WriteLine(fName + " " + lName);

        }

        public void SecreNumbes(int Code1, int Code2)
        {
            important1 = Code1;
            important2 = Code2;
        }
        public void DipslayNumb()
        {
            Console.WriteLine($"Secret numbers are {important1} and {important2}");
        }
    }
}
