namespace OOPPrinciplesPart1
{
    class Student : Person, IComentable
    {
        //fields
        private string studentID;

        //constructor
        public Student(string name, string studentID, string comment = null) : base(name, comment)
        {
            this.studentID = studentID;
        }

        //properties
        public string StudentID
        {
            get
            {
                return this.studentID;
            }
            set
            {
                this.studentID = value;
            }
        }
   
        
    }
}
