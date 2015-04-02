namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal, ISound
    {
        //constructors
        public Cat(int age, string name) 
            : base(age, name)
        {

        }

        //methods
        public override void MakeSound()
        {
            Console.WriteLine("Meao meao");
        }
    }
}
