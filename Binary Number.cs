using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first binary number: ");
            string binary1 = Console.ReadLine();

            Console.Write("Enter second binary number: ");
            string binary2 = Console.ReadLine();

            // Convert binary to decimal
            int num1 = Convert.ToInt32(binary1, 2);
            int num2 = Convert.ToInt32(binary2, 2);

            // Add the numbers
            int sum = num1 + num2;

            // Convert sum back to binary
            string binarySum = Convert.ToString(sum, 2);

            Console.WriteLine("Sum of the two binary numbers: " + binarySum);
        }
    }
    }

