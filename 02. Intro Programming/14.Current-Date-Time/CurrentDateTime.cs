using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentDateTime
{
    class CurrentDateTime
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.UTF8;
            DateTime today = DateTime.Now;
            Console.WriteLine(today);
        }
    }
}
