namespace School
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class SchoolClass : IComment
    {
        //fields
        private List<Student> students;
        private List<Teacher> teachers;
        private char identifier;
        private string comment;

        //constructors
        public SchoolClass(List<Student> students, List<Teacher> teachers, char identifier, string comment)
            : this(students, teachers, identifier)
        {
            this.Comment = comment;
        }

        public SchoolClass(List<Student> students, List<Teacher> teachers, char identifier)
            : this(identifier)
        {

        }

        public SchoolClass(char identifier)
        {
            this.Identifier = identifier;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        //properties
        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }
        }

        public char Identifier
        {
            get
            {
                return this.identifier;
            }
            set
            {
                if (!char.IsLetter(value))
                {
                    throw new ArgumentOutOfRangeException("Class identifier must be a letter from the alphabeth!");
                };
                if (char.IsLower(value))
                {
                    throw new ArgumentException("Class identifier should be a capital letter!");
                }
                this.identifier = value;
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
        public void AddTeacher(params Teacher[] teachers)
        {
            foreach (var item in teachers)
            {
                this.teachers.Add(item);
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void AddStudent(params Student[] students)
        {
            foreach (var item in students)
            {
                this.students.Add(item);
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Class \"{0}\":", this.Identifier));
            result.AppendLine("Teachers:");
            foreach (var item in this.Teachers)
            {
                result.AppendLine(item.ToString());//calls Teacher.ToString() method
            }
            result.AppendLine("Students:");
            foreach (var item in this.Students)
            {
                result.AppendLine(item.ToString());//calls Student.ToString() method
            }
            return result.ToString();
        }
    }
}
