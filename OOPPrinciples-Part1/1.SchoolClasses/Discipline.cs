namespace SchoolClasses
{
    class Discipline
    {
        public Discipline(string name, int lecturesNumber, int exercisesNumber)
        {
            this.Name = name;
            this.LecturesNumber = lecturesNumber;
            this.ExercisesNumber = exercisesNumber;
        }

        public string Name { get; set; }

        public int LecturesNumber { get; set; }

        public int ExercisesNumber { get; set; }

        public override string ToString()
        {
            return string.Format("subject: {0}, lectures: {1}, exercises: {2}", this.Name, this.LecturesNumber, this.ExercisesNumber);
        }
    }
}
