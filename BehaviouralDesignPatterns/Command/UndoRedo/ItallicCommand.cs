using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Command.UndoRedo
{
    public class ItallicCommand : IUndoCommand
    {
        // reference to the htmldocument object and history object
        private HtmlDocument _doc;

        private History _history;

        // field for the previous content
        private string PrevContent = "";

        public ItallicCommand(HtmlDocument doc, History history)
        {
            _doc = doc;
            _history = history;
        }
        // method to get current from the doc, store it in prevContent, convert to ittallic then push to history list
        public void Execute()
        {
            PrevContent = _doc.Content;
            _doc.MakeItallic(); // delegates to the htmldocument class
            _history.Push(this);
        }

        public void UnExecute()
        {
            _doc.Content = PrevContent;
        }
    }
}