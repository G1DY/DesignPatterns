using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Command
{
    public class Light
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Light is turning on");
        }
        public void TurnOff()
        {
            System.Console.WriteLine("Light is turning off");
        }
    }
}