using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Mediator
{
    public class TextBox : UIControl
    {
        private string _text = "";
        public TextBox(DialogueBox owner) : base(owner)
        {
        }

        public string GetText()
        {
            return _text;
        }
        public void SetText(string text)
        {
            _text = text;
            _owner.Changed(this);
        }
    }
}