using System;

namespace Decorator
{
    class Elf : Hero
    {
        public Elf()
        {
            Attack += 15;
            Speed += 30;
            Health += 100;
            Defence += 0;

            ParentClass = "Parent Class: None";
        }

        public override void Move()
        {
            Console.WriteLine($"The speed of the Elf is: {Speed}");
        }

        public override void Show()
        {
            Console.WriteLine("Class: Elf");
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
