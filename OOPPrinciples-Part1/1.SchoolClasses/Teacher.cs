namespace SchoolClasses
{
    using System.Collections.Generic;
    using System.Text;

    class Teacher : Person
    {
        private List<Discipline> discipline;
       
        public Teacher(string name)
            : base(name)
        {
            this.discipline = new List<Discipline>();
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(this.discipline);
            }
        }


        public void AddDiscipline(string disciplineName, int lecturesNumber, int exercisesNumber)
        {

            this.discipline.Add(new Discipline(disciplineName, lecturesNumber, exercisesNumber));
        }

        public string PrintDisciplines()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.discipline.Count; i++)
            {
                result.Append(this.discipline[i]);
                if (i != this.discipline.Count - 1)
                {
                    result.Append(", ");
                }
            }
            return result.ToString();
        }       

        public override string ToString()
        {
            return string.Format("Teacher: {0} {1} - {2}",this.FirstName, this.LastName, this.PrintDisciplines());
        }
    }
}
