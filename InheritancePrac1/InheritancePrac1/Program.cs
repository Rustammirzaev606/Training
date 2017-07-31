using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritancePrac1
{


    public class Employee  //base class
    {
        public string FirstName;
        public string LastName;
        public int EmployeeId;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine($"My first name is {FirstName} and my last name is {LastName}.");



        }
    }
    class Program
    {
            
       
        static void Main(string[] args)
        {
            FullTimeEmployee ft = new FullTimeEmployee();
            ft.FullTimeId = 1001;
            ft.FirstName = "Mary";
            ft.LastName = "Mitchel";
            ft.PrintFullName();
            WriteLine("********************");

            PartTimeEmployee pt = new PartTimeEmployee();
            pt.PartTimeId = 3025;
            pt.FirstName = "Peter";
            pt.LastName = "Parker";
            pt.PrintFullName();
            Console.ReadLine();
            SeasonalWorker sw = new SeasonalWorker();
            sw.FirstName = "Dude";
            sw.LastName = "Wtf";
            sw.PrintFullName();
            WriteLine("----------------------");
            HumanResources hr = new HumanResources();
            hr.FirstName = "soiiorre";
            hr.LastName = "riojtlk";
            hr.PrintFullName();
            WriteLine("////////////////////");
            ReadLine();
            

        }
    }
    public class FullTimeEmployee : Employee
    {
         public double Salary, FullTimeId;




    }

    public class PartTimeEmployee : Employee
    {
        public double HourlyRate, PartTimeId;
    }
    public class SeasonalWorker : FullTimeEmployee
    {
        public int SeasonID;
        public string Address;

    }

    public class HumanResources : SeasonalWorker
    {
        public int PhoneNumber;
        public string Memes;

    }
}
