namespace School
{
    using System;
    using System.Text;
    public class Student : Person, IComment
    {
        //fields
        private int classNumber;
        private string comment;

        //constructors
        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, int classNumber, string comment)
            : this(name, classNumber)
        {
            this.Comment = comment;
        }

        //properties
        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("The class number of a student cannot be a non-positive number!");
                }
                this.classNumber = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            private set
            {
                this.comment = value;
            }
        }

        //methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("{0} - number {1} //{2}", this.Name, this.ClassNumber, this.Comment));

            return result.ToString();
        }
    }
}
