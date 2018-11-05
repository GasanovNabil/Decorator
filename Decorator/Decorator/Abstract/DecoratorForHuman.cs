using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Abstract
{
    abstract class DecoratorForHuman : Human 
    {
        protected Human human;

        public DecoratorForHuman(Human human)
        {
            this.human = human;
        }

        public void setHuman(Human human)
        {
            this.human = human;
        }
    }
}
