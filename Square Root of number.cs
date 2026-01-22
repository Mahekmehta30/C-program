using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Root_of_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, res;
            Console.Write("Enter the Number : ");
            num = double.Parse(Console.ReadLine());
            res = Math.Ceiling(Math.Pow(num, (double)1 / 3));
            Console.Write("Cube Root : " + res);

        }
    }
}
