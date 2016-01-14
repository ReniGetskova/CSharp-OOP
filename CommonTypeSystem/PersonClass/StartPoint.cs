namespace PersonClass
{
    using System;

    class StartPoint
    {
        static void Main()
        {
            Person[] peopleWithNameAndAge =
            { 
                new Person("Marin", 23),
                new Person("Stela", 25),
                new Person("Vasil", null),
                new Person("Maria", null)
            };

            foreach (var person in peopleWithNameAndAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
