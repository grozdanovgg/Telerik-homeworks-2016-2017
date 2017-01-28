namespace OOPPrinciplesPart1
{
    public class Person : IComentable
    {
        //fields
        private string name;
        private string comment;

        //Constructors
        public Person(string name, string comment = null)
        {
            this.name = name;
            this.comment = comment;
        }

        //properties
        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
    }
}
