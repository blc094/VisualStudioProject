using System;

namespace Practical_4
{
    class ATM
    {
        public string Account_Holder;
        private int Balance;

        public ATM(string Account_holder_Name, int Initial_Balance = 0)
        {
            Balance = Initial_Balance;
            Account_Holder = Account_holder_Name;
            Console.WriteLine("Account holder name is {0} : ", Account_Holder);
        }

        public void Check_Balance() => Console.WriteLine("\n\t Your Balance is : {0}", Balance);

        public void Credit(int Amount)
        {
            Balance += Amount;
            Console.WriteLine("\n\t Amount Credited : {0}", Amount);
        }

        public void Debit(int Amount)
        {
            if(Amount > Balance)
            {
                Console.WriteLine("\n\t Your balance is less than the amount sorry! you wanna be able to debit");
                Console.WriteLine("\n\t What you want : Exit(0), Continue(1)");
                int Key = Convert.ToInt32(Console.ReadLine());
                if (Key == 1)
                {
                    Console.WriteLine("\n\t Amount debited : {0}, \n\t Remaining Amount is : {1}", Balance, Amount - Balance);
                    Balance = 0;
                }
                else return;
            }
            else
            {
                Balance -= Amount;
                Console.WriteLine("\n\t Amount debited : {0}", Amount);
            }
        }
        public void Information() => Console.WriteLine("\n\t Account Holder name is : {0}", Account_Holder);
    }
    class Govt
    {
        public static void Main()
        {
            int pin = 1234;
            Console.WriteLine("\t\t\t Welcome to SBI Services");
            Console.Write("\nEnter the Name of account holder : ");
            int Balance = 0;
            string Name = Console.ReadLine();
            ATM Account_Holder = new ATM(Name, Balance);

            Console.Write("\nEnter thr pin : ");
            pin = Convert.ToInt32(Console.ReadLine());

            if (pin == 1234)
            {
                Console.WriteLine("\nEnter Your Choice : " + "\n\tCredit : 1" + "\n\tDebit : 2" + "\n\tCheck_Balance : 3" + "\n\tInformation : 4" + "\n\tExit : 0");
                int Key = 0;

                while (true)
                {
                    Console.Write("\nEnter Your Choice : ");
                    Key = Convert.ToInt32(Console.ReadLine());

                    switch (Key)
                    {
                        case 0:
                            return;
                        case 1:
                            Console.Write("\nEnter amount you want to credit : ");
                            int Credit_Amount = Convert.ToInt32(Console.ReadLine());
                            Account_Holder.Credit(Credit_Amount);
                            break;
                        case 2:
                            Console.Write("\nEnter the amount you want to debit : ");
                            int Debit_Amount = Convert.ToInt32(Console.ReadLine());
                            Account_Holder.Debit(Debit_Amount);
                            break;
                        case 3:
                            Account_Holder.Check_Balance();
                            break;
                        case 4:
                            Account_Holder.Information();
                            break;
                        default:
                            Console.WriteLine("Please choose a valid option!!");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid pin number");
            }
        }
    }
}