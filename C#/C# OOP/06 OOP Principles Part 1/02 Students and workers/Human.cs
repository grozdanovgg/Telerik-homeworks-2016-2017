namespace _02_Students_and_workers
{
    public abstract class Human
    {
        
        //properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        
        //constructor
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

    }
}
