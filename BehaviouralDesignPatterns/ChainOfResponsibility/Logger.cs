using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.ChainOfResponsibility
{
    public class Logger
    {
        public void Log(HttpRequest request)
        {
            System.Console.WriteLine("Log");
        }
    }
}