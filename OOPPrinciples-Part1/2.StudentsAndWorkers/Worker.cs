namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, int workHourPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHourPerDay = workHourPerDay;
        }

        public decimal WeekSalary { get; set; }

        public int WorkHourPerDay { get; set; }

        public decimal MoneyPerHour(int workDays)
        {
            decimal result = 0;
            result = (this.WeekSalary / workDays) / WorkHourPerDay;
            return result;
        }
    }
}
