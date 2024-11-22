using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Command.UndoRedo
{
    // UndoCommand extends command interface
    // Therefore every undo is actaully a command
    public interface IUndoCommand : ICommand
    {
        void UnExecute();
    }
}