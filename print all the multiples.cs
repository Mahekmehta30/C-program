using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_all_the_multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiples of 17 less than 100:");

            for (int i = 17; i < 100; i += 17)
            {
                Console.WriteLine(i);
            }
        }
    }
}
