using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace threadTimeTest
{
    class Program
    {
        static AutoResetEvent _autoEvent = null;
        static Timer _timer;
        static void Main(string[] args)
        {
            _autoEvent = new AutoResetEvent(true);
            _timer = new Timer(new TimerCallback(callBack), _autoEvent,60000,4000);//60000：第一次触发回调函数前延迟时间，4000：以后每次间隔多久触发一次回调函数
            Console.ReadLine();
        }

        static void callBack(object autowait)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)autowait;
            autoEvent.WaitOne();
            Console.WriteLine("---执行一次---");
            autoEvent.Set();
            
        }
    }
}
