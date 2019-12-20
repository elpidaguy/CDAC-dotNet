using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Manager : Employee
    {
        private int salary = 15000;
        public override int ComputePay()
        {
            //return base.ComputePay();
            return 600 + 100 + 400 + salary;
        }
    }
}
