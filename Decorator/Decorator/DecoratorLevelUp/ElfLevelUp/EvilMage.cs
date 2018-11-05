using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratorLevelUp.ElfLevelUp
{
    class EvilMage : ElfMage
    {
        public EvilMage(Elf elf) : base(elf)
        {
            this.Attack = elf.Attack + 70;
            this.Speed = elf.Speed + 20;
            this.Health += 0;
            this.Defence += 0;
            this.Level = 2;
            this.ParentClass = "Parent Class: Elf Mage";
        }



        public override void Move()
        {
            Console.WriteLine($"The speed of the Evil Elf Mage is: {elf.Speed}");
        }
        public override void Show()
        {
            Console.WriteLine("Class: Evil Elf Mage");
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
