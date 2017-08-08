using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Program
    {
        static int value = 5;
        static void Main()
        {
            Console.WriteLine("The value of static variable before change is : {0}", value);
            Console.Write("Enter a value to store in the static variable : ");
            value = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of static variable after change is : {0}", value);
            Console.ReadKey();
        }
    }
}