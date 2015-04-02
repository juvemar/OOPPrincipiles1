namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal, ISound
    {
        //constructors
        public Dog(int age, string name) 
            : base(age, name)
        {

        }

        //methods
        public override void MakeSound()
        {
            Console.WriteLine("Raff raff");
        }
    }
}
