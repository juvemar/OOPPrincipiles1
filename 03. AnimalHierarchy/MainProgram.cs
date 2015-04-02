namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MainProgram
    {
        static void Main()
        {
            Kitten[] pussies = 
            { 
            new Kitten(2,"Missy"),
            new Kitten(1,"Sissy"),
            new Kitten(3, "Pissy"),
            new Kitten(2,"Kissy")
            };
            Console.WriteLine("The average age of all kittens is {0} years.", AverageAge(pussies));

            Tomcat[] maleCats =
            { 
            new Tomcat(3,"Tom"),
            new Tomcat(2,"Silvester"),
            new Tomcat(1, "Roger"),
            new Tomcat(4,"Miky")
            };
            Console.WriteLine("The average age of all tomcats is {0} years.", AverageAge(maleCats));

            Dog[] dogs = 
            { 
            new Dog(4,"Sharo"),
            new Dog(5,"Rex"),
            new Dog(4, "Persi"),
            new Dog(6,"Kudjo")
            };
            Console.WriteLine("The average age of all dogs is {0} years.", AverageAge(dogs));

            Frog[] frogs = 
            { 
            new Frog(2,"Arnold"),
            new Frog(1,"Jason"),
            new Frog(1, "Chester"),
            new Frog(2,"Mikel")
            };
            Console.WriteLine("The average age of all frogs is {0} years.\n", AverageAge(frogs));

            List<Cat> cats = new List<Cat>();
            cats.AddRange(pussies);
            cats.AddRange(maleCats);

            List<Animal> allAnimals = new List<Animal>();

            allAnimals.AddRange(cats);
            allAnimals.AddRange(dogs);
            allAnimals.AddRange(frogs);

            Console.WriteLine("Attention, animals are speaking:");
            foreach (var item in allAnimals)
            {
                Console.Write("{0} says ", item.Name);
                item.MakeSound();
            }
        }

        public static double AverageAge(params Animal[] array)
        {
            double result = array.Average(x => x.Age);

            return result;
        }
    }
}
