using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        DateTime start = DateTime.Parse("13:00");
        DateTime end = DateTime.Parse("3:00");
        DateTime time;
        
         try
        {
            time = DateTime.ParseExact(Console.ReadLine(), "H:mm", CultureInfo.InvariantCulture);

            if (time >= start || time <= end)
            {
                Console.WriteLine("\nbeer time\n");
            }

            else if (!(time >= start || time <= end))
            {
                Console.WriteLine("\nnon-beer time\n");
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("invalid time");
        }
    }
}