using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Lowercase_Characters_by_Uppercase_and_Vice_Versa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a;
            int i;
            Console.WriteLine("Enter the Character : ");
            a = Convert.ToChar(Console.ReadLine());
            i = (int)a;
            if (a >= 65 && a <= 90)
            {

                Console.WriteLine("The Character is : {0}", char.ToLower(a));

            }
            else if (a >= 97 && a <= 122)
            {
                Console.WriteLine("The Character is : {0}", char.ToUpper(a));
            }
            Console.ReadLine();
        }
    }
}
