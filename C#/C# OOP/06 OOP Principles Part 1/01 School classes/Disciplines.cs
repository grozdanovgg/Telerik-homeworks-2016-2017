namespace OOPPrinciplesPart1
{
    //Disciplines have a name, number of lectures and number of exercises. 
    public class Disciplines :IComentable
    {
        //fields
        private string name;
        private string comment;
        private int numberOfLectures;
        private int numberOfExercises;

        //constructors
         public Disciplines(string name, int numberOfLectures, int numberOfExercises, string comment = null)
        {
            this.name = name;
            this.comment = comment;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
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
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
            }
        }
    }
}
