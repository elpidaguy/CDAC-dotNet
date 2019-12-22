using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingHandlers
{
    public class AccountListeners
    {
        public static void BlockAccount()
        {
            Console.WriteLine("Your Account has been Blocked.");
        }

        public static void SendEmail()
        {
            Console.WriteLine("Email has been sent to your linked account.");
        }
    }
}
