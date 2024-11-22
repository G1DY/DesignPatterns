using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Command.UndoRedo
{
    public interface ICommand
    {
        void Execute();
    }
}