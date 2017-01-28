namespace BankAccounts
{
    public class LoanAccounts : AllBankAccounts, IBankAccount, IDepositable
    {
        //constructor
        public LoanAccounts(ICustomer customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }


        //IDepositable methods
        public void Deposit(double money)
        {
            this.Balance += money;
        }


        //IBankAccount
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

            string customerType = this.customer.GetType().Name;

            bool individual = customerType == "Individuals" ? true : false;

            if (individual)
            {
                if(months <= 3)
                {
                    result = 0;
                }
                else
                {
                    result = interestRate * (months - 3);
                }
            }
            else
            {
                if (months <= 2)
                {
                    result = 0;
                }
                else
                {
                    result = interestRate * (months - 2);
                }
            }
            return result;
        }
    }
}
