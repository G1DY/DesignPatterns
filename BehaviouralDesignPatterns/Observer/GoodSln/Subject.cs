using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Observer.GoodSln
{
    // Manages observers
    public class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObserver()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update();
            }
        }
    }
}