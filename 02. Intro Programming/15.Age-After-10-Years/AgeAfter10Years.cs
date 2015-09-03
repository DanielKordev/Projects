using System;
using System.Globalization;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            
            Console.Write("Please enter your date of birth: ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("bg-BG"));

            TimeSpan span = today.Subtract(dateOfBirth);
            span = today - dateOfBirth;

            Console.Write("Now: ");

            DateTime zeroTime = new DateTime(1, 1, 1);
            int age = (zeroTime + span).Year - 1;
            Console.WriteLine(age);
                  
            Console.WriteLine("After 10 years: {0}", age + 10);
        }
    }
}
