using Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratorLevelUp.ElfLevelUp
{
    class ElfMage : DecoratorForElf
    {
        public ElfMage(Elf elf) : base(elf)
        {
            this.Attack = elf.Attack + 10;
            this.Speed = elf.Speed + 10;
            this.Health = elf.Health - 50;
            this.Defence = elf.Defence + 10;
            this.Level = 1;
            this.ParentClass = "Parent Class: Elf";
        }



        public override void Move()
        {
            Console.WriteLine($"The speed of the Elf Mage is: {elf.Speed}");
        }
        public override void Show()
        {
            Console.WriteLine("Class: Elf Mage");
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
