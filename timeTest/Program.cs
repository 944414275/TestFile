using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Timers;

namespace timeTest
{
    class Program
    {
        static string _appTime;
        static System.Timers.Timer regular_Time = new System.Timers.Timer();

        static void Main(string[] args)
        {
            
            _appTime = ConfigurationManager.AppSettings["time"];
            
            //Console.WriteLine();
            regular_Time.AutoReset = true;
            regular_Time.Enabled = true;
            regular_Time.Interval = 50000;

            regular_Time.Start();
            regular_Time.Elapsed += new ElapsedEventHandler(regularTime);

            Console.ReadKey();
        }

        static void regularTime(object source, ElapsedEventArgs e)
        {
            int _dateTime;
            _dateTime = Convert.ToInt32(_appTime);
            if (DateTime.Now.Hour==15&&DateTime.Now.Minute==57)
                Console.WriteLine("----进入小时定时,时间是："+DateTime.Now.ToString());
            Console.ReadLine();
        }
    }
}
