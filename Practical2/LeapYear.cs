using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_2
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter the Year = ");
            int a = Convert.ToInt32(Console.ReadLine());

            if ((a%4==0 && a%100!=0) || (a%400==0))
            {
                Console.Write("{0} is a Leap Year ", a);
            }
            else
            {
                Console.Write("{0} is not a Leap Year ", a);
            }
            Console.ReadKey();
        }
    }
}
