using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;

namespace Static
{
    class process
    {
        public static void Main()
        {
            Process Memory = new Process();
            Console.WriteLine("New Process....");
            Console.WriteLine("Press enter to start process");
            Console.ReadKey();
            // Creates a process.
            Memory.StartInfo.FileName = "C:\\Users\\chandrakanth.nettem\\Documents\\Visual Studio 2015\\Projects\\StaticMemory\\Memory\\Memory\\bin\\Debug\\Memory.exe";
            Memory.Start();
            Console.WriteLine("Press enter to start the same process");
            Console.ReadKey();
            // Creates again same process.
            Memory.StartInfo.FileName = "C:\\Users\\chandrakanth.nettem\\Documents\\Visual Studio 2015\\Projects\\StaticMemory\\Memory\\Memory\\bin\\Debug\\Memory.exe";
            Memory.Start();
            Console.ReadKey();
        }
    }
}