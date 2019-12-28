using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathServiceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.MathService proxy = new localhost.MathService();
            double res = proxy.Add(10,50);
            double res2 = proxy.Subtract(10,50);
            double res3 = proxy.Multiply(10,50);
            double res4 = proxy.Divide(10,50);

            Console.WriteLine(res);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
            Console.ReadLine();
        }
    }
}
