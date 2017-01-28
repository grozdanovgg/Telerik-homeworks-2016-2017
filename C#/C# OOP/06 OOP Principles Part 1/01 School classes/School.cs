using System;
using System.Collections.Generic;

namespace OOPPrinciplesPart1
{
    class School
    {
        //fields
        private IList<ClassOfStudents> listOfClasses;

        //Constructors
        public School(IList<ClassOfStudents> listOfClasses)
        {
            this.listOfClasses = listOfClasses;
        }

        //properties
        public IList<ClassOfStudents> ListOfStudents
        {
            get
            {
                return this.listOfClasses;
            }
            private set
            {
                this.listOfClasses = value;
            }
        }

    }
}
