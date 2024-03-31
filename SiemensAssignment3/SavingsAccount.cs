using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class SavingsAccount : Account
    {
        public double rate;

        public SavingsAccount(string accountNumber, string accountHolder, double balance, double rate) : base(accountNumber, accountHolder, balance)
        {
            this.rate = rate;
        }

        public void deposit()
        {
            Console.WriteLine("Enter the amount that you want to deposit");
            double amount = Convert.ToDouble(Console.ReadLine());
            Balance = amount + Balance;
            Console.WriteLine("Your current balance      : " + Balance);
        }
        public void withdrawal()
        {
            Console.WriteLine("Enter the amount that you want to withdraw");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount <= 0)
            {
                Console.WriteLine("Invalid transaction");
            }
            else
            {
                if (amount > Balance)
                {
                    Console.WriteLine("Your account doesn't  have enough balance ");
                }
                else
                {
                    Balance = amount + Balance;
                    Console.WriteLine("Your current balance      : " + Balance);
                }


            }
        }
        public void interestCalculation()
        {
            double interest = (Balance * rate) / 100;
            Console.WriteLine("Current interest is " + interest);
            Balance = interest + Balance;
            Console.WriteLine("Your current balance      : " + Balance);
        }

    }

}
