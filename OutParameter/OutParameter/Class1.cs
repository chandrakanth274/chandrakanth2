using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OutParameter
{
    class ClassOutParameter
    {
        public void method(out int value)
        {
            Thread.Sleep(200);
            value = 20;
        }
    }
}
