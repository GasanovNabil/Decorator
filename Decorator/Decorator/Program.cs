using Decorator.DecoratorLevelUp;
using Decorator.DecoratorLevelUp.ElfLevelUp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{

    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Show();
            human = new HumanWarrior(human);
            human.Show();
            human = new SwordBearer((HumanWarrior)human);
            human.Show();
            human = new Rider((SwordBearer)human);
            human.Show();
            human = new Archer((HumanWarrior)human);
            human.Show();

            //Elf elf = new Elf();
            //elf.Show();
            //ElfWarrior elfWarrior = new ElfWarrior(elf);
            //elfWarrior.Show();

            //elfWarrior = new Crossbowman(elf);
            //elfWarrior.Show();

            //Elf elf2 = new Elf();
            ////elf2.Show();
            //ElfMage elfMage1 = new ElfMage(elf2);
            //elfMage1.Show();

            //GoodMage goodMage = new GoodMage(elfMage1);
            //goodMage.Show();

            //Elf elf3 = new Elf();
            ////elf3.Show();
            //ElfMage elfMage2 = new ElfMage(elf3);
            ////elfMage2.Show();
            //EvilMage evilMage = new EvilMage(elfMage2);
            //evilMage.Show();



        }
    }
}
