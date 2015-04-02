namespace School
{
    using System.Text;
    using System.Collections.Generic;

    public class Teacher : Person, IComment
    {
        //fields
        private string comment;
        private List<Discipline> disciplines;

        //constructors
        public Teacher(string name, params Discipline[] disciplines)
            : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public Teacher(string name, string comment, params Discipline[] disciplines)
            : this(name, disciplines)
        {
            this.Comment = comment;
        }

        //properties
        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
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

        //mathods
        public void AddDiscipline(params Discipline[] newDisciplines)
        {
            foreach (var item in newDisciplines)
            {
                this.disciplines.Add(item);
            }
        }

        public void AddDiscipline(Discipline newDiscipline)
        {
            this.disciplines.Add(newDiscipline);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Teacher {0} leads the following disciplines:", this.Name));
            foreach (var item in this.Disciplines)
            {
                result.Append(string.Format("-{0}", item));
            }

            return result.ToString();
        }
    }
}
