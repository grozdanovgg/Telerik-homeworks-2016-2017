using System;
using System.Collections.Generic;

namespace OOPPrinciplesPart1
{
    public class ClassOfStudents : IComentable
    {
        //fields
        private string comment;
        private string textIdentifier;
        private IList<Teacher> listOfTeachers;

        //constructors
        public ClassOfStudents(string textIdentifier)
        {
            this.textIdentifier = textIdentifier;
            this.listOfTeachers = new List<Teacher>();
        }

        //properties from the interface
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
        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            private set
            {
                this.textIdentifier = value;
            }
        }
        public IList<Teacher> ListOfTeachers
        {
            get
            {
                return this.listOfTeachers;
            }
            set
            {
                this.listOfTeachers = value;
            }
        }
    }
}
