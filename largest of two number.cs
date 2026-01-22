using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest_of_two_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("The largest number is: " + num1);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("The largest number is: " + num2);
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }
        }
    }
}
