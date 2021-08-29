using System;

namespace Practical_3
{
    class Remove_Duplicate_Elements
    {
        static void Main(string[] args)
        {
            int n, i, j, x;
            int[] arr = new int[20];

            Console.WriteLine("Enter the Array size");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the array elements");
            for(i=0; i<n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("After removing duplicate elements");
            for(i=0; i<n; i++)
            {
                for(j=i+1; j<n; j++)
                {
                    if(arr[i]==arr[j])
                    {
                        for(x=j; x<n; x++)
                        {
                            arr[x] = arr[x + 1];
                        }
                        n--;
                    }
                    else
                    {
                        j++; //nothing change output
                    }
                }
            }
            for(i=0; i<n;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
