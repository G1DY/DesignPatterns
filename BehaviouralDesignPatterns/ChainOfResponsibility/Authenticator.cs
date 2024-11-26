using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.ChainOfResponsibility
{
    public class Authenticator
    {
        public bool Authenticate(HttpRequest request)
        {
            var username = request.GetUsername();
            var password = request.GetPassword();

            return username == "Gideon" && password == "123";
        }
    }
}