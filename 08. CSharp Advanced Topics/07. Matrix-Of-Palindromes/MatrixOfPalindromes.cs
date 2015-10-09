using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("Please, enter a value for r: ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for c: ");
        int c = int.Parse(Console.ReadLine());

        List<string> palindromes = MakePalindromes();

        string[,] matrix = new string[r, c];
        int index = 0;
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                matrix[row, col] = palindromes[index];
                index++;
            }
            index += 27 - c; 
        }

        PrintMatrix(r, c, matrix);
    }

    private static void PrintMatrix(int r, int c, string[,] matrix)
    {
        Console.WriteLine();
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static List<string> MakePalindromes()
    {
        char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'g', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        List<string> palindromes = new List<string>();

        for (int c1 = 0; c1 < letters.Length; c1++)
        {
            for (int c2 = 0; c2 < letters.Length; c2++)
            {
                for (int c3 = 0; c3 < letters.Length; c3++)
                {
                    string temp = "" + letters[c1] + letters[c2] + letters[c3];
                    if (PalindromeCheck(temp))
                    {
                        palindromes.Add(temp);
                    }
                }
            }
        }
        return palindromes;
    }

    private static bool PalindromeCheck(string s)
    {
        bool isPalindrome = false;
        if (s == String.Join("", s.Reverse()))
        {
            isPalindrome = true;
        }
        return isPalindrome;
    }
}

