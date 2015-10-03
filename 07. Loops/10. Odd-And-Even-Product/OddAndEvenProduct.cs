using System;
using System.Linq;

class OddAndEvenProduct
{
    static void Main()
    {
        int productOdd = 1;
        int productEven = 1;

        Console.Write("Please, enter 5 numbers in a single line: ");
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); 

        for (int i = 0; i < nums.Length; i++)
        {           
            if (i % 2 == 0)
            {
                productOdd *= nums[i]; 
            }

            else
            {
                productEven *= nums[i]; 
            }
        }

        Console.WriteLine("\nNumbers: {0}", String.Join(", ", nums));
        Console.WriteLine("Product of the odd elements: {0}", productOdd);
        Console.WriteLine("Product of the even elements: {0}", productEven);

        Console.WriteLine("The product of the odd elements is equal to the product of the even elements: {0}\n", (productOdd == productEven)? "yes" : "no");
    }
}