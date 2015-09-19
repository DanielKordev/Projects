using System;
using System.Collections.Generic;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<string> halfDiamond = new List<string>();

        string topHyphen = new String('-', n / 2);
        string top = topHyphen + "*" + topHyphen;

        halfDiamond.Add(top);

        for (int i = 1, j = 1; i <= n/2; i++, j +=2)
        {
            string middleLineHyphenOut = new String('-', n / 2 - i);
            string middleLineHyphenIn = new String('-', j);
            string middle = middleLineHyphenOut + "*" + middleLineHyphenIn + "*" + middleLineHyphenOut;
            halfDiamond.Add(middle);
        }

        for (int i = 0; i < halfDiamond.Count; i++)
        {
            Console.WriteLine(halfDiamond[i]);
        }

        for (int k = halfDiamond.Count - 2; k >= 0; k--)
        {
            Console.WriteLine(halfDiamond[k]);
        }
    }
}

