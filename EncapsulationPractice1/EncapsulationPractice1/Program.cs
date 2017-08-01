using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice1
{
    class Program
    {
        //public int idNumber { get; set; }
        //private int idNumber;

        //public int IdNumber
        //{
        //    get
        //    {
        //        return idNumber;
        //    }
        //    set
        //    {
        //        IdNumber = value;
        //    }
        //}
        
        

        static void Main()
        {
            Student bruh = new Student();
            bruh.IdNumber = 1999;
            bruh.LastName = "Mirzaev";
            bruh.FirstName = "Rustam";
            Program dude = new Program();
            dude.ShowStudent(bruh);
            Console.ReadLine();
        }

        public void ShowStudent(Student scholar)
        {
            Console.WriteLine($"My Id Number is {scholar.IdNumber}, my first name is {scholar.FirstName} and my last name is {scholar.LastName}");


        }
    }
}
