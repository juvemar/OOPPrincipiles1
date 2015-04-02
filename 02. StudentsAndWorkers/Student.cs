namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        //fields
        private double grade;

        //constructors
        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        //properties
        public double Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("A grade cannot be less than 2 or more than 6!");
                }
                this.grade = value;
            }
        }

    }
}
