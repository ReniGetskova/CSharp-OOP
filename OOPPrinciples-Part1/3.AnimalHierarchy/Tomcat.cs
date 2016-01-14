namespace AnimalHierarchy
{
    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age)
            : base(name, age)
        {
            this.Gender = Gender.Male;
        }
    }
}
