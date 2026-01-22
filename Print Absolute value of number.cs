using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Absolute_value_of_number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                num = num * -1;
            }

            Console.WriteLine("Absolute value : " + num);
            Console.ReadLine();
        }
    }
}
