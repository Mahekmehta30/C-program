using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_all_the_multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum of multiples of 3 and 5: " + sum);
        }
    }
}
