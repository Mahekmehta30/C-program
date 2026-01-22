using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfrom_Currency_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter INR: ");
            double inr = double.Parse(Console.ReadLine());
            Console.WriteLine("USD = " + (inr / 83));
        }
    }
}
