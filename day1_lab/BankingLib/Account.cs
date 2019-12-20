using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    public class Account
    {
        private int balance;

        public int Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public String withdraw()
        {
            return "Withdraw is called";
        }

        public String deposite()
        {
            return "Deposite is called";
        }

        public override string ToString()
        {
            //return base.ToString();
            return "Balance is: " + this.balance;
        }
    }
}
