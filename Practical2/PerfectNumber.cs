using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_2
{
    class PerfectNumber
    {
        static void Main(String[] args)
        {
            int num, num1, n, sum = 0, mul = 1;
            Console.WriteLine("Enter any Number:");
            num = Convert.ToInt32(Console.ReadLine());
            num1 = num;
            while(num!=0)
            {
                n = num % 10;
                sum = sum + n;
                mul = mul * n;
                num = num / 10;
            }
            Console.WriteLine("Sum=" + sum);
            Console.WriteLine("Mul=" + mul);
            if(sum==mul)
            {
                Console.WriteLine(num1 + " is a perfect number");
            }
            else
            {
                Console.WriteLine(num1 + " is not a perfect number");
            }
            Console.ReadKey();
        }
    }
}
