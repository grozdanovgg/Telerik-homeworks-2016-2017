namespace _02_Students_and_workers
{
    class Worker : Human, IWorker
    {
        //propertis
        internal double WeekSalary { get; set; }
        internal double WorkHoursPerDay { get; set;  }
        internal double MoneyPerHour { get; }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.MoneyPerHour = MoneyPerHourCalc();
        }


        //methods
        public double MoneyPerHourCalc()
        {
            //returns money earned per hour by the worker
            double money = 0;
            money = WeekSalary / (WorkHoursPerDay * 5);

            return money;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}, money per hour: {MoneyPerHour:0.00}";
        }
    }
}
