using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Floyd_s_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k = 1;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j < i + 1; j++)
                {
                    Console.Write(k++ + " ");
                }

                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
