using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Command.GoodSln
{
    public class TurnOnCommand : ICommand
    {
        // reference to the Object/class we are controlling i.e light
        private Light _light;
        public TurnOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOn();
        }
    }
}