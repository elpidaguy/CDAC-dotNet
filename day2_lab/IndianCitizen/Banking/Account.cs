using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{

    public delegate void Operator();
    public class Account
    {

        public event Operator OverBalance;
        public event Operator UnderBalance;

        private double balance;

        public double Balance {
                get { return balance; }
                set { balance = value; }
        }

        public Account(double amount)
        {
            this.balance = amount;
        }

        public void Deposite(double amount)
        {
            balance += amount;
            Inspect();
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
            Inspect();
        }

        void Inspect()
        {
            if (balance < 5000)
            {
                UnderBalance();
            }
            else if (balance >= 25000)
            {
                OverBalance();
            }
        }
    }
}
