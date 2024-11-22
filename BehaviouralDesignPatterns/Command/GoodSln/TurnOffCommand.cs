using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Command.GoodSln
{
    public class TurnOffCommand : ICommand
    {
        private Light _light;
        public TurnOffCommand(Light light1)
        {
            _light = light1;
        }
        public void Execute()
        {
            _light.TurnOff();
        }
    }
}