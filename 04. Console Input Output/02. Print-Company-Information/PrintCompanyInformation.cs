using System;
using System.Text.RegularExpressions;

class PrintCompanyInformation
{
    static void Main()
    {
        string intro =
            @"This program reads the information 
about a company and its manager 
and prints it back on the console.
Please note that only 9-digt GSM numbers, 
and 7-digit Sofia land line numbers 
will get correctly formated :)";
        Console.WriteLine(intro);

        Console.WriteLine("\nCompany Information Form");

        Console.Write("\nCompany name: ");
        string companyName = Console.ReadLine();
            
        Console.Write("\nCompany address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("\nMobile phone number: +359 ");
        string companyMPhone = Console.ReadLine().Replace(" ", string.Empty); 
            
        companyMPhone = Regex.Replace(companyMPhone, @"(\d{3})(\d{2})(\d{2})(\d{2})", "$1 $2 $3 $4");

        if (companyMPhone.Length < 7) 
        {
            companyMPhone = "(no GSM)";
        }

        Console.Write("\nLand line number: +359 ");
        string companyLPhone = Console.ReadLine().Replace(" ", string.Empty); 

        companyLPhone = Regex.Replace(companyLPhone, @"(\d{1})(\d{3})(\d{3})", "$1 $2 $3");

        if (companyLPhone.Length < 7)
        {
            companyLPhone = "(no tel.)";
        }

        Console.Write("\nFax number: +359 ");
        string companyFax = Console.ReadLine().Replace(" ", string.Empty);
        companyFax = Regex.Replace(companyFax, @"(\d{1})(\d{3})(\d{3})", "$1 $2 $3" );

        if (companyFax.Length < 7)
        {
            companyFax = "(no fax)";
        }

        Console.Write("\nWeb site: ");
        string website = Console.ReadLine();

        if (website.Length < 2)
        {
            website = "(no web site)";
        }

        Console.Write("\nManager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("\nManager last name: ");
        string managerLastName = Console.ReadLine();

        string managerAge;
        byte age;

        do  
        {
            Console.Write("\nManager age: ");
            managerAge = Console.ReadLine();

        } while (!byte.TryParse(managerAge, out age));

        Console.Write("\nManager mobile phone number: +359 ");
        string managerMPhone = Console.ReadLine().Replace(" ", string.Empty);
        managerMPhone = Regex.Replace(managerMPhone, @"(\d{3})(\d{2})(\d{2})(\d{2})", "$1 $2 $3 $4");

        if (managerMPhone.Length < 7)
        {
            managerMPhone = "(no GSM)";
        }

        Console.Write("\nLand line number: +359 ");
        string managerLPhone = Console.ReadLine().Replace(" ", string.Empty);
        managerLPhone = Regex.Replace(managerLPhone, @"(\d{1})(\d{3})(\d{3})", "$1 $2 $3");

        if (managerLPhone.Length < 7)
        {
            managerLPhone = "(no tel.)";
        }

        Console.Clear();
        Console.WriteLine(@"{0}
Address: {1}
Tel. +359 {2}
GSM  +359 {3}
Fax: {4}
Web site: {5}

Manager: {6} {7} 
(age: {8}, tel. +359 {9}, GSM +359 {10} )  ", companyName, companyAddress, companyLPhone, 
                                            companyMPhone, companyFax, website, managerFirstName, managerLastName, 
                                            managerAge, managerLPhone, managerMPhone);
        Console.WriteLine();
    }
}

