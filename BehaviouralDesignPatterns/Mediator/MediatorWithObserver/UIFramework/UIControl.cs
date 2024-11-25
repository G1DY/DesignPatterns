using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Mediator.MediatorWithObserver.UIFramework
{
    // this is the subject class from the observer pattern
    // manages our eventhanders/keeps a list of callback methods
    public class UIControl
    {
        private List<EventHandler> _eventHandlers= new List<EventHandler>();

        public void AddEventHandler(EventHandler eventHandler)
        {
            _eventHandlers.Add(eventHandler);
        }
        public void NotifyEventHandlers()
        {
            foreach (var handler in _eventHandlers)
            {
                handler();
            }
        }
        
    }
}