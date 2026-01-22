using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_odd_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter starting number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter ending number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Odd numbers in the given range are:");

            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
