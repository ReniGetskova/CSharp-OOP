namespace RangeExceptions
{
    using System;

    public class StartPoint
    {
        static void Main()
        {
            Console.WriteLine("Insert number between 1 and 100");
            int number = int.Parse(Console.ReadLine());
            if (number < 1 || number > 100)
            {
                throw new InvalidRangeException<int>("Invalid number input. Min: {0} Max: {1}!", 1, 100);
            }

            Console.WriteLine("Insert date between 1.1.1980 and 31.12.2013");
            DateTime date = DateTime.Parse(Console.ReadLine());
            DateTime startDate = DateTime.Parse("1.1.1980");
            DateTime endDate = DateTime.Parse("31.12.2013");
            if (date.CompareTo(startDate) < 0 || date.CompareTo(endDate) > 0)
            {
                throw new InvalidRangeException<DateTime>("Invalid date input!", startDate, endDate);
            }
        }
    }
}
