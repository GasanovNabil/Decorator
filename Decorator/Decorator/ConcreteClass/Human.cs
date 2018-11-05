using System;

namespace Decorator
{
    class Human : Hero
    {
        public Human()
        {
            Attack += 20;
            Speed += 20;
            Health += 150;
            Defence += 0;

            ParentClass = "Parent Class: None";
        }

        public override void Move()
        {
            Console.WriteLine($"The speed of the Human is: {Speed}");
        }

        public override void Show()
        {
            Console.WriteLine("Class: Human");
            Console.WriteLine(ParentClass);
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Defence: {Defence}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine();
        }
    }
}
