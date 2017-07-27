using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValuePractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fav1 = "Lasagne";
            string fav2 = "Hamburgers";
            int dude1 = 228;
            int dude2 = 772;
            Console.WriteLine(FavFood(fav1, fav2));
            Console.ReadLine();
            Console.WriteLine(FavNoob(dude1, dude2));
            Console.ReadLine();
            int dudeWTF = 200;
            int dudeFML = 300;
            Console.WriteLine(Aaaa(dudeWTF, dudeFML));
            Console.ReadLine();
            int ads = 9999;
            int wquir = 098275;
            Console.WriteLine($" ({ads} + {wquir}) - ({wquir} * {ads}) * ({ads} / {wquir}) = {Ujererjnt(ads, wquir)}");
            Console.ReadLine();
        }

        private static string FavFood(string fave1, string fave2)
        {
            string bestFood =  fave1 + " " + fave2;
            return bestFood;
        }
        private static int FavNoob(int dude1, int dude2)
        {
            return dude1 + dude2;
        }
        private static int Aaaa(int qwe, int asd)
        {
            return qwe * asd;
        }
        private static int Ujererjnt(int jjjj, int jjjjg)
        {
            return (jjjj + jjjjg) - (jjjjg * jjjj) * (jjjj / jjjjg);
        }
    }
}
