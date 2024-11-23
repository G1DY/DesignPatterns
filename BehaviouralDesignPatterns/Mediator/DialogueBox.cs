using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Mediator
{
    public abstract class DialogueBox
    {
        public abstract void Changed(UIControl uIControl);
    }
}