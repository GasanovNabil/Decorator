using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratorLevelUp
{
    class Rider : SwordBearer
    {
        public Rider(SwordBearer swordBearer) : base(swordBearer)
        {
            this.human = swordBearer;
            this.human.Attack = swordBearer.Attack - 10;
            this.human.Speed = swordBearer.Speed + 40;
            this.human.Health = swordBearer.Health + 200;
            this.human.Defence = swordBearer.Defence + 100;
            human.Level = 3;
            this.human.ParentClass = "Parent Class: Sword Bearer";
        }

        public override void Move()
        {
            Console.WriteLine($"The speed of the Rider is: {human.Speed}");
        }
        public override void Show()
        {
            Console.WriteLine("Class: Rider");
            Console.WriteLine(human.ParentClass);
            Console.WriteLine($"Attack: {human.Attack}");
            Console.WriteLine($"Speed: {human.Speed}");
            Console.WriteLine($"Health: {human.Health}");
            Console.WriteLine($"Defence: {human.Defence}");
            Console.WriteLine($"Level: {human.Level}");
            Console.WriteLine();
        }

    }
}
