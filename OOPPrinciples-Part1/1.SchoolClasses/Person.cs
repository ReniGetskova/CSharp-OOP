namespace SchoolClasses
{
    public class Person
    {
        public Person(string name)
        {
            var fullname = name.Split(' ');
            this.FirstName = fullname[0];
            this.LastName = fullname[1];
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
