using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_3
{
    class Sort
    {
        public static void Main()
        {
            int[] arr = new int[10];
            int n, i, j, temp;

            Console.WriteLine("Enter the size of the array");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter elements in the array",n);
            for(i = 0; i < n; i++)
            {
                Console.Write("{0} :\t",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(i = 0; i < n; i++)
            {
                for( j = i + 1; j < n; j++)
                {
                    if(arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("\n Elements of array in sort");
            for(i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
