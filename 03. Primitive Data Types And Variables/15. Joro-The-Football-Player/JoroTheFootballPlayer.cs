using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        const int weekendsPerYear = 52;
        int numberOfPlays = p / 2 + ((weekendsPerYear - h) * 2) / 3 + h;
        if (year == "t")
        {
            numberOfPlays = p / 2 + ((weekendsPerYear - h) * 2) / 3 + h + 3;
        }
        Console.WriteLine();
        Console.Write(numberOfPlays);
        Console.WriteLine(" plays");
    }
}

