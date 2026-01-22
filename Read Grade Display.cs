using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Grade_Display
{
    internal class Program
    {
        public static void Main()
        {
            char grade;
            Console.WriteLine("Enter the Grade in UpperCase \n");
            grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'S':
                    Console.WriteLine(" SUPER");
                    break;
                case 'A':
                    Console.WriteLine(" VERY GOOD");
                    break;
                case 'B':
                    Console.WriteLine(" FAIR");
                    break;
                case 'Y':
                    Console.WriteLine(" ABSENT");
                    break;
                case 'F':
                    Console.WriteLine(" FAIL");
                    break;
                default:
                    Console.WriteLine("ERROR IN GRADE \n");
                    break;
                    Console.ReadLine();
            }
        }
    }
}
