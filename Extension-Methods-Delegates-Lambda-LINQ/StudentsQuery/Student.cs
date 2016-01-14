namespace StudentsQuery
{
    using System.Collections.Generic;
    using System.Text;

    class Student
    {
        //FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber

        public Student(string fname, string lname, int fn, string tel, string email, List<double> marks, int group)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = group;
        }

        public string FirstName { get; set; }

        public string LastName{ get; set; }

        public int FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<double> Marks { get; set; }

        public int GroupNumber { get; set; }

        public string PrintMarks()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Marks.Count; i++)
			{
                result.Append(this.Marks[i]);
                if (i != this.Marks.Count - 1)
                {
                    result.Append(", ");
                }			 
			} 

            return result.ToString();
        }     

        public override string ToString()
        {
            return string.Format("Name: {0} {1}\nEmail: {2},\nFN: {3}, Phone: {4}, Marks: {5}, Group: {6}\n",
                                 this.FirstName,
                                 this.LastName,
                                 this.Email,
                                 this.FN,
                                 this.Tel,
                                 this.PrintMarks(),
                                 this.GroupNumber);
        }
    }
}
