using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongSequence
{
    class LongSequence
    {
        static void Main()
        {
            List<int> numbers1 = new List<int>();
            for (int i = 2; i <= 1001; i++)
            {
                if (i % 2 == 0)
                {
                    numbers1.Add(i);
                }
                else
                {
                    numbers1.Add(-i);
                }
            }
            string sequence = string.Join(", ", numbers1.ToArray());
            Console.WriteLine(sequence);
        }
    }
}
