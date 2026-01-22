using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Two_Binary_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first binary number: ");
            string binary1 = Console.ReadLine();

            Console.Write("Enter second binary number: ");
            string binary2 = Console.ReadLine();

            // Convert binary strings to integers
            int num1 = Convert.ToInt32(binary1, 2);
            int num2 = Convert.ToInt32(binary2, 2);

            // Multiply the numbers
            int product = num1 * num2;

            // Convert result back to binary
            string binaryProduct = Convert.ToString(product, 2);

            Console.WriteLine("Product of the two binary numbers is: " + binaryProduct);
        }
    }
}
