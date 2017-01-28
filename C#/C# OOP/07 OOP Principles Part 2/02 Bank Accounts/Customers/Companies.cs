namespace BankAccounts
{
    class Companies : ICustomer
    {
        private string name;

        public Companies(string name)
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
