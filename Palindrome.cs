using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            Console.WriteLine("Reversed Number: " + reversedNumber);

            if (originalNumber == reversedNumber)
            {
                Console.WriteLine("The number is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The number is NOT a Palindrome.");
            }
        }
    }
}
