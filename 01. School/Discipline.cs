namespace School
{
    using System;
    using System.Text;
    public class Discipline : IComment
    {
        //fields
        private string comment;
        private string name;
        private int numLectures;
        private int numExercises;

        //constructors
        public Discipline(string name, int numLectures, int numExercises)
        {
            this.Name = name;
            this.NumLectures = numLectures;
            this.NumExercises = numExercises;
        }

        public Discipline(string name, int numLectures, int numExercises, string comment)
            : this(name, numLectures, numExercises)
        {
            this.Comment = comment;
        }

        //properties
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
                    throw new ArgumentNullException("Name of a discipline cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public int NumLectures
        {
            get
            {
                return this.numLectures;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be less than 1!");
                }
                this.numLectures = value;
            }
        }

        public int NumExercises
        {
            get
            {
                return this.numExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of exercises cannot be less than 0!");
                }
                this.numExercises = value;
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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} - {1} lectures, {2} exercises //{3}", this.Name, this.NumLectures, this.NumExercises, this.Comment));

            return sb.ToString();
        }
    }
}
