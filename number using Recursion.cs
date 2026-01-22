using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_using_Recursion
{
    internal class Program
    {
        static int SumOfDigits(int number)
        {
            if (number == 0)
                return 0;
            else
                return (number % 10) + SumOfDigits(number / 10);
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = SumOfDigits(number);
            Console.WriteLine("Sum of digits = " + result);
            

        }
    }
}
