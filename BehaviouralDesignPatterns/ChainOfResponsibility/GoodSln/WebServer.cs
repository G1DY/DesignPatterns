using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.ChainOfResponsibility.GoodSln
{
    public class WebServer
    {
        private Handler _handler;

        public WebServer(Handler handler)
        {
            _handler = handler;
        }
        public void Handle(HttpRequest request)
        {
            _handler.Handle(request);
        }

    }
}