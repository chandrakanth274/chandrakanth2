using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OutParameter
{
    class Program
    {
        public static void Main()
        {
            int value = 2;
            Console.WriteLine("value in main before change{0}", value);
            // Creating an object of ClassOutParameter.
            ClassOutParameter obj = new ClassOutParameter();
            // Creating a thread.
            Thread thread = new Thread(() => obj.method(out value));
            thread.Start();
            Console.WriteLine("value in out before change{0}", value);
            Thread.Sleep(300);
            Console.WriteLine("value in main after change{0}", value);
            Console.ReadKey();
        }
    }
}