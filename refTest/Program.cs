using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace refTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 3;
            Console.WriteLine("before {0},{1}",a.ToString(),b.ToString());
            function function = new function();
            b=function.squa(ref a);
            Console.WriteLine("after {0},{1}",a.ToString(),b.ToString());
            Console.ReadLine();
        }
    }

    class function
    {
        public double squa(ref double x)
        {
            double c = x;
            c *= c;
            //x *= x;
            return c;
        }
    }
}
