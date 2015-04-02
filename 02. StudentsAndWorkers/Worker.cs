namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;

    public class Worker : Human
    {
        //fields
        private decimal weekSalary;
        private int hoursPerDay;

        //constructors
        public Worker(string firstName, string lastName, decimal weekSalary, int hoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.HoursPerDay = hoursPerDay;
        }

        //properties
        public decimal WeekSalary
        {
            get
            {
                return weekSalary;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Week salary cannot be a non-positive number!");
                }
                weekSalary = value;
            }
        }

        public int HoursPerDay
        {
            get
            {
                return this.hoursPerDay;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Working hours per day cannot be a non-positive number!");
                }
                this.hoursPerDay = value;
            }
        }

        //methods
        public decimal MoneyPerHour(decimal calcWeekSalary, int calcHoursPerDay)
        {
            decimal result = 0;
            result = calcWeekSalary / (calcHoursPerDay * 5);

            return Math.Round(result, 2);
        }
    }
}
