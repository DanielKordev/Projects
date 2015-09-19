using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        string input;
        float weight;

        do
        {
        Console.Write("Enter a weight value: ");
        input = Console.ReadLine().Replace(",", ".");

        } while (!float.TryParse(input, out weight));
        
        Console.WriteLine("\nWeight on Moon (17% of the weight on Earth) \n= {0}kg\n", ((17 * weight)/100));
    }
}

