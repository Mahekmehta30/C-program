using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrate_of_Conditional_Logical_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter the Age :");
            age = int.Parse(Console.ReadLine());
            bool adult = age >= 18 ? true : false;
            Console.WriteLine("Adult : {0}", adult);
            Console.Read();
        }
    }
}
