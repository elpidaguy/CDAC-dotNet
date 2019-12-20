using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
using GraphicsLib;

namespace Tester
{

    public class Complex {
        private int real;
        private int img;
        private static int count;

        public Complex()
        {
            Console.WriteLine("inside default CTOR of complex");
        }

        public Complex(int r, int i)
        {
            this.Real = r;
            this.Img = i;
        }

        ~Complex() {

        }

       

        public int Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }

        public int Real
        {
            get
            {
                return real;
            }

            set
            {
                real = value;
            }
        }

        public static int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public override string ToString()
        {
            //return base.ToString();
            return "Real: " + this.real + ", Img: " + this.img;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex result = new Complex();
            result.Real = c1.Real + c2.Real;
            result.Img = c1.Img + c2.Img;

            return result;
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex result = new Complex();
            result.Real = c1.Real - c2.Real;
            result.Img = c1.Img - c2.Img;

            return result;
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex result = new Complex();
            result.Real = c1.Real * c2.Real;
            result.Img = c1.Img * c2.Img;

            return result;
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex result = new Complex();
            result.Real = c1.Real / c2.Real;
            result.Img = c1.Img / c2.Img;

            return result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Kaustubh", "Joshi", "exabytes.js@gmail.com", "Nashik", new DateTime(1996,06,13));
            Console.WriteLine(person);

            Employee mgr = new Manager();
            Console.WriteLine("Salary of Manager: "+mgr.ComputePay());

            Employee slmgr = new SalesManager();
            Console.WriteLine("Salary of SalesManager: "+ slmgr.ComputePay());


            Shape line = new Line(10,10);
            Console.Write("Line Class SP and EP: "+line);

            Shape point = new Point(10, 10);
            Console.Write(point.draw());

            Shape rec = new Rectangle();
            Console.WriteLine(rec.draw());


            int ch = 0;
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine("Enter Choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                    Complex c1 = new Complex(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
                    Complex c2 = new Complex(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine(c1 + c2);
                        Console.ReadLine();
                    }
                    break;
                case "2":
                    { 
                    Complex c1 = new Complex(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Complex c2 = new Complex(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine(c1 - c2);
                        Console.ReadLine();

                    }
                    break;

                case "3":
                    { 
                    Complex c1 = new Complex(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Complex c2 = new Complex(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine(c1 * c2);
                        Console.ReadLine();

                    }
                    break;

                case "4":
                    { 
                    Complex c1 = new Complex(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Complex c2 = new Complex(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine(c1 / c2);
                        Console.ReadLine();

                    }
                    break;
            }
        }
    }
}
