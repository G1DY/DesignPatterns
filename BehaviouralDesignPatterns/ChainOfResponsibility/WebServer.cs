using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.ChainOfResponsibility
{
    public class WebServer
    {
        public void Handle(HttpRequest request)
        {
            var Validator = new Validator();
            Validator.Validate(request);

            var Authenticator = new Authenticator();
            Authenticator.Authenticate(request);

            var Logger = new Logger();
            Logger.Log(request);
        }
    }
}