using System;
class CompanyInfo
{
    static void Main()
    {
        string CompanyName = Console.ReadLine();
        string CompanyAddress = Console.ReadLine();
        string PhpneNumber = Console.ReadLine();
        string FaxNumber = Console.ReadLine();
        string WebSite = Console.ReadLine();
        string ManagerFirstName = Console.ReadLine();
        string ManagerLastName = Console.ReadLine();
        string ManagerAge = Console.ReadLine();
        string ManagerPhone = Console.ReadLine();

        Console.WriteLine(CompanyName);
        Console.WriteLine("Address: {0}", CompanyAddress);
        Console.WriteLine("Tel. {0}", PhpneNumber);
        if (string.IsNullOrEmpty(FaxNumber))
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}", FaxNumber);
        }
        Console.WriteLine("Web site: {0}", WebSite);
        Console.Write("Manager: {0} ", ManagerFirstName);
        Console.Write(ManagerLastName);
        Console.Write(" (age: {0}", ManagerAge);
        Console.WriteLine(", tel. {0})", ManagerPhone);
    }
}
