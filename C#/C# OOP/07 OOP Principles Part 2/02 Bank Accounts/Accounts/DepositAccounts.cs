namespace BankAccounts
{
    public class DepositAccounts : AllBankAccounts, IBankAccount, IWithdrawable, IDepositable
    {
        //Constructor
        public DepositAccounts(ICustomer customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        //IWithdrawable and IDepositable methods
        public void Deposit(double money)
        {
            this.Balance += money;
        }

        public void Withdraw(double money)
        {
            this.Balance -= money;
        }

        //IBankaccount interface inheritance
        public double Balance
        {
            get
            {
                return this.balance;
            }

            private set
            {
                this.balance = value;
            }
        }

        public ICustomer Customer
        {
            get
            {
                return this.customer;
            }

            private set
            {
                this.customer = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }

            private set
            {
                this.interestRate = value;
            }
        }

        public double InterestAmount(int months)
        {
            double result = 0;
            if (this.balance > 0 && this.balance <= 1000)
            {
                result = 0;
            }
            else
            {
                result = interestRate * months;
            }
            return result;
        }
    }
}
