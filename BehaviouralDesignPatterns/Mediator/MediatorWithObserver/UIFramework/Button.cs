using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Mediator.MediatorWithObserver.UIFramework
{
    public class Button : UIControl
    {
        private bool _isEnabled;

        public bool IsEnabled()
        {
            return _isEnabled;
        }
        public void SetEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;
            NotifyEventHandlers();
        } 
    }
}