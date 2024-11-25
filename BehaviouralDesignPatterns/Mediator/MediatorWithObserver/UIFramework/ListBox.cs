using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Mediator.MediatorWithObserver.UIFramework
{
    public class ListBox : UIControl
    {
        private string _selection = "";
        public string GetSelection()
        {
            return _selection;
        }
        public void SetSelection(string selection)
        {
            _selection = selection;
            NotifyEventHandlers();
        }  
    }
}