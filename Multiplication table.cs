using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no;

            Console.Write("Enter a no : ");
            no = Convert.ToInt32(Console.ReadLine());
            while (no <= 0)
            {
                Console.WriteLine("You entered an invalid no");

                Console.Write("Enter a no great than 0: ");
                no = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Multiplication Table :");
            for (int i = 1; i <= no; i++)
            {
                Console.WriteLine("\n");

                for (int j = 1; j <= no; j++)
                {
                    Console.Write("{0,6}", i * j);
                }
            }

            Console.Read();
        }
    }
}
