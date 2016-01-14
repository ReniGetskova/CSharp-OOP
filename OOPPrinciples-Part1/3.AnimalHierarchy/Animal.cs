namespace AnimalHierarchy
{
    using System;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }

                this.age = value;
            }
        }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Name, this.Age, this.Gender);
        }

        public abstract void MakeSound();
    }
}
