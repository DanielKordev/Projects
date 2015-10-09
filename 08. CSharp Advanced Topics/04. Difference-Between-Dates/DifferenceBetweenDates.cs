using System;
using System.Globalization;
using System.Threading;

class DifferenceBetweenDates
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        Console.Write("Please, enter first date: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Please, enter second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        int daysBetween = (int)(secondDate - firstDate).TotalDays;
        Console.WriteLine("\n{0, -12}\n{1, -15}{2}", "First date", "Second date", "Days between");
        Console.WriteLine("{0, -12}\n{1, -15}{2}\n", firstDate.ToString("d.MM.yyyy"), secondDate.ToString("d.MM.yyyy"), daysBetween);
    }
}

