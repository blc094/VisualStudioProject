using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_2
{
    class Even_Number
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter the Number = ");
                int a = Convert.ToInt32(Console.ReadLine());
                if(a%2==0)
                {
                    Console.WriteLine("Entered Number is Even");
                }
                else
                {
                    throw new Exception("Entered Number is not Even");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
