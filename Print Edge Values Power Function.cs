using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Edge_Values_Power_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value1 = Math.Pow(double.MinValue, double.MaxValue);
            double value2 = Math.Pow(double.MinValue, 0);
            double value3 = Math.Pow(double.NaN, 2);
            double value4 = Math.Pow(double.PositiveInfinity, 2);
            double value5 = Math.Pow(double.NegativeInfinity, 2);
            Console.WriteLine("Result : {0}", value1);
            Console.WriteLine("Result : {0}", value2);
            Console.WriteLine("Result : {0}", value3);
            Console.WriteLine("Result : {0}", value4);
            Console.WriteLine("Result : {0}", value5);
            Console.ReadLine();
        }
    }
}
