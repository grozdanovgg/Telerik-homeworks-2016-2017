using System;
using System.Collections.Generic;

namespace BankAccounts
{
    public class Startup
    {
        static void Main()
        {
            Individuals pesho = new Individuals("Pesho");
            Individuals gosho = new Individuals("Gosho");
            Individuals tosho = new Individuals("Tosho");
            Companies ibm = new Companies("IBM");
            Companies google= new Companies("Google");
            Companies apple = new Companies("Apple");

            var peshosAccount = new DepositAccounts(pesho, 1000, 0.01);
            var goshosAccount = new LoanAccounts(gosho, 200, 0.01);
            var toshosAccount = new MortgageAccounts(tosho, 40000, 0.01);
            var ibmsAccount = new DepositAccounts(ibm, 500000000, 0.01);
            var googlesAccount = new LoanAccounts(google, 6000000000, 0.01);
            var applesAccount = new MortgageAccounts(apple, 90000000000, 0.01);

            var allAccounts = new List<IBankAccount>() { peshosAccount, goshosAccount, toshosAccount, ibmsAccount, googlesAccount, applesAccount };

            foreach (var account in allAccounts)
            {
                int months3 = 3;
                int months12 = 12;
                Console.WriteLine("{0} account balance: {1}", account.Customer.Name, account.Balance);
                Console.WriteLine("Interest ammount for {0} months is: {1}", months3, account.InterestAmount(months3));
                Console.WriteLine("and interest ammount for {0} months is: {1}\r\n", months12, account.InterestAmount(months12));
            }






        }
    }
}
