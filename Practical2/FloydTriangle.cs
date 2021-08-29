using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_2
{
    class FloydTriangle
    {
        static void Main()
        {
            int temp = 1;
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<num; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write(temp + " ");
                    temp++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
