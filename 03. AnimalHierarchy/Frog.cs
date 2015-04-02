namespace AnimalHierarchy
{
    using System;
    public class Frog : Animal, ISound
    {
        //constructors
        public Frog(int age, string name) 
            : base(age, name)
        {

        }

        //methods
        public override void MakeSound()
        {
            Console.WriteLine("Guabeck guabeck");
        }
    }
}
