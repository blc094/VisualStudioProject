using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_3
{
    class Out
    {
        public static void update(out int a)
        {
            a = 10;
        }
        public static void change(ref int d)
        {
            d = 11;
        }
        public static void Main()
        {
            int b;
            int c = 9;
            Out o1 = new Out();
            update(out b);
            change(ref c);
            Console.WriteLine("Updated value is: {0}", b);
            Console.WriteLine("Changed value is: {0}", c);
        }
    }
}
