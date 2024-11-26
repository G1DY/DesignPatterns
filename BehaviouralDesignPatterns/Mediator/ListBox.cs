using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Mediator
{
    public class ListBox : UIControl
    {
        private string _selection = "";
        public ListBox(DialogueBox owner) : base(owner){}
        public string GetSelection()
        {
            return _selection;
        }
        public void SetSelection(string selection)
        {
            _selection = selection;
            _owner.Changed(this);
        }
    }
}