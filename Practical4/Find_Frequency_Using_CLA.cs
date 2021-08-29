using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_4
{
    class Find_Frequency_Using_CLA
    {
        static void Main(String[] args)
        {
            int l = args.Length, count = 1;
            int[] freq = new int[l];
            for(int i = 0; i < l; i++)
            {
                Console.Write("{0}", args[i]);
                freq[i] = -1;
            }
            
            for(int i = 0; i < l; i++)
            {
                count = 1;
                for(int j = i + 1; j < l; j++)
                {
                    if(args[i] == args[j])
                    {
                        count++;
                        freq[j] = 0;
                    }
                    if(freq[i] != 0)
                    {
                        freq[i] = count;
                    }
                }
            }

            for(int i = 0; i < l; i++)
            {
                if(freq[i] != 0)
                {
                    Console.Write("\nThe frequency of {0} is {1}\n", args[i], freq[i]);
                }
            }
        }
    }
}
