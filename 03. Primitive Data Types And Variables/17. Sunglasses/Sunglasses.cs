using System;

class Sunglasses
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string upFrames = new String('*', 2 * N);
        string betweenFrames = new String(' ', N);
        string bridge = new String('|', N);
        string lenses = new String('/', (2 * N) - 2);

        Console.WriteLine("{0}{1}{0}", upFrames, betweenFrames);
        for (int i = 0; i < (N / 2) - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", lenses, betweenFrames);
        }
        Console.WriteLine("*{0}*{1}*{0}*", lenses, bridge);
        for (int i = 0; i < (N / 2) - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", lenses, betweenFrames);
        }
        Console.WriteLine("{0}{1}{0}", upFrames, betweenFrames);
    }
}


