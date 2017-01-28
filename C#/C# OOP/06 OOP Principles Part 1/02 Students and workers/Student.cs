namespace _02_Students_and_workers
{
    public class Student : Human
    {
        //fields
        internal int grade;

        //properties
        internal int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                this.grade = value;
            }
        }

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.grade = grade;
        }
        public override string ToString()
        {

            return $"{this.FirstName} {this.LastName}, grade: {grade}";
        }
    }
}
