using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.ChainOfResponsibility.GoodSln
{
    public abstract class Handler
    {
        private Handler _nextHandler;

        public Handler SetNext(Handler handler)
        {
            _nextHandler = handler;

            return handler;
        }
        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                return;
            } 
            else if(_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
        }
        public abstract bool DoHandle(HttpRequest request);
            
    } 
       
}