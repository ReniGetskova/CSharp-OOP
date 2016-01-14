namespace StudentClass
{
    using System;

    class StartPoint
    {
        static void Main()
        {
            var student1 = new Student()
            {
                FirstName = "Ivan",
                MiddleName = "Atanasov",
                LastName = "Georgiev",
                SSN = 940329010526,
                Address = "Sofia, Studentski Grad",
                Phone = "+359878224387",
                Email = "ivan.georgiev@gmail.com",
                Course = 2,
                Specialty = Specialty.InformationSystems,
                University = University.SU,
                Faculty = Faculty.FMI
            };

            var student2 = new Student()
            {
                FirstName = "Ivaylo",
                MiddleName = "Asenov",
                LastName = "Todorov",
                SSN = 920513010948,
                Address = "Sofia, Lulin",
                Phone = "+359878564389",
                Email = "ivaylo.todorov@gmail.com",
                Course = 4,
                Specialty = Specialty.Biology,
                University = University.MedicalUniversity,
                Faculty = Faculty.BiologyDepartment
            };

            //check for equals SSN
            Console.WriteLine("student1 == student2: {0}", student1 == student2);
            Console.WriteLine("student1 != student2: {0}", student1 != student2);
            Console.WriteLine();

            //Clone() return object and cast is nessesary
            Student newStudent = (Student)student1.Clone();
            newStudent.FirstName = "Petar";
            Console.WriteLine(student1);
            Console.WriteLine();
            Console.Write("This is test for Clone() method. New object doesn't change the original object:");
            Console.WriteLine(newStudent);
            Console.WriteLine();
            Console.WriteLine(student2);
            Console.WriteLine();

            Console.WriteLine("Test CompareTo() method:");
            int resultCompare = student1.CompareTo(student2);
            if (resultCompare == 0)
            {
                //this can not happent because if three names is the same we finaly compare to SSN which in real life is unique
                Console.WriteLine("student1 = student2");
            }
            else if (resultCompare < 0)
            {
                //the passed object is bigger of this
                //compare to one of three names
                Console.WriteLine("student1 < student2");
            }
            else
            {
                Console.WriteLine("student1 > student2");
            }
        }
    }
}
