using Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratorLevelUp
{
    class Archer : HumanWarrior
    {

        public Archer(HumanWarrior humanWarrior) : base(humanWarrior)
        {

                    this.human.Attack = humanWarrior.Attack + 20;
                    this.human.Speed = humanWarrior.Speed + 20;
                    this.human.Health = humanWarrior.Health + 50;
                    this.human.Defence = humanWarrior.Defence + 10;
                    human.Level = 2;
                    this.human.ParentClass = "Parent Class: Human Warrior";
        }

        public override void Move()
        {
            Console.WriteLine($"The speed of the Archer is: {human.Speed}");
        }
        public override void Show()
        {
            Console.WriteLine("Class: Archer");
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
