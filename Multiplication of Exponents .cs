using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_Multiplication_Division_and_Subtraction_of_two_numbers
{
    internal class Multiplication_of_Exponents
    {
        
        static void main()
        {
            Console.WriteLine("Enter the Base : ");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the First Exponent :");
            double exp1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Exponent :");
            double exp2 = double.Parse(Console.ReadLine());
            double mul;
            mul = exp1 + exp2;
            Console.WriteLine("Result is : {0}^{1} : {2}", num, mul, Math.Pow(num, mul));
            Console.ReadLine();
        }
    }
}

