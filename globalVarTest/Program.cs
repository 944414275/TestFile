using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace globalVarTest
{
    class Program
    {
        static string _appTime;
        static System.Timers.Timer regular_Time = new System.Timers.Timer();
        static int a = 0;
        static Int32 sum = 0;
        static SortedDictionary<int, string> t = new SortedDictionary<int, string>();

        static void Main(string[] args)
        {
            regular_Time.AutoReset = true;
            regular_Time.Enabled = true;
            regular_Time.Interval = 2000;

            t.Add(1, "102459.38");
            t.Add(2, "74931.88");
            //t.Add(3, "30");
            //t.Add(4, "40");
            //t.Add(5, "50");
            
            regular_Time.Start();
            regular_Time.Elapsed += new ElapsedEventHandler(regularTime);
            Console.ReadKey();
        }

        static void regularTime(object source, ElapsedEventArgs e)
        {

            try
            {
                foreach (var temp in t)
                {
                    //sum += Convert.ToInt32(Convert.ToDouble(temp.Value));
                    sum += Convert.ToInt32(temp.Value,10);
                }
            }
            catch (Exception xe)
            {

                Console.WriteLine("---将字符串转换成int型出错"+ xe.ToString());
            }
            
            Console.WriteLine(sum.ToString());
            sum = 0;
            Console.ReadLine();
        }
    }
}
