using System;

class DeclareVariables
{
    static void Main()
    {
        ushort numberOne = 52130;
        sbyte numberTwo = -115;
        int numberThree = 4825932;
        byte numberFour = 97;
        short numberFive = -10000;

        Console.WriteLine("{0} {1} \n{2} {3} \n{4} {5} \n{6} {7} \n{8} {9}\n", numberOne.GetType().Name, numberOne, numberTwo.
            GetType().Name, numberTwo, numberThree.GetType().Name, numberThree, numberFour.GetType().Name, numberFour, numberFive.GetType().Name, numberFive);

    }
}