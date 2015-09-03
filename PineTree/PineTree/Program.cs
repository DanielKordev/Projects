using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int asterix = i;
                int spaces = n - asterix;
                Console.Write(new string(' ', spaces));
                Console.Write(new string('*', asterix));
                Console.Write("|");
                Console.Write(new string('*', asterix));
                Console.WriteLine(new string(' ', spaces));
            }
        }
    }
}
