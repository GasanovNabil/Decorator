using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratorLevelUp.ElfLevelUp
{
    class GoodMage : ElfMage
    {
        public GoodMage(Elf elf) : base(elf)
        {
            this.Attack = elf.Attack + 50;
            this.Speed = elf.Speed + 30;
            this.Health = elf.Health + 100;
            this.Defence = elf.Defence + 30;
            this.Level = 2;
            this.ParentClass = "Parent Class: Elf Mage";
        }



        public override void Move()
        {
            Console.WriteLine($"The speed of the Good Elf Mage is: {elf.Speed}");
        }
        public override void Show()
        {
            Console.WriteLine("Class: Good Elf Mage");
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
