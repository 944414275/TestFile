using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace autoReSetEvent
{
    class Program
    {
        AutoResetEvent auto1 = new AutoResetEvent(true);
        AutoResetEvent auto2 = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Console.WriteLine("please enter key to create three thread");
            for(int i=1;i<4;i++)
            {
                Thread t = new Thread(threadPro);
                t.Name = "线程" + i;
                t.Start();
            }


        }

        static void threadPro()
        {

        }
    }
}
