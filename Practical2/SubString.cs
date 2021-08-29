using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_2
{
    class SubString
    {
        static void Main()
        {
            Console.WriteLine("Enter the String : ");
            string s = Console.ReadLine();

            Console.WriteLine("Enter Sub String : ");
            string sb = Console.ReadLine();

            Console.WriteLine("Enter Index : ");
            int I = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Length : ");
            int L = Convert.ToInt32(Console.ReadLine());

            string s1 = s.Remove(I, L);
            string replace = s1.Insert(I, sb);

            Console.WriteLine("New String : " + replace);
            Console.ReadKey();
        }
    }
}
