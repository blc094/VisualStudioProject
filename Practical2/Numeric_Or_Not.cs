using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_2
{
    class Numeric_Or_Not
    {
        static void Main()
        {
            double d;
            try
            {
                Console.Write("Enter the value = ");
                d = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entered Number is not Numeric");
            }
            Console.ReadKey();
        }
    }
}
