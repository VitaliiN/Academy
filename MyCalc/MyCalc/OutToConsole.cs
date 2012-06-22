using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalc
{
    class OutToConsole : IOut
    {
        public void Out(string result)
        {
            System.Console.Out.WriteLine(result);
        }
    }
}
