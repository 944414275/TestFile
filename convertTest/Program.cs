using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading;

namespace convertTest
{
    class Program
    {
        static string _appTime;


        static void Main(string[] args)
        {
            int _dateTime;
            _appTime = ConfigurationManager.AppSettings["time"];
            _dateTime=Convert.ToInt32(_appTime);
            //Console.WriteLine();
            Console.ReadKey();
        }
    }
}
