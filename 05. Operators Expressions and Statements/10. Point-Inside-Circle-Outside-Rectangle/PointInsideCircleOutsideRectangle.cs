using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        double radius = 1.5;
        double cCentX = 1;
        double cCentY = 1;

        double rTop = 1;
        double rLeft = -1;
        double rWidth = 6;
        double rHeight = 2;

        string inputX;
        double x;

        string inputY;
        double y;

        do  
        {
            Console.Write("Enter a value for x: ");
            inputX = Console.ReadLine();

        } while (!double.TryParse(inputX, out x));

        do  
        {
            Console.Write("Enter a value for y: ");
            inputY = Console.ReadLine();

        } while (!double.TryParse(inputY, out y));

        bool insideCircle = Math.Pow((x - cCentX), 2) + Math.Pow((y - cCentY), 2) <= Math.Pow(radius, 2);

        bool insideRectangle = (x >= rLeft) && (x <= (rLeft + rWidth)) && (y <= rTop) && (y >= (rTop - rHeight));

        Console.WriteLine( "\ninside K & outside of R: {0}\n", (insideCircle && !insideRectangle) ? "Yes" : "No");
    }
}