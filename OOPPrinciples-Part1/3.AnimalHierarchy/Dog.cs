namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, Gender gender, string breed) : base(name, age, gender)
        {
            this.Breed = breed;
        }

        public string Breed { get; private set; }

        public override void MakeSound()
        {
            Console.WriteLine("{0} is barking", this.Name);
        }
    }
}
