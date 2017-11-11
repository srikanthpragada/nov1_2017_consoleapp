using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    interface IAccount
    {
        void Withdraw(double amount);
        void Deposit(double amount);
        double Balance
        {
            get;
        }
    }

    class SavingsAccount : IAccount
    {
        double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
