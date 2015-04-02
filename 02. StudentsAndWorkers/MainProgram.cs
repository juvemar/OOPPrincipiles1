namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MainProgram
    {
        public static readonly List<Student> students = new List<Student> 
        {
            new Student("Petran", "Stoilov", 4.85)
            ,new Student("Stoil", "Tonchev", 3.5)
            ,new Student("Boqna", "Daskalova", 3.7)
            ,new Student("Krasimira", "Paneva", 4.9)
            ,new Student("Ivan", "Dermenjiev", 5)
            ,new Student("Dobromir", "Petkov", 3.2)
            ,new Student("Luben", "Haralambiev", 5.62)
            ,new Student("Georgi", "Aleksov", 6)
            ,new Student("Iliana", "Tsvetkova", 5.5)
            ,new Student("Stanimira", "Koleva", 3.44)
        };

        public static readonly List<Worker> workers = new List<Worker>
        {
             new Worker("Petran", "Stamov", 150, 6)
            ,new Worker("Milen", "Karachanakov", 140, 5)
            ,new Worker("Anna", "Dobreva", 165, 7)
            ,new Worker("Anastasiq", "Kopcheva", 128, 8)
            ,new Worker("Qvor", "Tinchev", 135, 5)
            ,new Worker("Stamen", "Georgiev", 152, 7)
            ,new Worker("Luben", "Dimchev", 170, 8)
            ,new Worker("Georgi", "Rachkov", 162, 6)
            ,new Worker("Mariq", "Milcheva", 140, 8)
            ,new Worker("Stanimira", "Goranova", 154, 7)
        };
        static void Main()
        {
            Console.WriteLine("Students ordered by their grade:");
            GroupStudentsByGrade();

            Console.WriteLine("\nWorkers ordered in descending by the money they earn per hour:");
            GroupWorkerByMoneyPerHour();

            Console.WriteLine("\nAll people sorted by first and last name:");
            SortEveryoneByNames(MergeLists(students,workers));
        }

        private static void GroupStudentsByGrade()
        {
            var orderedStudents = students
                .OrderBy(g => g.Grade);

            foreach (var studentPrint in orderedStudents)
            {
                Console.WriteLine("{0} {1} - {2} grade", studentPrint.FirstName, studentPrint.LastName, studentPrint.Grade);
            }
        }

        private static void GroupWorkerByMoneyPerHour()
        {
            var orderedWorkers = workers.OrderByDescending(w => w.MoneyPerHour(w.WeekSalary, w.HoursPerDay));

            foreach (var workerPrint in orderedWorkers)
            {
                Console.WriteLine("{0} {1} - {2} BGN per hour", workerPrint.FirstName, workerPrint.LastName
                    , workerPrint.MoneyPerHour(workerPrint.WeekSalary, workerPrint.HoursPerDay));
            }
        }

        private static List<Human> MergeLists(IEnumerable<Student> studentsList, IEnumerable<Worker> workersList)
        {
            List<Human> newList = new List<Human>();
            newList.AddRange(studentsList);
            newList.AddRange(workersList);

            return newList;
        }

        private static void SortEveryoneByNames(IEnumerable<Human> list)
        {
            var result = list
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);

            foreach (var item in result)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
