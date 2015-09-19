using System;

class PointsInACircle
{
    static void Main()
    {
        const int center_x = 0;
        const int center_y = 0;
        const double radius = 2;

        string inputX;
        double x;

        string inputY;
        double y;

        do  
        {
            Console.Write("Enter value for x: ");
            inputX = Console.ReadLine();

        } while (!double.TryParse(inputX, out x));
        
        do  
        {
            Console.Write("Enter value for y: ");
            inputY = Console.ReadLine();

        } while (!double.TryParse(inputY, out y));

        bool insideCircle = Math.Pow((x - center_x), 2) + Math.Pow((y - center_y), 2) <= Math.Pow(radius, 2);

        Console.WriteLine("Inside the circle: {0}\n", insideCircle);
    }
}