using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value of i is {i}");
                
            }

            string[] stars = { "Beyonce", "Rhianna", "Janet Jackson", "Madonna" };
            for(int k = 4; k > stars.Length; --k)
            {
                
                Console.WriteLine($"The stars are " + (stars[k]));
            }

            int[] numbers = {1, 2, 3, 4, 5, };
            
            for (int d = numbers.Length - 1; d >= 0; --d)
            {
                
                Console.WriteLine(numbers[d]);

            }
            Console.ReadKey();
            string[] vidiaGames = { "DOTA 2", "WarCraft", "World of WarCraft", "StarCraft", "S.T.A.L.K.E.R", "CS:GO", "RockSmith", "Town of Salem", "PUBg", "The Elder Scrolls" };
            for (int x = vidiaGames.Length - 1; x >= 0; --x )
            {
                Console.WriteLine(vidiaGames[x]);
            }
            string[] colors = { "red", "blue", "green", "black", "white" };

            int[] nums = new int[6];
            nums[0] = 1;
            nums[1] = 5;
            nums[2] = 99;
            nums[3] = 500;
            for (int n = 0; n < 6; ++n)  
            {
                Console.WriteLine($"The values of array nums is " + nums[n]);
            }
            char[] bruh = { 'v', 'a', 'c', 'b', 'a', 'n' };
            for( int m = 0; m < bruh.Length; ++m)
            {
                Console.WriteLine($"The value of the letter with index of {m} is {bruh[m]}");
            }
            Console.ReadKey();

        }
    }
}
