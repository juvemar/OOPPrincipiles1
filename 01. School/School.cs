namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class School
    {
        //fields
        private string name;
        private List<SchoolClass> schoolClasses;

        //constructors
        public School(string name)
        {
            this.Name = name;
            this.schoolClasses = new List<SchoolClass>();
        }

        //properties
        public List<SchoolClass> SchoolClasses
        {
            get
            {
                return new List<SchoolClass>(this.schoolClasses);
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("The school's name cannot be null!");
                }
                this.name = value;
            }
        }

        //methods
        public void AddClass(SchoolClass newClass)
        {
            this.schoolClasses.Add(newClass);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format(@"School's name - ""{0}""", this.Name));
            result.AppendLine(string.Format("There are {0} classes in the school.", this.SchoolClasses.Count));
            result.AppendLine();
            foreach (var item in schoolClasses)
            {
                result.Append(string.Format("{0}", item));//calls SchoolClass.ToString() method
                result.AppendLine(new string('=', 20));
            }
            return result.ToString();
        }
    }
}
