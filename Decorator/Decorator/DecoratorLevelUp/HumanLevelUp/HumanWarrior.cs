using Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratorLevelUp
{
    class HumanWarrior : DecoratorForHuman
    {
        public HumanWarrior(Human human) : base(human)
        {
            this.human.Attack =base.Attack + 20;
            this.human.Speed = base.Speed + 10;
            this.human.Health = base.Health + 50;
            this.human.Defence = base.Defence + 20;
            this.human.Level = 1;
            this.human.ParentClass = "Parent Class: Human";
        }



        public override void Move()
        {
            Console.WriteLine($"The speed of the Human Warrior is: {human.Speed}");
        }
        public override void Show()
        {
            Console.WriteLine("Class: Human Warrior");
            Console.WriteLine(human.ParentClass);
            Console.WriteLine($"Attack: {human.Attack}");
            Console.WriteLine($"Speed: {human.Speed}");
            Console.WriteLine($"Health: {human.Health}");
            Console.WriteLine($"Defence: {human.Defence}");
            Console.WriteLine();
        }
    }
}
