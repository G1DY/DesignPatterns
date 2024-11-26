using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.ChainOfResponsibility.GoodSln
{
    public class Authenticator : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Authenticating");
            var username = request.GetUsername();
            var password = request.GetPassword();

            return !(username == "Gideon" && password == "123");
        }
    }
}