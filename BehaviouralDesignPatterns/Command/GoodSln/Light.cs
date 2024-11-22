using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Command.GoodSln
{
    // Reciever class
    public class Light
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Light is on");
        }
        public void TurnOff()
        {
            System.Console.WriteLine("Light is off");
        }
        public void DimLight()
        {
            System.Console.WriteLine("Light is Dim");
        }
    }
}