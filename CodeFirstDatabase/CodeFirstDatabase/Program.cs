using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using static System.Console;
//using System.ComponentModel.DataAnnotations;


namespace CodeFirstDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookContext())
            {
                Book book1 = new Book { Title = "Beginning Visual C# 2015", Author = "Perkins, Reid, and  Hammer" };
                db.Books.Add(book1);


                Book book2 = new Book { Title = "Beginning XML", Author = "Lerooooy Jaaankins" };

                db.Books.Add(book2);
                db.SaveChanges();

                var query = from b in db.Books
                            orderby b.Title
                            select b;
                WriteLine("All books in the database:");
                foreach(var b in query)
                {
                    WriteLine($"{b.Title} by {b.Author}, code = {b.Code}");

                }
                WriteLine("Press a key to exit");
                ReadKey();


            }
        }
    }
}
