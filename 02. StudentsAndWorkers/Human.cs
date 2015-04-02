namespace StudentsAndWorkers
{
    using System;

    public abstract class Human
    {
        //fields
        private string firstName;
        private string lastName;

        //constructors
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //properties
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty!");
                }
                this.lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty!");
                }
                this.firstName = value;
            }
        }
    }
}
