namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartPoint
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Asen", "Borisov", 4));
            students.Add(new Student("Borislav", "Vasilev", 3));
            students.Add(new Student("Vasil", "Georgiev", 2));
            students.Add(new Student("Georgi", "Dimitrov", 5));
            students.Add(new Student("Dimitur", "Emilov", 6));
            students.Add(new Student("Emil", "Zahariev", 4));
            students.Add(new Student("Zahari", "Iliev", 3));
            students.Add(new Student("Ilian", "Milenov", 2));
            students.Add(new Student("Milen", "Petrov", 5));
            students.Add(new Student("Peter", "Rusenov", 6));

            var sortedByGrade = from st in students
                                orderby st.Grade
                                select st;

            foreach (var st in sortedByGrade)
            {
                Console.WriteLine(st);
            }
        }
    }
}
