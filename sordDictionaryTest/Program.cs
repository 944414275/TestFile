using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sordDictionaryTest
{
    class Program
    {
        static SortedDictionary<int, string> t = new SortedDictionary<int, string>();
        static void Main(string[] args)
        {
            t.Add(1,"10");
            t.Add(2, "20");
            t.Add(3, "30");
            t.Add(4, "40");
            t.Add(5, "50");

            Int32 sum=0;
            foreach(var temp in t)
            {
                sum += Convert.ToInt32(temp.Value);
            }
            Console.WriteLine(sum.ToString());
            Console.ReadLine();

        }
    }
}
