using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.ChainOfResponsibility.GoodSln
{
    public class HttpRequest
    {
        private string _username;
        private string _password;

        public string ValidateUsername { get; set; }
        public string ValidatePassword { get; set;}

        public HttpRequest(string username, string password)
        {
            _username = username;
            _password = password;
        }
        public string GetUsername()
        {
            return _username;
        }
        public string GetPassword()
        {
            return _password;
        }
    }
}
// CLIENTSIDECODE
// using BehaviouralDesignPatterns.ChainOfResponsibility.GoodSln;

// var validator = new Validator();
// var authenticator = new Authenticator();
// var logger = new Logger();

// validator.SetNext(authenticator).SetNext(logger);

// var server = new WebServer(validator);
// var req = new HttpRequest("Gideon", "123");
// server.Handle(req);

// var req2 = new HttpRequest("", "123");
// server.Handle(req2);;	