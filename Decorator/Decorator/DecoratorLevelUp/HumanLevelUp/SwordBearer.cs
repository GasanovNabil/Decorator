using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratorLevelUp
{
    class SwordBearer : HumanWarrior
    {
        public SwordBearer(HumanWarrior humanWarrior) : base(humanWarrior)
        {
            this.human.Attack = humanWarrior.Attack + 40;
            this.human.Speed = humanWarrior.Speed - 10;
            this.human.Health = humanWarrior.Health + 50;
            this.human.Defence = humanWarrior.Defence + 40;
            this.human.Level = 2;
            this.human.ParentClass = "Parent Class: Human Warrior";
        }

        
        public override void Move()
        {
            Console.WriteLine($"The speed of the Sword Bearer is: {human.Speed}");
        }
        public override void Show()
        {
            Console.WriteLine("Class: Sword Bearer");
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
