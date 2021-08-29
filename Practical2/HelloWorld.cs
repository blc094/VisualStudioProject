using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_2
{
    class HelloWorld
    {
        static void Main()
        {
            int a;
            double d;
            char c;
            string s;
            Console.Write("Entered the value of a = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entered the value of d = ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entered the value of c = ");
            c = Convert.ToChar(Console.ReadLine());

            Console.Write("Entered the value of s = ");
            s = Console.ReadLine();

            Console.WriteLine("Integer : {0}\n Double : {1}\n Character : {2}\n String : {3} ", a, d, c, s);
            Console.ReadKey();
        }
    }
}
