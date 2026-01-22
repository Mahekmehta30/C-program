using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caluculate_Power_of_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new GeneratePowers().RaiseToPower
                       (5,    // 4 values per table
                        3);
            Console.ReadLine();// power to raise each value
        }
    }

    public class GeneratePowers
    {
        public void RaiseToPower(int maxIterations, int power)
        {
            Console.WriteLine("{0,8}{1,16}",
                "Number", "Power of " + power);
            for (int i = 1; i <= maxIterations; ++i)
            {
                Console.Write("{0,5}{1,15}\n", i,
                   Math.Pow(i, power));
            }
        }
    }
}
