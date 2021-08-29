using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_3
{
    class Params
    {
             // User defined function  
        public void Show(params int[] val) // Params Paramater  
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            Params program = new Params(); // Creating Object  
            program.Show(2, 4, 6, 8, 10, 12, 14); // Passing arguments of variable length  
        }
    }
}
