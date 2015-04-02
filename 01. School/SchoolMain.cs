namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SchoolMain
    {
        static void Main()
        {
            School highSchool = new School("FEG");

            Discipline[] disciplines = 
            {
                new Discipline("Physics", 5, 6, "so hard"),
                new Discipline("Electrotechnic", 6, 7),
                new Discipline("Mathematics", 4, 2, "favorite one"),
                new Discipline("Mechanic", 5, 5, "like it"),
                new Discipline("Material resistance", 4, 1)
            };

            Student[] studentsFirstGroup = 
            {
                new Student("Pencho", 1, "Looser"),
                new Student("Boncho", 2, "So so"),
                new Student("Vanio", 3, "New one")
            };

            Student[] studentsSecondGroup =
            {
                new Student("Toshko", 1, "No comment"),
                new Student("Gosho", 2, "So ambitious"),
                new Student("Misho", 3, "So ambigious ^_^"),
                new Student("Ismail", 4,"Excellent student")
            };

            Teacher[] teachersList =
            {
                new Teacher("Petrov"),
                new Teacher("Stoev"),
                new Teacher("Bruchkov")
            };

            teachersList[0].AddDiscipline(disciplines[0], disciplines[1], disciplines[4]);
            teachersList[1].AddDiscipline(disciplines[3], disciplines[2]);
            teachersList[2].AddDiscipline(disciplines[0], disciplines[1], disciplines[2], disciplines[3]);

            SchoolClass classA = new SchoolClass('A');
            SchoolClass classB = new SchoolClass('B');

            classA.AddStudent(studentsFirstGroup);
            classB.AddStudent(studentsSecondGroup);

            classA.AddTeacher(teachersList[0]);
            classA.AddTeacher(teachersList[1]);

            classB.AddTeacher(teachersList[1]);
            classB.AddTeacher(teachersList[2]);

            highSchool.AddClass(classA);
            highSchool.AddClass(classB);
            Console.WriteLine(highSchool);
        }
    }
}