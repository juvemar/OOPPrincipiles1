namespace AnimalHierarchy
{
    using System;
    using System.Linq;
    public abstract class Animal : ISound
    {
        //fields
        private int age;
        private string name;
        private Sex gender;

        //constructors
        public Animal(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public Animal(int age, string name, Sex gender)
            : this(age, name)
        {
            this.gender = gender;
        }

        //properties
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be a negative number!");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public Sex Gender
        {
            get
            {
                return this.gender;
            }
        }

        //methods
        public abstract void MakeSound();
    }
}
