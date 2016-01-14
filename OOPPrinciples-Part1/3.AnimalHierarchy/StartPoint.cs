namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    class StartPoint
    {
        static void Main()
        {
            Animal[] animals =
            {
                new Dog("Lisa", 10, Gender.Female, "Husky"),
                new Dog("Tomi", 2, Gender.Male, "Poodle"),

                new Frog("Prince", Gender.Male, 1),
                new Frog("Quene", Gender.Female, 3),

                new Cat("Darko", 5, Gender.Male, "Street the best"),
                new Tomcat("Ivan", 4),
                new Kitten("Maria", 6, "Sphynx"),
            };

            double averageDogsAge = animals.Where(x => x is Dog).Average(x => x.Age);
            double averageFrogsAge = animals.Where(x => x is Frog).Average(x => x.Age);
            double averageCatsAge = animals.Where(x => x is Cat).Average(x => x.Age);

            Console.WriteLine("Average age of the dogs: {0}", averageDogsAge);
            Console.WriteLine("Average age of the frogs: {0}", averageFrogsAge);
            Console.WriteLine("Average age of the cats: {0}", averageCatsAge);
        }
    }
}
