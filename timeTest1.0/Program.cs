using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace timeTest1._0
{
    class Program
    {
        static System.Timers.Timer timer = new System.Timers.Timer();
        
        static void Main(string[] args)
        {
            timer.Enabled = true;
            timer.Interval = 60000;//执行间隔时间,单位为毫秒  
            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer1_Elapsed);
            Console.ReadLine();
        }

        static void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // 得到 hour minute second  如果等于某个值就开始执行某个程序。  
            int intHour = e.SignalTime.Hour;
            int intMinute = e.SignalTime.Minute;
            int intSecond = e.SignalTime.Second;
            // 定制时间； 比如 在10：30 ：00 的时候执行某个函数  
            int iHour = 10;
            int iMinute = 30;
            int iSecond = 00;
            // 设置　 每秒钟的开始执行一次  
            if (intSecond == iSecond)
            {
                Console.WriteLine("每秒钟的开始执行一次！");
            }
            // 设置　每个小时的３０分钟开始执行  
            if (intMinute == iMinute && intSecond == iSecond)
            {
                Console.WriteLine("每个小时的３０分钟开始执行一次！");
            }

            // 设置　每天的１０：３０：００开始执行程序  
            if (intHour == iHour && intMinute == iMinute && intSecond == iSecond)
            {
                Console.WriteLine("在每天１０点３０分开始执行！");
            }
        }
    }
}
