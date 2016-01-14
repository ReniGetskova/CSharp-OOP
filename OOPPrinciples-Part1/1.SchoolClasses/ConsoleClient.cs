namespace SchoolClasses
{
    using System;

    class ConsoleClient
    {
        public static void Main()
        {
            Classes classes = new Classes("5B");
            classes.AddPerson(new Teacher("Slavka Todorova"));
            classes.AddPerson(new Teacher("Velichka Taseva"));
            classes.AddPerson(new Teacher("Roza Georgieva"));
            classes.AddPerson(new Teacher("Maria Asenova"));
            classes.AddPerson(new Student("Emilia Filcheva", classes.ClassID));
            classes.AddPerson(new Student("Anelia Koleva", classes.ClassID));
            string[] disciplinesNames = {"English", "Math", "French", "Biology", "Chemistry", "Geography", "History"};
            int count = -1;
            foreach(var person in classes.People)
            {
                count++;
                if (count == disciplinesNames.Length)
                {
                    count = count % disciplinesNames.Length;
                }
                if (person is Teacher)
                {
                    Teacher teacher = person as Teacher;
                    teacher.AddDiscipline(disciplinesNames[count], count + 1, (count + 1)*2);
                }

                Console.WriteLine(person.ToString());
            }           
        }
    }
}
