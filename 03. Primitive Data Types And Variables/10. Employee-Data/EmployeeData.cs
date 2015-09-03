using System;
using System.Collections.Generic;
using System.Linq;

public class EmployeeData
{
    #region Generate Unique Employee ID
    static Random random = new Random();

    public static List<int> GenerateRandom(int count, int min = 27560000, int max = 27569999)
    {
        if (max <= min || count < 0 ||
                (count > max - min && max - min > 0))
        {
            throw new ArgumentOutOfRangeException("Range or count " + count + " is illegal");
        }

        HashSet<int> candidates = new HashSet<int>();

        for (int top = max - count; top < max; top++)
        {
            if (!candidates.Add(random.Next(min, top + 1)))
            {
                candidates.Add(top);
            }
        }

        List<int> result = candidates.ToList();

        for (int i = result.Count - 1; i > 0; i--)
        {
            int k = random.Next(i + 1);
            int tmp = result[k];
            result[k] = result[i];
            result[i] = tmp;
        }
        return result;
    }

    public static List<int> GenerateRandom(int count)
    {
        return GenerateRandom(count, 27560000, 27569999);
    }
    #endregion
    public static void Main()
    {
        int age; 
        long IDNumber; 
        int employeeID;
        string firstName; 
        string lastName; 
        string ageStr;
        string gender; 
        string IdNumberStr; 
        string employeeIDStr; 

        List<int> randomId = GenerateRandom(1); 
        employeeIDStr = string.Join(", ", randomId.ToArray()); 
        employeeID = Convert.ToInt32(employeeIDStr); 

        Console.Write("New Employee Form: \n\nFirst Name:\t\t");;  
        firstName = Console.ReadLine();
        Console.Write("Last Name:\t\t"); 
        lastName = Console.ReadLine(); 

        do    
        {
            Console.Write("Age:\t\t\t");  
            ageStr = Console.ReadLine();  
        }
        while ((!int.TryParse(ageStr, out age) || age <= 0 || age >= 150));  

        do  
        {
            Console.Write("Gender: F/M?\t\t");
            gender = Console.ReadLine();  
        } while (!gender.Equals("f", StringComparison.OrdinalIgnoreCase) 
            && !gender.Equals("female", StringComparison.OrdinalIgnoreCase) 
            && !gender.Equals("m", StringComparison.OrdinalIgnoreCase) 
            && !gender.Equals("Male", StringComparison.OrdinalIgnoreCase));

        if (gender.Equals("f", StringComparison.OrdinalIgnoreCase) 
            || gender.Equals("female", StringComparison.OrdinalIgnoreCase))
        {
            gender = "Female";
        }

        else if (gender.Equals("m", StringComparison.OrdinalIgnoreCase) 
            || gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
        {
            gender = "Male";
        }

        bool personalId = false;
        do 
        {
            Console.Write("Personal ID Number:\t");
            IdNumberStr = Console.ReadLine();
            personalId = long.TryParse(IdNumberStr, out IDNumber);
        } while (!personalId || IdNumberStr.Length < 10 || IdNumberStr.Length > 10);


        bool Id = false;
        do
        {
            Console.Write("Unique Employee number:\t");
            employeeIDStr = Console.ReadLine();
            personalId = long.TryParse(employeeIDStr, out IDNumber);
        } while (!personalId || employeeIDStr.Length < 8 || employeeIDStr.Length > 8);

        Console.Clear(); 
        Console.WriteLine("Employee ID: {0} \nName: {1} {2} \nAge: {3} \nGender: {4} \nPersonal ID Number: {5} \nUnique Employee number: {6}", employeeID, firstName, lastName, age, gender, IDNumber, employeeID);
    }
}