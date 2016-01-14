namespace StudentClass
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        // first, middle and last name, SSN, permanent address, mobile phone, e-mail, course, specialty, university, faculty
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public long SSN { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int Course { get; set; }

        public Specialty Specialty { get; set; }

        public University University { get; set; }

        public Faculty Faculty { get; set; }

        public override bool Equals(object obj)
        {
            var objAsStudent = obj as Student;
            if (objAsStudent == null)
            {
                return false;
            }
            if (objAsStudent.SSN != this.SSN)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            //call static method Equals that takes two arguments
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }


        public override string ToString()
        {
            return string.Format("Name: {0} {1} {2} SSN: {3}\nAddress: {4}\nPhone: {5} Email: {6}\nUniversity: {7} Faculty: {8} Specialty: {9} Course: {10}", 
                                 this.FirstName, 
                                 this.MiddleName, 
                                 this.LastName,
                                 this.SSN,
                                 this.Address,
                                 this.Phone,
                                 this.Email,
                                 this.University,
                                 this.Faculty,
                                 this.Specialty,
                                 this.Course);
        }

        public override int GetHashCode()
        {
            //this two properties are most unique
            return this.Phone.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public object Clone()
        {
            var newStudent = new Student();
            newStudent.FirstName = this.FirstName;
            newStudent.MiddleName = this.MiddleName;
            newStudent.LastName = this.LastName;
            newStudent.SSN = this.SSN;
            newStudent.Address = this.Address;
            newStudent.Phone = this.Phone;
            newStudent.Email = this.Email;
            newStudent.Course = this.Course;
            newStudent.Specialty = this.Specialty;
            newStudent.University = this.University;
            newStudent.Faculty = this.Faculty;

            //we have only values type so we can use MemberwiseClone() that makes shallo copy 
            //return this.MemberwiseClone();
            return newStudent;
        }

        public int CompareTo(Student otherStudent)
        {
            int resultFirstName = this.FirstName.CompareTo(otherStudent.FirstName);
            int resultMiddleName = 0;
            int resultLastName = 0;
            int resultSSN = 0;
            if (resultFirstName == 0)
            {
                resultMiddleName = this.MiddleName.CompareTo(otherStudent.MiddleName);
                if (resultMiddleName == 0)
                {
                    resultLastName = this.LastName.CompareTo(otherStudent.LastName);
                    if (resultLastName == 0)
                    {
                        resultSSN = this.SSN.CompareTo(otherStudent.SSN);
                        return resultSSN;
                    }
                    else
                    {
                        return resultLastName;
                    }
                }
                else
                {
                    return resultMiddleName;
                }
            }
            else
            {
                return resultFirstName;
            }
        }
    }
}
