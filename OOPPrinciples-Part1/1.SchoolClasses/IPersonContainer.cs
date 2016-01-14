namespace SchoolClasses
{
    using System.Collections.Generic;

    public interface IPersonContainer
    {
        void AddPerson(Person person);

        IEnumerable<Person> People { get; }
    }
}
