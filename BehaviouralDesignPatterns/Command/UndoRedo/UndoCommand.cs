using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Command.UndoRedo
{
    public class UndoCommand : ICommand
    {
        private History _history;
        public UndoCommand(History history)
        {
            _history = history;
        }
        // checks if list has items then pop the last item from the list
        public void Execute()
        {
            if (_history.Size() > 0)
            {
                var lastcommand = _history.Pop();
                lastcommand.UnExecute(); // delegates the undo logic to the IUndoCommand object
            }
        }
    }
}
// UndoRedo code from the client side
// 