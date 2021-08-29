using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_4
{
    class String_Builder
    {
        static void Main()
        {
            StringBuilder testString = new StringBuilder("indiais");
            String test = "Jay Hind";
            testString.Append("great");
            Console.WriteLine("After Append : {0}\n", testString);

            testString.AppendFormat(" i proud to be an Indian {0}", test);
            Console.WriteLine("After AppendFormat : {0}\n", testString);

            testString.Insert(5, " ");
            testString.Insert(8, " ");
            Console.WriteLine("After Insert : {0}\n", testString);

            testString.Replace("i","I");
            testString.Replace("g", "G");
            Console.WriteLine("After Replace : {0}\n", testString);

            testString.Remove(14, 10);
            testString.Remove(6, 4);
            Console.WriteLine("After Remove : {0}\n", testString);

            Console.WriteLine("Final string is : {0}\n", testString);
        }
    }
}
