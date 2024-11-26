using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Mediator
{
    public class Button : UIControl
    {
        private bool _isEnabled;

        public Button(DialogueBox owner) : base(owner)
        {
        }

        public bool isEnabled()
        {
            return _isEnabled;
        }
        public void SetEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;
            _owner.Changed(this);
        } 
    }
}