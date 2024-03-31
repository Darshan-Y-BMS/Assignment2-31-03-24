using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Account
    {
        protected string AccountNumber;
        protected string AccountHolder;
        protected double Balance;

        public Account(string accountNumber, string accountHolder, double balance)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolder = accountHolder;
            this.Balance = Math.Abs(balance);

        }
        public void ShowBalance()
        {
            Console.WriteLine("Account Holder " + AccountHolder);
            Console.WriteLine("Your current Balance is " + Balance);
        }
    }

}
