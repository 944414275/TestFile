using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace autoReSetEvent
{
    class Program
    {
        static AutoResetEvent auto1 = new AutoResetEvent(true);
        static AutoResetEvent auto2 = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Console.WriteLine("please enter key to create three thread");
            Console.ReadLine();

            for(int i=1;i<4;i++)
            {
                Thread t = new Thread(threadPro);
                t.Name = "线程" + i;
                t.Start();
            }
            Thread.Sleep(1000);
            
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("press enter to releas another thread.");
                Console.ReadLine();
                auto1.Set();
                Thread.Sleep(1000);
            }

            Console.WriteLine("\r\nall threads are waiting on 2#");
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("press enter to release a thread.");
                Console.ReadLine();
                auto2.Set();
                Thread.Sleep(1000);
            }
        }

        static void threadPro()
        {
            string name = Thread.CurrentThread.Name;

            Console.WriteLine("{0} waits on autoresetevent 1#.",name);
            auto1.WaitOne();
            Console.WriteLine("{0} is releasedd from aotoresetevent 1#.",name);

            Console.WriteLine("{0} waits on autoresetevent 2#.",name);
            auto2.WaitOne();
            Console.WriteLine("{0} is realeased from autoresetevent 2#.",name);

            Console.WriteLine("{0} ends.",name);
        }
    }
}
