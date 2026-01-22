using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_Multiplication_Division_and_Subtraction_of_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sum = " + (num1 + num2));
            Console.WriteLine("Subtraction = " + (num1 - num2));
            Console.WriteLine("Multiplication = " + (num1 * num2));

            if (num2 != 0)
            {
                Console.WriteLine("Division = " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
        }
    }
}
