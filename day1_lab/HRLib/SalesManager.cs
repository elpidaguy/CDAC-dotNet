using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class SalesManager : Employee
    {
        private int salary = 10000;

        public override int ComputePay()
        {
            //return base.ComputePay();

            return 500 + 500 + salary;
        }
    }
}
