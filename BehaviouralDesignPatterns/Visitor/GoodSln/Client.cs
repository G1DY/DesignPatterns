using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Visitor.GoodSln
{
    public abstract class Client
    {
        protected string _name;
        protected string _email;
        public Client(string name, string email)
        {
            _name = name;
            _email = email;
        }

        public string GetEmail()
        {
            return _email;
        }
        public abstract void Accept(Visitor visitor);
    }
}