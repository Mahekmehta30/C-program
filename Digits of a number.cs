using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine("Sum of digits = " + sum);
        }
    }
}
