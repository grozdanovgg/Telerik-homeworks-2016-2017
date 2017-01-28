namespace BankAccounts
{
    public interface IBankAccount
    {
        ICustomer Customer { get; }
        double Balance { get; }
        double InterestRate { get; }

        double InterestAmount(int months);
    }
}
