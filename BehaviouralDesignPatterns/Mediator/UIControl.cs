using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Mediator
{
    public class UIControl
    {
        // All uicontrol objects can be grouped into a dialoguebox and no one can talk to their owner
        protected DialogueBox _owner;

        public UIControl(DialogueBox owner)
        {
            _owner = owner;
        }
    }
}