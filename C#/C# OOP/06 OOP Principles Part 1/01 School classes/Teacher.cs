using System;
using System.Collections.Generic;

namespace OOPPrinciplesPart1
{
    public class Teacher : Person
    {
        //fields
        private IList<Disciplines> listOfDisciplines;

        //constructor
        public Teacher(string name, string comment = null) : base(name, comment)
        {
            this.listOfDisciplines = new List<Disciplines>();
        }

        //properties
        public IList<Disciplines> ListOfDisciplines
        {
            get
            {
               return this.listOfDisciplines ;
            }
             private set
            {
                this.listOfDisciplines = value;
            }
        }
    }
}
