using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Array_Practice_Sum_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = { 5, 10, 15, 20, 10, 50 }; //110
            for (int q = 0; q < nums.Length; ++q)
            {
                Console.WriteLine($"{sum} + {nums[q]} = " + (sum + nums[q]));
                //Console.WriteLine($"{sum} + {nums[q]}");
                sum += nums[q];
                //Console.WriteLine($"{sum} + {nums[q]}");
                //Console.WriteLine(sum += nums[q]);
                //Console.ReadKey();
                //Console.WriteLine(sum);
                Console.ReadKey();
                
            }

            //sum = nums.Sum();
            Console.WriteLine($"The SUM of the numbers in NUMS array is = {sum}");

            Console.WriteLine($"The SUM of numbers in NUMS array is = {nums.Sum()}");

            Console.ReadKey();
        }
    }
}
