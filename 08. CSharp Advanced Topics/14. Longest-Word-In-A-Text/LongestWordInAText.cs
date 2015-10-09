using System;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        string text1 = @"Welcome to the Software University.";
        string text2 = @"The C# Basics course is awesome start 
in programming with C# and Visual Studio.";

        Console.WriteLine("{0, -50}{1, -12}", "Input", "Output");
        Console.WriteLine("{0, -50}{1, -12}", text1, FindLongestWord(text1));
        Console.WriteLine();
        Console.WriteLine("{0, -50}{1, -12}", "Input", "Output");
        Console.WriteLine("{0, -90}{1, -12}", text2, FindLongestWord(text2));
        Console.WriteLine();
    }

    private static string FindLongestWord(string text1)
    {
        char[] delimiter = new char[] { '.', ' ' };
        string[] arr1 = text1.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToArray(); 
        arr1 = arr1.OrderBy(aux => aux.Length).ToArray(); 
        return arr1[arr1.Length - 1]; 
    }
}

