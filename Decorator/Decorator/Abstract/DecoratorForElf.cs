using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Abstract
{
    abstract class DecoratorForElf : Elf
    {
        protected Elf elf;

        public DecoratorForElf(Elf elf)
        {
            this.elf = elf;
        }

        public void setElf(Elf elf)
        {
            this.elf = elf;
        }
    }
}
