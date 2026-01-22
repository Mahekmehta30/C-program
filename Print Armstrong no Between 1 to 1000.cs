using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Armstrong_no_Between_1_to_1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, a, b, c, d;
            for (int i = 1; i <= 1000; i++)
            {
                num = i;
                a = num / 1000;   // thousands place
                num = num % 1000;
                b = num / 100;    // hundreds place
                num = num % 100;
                c = num / 10;     // tens place
                d = num % 10;     // units place

                // Check if the sum of the cubes of the digits equals the original number
                if (i == a * a * a * a + b * b * b * b + c * c * c * c + d * d * d * d)
                {
                    System.Console.WriteLine(i);
                }
                else if (i == b * b * b + c * c * c + d * d * d)  // for 3-digit numbers
                {
                    System.Console.WriteLine(i);
                }
                else if (i == c * c + d * d)  // for 2-digit numbers
                {
                    System.Console.WriteLine(i);
                }
                else if (i == d)  // for single-digit numbers
                {
                    System.Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
