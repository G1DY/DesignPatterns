using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Command.GoodSln
{
    // Invoker/Sender class
    public class RemoteControl
    {
        private ICommand _command;
        public RemoteControl(ICommand command)
        {
            _command = command;
        }
        // method to allow the client swap commands at runtime
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void PressButton()
        {
            _command.Execute();
        }
    }
}