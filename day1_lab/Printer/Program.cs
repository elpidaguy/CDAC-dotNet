using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingLib;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAcc = new Account();
            Console.WriteLine(myAcc.withdraw());
            Console.WriteLine(myAcc.deposite());
            Console.WriteLine(myAcc);
            Console.ReadLine();
        }
    }
}
