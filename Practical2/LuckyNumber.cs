using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_2
{
    class LuckyNumber
    {
        static void Main()
        {
            int num, flag = 0, temp, sum = 0;
            Console.Write("Enter the Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            //Checking your number is prime or not
            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            //For the sum of digits of your number
            while(num > 0)
            {
                temp = num % 10;
                sum = sum + temp;
                num = num / 10;
            }
            if(flag == 0)
            {
                //Checking the sum is prime or not
                for(int i = 2; i < sum; i++)
                {
                    if(sum % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                //If sum of digits of your number is Prime
                if(flag == 0)
                {
                    Console.Write("You entered number is a Lucky Number");
                }
                
                //If not Prime
                else
                {
                    Console.Write("You entered number is not a Lucky Number");
                }
            }
            Console.ReadKey();
        }
    }
}
