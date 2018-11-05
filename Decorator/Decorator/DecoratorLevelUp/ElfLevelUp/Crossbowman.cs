using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratorLevelUp.ElfLevelUp
{
    class Crossbowman : ElfWarrior
    {
        public Crossbowman(Elf elf) : base(elf)
        {
            this.Attack = elf.Attack + 20;
            this.Speed = elf.Speed + 10;
            this.Health = elf.Health + 50;
            this.Defence = elf.Defence - 10;

            this.Level = 2;
            this.ParentClass = "Parent Class: Elf Warrior";
        }



        public override void Move()
        {
            Console.WriteLine($"The speed of the Crossbowman is: {elf.Speed}");
        }
        public override void Show()
        {
            Console.WriteLine("Class: Crossbowman");
            Console.WriteLine(elf.ParentClass);
            Console.WriteLine($"Attack: {elf.Attack}");
            Console.WriteLine($"Speed: {elf.Speed}");
            Console.WriteLine($"Health: {elf.Health}");
            Console.WriteLine($"Defence: {elf.Defence}");
            Console.WriteLine($"Level: {elf.Level}");
            Console.WriteLine();
        }
    }
}
