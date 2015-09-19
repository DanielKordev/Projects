using System;

class Rectangles
{
    static void Main()
    {
        string inputW;
        float yourWidth;

        string inputH;
        float yourHeight;

        do 
        {
            Console.Write("Enter a value for width: ");
            inputW = Console.ReadLine(); 

        } while (!float.TryParse(inputW, out yourWidth));


        do 
        {
            Console.Write("Enter a value for height: ");
            inputH = Console.ReadLine(); 

        } while (!float.TryParse(inputH, out yourHeight));

        Console.WriteLine("\nPerimeter = {0};  Area = {1}\n", ((yourWidth + yourHeight) * 2), (yourWidth * yourHeight));
    }
}


