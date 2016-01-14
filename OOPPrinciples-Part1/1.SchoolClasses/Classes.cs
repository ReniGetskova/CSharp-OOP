namespace SchoolClasses
{
    using System.Collections.Generic;

    class Classes : IPersonContainer
    {
        //in scholl class we have students and teachers. We use abstraction and create list from people
        private List<Person> people = new List<Person>();

        private string classID;

        public Classes(string classID)
        {
            this.ClassID = classID;
        }

        public string ClassID { get; set; }

        public void AddPerson(Person person)
        {
            this.people.Add(person);
        }

        public IEnumerable<Person> People
        {
            get
            {
                return new List<Person>(this.people);
            }
        }
    }
}
