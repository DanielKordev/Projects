using System;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractURLsFromText
{
    static void Main()
    {
        string text = @"The site nakov.com can be access from http://nakov.com or www.nakov.com. 
It has subdomains like mail.nakov.com and svetlin.nakov.com. 
Please check http://blog.nakov.com for more information.";

        string[] words = text.Split(' ').ToArray();

        Console.WriteLine("Output:");
        foreach (string str in words)
        {
            if (IsUrl(str))
            {
                Console.WriteLine(str);
            }
        }
        Console.WriteLine();
        
    }

    private static bool IsUrl(string url)
    {
        string pattern = @"((https?|ftp|file)\://|www.)[A-Za-z0-9\.\-]+(/[A-Za-z0-9\?\&\=;\+!'\(\)\*\-\._~%]*)*";
        Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        return reg.IsMatch(url);
    }
}

