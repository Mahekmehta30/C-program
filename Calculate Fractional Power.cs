using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Fractional_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value1 = Math.Pow(2, 2.1);
            double value2 = Math.Pow(Math.E, 2);
            double value3 = Math.Pow(Math.PI, 1);
            Console.WriteLine("Result : {0}", value1);
            Console.WriteLine("Result : {0}", value2);
            Console.WriteLine("Result : {0}", value3);
            Console.ReadLine();
        }
    }
}
