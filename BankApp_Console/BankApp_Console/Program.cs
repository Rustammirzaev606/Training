﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 1000;
            string tempInput, decision;
            Program bank = new Program();
            Console.WriteLine("Hello! Welcome to Rustam's BadAss Bank.");
            do
            {
                Console.WriteLine($"How can we help you?\n1 - Deposit:\n2 - Withdraw:\n3 - Balance:  {balance.ToString("C")}");
                tempInput = Console.ReadLine().ToLower();
                if (tempInput == "1" || tempInput == "deposit")
                {
                    bank.Deposit(ref balance);
                }
                else if (tempInput == "2" || tempInput == "withdraw")
                {
                    bank.Withdraw(ref balance);
                }
                else if (tempInput == "3" || tempInput == "balance")
                {
                    Console.WriteLine($"Your current balance is {balance.ToString("C")}");
                }
                else
                {
                    Console.WriteLine("Ooops! Something went wrong!");
                }
                Console.WriteLine("\n Press Enter to make another transaction. Or type NO or EXIT to finish the programm:");
                decision = Console.ReadLine().ToLower();
            } while (decision != "no" ^ decision != "n" ^ decision != "exit");
            bank.ByeBye();
            Console.ReadLine();
        }
        void Withdraw(ref double balance)
        {
            string tempInput;
            double tempWithd;
            Console.WriteLine("How much would you like to withdraw?:");
            tempInput = Console.ReadLine();
            double.TryParse(tempInput, out tempWithd);
            while(!double.TryParse(tempInput, out tempWithd))
            {
                Console.WriteLine("Sorry, we dont understand You.\nHow much would You like to withdraw?:");
                tempInput = Console.ReadLine();
                double.TryParse(tempInput, out tempWithd);
            }
            if (tempWithd < 0)
            {
                
                while (!double.TryParse(tempInput, out tempWithd))
                {
                    Console.WriteLine("Sorry, we dont understand You.\nHow much would You like to withdraw?:");
                    tempInput = Console.ReadLine();
                    double.TryParse(tempInput, out tempWithd);
                }
                while (tempWithd < 0)
                {
                    Console.WriteLine("Please dont use negative values! Try again!:");
                    tempInput = Console.ReadLine();
                    double.TryParse(tempInput, out tempWithd);

                }

            }
            else if (tempWithd > balance)
            {
                while (!double.TryParse(tempInput, out tempWithd))
                {
                    Console.WriteLine("Sorry, we dont understand You.\nHow much would You like to withdraw?:");
                    tempInput = Console.ReadLine();
                    double.TryParse(tempInput, out tempWithd);
                }
                while (tempWithd > balance)
                {
                    Console.WriteLine("Please dont use negative values! Try again!:");
                    tempInput = Console.ReadLine();
                    double.TryParse(tempInput, out tempWithd);

                }
            }
            else
            {
                Console.WriteLine("Oooop! Something went wrong!");
            }
            balance -= tempWithd;
            Console.WriteLine($"We are printing {tempWithd.ToString("C")} for You.\n\nNew balance is {balance.ToString("C")}");
        }
        void Deposit(ref double balance)
        {
            string tempInput;
            double tempDepo;
            //Console.WriteLine($"Current balance = {balance.ToString("C")}");
            Console.WriteLine("How much would you like to deposit?:");
            tempInput = Console.ReadLine();
            double.TryParse(tempInput, out tempDepo);
            while (!(tempDepo > 0))
            {
                while (!double.TryParse(tempInput, out tempDepo))
                {
                    Console.WriteLine("Sorry, we dont understand You.\nHow much would You like to deposit?:");
                    tempInput = Console.ReadLine();
                    double.TryParse(tempInput, out tempDepo);
                }
                while (tempDepo < 0)
                {
                    Console.WriteLine("Please dont use negative values! Try again!");
                    tempInput = Console.ReadLine();
                    double.TryParse(tempInput, out tempDepo);

                }
            }

            balance += tempDepo;
            Console.WriteLine($"We added {tempDepo.ToString("C")} to your balance!\n\nNew balance is {balance.ToString("C")}");

        }
        void ByeBye()
        {
            string email = "RustamMirzaev606@gmail.com", phone = "(216)801-6162", firstName = "Rustam", lastName = "Mirzaev";
            Console.WriteLine($"Thank you for using our bank.\nCEO/GM/PRESIDENT \n{firstName} {lastName}\n{phone}\n{email}");

        }
    }
}
