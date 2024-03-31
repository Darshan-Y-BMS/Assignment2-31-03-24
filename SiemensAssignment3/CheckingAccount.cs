using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class CheckingAccount : Account
    {
        protected double OverdraftLimit;

        public CheckingAccount(string accountNumber, string accountHolder, double balance, double overdraftLimit) : base(accountNumber, accountHolder, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public void withdraw()
        {
            Console.WriteLine("Enter the amount that you want to withdraw");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount <= 0)
            {
                Console.WriteLine("Invalid transaction");
            }
            else
            {
                if (amount > Balance - OverdraftLimit)
                {
                    Console.WriteLine("Your account doesn't  have enough balance ");
                }
                else
                {
                    Balance = Balance - amount;
                    Console.WriteLine("Your current balance      : " + Balance);
                }
            }

        }
    }

}
