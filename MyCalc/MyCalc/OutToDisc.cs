using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace MyCalc
{
    class OutToDisc : IOut
    {
        public string FilePath { get; set; }
        public void Out(string result)
        {
            using (var file = new StreamWriter(@FilePath, true))
            {
                file.WriteLine(result);
            }  
        }
    }
}
