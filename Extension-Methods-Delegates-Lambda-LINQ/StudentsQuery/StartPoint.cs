namespace StudentsQuery
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartPoint
    {
        public static void Main()
        {
            //create array from anonymous type
            var students = new[]
                          {
                              new {FirstName = "Anelia", LastName = "Ivanova", Age = 20},
                              new {FirstName = "Maria", LastName = "Angelova", Age = 26},
                              new {FirstName = "Maria", LastName = "Petrova", Age = 24},
                              new {FirstName = "Georgi", LastName = "Krilchev", Age = 25},
                              new {FirstName = "Milcho", LastName = "Vasilev", Age = 21},
                              new {FirstName = "Vasil", LastName = "Todorov", Age = 22}
                          };

            //students whose first name is before its last name alphabetically
            var foundName = from student in students
                            where student.FirstName.CompareTo(student.LastName) < 0
                            select student;
            Console.WriteLine("Students whose first name is before its last name alphabetically:");
            foreach (var student in foundName)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //first name and last name of all students with age between 18 and 24
            var foundAge = from student in students
                           where student.Age >= 18 && student.Age <= 24
                           select student;
            Console.WriteLine("First name and last name of all students with age between 18 and 24:");
            foreach (var student in foundAge)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //sort the students by first name and last name in descending order
            var sortNames = from student in students
                            orderby student.LastName descending
                            orderby student.FirstName descending
                            select student;
            Console.WriteLine("Sort the students by first name and last name in descending order");
            foreach (var student in sortNames)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //numbers that are divisible by 7 and 3
            int[] array = new[] { 2, 3, 7, 10, 6, 12, 9, 14, 5, 12, 17, 63, 21, 23, 30, 35, 13, 36, 15, 40, 42, 49, 56, 33, 100 };
            var foundDeviders = from number in array
                                where number % 3 == 0 && number % 7 == 0 // or may be ||
                                select number;
            Console.WriteLine("Numbers that are divisible by 7 and 3");
            foreach (var number in foundDeviders)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();

            List<Student> studentsList = GetStudents();

            //students that are from group number 2
            var studentsFromGroup2 = from st in studentsList
                                     where st.GroupNumber == 2
                                     orderby st.FirstName
                                     select st;
            Console.WriteLine();
            Console.WriteLine("Students that are from group number 2:".ToUpper());
            foreach (var st in studentsFromGroup2)
            {
                Console.WriteLine(st.ToString());
            }

            //students that have email in abv.bg
            var studentsEmail = from st in studentsList
                                where st.Email.Contains("abv.bg")
                                select st;
            Console.WriteLine("Students that have email in abv.bg:".ToUpper());
            foreach (var st in studentsEmail)
            {
                Console.WriteLine(st.ToString());
            }

            //students with phones in Sofia
            var studentPhoneSofia = from st in studentsList
                                    where st.Tel.StartsWith("02")
                                    select st;
            Console.WriteLine("Students with phones in Sofia".ToUpper());
            foreach (var st in studentPhoneSofia)
            {
                Console.WriteLine(st.ToString());
            }

            var studentsExcellent = from st in studentsList
                                    where st.Marks.Exists(x => x == 6)
                                    select st.FirstName + " - " + st.LastName + " " + st.PrintMarks();
            Console.WriteLine("Students that have at least one mark Excellent".ToUpper());
            foreach (var st in studentsExcellent)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();

            //Extract all Marks of the students that enrolled in 2006
            var students2006 = from st in studentsList
                               where st.FN.ToString().Substring(5, 2) == "06"
                               select st.FN + " - " + st.PrintMarks();
            Console.WriteLine("Students that enrolled in 2006".ToUpper());
            foreach (var st in students2006)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();
            string text = "Write a program to return the string with maximum length from an array of strings";
            string[] words = text.Split(' ');
            var longestWord = words.OrderByDescending(w => w.Length).First();
            Console.WriteLine("Longest word: {0}", longestWord);
        }

        private static List<Student> GetStudents()
        {
            //FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber
            List<Student> result = new List<Student>
            {
                new Student("Dimitur", "Krumov", 71233079, "074523040", "dimitur.krumov@gmail.com", new List<double>{3.5, 4, 2, 5, 6}, 2),
                new Student("Vera","Stamatova", 71523069, "08263040", "vera.stamatova@abv.bg",new List<double>{5.5, 2.5, 2, 3, 2}, 1),
                new Student("Tihomir", "Ganchev", 71913085, "02341040", "tisho.ganchev@abv.bg", new List<double>{3, 4.5, 2, 5, 6}, 2),
                new Student("Svetlana", "Dicheva", 71934064, "02135642", "svetla.dicheva@mail.bg", new List<double>{2, 4, 2, 5, 4.5}, 3),
                new Student("Radoslav", "Iliev", 71943061, "062435785", "rado.iliev@abv.bg", new List<double>{2, 5.5, 4, 3, 6}, 2),
                new Student("Radoslav", "Iliev", 71942053, "02635785", "rado.iliev@gmail.com", new List<double>{3, 4, 2, 5, 4}, 1)
            };

            return result;
        }
    }
}
