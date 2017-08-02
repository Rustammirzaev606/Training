using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee rustam = new Employee();
            rustam.FirstName = "Rustam";
            rustam.LastName = "Mirzaev";
            rustam.IdNumber = 5000;
            rustam.SocNumber = 1234400;
            rustam.Tuition = 5000;
            Program p = new Program();
            p.DisplayInfo(rustam);
            
            Console.ReadLine();
        }

        public void DisplayInfo(Employee emp)
        {
            Console.WriteLine($"My first name is {emp.FirstName}.\nMy last name is {emp.LastName}.\nID Number {emp.IdNumber}.\nSocial Security Number {emp.SocNumber}.\n Tuition is {emp.Tuition}");

        }
    }
}
