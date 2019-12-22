using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;
using Govt;
using BankingHandlers;

namespace Portal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account acct = new Account(15000);
            acct.UnderBalance += new Operator(AccountListeners.BlockAccount);
            acct.UnderBalance += new Operator(AccountListeners.SendEmail);
            acct.OverBalance += new Operator(UPAGovt.PayIncomeTax);

            acct.Deposite(3000000);
            //acct.Withdraw(11000);

            Console.ReadLine();
        }
    }
}
