namespace StudentsAndWorkers
{
    public class Student : Human   
    {
        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} - {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
