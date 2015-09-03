using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class BankAccountData 
{
    public string HolderName = "Daniel Zekremov Kordev";
    public string BankName = "Societe Generale Expressbank";
    public string IBAN = "BG22 TTBB 9400 1526 9292 73";

    public long CreditCardNumber1 = 4143871006408609;
    public decimal CCBalance1 = 3764.48m;
    public long CreditCardNumber2 = 5169247500408853;
    public decimal CCBalance2 = 10050.28m;
    public long CreditCardNumber3 = 4870022009123929;
    public decimal CCBalance3 = 39.01m;

    public decimal salary;

    public void PrintBankAccountData()  
    {
        Console.WriteLine("This program will access your fictional Bank Account. \nPlease enter your first middle and last name, \nso that you can retrieve your Bank Account Data:\n");
        HolderName = Console.ReadLine();
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Bank Account Holder Name: {0} \nBank Name: {1} \nIBAN: {2} \nCredit Card 1: {3} \nCredit Card 2: {4} \nCredit Card 3: {5}",
            HolderName, BankName, IBAN, CreditCardNumber1, CreditCardNumber2, CreditCardNumber3);
        Console.WriteLine("-------------------------------------------");

    }

    public void PrintCCOneBalance() 
    {
        Console.WriteLine("Credit Card 1: {0} \nCredit Card Balance: {1}", CreditCardNumber1, CCBalance1);
    }

    public void PrintCCTwoBalance() 
    {
        Console.WriteLine("Credit Card 2: {0} \nCredit Card Balance: {1}", CreditCardNumber2, CCBalance2);
    }

    public void PrintCCThreeBalance() 
    {
        Console.WriteLine("Credit Card 3: {0} \nCredit Card Balance: {1}", CreditCardNumber3, CCBalance3);
    }

    public void PrintTotalBalance() 
    {
        Console.WriteLine("=========================");
        Console.WriteLine("Total Balance: {0} ", (CCBalance1 + CCBalance2 + CCBalance3));
        Console.WriteLine("=========================");
    }

    public void GetSalary() 
    {
        Console.WriteLine("\nEnter choose a salary for yourself:");
        salary = decimal.Parse(Console.ReadLine());
    }

    public void Debit() 
    {
        CCBalance2 += salary;
        Console.WriteLine("\nCredit Card 2: {0} \nSalary: {1} \nFinal Balance: {2}", CreditCardNumber2, salary, CCBalance2);
    }
}
class AccountHolders
{

    static void Main()
    {
        BankAccountData accountHolder = new BankAccountData();
        accountHolder.PrintBankAccountData();
        Console.WriteLine();
        accountHolder.PrintCCOneBalance();
        Console.WriteLine();
        accountHolder.PrintCCTwoBalance();
        Console.WriteLine();
        accountHolder.PrintCCThreeBalance();
        Console.WriteLine();
        accountHolder.PrintTotalBalance();
        accountHolder.GetSalary();
        accountHolder.Debit();
        accountHolder.PrintTotalBalance();
    }
}


