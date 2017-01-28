namespace BankAccounts
{
    public class Individuals : ICustomer
    {
        private string name;

        public Individuals(string name)
        {
            this.name = name;
        }

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}
