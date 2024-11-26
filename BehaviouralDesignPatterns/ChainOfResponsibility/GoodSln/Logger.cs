using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.ChainOfResponsibility.GoodSln
{
    public class Logger : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Logging");
            return false;
        }
    }
}