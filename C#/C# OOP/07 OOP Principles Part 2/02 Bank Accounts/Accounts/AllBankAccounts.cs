namespace BankAccounts
{
    public class AllBankAccounts
    {
        //fields
        protected ICustomer customer;
        protected double balance;
        protected double interestRate;

        //constructor

        public AllBankAccounts(ICustomer customer, double balance, double interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }
    }
}
