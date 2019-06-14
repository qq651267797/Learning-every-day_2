using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadName
{
    class ThreadName
    {
        static void Main(string[] args)
        {
            Thread MyThread = Thread.CurrentThread;

            MyThread.Name = "xuegao";

            Console.WriteLine("This is " + MyThread.Name);
            Console.ReadKey();
        }
    }
}
