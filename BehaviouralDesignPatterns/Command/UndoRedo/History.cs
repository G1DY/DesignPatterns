using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Command.UndoRedo
{
    // this class keeps track of the commands we have applied
    public class History
    {
        private List<IUndoCommand> _commands = new List<IUndoCommand>();

        public void Push(IUndoCommand command)
        {
            _commands.Add(command);
        }
        public IUndoCommand Pop()
        {
            var last = _commands.Last();
            _commands.Remove(last);
            return last;
        }

        // Size method helps check if we have commands in the list 
        public int Size()
        {
            return _commands.Count;
        }
    }
}