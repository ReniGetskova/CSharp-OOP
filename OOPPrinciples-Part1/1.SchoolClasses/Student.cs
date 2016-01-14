namespace SchoolClasses
{
    public class Student : Person
    {
        public Student(string name, string classID) : base(name)
        {
            this.ClassID = classID;
        }

        public string ClassID { get; set; }

        public override string ToString()
        {
            return string.Format("Student: {0} {1} - class: {2}", this.FirstName, this.LastName, this.ClassID);
        }
    }
}
